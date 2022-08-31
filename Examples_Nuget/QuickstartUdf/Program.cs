using System;
using System.Collections.Generic;
using System.Linq;
using TileDB.Cloud;
using TileDB.Cloud.Rest.Model;

namespace QuickstartUdf
{
    class Program
    {
        static UDFInfo UdfGetInfo(string uri)
        {
            return TileDB.Cloud.Udf.GetInfo(uri);
        }

        // Run generic UDF using JSON to pass args
        // + (Python) UDF declaration for this example: def test_udf_args(arg1, arg2="default")
        static void UdfGenericExec(string uri, string charged=null, string args=null)
        {
            var result = TileDB.Cloud.Udf.ExecGeneric(uri, args, chargedOrg: charged);

            // Output result to console
            result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine();
        }

        static void UdfGenericExecAsync(string uri)
        {
            // Call UDF asynchronously; Does not block execution on call to SubmitGenericUDFAsync()
            var resultTask = TileDB.Cloud.Udf.ExecGenericAsync(uri, chargedOrg: "TileDB-Inc");
            // Here we are free to do some work while waiting on resultTask...
            Console.WriteLine("Started async UDF task...");

            var result = resultTask.Result; // Blocks execution until we get a result
            result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine();
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def test_udf_array(data, attr, scalar)
        static void UdfArrayExec(string udfUri, string arrayUri, string attribute, int scalar, string charged=null)
        {
            var args = $"{{\"attr\": \"{attribute}\",\"scale\": {scalar}}}";
            var chargedOrg = charged ?? arrayUri.Split('/')[0];

            // Run against an array with string dimensions
            arrayUri = "tiledb://shaunreed/sparse-string-dimensions";
            var response = TileDB.Cloud.Udf.Exec(
                udfUri, arrayUri, ranges: new List<dynamic>() { new[] { "a", "c" }, new[] { 1, 4 }},
                args, Layout.Unordered, chargedOrg
            );
            Console.Write($"Result from {udfUri} against {arrayUri}: ");
            response.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine();
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def test_udf_array(data, attr, scalar)
        static void UdfArrayExecAsync(string udfUri, string arrayUri, string attribute, int scalar, string charged=null)
        {
            var args = $"{{\"attr\": \"{attribute}\",\"scale\": {scalar}}}";

            // Run against an array with integer dimensions
            var taskResponse = TileDB.Cloud.Udf.ExecAsync(
                udfUri, arrayUri, args: args,
                ranges: new List<dynamic>() { new[] { 1, 4 }, new[] { 1, 4 } }
            );
            Console.WriteLine($"Waiting for result...");
            Console.Write($"Result from {udfUri} against {arrayUri}: ");
            // Accessing the `Result` property of `taskResponse` will block until async task completes
            taskResponse.Result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine();
        }

        static void UdfUpdate(string uri, string readmeText)
        {
            Console.WriteLine($"UDF info before update: {UdfGetInfo(uri).ToJson()}");

            // Update existing UDF tags
            var curTags = UdfGetInfo(uri).Tags;
            if (!curTags.Contains("csharp-test"))
            {
                curTags.Add("csharp-test");
            }
            Udf.UpdateUdf(uri, readmeText, curTags.ToArray());

            Console.WriteLine($"UDF info after update: {UdfGetInfo(uri).ToJson()}");
        }

        // TODO: Errors around incorrect padding for UDFs that update `exec`
        // + Once this is resolved it would be possible to write python in C# and register new UDFs
        static void UdfUpdateExec(string uri)
        {
            Console.WriteLine($"UDF info before update: {UdfGetInfo(uri).ToJson()}");

            var pythonFunction =
@"
def new_udf_name():
    return ""The UDF execution was successful""
";
            Udf.UpdateUdf(uri,
                $"This README was updated using TileDB-Cloud-CSharp on {System.DateTime.Now}",
                new []{ "csharp", "test", "updating", "tags" }, "new-udf-name", "Beerware",
                "No limitations", pythonFunction, pythonFunction, UDFLanguage.Python);
            Console.WriteLine($"UDF info after update: {UdfGetInfo(uri).ToJson()}");

            // Test executing the UDF after update
            var response = Udf.ExecGeneric(uri);
            response.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine();
        }

        static void Run()
        {
            var udfUri = "tiledb://shaunreed/test-array-udf";
            string arrayUri = "tiledb://shaunreed/dense-array";

            // Get information on cloud UDF
            var udfInfo = UdfGetInfo(udfUri);
            Console.WriteLine(udfInfo.ToJson());

            UdfGenericExec("tiledb://shaunreed/test-udf"); // Charge the namespace that owns the UDF
            UdfGenericExec("tiledb://shaunreed/test-udf", "TileDB-Inc"); // Charge the TileDB-Inc namespace
            UdfGenericExecAsync("tiledb://shaunreed/test-udf");

            // Pass JSON args to generic UDF
            UdfGenericExec("tiledb://shaunreed/test-udf-args", args: "{\"arg1\": \"test 1st argument\"}");
            UdfGenericExec("tiledb://shaunreed/test-udf-args",
                args: "{\"arg1\": \"test 1st argument\", \"arg2\": \"test 2nd argument\"}");

            // Execute udf on an existing TileDB Cloud array
            UdfArrayExec(udfUri, arrayUri, "a1", 2);
            // Execute the same udf asynchronously
            UdfArrayExecAsync(udfUri, arrayUri, "a1", 2);

            UdfUpdate(udfUri, $"This README was updated using TileDB-Cloud-CSharp on {System.DateTime.Now}");

            // Update information on cloud UDF
            // TODO: Update (Python / R) Udf function definition using string literals?
            // UdfUpdateExec("tiledb://shaunreed/new-udf-name");
        }

        // Serverless UDFs
        static void Main(string[] args)
        {
            TileDB.Cloud.Client.Login();
            var user = TileDB.Cloud.RestUtil.GetUser();
            Console.WriteLine($"User: {user.ToJson()}");

            Run();
        }
    }
}
