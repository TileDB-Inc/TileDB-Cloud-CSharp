﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TileDB.Cloud;
using TileDB.Cloud.Rest.Model;

namespace QuickstartUdf
{
    class Program
    {
        private static readonly Stream OutputStream = Console.OpenStandardOutput();

        static UDFInfo UdfGetInfo(string uri)
        {
            return TileDB.Cloud.RestUtil.UserDefinedFunction.GetInfo(uri);
        }

        // Run generic UDF using JSON to pass args
        // + (Python) UDF declaration for this example: def args_udf(arg1, arg2="default")
        static void UdfGenericExec(string udfUri, string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running generic UDF {udfUri}...");
            DebugOutput(udfUri, chargedOrg, args);

            var result = TileDB.Cloud.RestUtil.UserDefinedFunction.ExecGeneric(udfUri, args, chargedOrg);
            // Output result to console
            Console.Write("Result from generic UDF: ");
            result.CopyTo(OutputStream);
            Console.WriteLine();
            Console.WriteLine();
        }

        static async Task UdfGenericExecAsync(string udfUri, string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running generic UDF {udfUri} asynchronously...");
            DebugOutput(udfUri, chargedOrg, args);

            // Call UDF asynchronously; Does not block execution on call to SubmitGenericUDFAsync()
            var resultTask = TileDB.Cloud.RestUtil.UserDefinedFunction.ExecGenericAsync(udfUri, args, chargedOrg);
            // Here we are free to do some work while waiting on resultTask...
            Console.WriteLine($"Waiting for result...");
            var result = await resultTask;

            Console.Write($"Async UDF task completed with output: ");
            await result.Result.CopyToAsync(OutputStream);
            Console.WriteLine();
            Console.WriteLine();
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def array_udf(data, attr, scalar)
        static void UdfArrayExec(
            string udfUri, string arrayUri, List<object> ranges, string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayUri}...");
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with string dimensions
            var response = TileDB.Cloud.RestUtil.Array.Apply(
                udfUri, arrayUri, ranges, args, Layout.Unordered, chargedOrg);

            Console.Write($"Result from {udfUri} against {arrayUri}: ");
            response.CopyTo(OutputStream);
            Console.WriteLine();
            Console.WriteLine();
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def array_udf(data, attr, scalar)
        static async Task UdfArrayExecAsync(
            string udfUri, string arrayUri, List<object> ranges, string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayUri} asynchronously...");
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with integer dimensions
            var taskResponse = TileDB.Cloud.RestUtil.Array.ApplyAsync(udfUri, arrayUri, ranges, args);
            Console.WriteLine($"Waiting for result...");
            var result = await taskResponse;

            Console.Write($"Result from {udfUri} against {arrayUri}: ");
            await result.Result.CopyToAsync(OutputStream);
            Console.WriteLine();
            Console.WriteLine();
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
            response.CopyTo(OutputStream);
            Console.WriteLine();
            Console.WriteLine();
        }

