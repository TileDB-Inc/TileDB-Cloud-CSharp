using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TileDB.Cloud.Rest.Model;

namespace TileDB.Cloud
{
    public partial class RestUtil
    {
        public class ArrayList
        {
            public List<UDFArrayDetails> Arrays { get; set; }

            public ArrayList()
            {
                Arrays = new List<UDFArrayDetails>();
            }

            public ArrayList(List<UDFArrayDetails> arrayList)
            {
                Arrays = arrayList;
            }

            public void Add(string arrayUri, List<dynamic> ranges, List<string> buffers, Layout layout)
            {
                var (arrayNamespace, arrayName) = SplitUri(arrayUri);
                var array = new ArrayDetails()
                {
                    Uri = arrayUri,
                    Ranges = new UdfQueryRanges(layout, new List<dynamic>()),
                    Buffers = buffers
                };
                array.Ranges.Ranges.AddRange(ranges);

                Arrays.Add(array);
            }
        }

        public class Array
        {
            /// <summary>
            /// Delete an array.
            /// </summary>
            /// <param name="array_uri"></param>
            public static void DeleteArray(string array_uri)
            {
                if (string.IsNullOrEmpty(array_uri))
                {
                    return;
                }

                var (name_space, array_name) = RestUtil.SplitUri(array_uri);
                Rest.Api.ArrayApi apiInstance = Client.GetInstance().GetArrayApi();
                string contentType = "application/json";
                Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
                policywrap.Execute(
                    () => { apiInstance.DeleteArray(name_space, array_name, contentType); }
                );
                return;
            }

            public static Rest.Model.ArrayInfo GetArrayInfo(string array_uri)
            {
                if (string.IsNullOrEmpty(array_uri))
                {
                    return new Rest.Model.ArrayInfo();
                }

                var (name_space, array_name) = RestUtil.SplitUri(array_uri);

                Rest.Api.ArrayApi apiInstance = Client.GetInstance().GetArrayApi();

                Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
                var policyResult = policywrap.ExecuteAndCapture<Rest.Model.ArrayInfo>(
                    () => { return apiInstance.GetArrayMetadata(name_space, array_name); }
                );
                if (policyResult.FinalException != null)
                {
                    System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
                }

                return policyResult.Result;
            }

            /// <summary>
            /// List owned arrays in a name_space.
            /// </summary>
            /// <param name="name_space"></param>
            /// <param name="permissions">permissions valid values include read, read_write, write, admin (optional)</param>
            /// <param name="tags">tag to search for, more than one can be included (optional)</param>
            /// <param name="exclude_tags">tags to exclude matching array in results, more than one can be included (optional)</param>
            /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
            /// <param name="file_types">file_type to search for, more than one can be included (optional)</param>
            /// <param name="exclude_file_types">file_type to exclude matching array in results, more than one can be included</param>
            /// <param name="page">pagination offset (optional)</param>
            /// <param name="per_page">pagination limit (optional)</param>
            /// <returns></returns>
            public static Rest.Model.ArrayBrowserData ListArrays(
                string name_space,
                string permissions = default(string),
                List<string> tags = default(List<string>),
                List<string> exclude_tags = default(List<string>),
                string search = default(string),
                List<string> file_types = default(List<string>),
                List<string> exclude_file_types = default(List<string>),
                int? page = default(int?),
                int? per_page = default(int?))
            {
                Rest.Api.ArrayApi apiInstance = Client.GetInstance().GetArrayApi();

                Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
                var policyResult = policywrap.ExecuteAndCapture<Rest.Model.ArrayBrowserData>(
                    () =>
                    {
                        return apiInstance.ArraysBrowserOwnedGet(page, per_page, search, name_space, null, permissions,
                            tags, exclude_tags, file_types, exclude_file_types, null);
                    }
                );
                if (policyResult.FinalException != null)
                {
                    System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
                }

                return policyResult.Result;
            }

            /// <summary>
            /// List public arrays in a name_space.
            /// </summary>
            /// <param name="name_space"></param>
            /// <param name="permissions">permissions valid values include read, read_write, write, admin (optional)</param>
            /// <param name="tags">tag to search for, more than one can be included (optional)</param>
            /// <param name="exclude_tags">tags to exclude matching array in results, more than one can be included (optional)</param>
            /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
            /// <param name="file_types">file_type to search for, more than one can be included (optional)</param>
            /// <param name="exclude_file_types">file_type to exclude matching array in results, more than one can be included</param>
            /// <param name="page">pagination offset (optional)</param>
            /// <param name="per_page">pagination limit (optional)</param>
            /// <returns></returns>
            public static Rest.Model.ArrayBrowserData ListPublicArrays(
                string name_space,
                string permissions = default(string),
                List<string> tags = default(List<string>),
                List<string> exclude_tags = default(List<string>),
                string search = default(string),
                List<string> file_types = default(List<string>),
                List<string> exclude_file_types = default(List<string>),
                int? page = default(int?),
                int? per_page = default(int?))
            {
                Rest.Api.ArrayApi apiInstance = Client.GetInstance().GetArrayApi();

                Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
                var policyResult = policywrap.ExecuteAndCapture<Rest.Model.ArrayBrowserData>(
                    () =>
                    {
                        return apiInstance.ArraysBrowserPublicGet(page, per_page, search, name_space, null, permissions,
                            tags, exclude_tags, file_types, exclude_file_types, null);
                    }
                );
                if (policyResult.FinalException != null)
                {
                    System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
                }

                return policyResult.Result;
            }

