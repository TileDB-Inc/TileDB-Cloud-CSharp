using System;
using System.Collections.Generic;
using System.Linq;
using TileDB.Cloud;
using TileDB.Cloud.Rest.Model;

namespace QuickstartUdf
{
    class Program
    {
        // Uri format: '<NAMESPACE>/<UDF_NAME>'
        static UDFInfo UdfGetInfo(string uri)
        {
            var udfApi = TileDB.Cloud.Client.GetInstance().GetUdfApi();
            var udfPath = uri.Split('/');

            return udfApi.GetUDFInfo(udfPath[0], udfPath[1]);
        }

        // Uri format: '<NAMESPACE>/<UDF_NAME>'
        // Run UDF using JSON to pass args
        // + (Python) UDF declaration: def test_udf_args(arg1, arg2="default")
        static void UdfGenericExec(string uri, string charged=null, string args=null)
        {
            var udfApi = TileDB.Cloud.Client.GetInstance().GetUdfApi();

            // Select namespace to charge for UDF execution
            string namespaceCharged = charged ?? uri.Split('/')[0];
            // Construct GenericUDF to call using cloud UDF
            var genericUdf = new GenericUDF(udfInfoName: uri, argument: args);
            var result = udfApi.SubmitGenericUDF(namespaceCharged, genericUdf);

            // Output result to console
            result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine();
        }

        static void UdfGenericAsync(string uri)
        {
            var udfApi = TileDB.Cloud.Client.GetInstance().GetUdfApi();
            // Call UDF asynchronously; Does not block execution on call to SubmitGenericUDFAsync()
            var resultTask = udfApi.SubmitGenericUDFAsync("TileDB-Inc", new GenericUDF(udfInfoName: uri));
            // Here we are free to do some work while waiting on resultTask...
            var result = resultTask.Result; // Blocks execution until we get a result
            result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine();
        }

        // Uri format: '<NAMESPACE>/<UDF_NAME>'
        // Run Array UDF using array as input; `data` arg below will contain array slice data
        // + (Python) UDF declaration: def test_udf_array(data, attr, scalar)
        static void UdfArrayExec(string uri, string arrayUri, string attribute, int scalar, string charged=null)
        {
            var udfApi = TileDB.Cloud.Client.GetInstance().GetUdfApi();

            var udfs = new List<TileDB.Cloud.Udf>();
            var args = $"{{\"attr\": \"{attribute}\",\"scale\": {scalar}}}";

            // Int dimensions
            var multiUDF = new TileDB.Cloud.Udf();
            multiUDF.UdfInfoName = uri;
            multiUDF.Argument = args;
            multiUDF.Arrays = new List<UDFArrayDetails>();
            multiUDF.Arrays.Add(new UDFArrayDetails(uri: "tiledb://shaunreed/dense-array"));
            multiUDF.Ranges = new TileDB.Cloud.UdfQueryRanges(Layout.RowMajor, new List<dynamic>());
            multiUDF.Ranges.Ranges.Add(new List<int>() {1, 4});
            multiUDF.Ranges.Ranges.Add(new List<int>() {1, 4});
            udfs.Add(multiUDF);

            // String dimensions
            multiUDF = new TileDB.Cloud.Udf();
            multiUDF.UdfInfoName = uri;
            multiUDF.Argument = args;
            multiUDF.Arrays = new List<UDFArrayDetails>();
            multiUDF.Arrays.Add(new UDFArrayDetails(uri: "tiledb://shaunreed/sparse-string-dimensions"));
            multiUDF.Ranges = new TileDB.Cloud.UdfQueryRanges(Layout.Unordered, new List<dynamic>());
            multiUDF.Ranges.Ranges.Add(new List<string>() {"a", "bb"});
            multiUDF.Ranges.Ranges.Add(new List<int>() {1, 4});
            udfs.Add(multiUDF);

            foreach (var udf in udfs)
            {
                var uriSegments = udf.Arrays.Last().Uri.Replace("tiledb://", "").Split('/');
                var nameSpace = uriSegments.First();
                var arrayName = uriSegments.Last();

                var response = udfApi.SubmitUDF(nameSpace, arrayName, udf);
                Console.Write($"Result from {udf.UdfInfoName} against {arrayName}: ");
                response.CopyTo(Console.OpenStandardOutput());
                Console.WriteLine();
            }

            // var chargedOrg = charged ?? arrayUri.Split('/')[0];
            // var result = udfApi.SubmitUDF(chargedOrg, arrayUri.Split('/')[1], multiUDF);
            // result.CopyTo(Console.OpenStandardOutput());
        }

        static void UdfUpdate(string uri, string readmeText)
        {
            // Update an existing UDF
            var udfApi = TileDB.Cloud.Client.GetInstance().GetUdfApi();
            var udfInfoUpdate = new UDFInfoUpdate();
            udfInfoUpdate.Readme = readmeText;
            var curTags = UdfGetInfo(uri).Tags;
            if (!curTags.Contains("csharp"))
            {
                curTags.Add("csharp");
            }
            udfInfoUpdate.Tags = curTags;
            udfApi.UpdateUDFInfo(uri.Split('/')[0], uri.Split('/')[1], udfInfoUpdate);

            UdfGenericExec(uri);
        }

        static void Run()
        {
            var uri = "shaunreed/test-udf";
            UdfGenericExec(uri); // Charge the namespace that owns the UDF (shaunreed)
            UdfGenericExec(uri, "TileDB-Inc"); // Charge the TileDB-Inc namespace
            UdfGenericAsync(uri);
            UdfUpdate(uri, $"This README was updated using TileDB-Cloud-CSharp on {System.DateTime.Now}");

            uri = "shaunreed/test-udf-args";
            UdfGenericExec(uri, args: "{\"arg1\": \"test 1st argument\"}");
            UdfGenericExec(uri, args: "{\"arg1\": \"test 1st argument\", \"arg2\": \"test 2nd argument\"}");

            uri = "shaunreed/test-array-udf";
            string arrayUri = "shaunreed/dense-array";
            UdfArrayExec(uri, arrayUri, "a1", 2);
        }

        // Serverless UDFs
        static void Main(string[] args)
        {
            TileDB.Cloud.Client.Login();
            var user = TileDB.Cloud.RestUtil.GetUser();
            Console.WriteLine($"User: {user.ToJson()}");

            var a = $"{{\"attr\": \"a1\",\"scale\": 2}}";
            var udfUri = "tiledb://shaunreed/test-array-udf";
            var arrayUri = "tiledb://shaunreed/dense-array";

            // Int dimensions
            var response = TileDB.Cloud.UdfUtil.Apply(
                udfUri, arrayUri, args: a,
                ranges: new List<dynamic>() { new[] { 1, 4 }, new[] { 1, 4 } }
            );
            Console.Write($"Result from {udfUri} against {arrayUri}: ");
            response.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine();

            // String dimensions
            arrayUri = "tiledb://shaunreed/sparse-string-dimensions";
            response = TileDB.Cloud.UdfUtil.Apply(
                udfUri, arrayUri, args: a, layout: Layout.Unordered,
                ranges: new List<dynamic>() { new[] { "a", "c" }, new[] { 1, 4 }}
            );
            Console.Write($"Result from {udfUri} against {arrayUri}: ");
            response.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine();

            response.CopyTo(Console.OpenStandardOutput());

            Run();
        }
    }
}