        // Run Array UDF using array as input; `data` arg in the UDF below will contain array slice data
        // + (Python) UDF declaration for this example: def multi_array_udf(data, attr, scalar)
        static async Task UdfMultiArrayExecAsync(string udfUri, RestUtil.ArrayList arrayList, string arrayNamespace,
            string args=null, string chargedOrg=null)
        {
            Console.WriteLine($"Running {udfUri} against {arrayList.Arrays.Count} arrays asynchronously...");
            DebugOutput(udfUri, chargedOrg, args);

            // Run against an array with string dimensions
            var taskResponse = TileDB.Cloud.RestUtil.Array.ApplyMultiArrayAsync(
                udfUri, arrayList, arrayNamespace, args);
            Console.WriteLine($"Waiting for result...");
            var result = await taskResponse;

            Console.Write($"Result from {udfUri} against {arrayList.Arrays.Count} arrays: ");
            await result.Result.CopyToAsync(OutputStream);
            Console.WriteLine();
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
            RestUtil.UserDefinedFunction.UpdateGenericUdf(uri, readmeText, curTags.ToArray());

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

        static async Task Run()
        {
            string arrayUdfUri = "tiledb://shaunreed/array-udf";
            string friendNamespace = "shaunrd0";
            RestUtil.UserDefinedFunction.Unshare(arrayUdfUri, friendNamespace);
            RestUtil.UserDefinedFunction.Share(arrayUdfUri, friendNamespace, new[] { UDFActions.Fetchudf });
            RestUtil.UserDefinedFunction.Share(arrayUdfUri, friendNamespace, new[] { UDFActions.Fetchudf, UDFActions.Shareudf });

            // Get information on cloud UDF
            var udfInfo = UdfGetInfo(arrayUdfUri);
            Console.WriteLine($"Info for UDF: \n{udfInfo.ToJson()}\n");

            // S3 location to store copied UDF data
            string copyUdfStorageS3 = "s3://shaun.reed/registered_udfs/copied-udf";
            string copyUdfName = "copied-udf-name";
            string copyUdfNamespace = "shaunreed";
            // To use the default namespace, we can leave `copyNamespace` parameter unset in call to Udf.Copy()
            // + Default namespace can be obtained in C# with RestUtil.GetDefaultChargedNamespace()
            RestUtil.UserDefinedFunction.Copy(arrayUdfUri, copyUdfStorageS3, copyNamespace: copyUdfNamespace, copyName: copyUdfName);

            // Update info for the UDF we copied above; Delete the copied UDF
            string resultUri = $"tiledb://{copyUdfNamespace}/{copyUdfName}";
            UdfUpdate(resultUri, $"This README was updated using TileDB-Cloud-CSharp on {DateTime.Now}");
            // Udf.Delete also removes UDF data stored on S3
            RestUtil.UserDefinedFunction.Delete(resultUri);

            #region GenericUDFs

            // Executing generic UDFs with no arguments
            string udfNoArgs = "tiledb://shaunreed/print-udf";
            UdfGenericExec(udfNoArgs); // Charge the namespace that owns the UDF
            UdfGenericExec(udfNoArgs, chargedOrg: "TileDB-Inc"); // Charge the TileDB-Inc namespace
            await UdfGenericExecAsync(udfNoArgs);

            // Executing generic UDFs with arguments
            string udfArgs = "tiledb://shaunreed/args-udf";
            // Build dictionary to represent arguments that will be passed to generic UDF
            var argsDict = new Dictionary<string, object>() { { "arg1", "1st argument" } };
            UdfGenericExec(udfArgs, JsonConvert.SerializeObject(argsDict));
            // Add an additional argument
            argsDict.Add("arg2", "2nd argument");
            UdfGenericExec(udfArgs, JsonConvert.SerializeObject(argsDict));

            #endregion

            #region ArrayUDFs

            // Construct args and ranges to pass to array UDF
            var args = JsonConvert.SerializeObject(
            new Dictionary<string, object>() {{"attr", "a1"}, {"scale", 2}});
            var ranges = new List<object>() { new[] { "a", "c" }, new[] { 1, 4 } };

            // Execute udf on an existing TileDB Cloud array
            string sparseUri = "tiledb://shaunreed/sparse-string-dimensions";
            UdfArrayExec(arrayUdfUri, sparseUri, ranges, args);
            // Execute the same udf asynchronously
            await UdfArrayExecAsync(arrayUdfUri, sparseUri, ranges, args);

            // Execute multi-array UDF against 2 or more arrays
            string multiArrayUdf = "tiledb://shaunreed/multi-array-udf";
            string arrayUri1 = "tiledb://shaunreed/dense-array";
            string arrayUri2 = "tiledb://TileDB-Inc/quickstart_dense";
            string arrayNamespace = RestUtil.SplitUri(arrayUri1).name_space;

            // Construct a list of arrays to run multi-array UDF against
            ranges = new List<object>() { new[] { 1, 4 }, new[] { 1, 4 } };
            var arrayList = new RestUtil.ArrayList();
            var buffers = new List<string>() { "rows", "cols", "a1" };
            arrayList.Add(arrayUri1, ranges: ranges, buffers: buffers, Layout.RowMajor);
            buffers = new List<string>() { "rows", "cols", "a" };
            arrayList.Add(arrayUri2, ranges: ranges, buffers: buffers, Layout.RowMajor);

            args = JsonConvert.SerializeObject(new Dictionary<string, object>() {{"attr1", "a1"}, {"attr2", "a"}});
            UdfMultiArrayExec(multiArrayUdf, arrayList, arrayNamespace, args);
            await UdfMultiArrayExecAsync(multiArrayUdf, arrayList, arrayNamespace, args);

            #endregion
        }

        static async Task Main(string[] args)
        {
            TileDB.Cloud.Client.Login();
            var user = TileDB.Cloud.RestUtil.GetUser();
            Console.WriteLine($"Logged in as TileDB Cloud user: {user.ToJson()}\n");

            await Run();
        }
    }
}