            /// <summary>
            /// List shared arrays in a name_space.
            /// </summary>
            /// <param name="name_space"></param>
            /// <param name="permissions">permissions valid values include read, read_write, write, admin (optional)</param>
            /// <param name="tags">tag to search for, more than one can be included (optional)</param>
            /// <param name="exclude_tags">tags to exclude matching array in results, more than one can be included (optional)</param>
            /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
            /// <param name="file_types">file_type to search for, more than one can be included (optional)</param>
            /// <param name="exclude_file_types">file_type to exclude matching array in results, more than one can be included</param>
            /// <param name="page">pagination offset (optional)</param>
            /// <param name="per_page">pagination limit (optional)</param>
            /// <returns></returns>
            public static Rest.Model.ArrayBrowserData ListSharedArrays(
                string name_space,
                string permissions = default(string),
                List<string> tags = default(List<string>),
                List<string> exclude_tags = default(List<string>),
                string search = default(string),
                List<string> file_types = default(List<string>),
                List<string> exclude_file_types = default(List<string>),
                int? page = default(int?),
                int? per_page = default(int?))
            {
                Rest.Api.ArrayApi apiInstance = Client.GetInstance().GetArrayApi();

                Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
                var policyResult = policywrap.ExecuteAndCapture<Rest.Model.ArrayBrowserData>(
                    () =>
                    {
                        return apiInstance.ArraysBrowserSharedGet(page, per_page, search, name_space, null, permissions,
                            tags, exclude_tags, file_types, exclude_file_types, null);
                    }
                );
                if (policyResult.FinalException != null)
                {
                    System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
                }

                return policyResult.Result;
            }

            /// <summary>
            /// Execute a single-array UDF
            ///
            /// If no `chargedOrg` is provided we will charge the current user's default charged namespace.
            /// This defaults to the current username, but this can be reconfigured on TileDB Cloud Console
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF to execute</param>
            /// <param name="arrayUri">TileDB uri for array to run against</param>
            /// <param name="ranges">Ranges to use for slicing array</param>
            /// <param name="args">JSON formatted arguments to pass to UDF</param>
            /// <param name="layout">Layout to perform array slicing</param>
            /// <param name="chargedOrg">Organization to charge for UDF execution</param>
            /// <returns>Stream containing UDF result</returns>
            public static Stream Apply(
                string udfUri, string arrayUri, List<dynamic> ranges,
                string? args = null, Layout layout = Layout.RowMajor, string? chargedOrg = null)
            {
                var (_, arrayName) = SplitUri(arrayUri);
                var udf = new ArrayUdf(udfUri, arrayUri, layout, ranges, args!);
                return Udf.UdfApi.SubmitUDF(chargedOrg ?? GetDefaultChargedNamespace(), arrayName, udf);
            }

            /// <summary>
            /// Execute a single-array UDF asynchronously
            ///
            /// If no `chargedOrg` is provided we will charge the current user's default charged namespace.
            /// This defaults to the current username, but this can be reconfigured on TileDB Cloud Console
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF to execute</param>
            /// <param name="arrayUri">TileDB uri for array to run against</param>
            /// <param name="ranges">Ranges to use for slicing array</param>
            /// <param name="args">JSON formatted arguments to pass to UDF</param>
            /// <param name="layout">Layout to perform array slicing</param>
            /// <param name="chargedOrg">Organization to charge for UDF execution</param>
            /// <returns>Stream containing UDF result</returns>
            public static Task<Stream> ApplyAsync(
                string udfUri, string arrayUri, List<dynamic> ranges,
                string? args = null, Layout layout = Layout.RowMajor, string? chargedOrg = null)
            {
                var (_, arrayName) = SplitUri(arrayUri);
                var udf = new ArrayUdf(udfUri, arrayUri, layout, ranges, args!);
                return Udf.UdfApi.SubmitUDFAsync(chargedOrg ?? GetDefaultChargedNamespace(), arrayName, udf);
            }

            /// <summary>
            /// Execute a multi-array UDF
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF to execute</param>
            /// <param name="arrayList">Constructed ArrayList object</param>
            /// <param name="args">JSON formatted arguments to pass to UDF</param>
            /// <param name="chargedOrg">Organization to charge for UDF execution</param>
            /// <returns></returns>
            public static Stream ApplyMultiArray(
                string udfUri, ArrayList arrayList, string? args = null, string? chargedOrg = null)
            {
                var udf = new ArrayUdf(udfUri, arrayList, args!);
                return Udf.UdfApi.SubmitMultiArrayUDF(chargedOrg ?? GetDefaultChargedNamespace(), udf);
            }

            /// <summary>
            /// Execute a multi-array UDF
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF to execute</param>
            /// <param name="arrayList">Constructed ArrayList object</param>
            /// <param name="args">JSON formatted arguments to pass to UDF</param>
            /// <param name="chargedOrg">Organization to charge for UDF execution</param>
            /// <returns></returns>
            public static Task<Stream> ApplyMultiArrayAsync(
                string udfUri, ArrayList arrayList, string? args = null, string? chargedOrg = null)
            {
                var udf = new ArrayUdf(udfUri, arrayList, args!);
                return Udf.UdfApi.SubmitMultiArrayUDFAsync(chargedOrg ?? GetDefaultChargedNamespace(), udf);
            }
        }
    }
}