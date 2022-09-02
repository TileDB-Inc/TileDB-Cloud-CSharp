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
        static void UdfGenericExec(string udfUri, string chargedOrg=null, string args=null)
        {
            Console.WriteLine($"Running generic UDF {udfUri}...");
            DebugOutput(udfUri, chargedOrg, args);

            var result = TileDB.Cloud.RestUtil.Udf.ExecGeneric(udfUri, args, chargedOrg: chargedOrg);
            // Output result to console
            Console.Write("Result from generic UDF: ");
            result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
        }

        static void UdfGenericExecAsync(string udfUri)
        {
            Console.WriteLine($"Running generic UDF {udfUri} asynchronously...");
            // Call UDF asynchronously; Does not block execution on call to SubmitGenericUDFAsync()
            var resultTask = TileDB.Cloud.RestUtil.Udf.ExecGenericAsync(udfUri, chargedOrg: "TileDB-Inc");
            // Here we are free to do some work while waiting on resultTask...
            Console.WriteLine("Started async UDF task...");

            Console.Write($"Async UDF task completed with output: ");
            // Accessing the `Result` property of `taskResponse` will block until async task completes
            resultTask.Result.Result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def array_udf(data, attr, scalar)
        static void UdfArrayExec(string udfUri, string arrayUri, string attribute, int scalar, string charged=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayUri}...");
            var args = RestUtil.SerializeArguments(
                new Dictionary<string, dynamic>() {{"attr", attribute}, {"scale", scalar}});
            var chargedOrg = charged ?? RestUtil.SplitUri(arrayUri).name_space;
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with string dimensions
            arrayUri = "tiledb://shaunreed/sparse-string-dimensions";
            var response = TileDB.Cloud.RestUtil.Array.Apply(
                udfUri, arrayUri, ranges: new List<dynamic>() { new[] { "a", "c" }, new[] { 1, 4 }},
                args, Layout.Unordered, chargedOrg
            );
            Console.Write($"Result from {udfUri} against {arrayUri}: ");
            response.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def array_udf(data, attr, scalar)
        static void UdfArrayExecAsync(string udfUri, string arrayUri, string attribute, int scalar, string chargedOrg=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayUri} asynchronously...");
            var args = RestUtil.SerializeArguments(
                new Dictionary<string, dynamic>() {{"attr", attribute}, {"scale", scalar}});
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with integer dimensions
            var taskResponse = TileDB.Cloud.RestUtil.Array.ApplyAsync(
                udfUri, arrayUri, args: args,
                ranges: new List<dynamic>() { new[] { 1, 4 }, new[] { 1, 4 } }, chargedOrg: "shaunreed"
            );
            Console.WriteLine($"Waiting for result...");
            Console.Write($"Result from {udfUri} against {arrayUri}: ");
            // Accessing the `Result` property of `taskResponse` will block until async task completes
            taskResponse.Result.Result.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def multi_array_udf(data, attr, scalar)
        static void UdfMultiArrayExec(string udfUri, RestUtil.ArrayList arrayList, string attribute, string charged=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayList.Arrays.Count} arrays...");
            var args = RestUtil.SerializeArguments(new Dictionary<string, dynamic>() {{"attr", attribute}});
            var chargedOrg = charged ?? RestUtil.SplitUri(udfUri).name_space;
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with string dimensions
            var response = TileDB.Cloud.RestUtil.Array.ApplyMultiArray(udfUri, arrayList, args, chargedOrg);
            Console.Write($"Result from {udfUri} against {arrayList.Arrays.Count} arrays: ");
            response.CopyTo(Console.OpenStandardOutput());
            Console.WriteLine("\n");
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def multi_array_udf(data, attr, scalar)
        static void UdfMultiArrayExecAsync(string udfUri, RestUtil.ArrayList arrayList, string attribute, string charged=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayList.Arrays.Count} arrays asynchronously...");
            var args = RestUtil.SerializeArguments(new Dictionary<string, dynamic>() {{"attr", attribute}});
            var chargedOrg = charged ?? RestUtil.SplitUri(udfUri).name_space;
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with string dimensions
            var taskResponse = TileDB.Cloud.RestUtil.Array.ApplyMultiArrayAsync(udfUri, arrayList, args, chargedOrg);
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
            var udfUri = "tiledb://shaunreed/array-udf";
            string arrayUri = "tiledb://shaunreed/dense-array";

            RestUtil.Udf.Unshare("tiledb://shaunreed/array-udf", "shaunrd0");
            RestUtil.Udf.Share("tiledb://shaunreed/array-udf", "shaunrd0",
                new [] { UDFActions.Fetchudf });
            RestUtil.Udf.Share("tiledb://shaunreed/array-udf", "shaunrd0",
                new [] { UDFActions.Fetchudf, UDFActions.Shareudf });

            // Get information on cloud UDF
            var udfInfo = UdfGetInfo("tiledb://shaunreed/array-udf");
            Console.WriteLine($"Info for UDF: \n{udfInfo.ToJson()}\n");

            UdfGenericExec("tiledb://shaunreed/print-udf"); // Charge the namespace that owns the UDF
            UdfGenericExec("tiledb://shaunreed/print-udf", "TileDB-Inc"); // Charge the TileDB-Inc namespace
            UdfGenericExecAsync("tiledb://shaunreed/print-udf");

            // Build dictionary to represent arguments that will be passed to generic UDF
            var argsDict = new Dictionary<string, dynamic>() { { "arg1", "1st argument" } };
            UdfGenericExec("tiledb://shaunreed/args-udf", args: RestUtil.SerializeArguments(argsDict));
            // Add an additional argument
            argsDict.Add("arg2", "2nd argument");
            UdfGenericExec("tiledb://shaunreed/args-udf", args: RestUtil.SerializeArguments(argsDict));

            // Execute udf on an existing TileDB Cloud array
            UdfArrayExec("tiledb://shaunreed/array-udf", arrayUri, "a1", 2);
            // Execute the same udf asynchronously
            UdfArrayExecAsync("tiledb://shaunreed/array-udf", arrayUri, "a1", 2);

            var arrayList = new RestUtil.ArrayList();
            arrayList.Add("tiledb://shaunreed/dense-array-2",
                new List<dynamic>() { new[] { 1, 4 }, new[] { 1, 4 } },
                new List<string>() { "rows", "cols", "a1" }, Layout.RowMajor);
            arrayList.Add("tiledb://shaunreed/dense-array",
                new List<dynamic>() { new[] { 1, 4 }, new[] { 1, 4 } },
                new List<string>() { "rows", "cols", "a1" }, Layout.RowMajor);
            UdfMultiArrayExec("tiledb://shaunreed/multi-array-udf", arrayList, "a1");
            UdfMultiArrayExecAsync("tiledb://shaunreed/multi-array-udf", arrayList, "a1");

            RestUtil.Udf.Copy("tiledb://shaunreed/array-udf", "s3://shaun.reed/registered_udfs/copied-udf",
                "shaunreed", "copied-udf");
            UdfUpdate("tiledb://shaunreed/copied-udf",
                $"This README was updated using TileDB-Cloud-CSharp on {System.DateTime.Now}");

            // Udf.Delete also removes UDF data stored on S3
            RestUtil.Udf.Delete("tiledb://shaunreed/copied-udf");
        }

        // Serverless UDFs
        static void Main(string[] args)
        {
            TileDB.Cloud.Client.Login();
            var user = TileDB.Cloud.RestUtil.GetUser();
            Console.WriteLine($"Logged in as TileDB Cloud user: {user.ToJson()}\n");

            Run();
        }
    }
}
