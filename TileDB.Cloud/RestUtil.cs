using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Polly;
using TileDB.Cloud.Rest.Model;

namespace TileDB.Cloud
{
    public static partial class RestUtil
    {
        #region Files

        public static Rest.Model.FileCreated CreateFile(string name_space, string input_uri, string output_uri,
            string name = null)
        {
            Rest.Api.FilesApi apiInstance = Client.GetInstance().GetFilesApi();
            Rest.Model.FileCreate fileCreate = new Rest.Model.FileCreate(input_uri, output_uri, name);

            Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.FileCreated>(
                () => { return apiInstance.HandleCreateFile(name_space, fileCreate, null); }
            );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }


        public static Rest.Model.FileExported ExportFile(string name_space, string input_uri, string output_uri)
        {
            Rest.Api.FilesApi apiInstance = Client.GetInstance().GetFilesApi();
            Rest.Model.FileExport fileExport = new Rest.Model.FileExport(output_uri);

            Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.FileExported>(
                () => { return apiInstance.HandleExportFile(name_space, input_uri, fileExport); }
            );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        //ToDo: Replace after adding support for save_file_from_path in TileDB.CSharp
        //[Obsolete("Plase use TileDB.CoreUtil.SaveFileToArray method.", false)]
        //public static void SaveLocalFileToFileArray(TileDB.CSharp.Context ctx, string uri, string local_file, string mime_type, string mime_coding)
        //{
        //    if (ctx == null)
        //    {
        //        TileDB.CSharp.Config cfg = new TileDB.CSharp.Config();
        //        ctx = new TileDB.CSharp.Context(cfg);
        //    }
        //    TileDB.CSharp.VFS vfs = new TileDB.CSharp.VFS(ctx);
        //    if (vfs.IsDir(uri))
        //    {
        //        vfs.RemoveDir(uri);
        //    }
        //    TileDB.CSharp.ArrayUtil.save_file_from_path(ctx, uri, local_file, mime_type, mime_coding);
        //}

        //ToDo: Replace after adding support for export_file_to_path in TileDB.CSharp
        //[Obsolete("Plase use TileDB.CoreUtil.ExportArrayToFile method.", false)]
        //public static void ExportFileArrayToLocalFile(TileDB.CSharp.Context ctx, string uri, string local_path)
        //{
        //    if(ctx==null)
        //    {
        //        TileDB.CSharp.Config cfg = new TileDB.CSharp.Config();
        //        ctx = new TileDB.CSharp.Context(cfg);
        //    }
        //    TileDB.CSharp.ArrayUtil.export_file_to_path(ctx, uri, local_path, 0);
        //}

        #endregion Files

        #region Groups

        /// <summary>
        /// Delete a group.
        /// </summary>
        /// <param name="group_uri"></param>
        public static void DeleteGroup(string group_uri)
        {
            if (string.IsNullOrEmpty(group_uri))
            {
                return;
            }

            var (name_space, group_name) = SplitUri(group_uri);
            Rest.Api.GroupsApi apiInstance = Client.GetInstance().GetGroupsApi();
            Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
            policywrap.Execute(
                () => { apiInstance.DeleteGroup(name_space, group_name); }
            );
            return;
        }

        /// <summary>
        /// Get group info.
        /// </summary>
        /// <param name="group_uri"></param>
        public static Rest.Model.GroupInfo GetGroupInfo(string group_uri)
        {
            if (string.IsNullOrEmpty(group_uri))
            {
                return new Rest.Model.GroupInfo();
            }

            var (name_space, group_name) = SplitUri(group_uri);

            Rest.Api.GroupsApi apiInstance = Client.GetInstance().GetGroupsApi();

            Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.GroupInfo>(
                () => { return apiInstance.GetGroup(name_space, group_name); }
            );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        /// <summary>
        /// List owned groups in a name_space.
        /// </summary>
        /// <param name="group_uri"></param>
        /// <param name="name_space"></param>
        /// <param name="tags">tag to search for, more than one can be included (optional)</param>
        /// <param name="exclude_tags">tags to exclude matching array in results, more than one can be included (optional)</param>
        /// <param name="member_type">member type to search for, more than one can be included (optional)</param>
        /// <param name="exclude_member_type">member type to exclude matching groups in results, more than one can be included (optional)</param>
        /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
        /// <param name="page">pagination offset (optional)</param>
        /// <param name="per_page">pagination limit (optional)</param>
        /// <returns></returns>
        public static Rest.Model.GroupContents GetGroupContents(
            string group_uri,
            string name_space = default(string),
            List<string> tags = default(List<string>),
            List<string> exclude_tags = default(List<string>),
            List<string> member_type = default(List<string>),
            List<string> exclude_member_type = default(List<string>),
            string search = default(string),
            int? page = default(int?),
            int? per_page = default(int?))
        {
            if (string.IsNullOrEmpty(group_uri))
            {
                return new Rest.Model.GroupContents();
            }

            var (group_name_space, group_name) = SplitUri(group_uri);

            Rest.Api.GroupsApi apiInstance = Client.GetInstance().GetGroupsApi();

            Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.GroupContents>(
                () =>
                {
                    return apiInstance.GetGroupContents(group_name_space, group_name, page, per_page, name_space,
                        search, null, tags, exclude_tags, member_type, exclude_member_type);
                }
            );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        /// <summary>
        /// List owned groups in a name_space.
        /// </summary>
        /// <param name="name_space"></param>
        /// <param name="permissions">permissions valid values include read, read_write, write, admin (optional)</param>
        /// <param name="parent">search only the children of the groups with this uuid (optional)</param>
        /// <param name="tags">tag to search for, more than one can be included (optional)</param>
        /// <param name="exclude_tags">tags to exclude matching array in results, more than one can be included (optional)</param>
        /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
        /// <param name="flat">if true, ignores the nesting of groups and searches all of them (optional)</param>
        /// <param name="page">pagination offset (optional)</param>
        /// <param name="per_page">pagination limit (optional)</param>
        /// <returns></returns>
        public static Rest.Model.GroupBrowserData ListGroups(
            string name_space,
            string permissions = default(string),
            string parent = default(string),
            List<string> tags = default(List<string>),
            List<string> exclude_tags = default(List<string>),
            string search = default(string),
            bool? flat = default(bool?),
            int? page = default(int?),
            int? per_page = default(int?))
        {
            Rest.Api.GroupsApi apiInstance = Client.GetInstance().GetGroupsApi();

            Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.GroupBrowserData>(
                () =>
                {
                    return apiInstance.ListOwnedGroups(page, per_page, search, name_space, null, permissions, tags,
                        exclude_tags, flat, parent);
                }
            );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        /// <summary>
        /// List public groups in a name_space.
        /// </summary>
        /// <param name="name_space"></param>
        /// <param name="permissions">permissions valid values include read, read_write, write, admin (optional)</param>
        /// <param name="parent">search only the children of the groups with this uuid (optional)</param>
        /// <param name="tags">tag to search for, more than one can be included (optional)</param>
        /// <param name="exclude_tags">tags to exclude matching array in results, more than one can be included (optional)</param>
        /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
        /// <param name="flat">if true, ignores the nesting of groups and searches all of them (optional)</param>
        /// <param name="page">pagination offset (optional)</param>
        /// <param name="per_page">pagination limit (optional)</param>
        /// <returns></returns>
        public static Rest.Model.GroupBrowserData ListPublicGroups(
            string name_space,
            string permissions = default(string),
            string parent = default(string),
            List<string> tags = default(List<string>),
            List<string> exclude_tags = default(List<string>),
            string search = default(string),
            List<string> file_types = default(List<string>),
            List<string> exclude_file_types = default(List<string>),
            bool? flat = default(bool?),
            int? page = default(int?),
            int? per_page = default(int?))
        {
            Rest.Api.GroupsApi apiInstance = Client.GetInstance().GetGroupsApi();

            Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.GroupBrowserData>(
                () =>
                {
                    return apiInstance.ListPublicGroups(page, per_page, search, name_space, null, permissions, tags,
                        exclude_tags, flat, parent);
                }
            );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        /// <summary>
        /// List shared groups in a name_space.
        /// </summary>
        /// <param name="name_space"></param>
        /// <param name="permissions">permissions valid values include read, read_write, write, admin (optional)</param>
        /// <param name="parent">search only the children of the groups with this uuid (optional)</param>
        /// <param name="tags">tag to search for, more than one can be included (optional)</param>
        /// <param name="exclude_tags">tags to exclude matching array in results, more than one can be included (optional)</param>
        /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
        /// <param name="flat">if true, ignores the nesting of groups and searches all of them (optional)</param>
        /// <param name="page">pagination offset (optional)</param>
        /// <param name="per_page">pagination limit (optional)</param>
        /// <returns></returns>
        public static Rest.Model.GroupBrowserData ListSharedGroups(
            string name_space,
            string permissions = default(string),
            string parent = default(string),
            List<string> tags = default(List<string>),
            List<string> exclude_tags = default(List<string>),
            string search = default(string),
            bool? flat = default(bool?),
            int? page = default(int?),
            int? per_page = default(int?))
        {
            Rest.Api.GroupsApi apiInstance = Client.GetInstance().GetGroupsApi();

            Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.GroupBrowserData>(
                () =>
                {
                    return apiInstance.ListSharedGroups(page, per_page, search, name_space, null, permissions, tags,
                        exclude_tags, flat, parent);
                }
            );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        #endregion Groups

        #region User

        public static Rest.Model.User GetUser()
        {
            Rest.Api.UserApi apiInstance = Client.GetInstance().GetUserApi();

            Polly.Wrap.PolicyWrap policywrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.User>(
                () => { return apiInstance.GetUser(); }
            );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        public static string GetDefaultChargedNamespace()
        {
            var user = GetUser();
            var chargedOrg = user.Username;
            if (user.DefaultNamespaceCharged != String.Empty)
            {
                chargedOrg = user.DefaultNamespaceCharged;
            }

            return chargedOrg;
        }

        #endregion User

        /// <summary>
        /// Split a uri into name_space and array_name.
        /// </summary>
        /// <param name="array_uri"></param>
        /// <returns></returns>
        public static (string name_space, string array_path) SplitUri(string array_uri)
        {
            System.Uri uri = new Uri(array_uri);
            if (uri.Scheme != "tiledb")
            {
                throw new System.ArgumentException("Invalid array uri(not starting with tiledb):" + array_uri);
            }
            return (uri.Host, uri.LocalPath.TrimStart('/'));
        }

        public static string SerializeArguments(Dictionary<string, dynamic> args)
        {
            return JsonConvert.SerializeObject(args);
        }

        /// <summary>
        /// Helper function to check PolicyResult for final exception
        /// </summary>
        /// <param name="policyResult"></param>
        private static void CheckPolicyResult(PolicyResult policyResult)
        {
            if (policyResult.FinalException != null)
            {
                Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
        }
        /// <summary>
        /// Helper function to check PolicyResult for final exception
        /// </summary>
        /// <param name="policyResult"></param>
        private static void CheckPolicyResult<T>(PolicyResult<T> policyResult)
        {
            if (policyResult.FinalException != null)
            {
                Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
        }

        # region OpenAPI Overrides

        // Overrides members of OpenAPI generated code to support variable range type serialization
        // + These overrides are only accessible within classes encapsulated by RestUtil

        [DataContract]
        private class UdfQueryRanges : QueryRanges
        {
            public UdfQueryRanges(Layout layout, List<dynamic> ranges)
            {
                Layout = layout;
                Ranges = ranges;
            }

            [DataMember(Name = "ranges", EmitDefaultValue = false)]
            public new List<dynamic> Ranges { get; set; }
        }

        [DataContract]
        private class ArrayUdf : MultiArrayUDF
        {
            [DataMember(Name = "ranges", EmitDefaultValue = false)]
            public new UdfQueryRanges? Ranges { get; set; }

            public ArrayUdf() { }

            public ArrayUdf(string udfUri, string arrayUri, Layout layout, List<dynamic> ranges, string args)
            {
                UdfInfoName = udfUri.Replace("tiledb://", "");
                Arrays = new List<UDFArrayDetails>() { new UDFArrayDetails(uri: arrayUri) };
                Ranges = new UdfQueryRanges(layout, new List<dynamic>());
                Ranges.Ranges.AddRange(ranges);
                Argument = args;
            }

            public ArrayUdf(string udfUri, ArrayList arrayList, string args)
            {
                UdfInfoName = udfUri.Replace("tiledb://", "");
                Argument = args;
                Arrays = new List<UDFArrayDetails>();
                Arrays.AddRange(arrayList.Arrays);
            }

        }

        [DataContract]
        private class ArrayDetails : UDFArrayDetails
        {
            [DataMember(Name = "ranges", EmitDefaultValue = false)]
            public new UdfQueryRanges? Ranges { get; set; }
        }

        #endregion
    }
}
