using System;
using System.Collections.Generic;
using TileDB.Cloud;
using TileDB.Cloud.Rest.Model;

namespace QuickstartUdf
{
    class Program
    {
        static UDFInfo UdfGetInfo(string uri)
        {
            return TileDB.Cloud.RestUtil.Udf.GetInfo(uri);
        }

        // Run generic UDF using JSON to pass args
        // + (Python) UDF declaration for this example: def args_udf(arg1, arg2="default")
        static void UdfGenericExec(string udfUri, string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running generic UDF {udfUri}...");
            DebugOutput(udfUri, chargedOrg, args);

            var result = TileDB.Cloud.RestUtil.Udf.ExecGeneric(udfUri, args, chargedOrg);
            // Output result to console
            Console.Write("Result from generic UDF: ");
            result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
        }

        static void UdfGenericExecAsync(string udfUri, string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running generic UDF {udfUri} asynchronously...");
            DebugOutput(udfUri, chargedOrg, args);

            // Call UDF asynchronously; Does not block execution on call to SubmitGenericUDFAsync()
            var resultTask = TileDB.Cloud.RestUtil.Udf.ExecGenericAsync(udfUri, args, chargedOrg);
            // Here we are free to do some work while waiting on resultTask...
            Console.WriteLine("Started async UDF task...");

            Console.Write($"Async UDF task completed with output: ");
            // Accessing the `Result` property of `taskResponse` will block until async task completes
            resultTask.Result.Result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def array_udf(data, attr, scalar)
        static void UdfArrayExec(
            string udfUri, string arrayUri, List<dynamic> ranges, string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayUri}...");
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with string dimensions
            var response = TileDB.Cloud.RestUtil.Array.Apply(
                udfUri, arrayUri, ranges, args, Layout.Unordered, chargedOrg);

            Console.Write($"Result from {udfUri} against {arrayUri}: ");
            response.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def array_udf(data, attr, scalar)
        static void UdfArrayExecAsync(
            string udfUri, string arrayUri, List<dynamic> ranges, string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayUri} asynchronously...");
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with integer dimensions
            var taskResponse = TileDB.Cloud.RestUtil.Array.ApplyAsync(udfUri, arrayUri, ranges, args);
            Console.WriteLine($"Waiting for result...");
            Console.Write($"Result from {udfUri} against {arrayUri}: ");

            // Accessing the `Result` property of `taskResponse` will block until async task completes
            taskResponse.Result.Result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def multi_array_udf(data, attr, scalar)
        static void UdfMultiArrayExec(string udfUri, RestUtil.ArrayList arrayList, string arrayNamespace,
            string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayList.Arrays.Count} arrays...");
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with string dimensions
            var response = TileDB.Cloud.RestUtil.Array.ApplyMultiArray(udfUri, arrayList, arrayNamespace, args);
            Console.Write($"Result from {udfUri} against {arrayList.Arrays.Count} arrays: ");
            response.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def multi_array_udf(data, attr, scalar)
        static void UdfMultiArrayExecAsync(string udfUri, RestUtil.ArrayList arrayList, string arrayNamespace,
            string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayList.Arrays.Count} arrays asynchronously...");
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with string dimensions
            var taskResponse = TileDB.Cloud.RestUtil.Array.ApplyMultiArrayAsync(
                udfUri, arrayList, arrayNamespace, args);
            Console.WriteLine($"Waiting for result...");
            Console.Write($"Result from {udfUri} against {arrayList.Arrays.Count} arrays: ");

            // Accessing the `Result` property of `taskResponse` will block until async task completes
            taskResponse.Result.Result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
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
            RestUtil.Udf.UpdateGenericUdf(uri, readmeText, curTags.ToArray());

            Console.WriteLine($"UDF info after update: {UdfGetInfo(uri).ToJson()}\n");
        }

        static void DebugOutput(string uri, string chargedOrg = null, string args = null)
        {
            if (chargedOrg != null)
            {
                Console.WriteLine($"Charging {uri} to {chargedOrg} namespace");
            }
            if (args != null)
            {
                Console.WriteLine($"Passing arguments to UDF: {args}");
            }
        }

        static void Run()
        {
            string arrayUdfUri = "tiledb://shaunreed/array-udf";
            string friendNamespace = "shaunrd0";
            RestUtil.Udf.Unshare(arrayUdfUri, friendNamespace);
            RestUtil.Udf.Share(arrayUdfUri, friendNamespace, new[] { UDFActions.Fetchudf });
            RestUtil.Udf.Share(arrayUdfUri, friendNamespace, new[] { UDFActions.Fetchudf, UDFActions.Shareudf });

            // Get information on cloud UDF
            var udfInfo = UdfGetInfo(arrayUdfUri);
            Console.WriteLine($"Info for UDF: \n{udfInfo.ToJson()}\n");

            // S3 location to store copied UDF data
            string copyUdfStorageS3 = "s3://shaun.reed/registered_udfs/copied-udf";
            string copyUdfName = "copied-udf-name";
            string copyUdfNamespace = "shaunreed";
            // To use the default namespace, we can leave `copyNamespace` parameter unset in call to Udf.Copy()
            // + Default namespace can be obtained in C# with RestUtil.GetDefaultChargedNamespace()
            RestUtil.Udf.Copy(arrayUdfUri, copyUdfStorageS3, copyNamespace: copyUdfNamespace, copyName: copyUdfName);

            // Update info for the UDF we copied above; Delete the copied UDF
            string resultUri = $"tiledb://{copyUdfNamespace}/{copyUdfName}";
            UdfUpdate(resultUri, $"This README was updated using TileDB-Cloud-CSharp on {DateTime.Now}");
            // Udf.Delete also removes UDF data stored on S3
            RestUtil.Udf.Delete(resultUri);

            #region GenericUDFs

            // Executing generic UDFs with no arguments
            string udfNoArgs = "tiledb://shaunreed/print-udf";
            UdfGenericExec(udfNoArgs); // Charge the namespace that owns the UDF
            UdfGenericExec(udfNoArgs, chargedOrg: "TileDB-Inc"); // Charge the TileDB-Inc namespace
            UdfGenericExecAsync(udfNoArgs);

            // Executing generic UDFs with arguments
            string udfArgs = "tiledb://shaunreed/args-udf";
            // Build dictionary to represent arguments that will be passed to generic UDF
            var argsDict = new Dictionary<string, dynamic>() { { "arg1", "1st argument" } };
            UdfGenericExec(udfArgs, RestUtil.SerializeArguments(argsDict));
            // Add an additional argument
            argsDict.Add("arg2", "2nd argument");
            UdfGenericExec(udfArgs, RestUtil.SerializeArguments(argsDict));

            #endregion

            #region ArrayUDFs

            // Construct args and ranges to pass to array UDF
            var args = RestUtil.SerializeArguments(
                new Dictionary<string, dynamic>() {{"attr", "a1"}, {"scale", 2}});
            var ranges = new List<dynamic>() { new[] { "a", "c" }, new[] { 1, 4 } };

            // Execute udf on an existing TileDB Cloud array
            string sparseUri = "tiledb://shaunreed/sparse-string-dimensions";
            UdfArrayExec(arrayUdfUri, sparseUri, ranges, args);
            // Execute the same udf asynchronously
            UdfArrayExecAsync(arrayUdfUri, sparseUri, ranges, args);

            // Execute multi-array UDF against 2 or more arrays
            string multiArrayUdf = "tiledb://shaunreed/multi-array-udf";
            string arrayUri1 = "tiledb://shaunreed/dense-array";
            string arrayUri2 = "tiledb://shaunreed/dense-array-2";
            string arrayNamespace = RestUtil.SplitUri(arrayUri1).name_space;

            // Construct a list of arrays to run multi-array UDF against
            ranges = new List<dynamic>() { new[] { 1, 4 }, new[] { 1, 4 } };
            var buffers = new List<string>() { "rows", "cols", "a1" };
            var arrayList = new RestUtil.ArrayList();
            arrayList.Add(arrayUri1, ranges: ranges, buffers: buffers, Layout.RowMajor);
            arrayList.Add(arrayUri2, ranges: ranges, buffers: buffers, Layout.RowMajor);

            args = RestUtil.SerializeArguments(new Dictionary<string, dynamic>() {{"attr", "a1"}});
            UdfMultiArrayExec(multiArrayUdf, arrayList, arrayNamespace, args);
            UdfMultiArrayExecAsync(multiArrayUdf, arrayList, arrayNamespace, args);

            #endregion
        }

        static void Main(string[] args)
        {
            TileDB.Cloud.Client.Login();
            var user = TileDB.Cloud.RestUtil.GetUser();
            Console.WriteLine($"Logged in as TileDB Cloud user: {user.ToJson()}\n");

            Run();
        }
    }
}
