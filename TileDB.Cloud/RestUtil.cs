#nullable enable
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

        public static FileCreated CreateFile(string nameSpace, string inputUri, string outputUri,
            string? name = null)
        {
            var apiInstance = Client.GetInstance().GetFilesApi();
            var fileCreate = new FileCreate(inputUri, outputUri, name);

            var policyWrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policyWrap.ExecuteAndCapture<Rest.Model.FileCreated>(
                () => apiInstance.HandleCreateFile(nameSpace, fileCreate, null));
            if (policyResult.FinalException != null)
            {
                Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }


        public static FileExported ExportFile(string nameSpace, string inputUri, string outputUri)
        {
            var apiInstance = Client.GetInstance().GetFilesApi();
            var fileExport = new Rest.Model.FileExport(outputUri);

            var policyWrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policyWrap.ExecuteAndCapture<Rest.Model.FileExported>(
                () => apiInstance.HandleExportFile(nameSpace, inputUri, fileExport));
            if (policyResult.FinalException != null)
            {
                Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
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
        /// <param name="groupUri"></param>
        public static void DeleteGroup(string groupUri)
        {
            if (string.IsNullOrEmpty(groupUri))
            {
                return;
            }

            var (nameSpace, groupName) = SplitUri(groupUri);
            var apiInstance = Client.GetInstance().GetGroupsApi();
            var policyWrap = Client.GetInstance().GetRetryPolicyWrap();
            policyWrap.Execute( () => { apiInstance.DeleteGroup(nameSpace, groupName); } );
        }

        /// <summary>
        /// Get group info.
        /// </summary>
        /// <param name="groupUri"></param>
        public static GroupInfo GetGroupInfo(string groupUri)
        {
            if (string.IsNullOrEmpty(groupUri))
            {
                return new GroupInfo();
            }

            var (nameSpace, groupName) = SplitUri(groupUri);

            var apiInstance = Client.GetInstance().GetGroupsApi();

            var policyWrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policyWrap.ExecuteAndCapture<Rest.Model.GroupInfo>(
                () => apiInstance.GetGroup(nameSpace, groupName));
            if (policyResult.FinalException != null)
            {
                Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        /// <summary>
        /// List owned groups in a name_space.
        /// </summary>
        /// <param name="groupUri"></param>
        /// <param name="nameSpace"></param>
        /// <param name="tags">tag to search for, more than one can be included (optional)</param>
        /// <param name="excludeTags">tags to exclude matching array in results, more than one can be included (optional)</param>
        /// <param name="memberType">member type to search for, more than one can be included (optional)</param>
        /// <param name="excludeMemberType">member type to exclude matching groups in results, more than one can be included (optional)</param>
        /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
        /// <param name="page">pagination offset (optional)</param>
        /// <param name="perPage">pagination limit (optional)</param>
        /// <returns></returns>
        public static GroupContents GetGroupContents(
            string groupUri,
            string? nameSpace = null,
            List<string>? tags = null,
            List<string>? excludeTags = null,
            List<string>? memberType = null,
            List<string>? excludeMemberType = null,
            string? search = null,
            int? page = default,
            int? perPage = default)
        {
            if (string.IsNullOrEmpty(groupUri))
            {
                return new GroupContents();
            }

            var (groupNameSpace, groupName) = SplitUri(groupUri);

            var apiInstance = Client.GetInstance().GetGroupsApi();

            var policyWrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policyWrap.ExecuteAndCapture<Rest.Model.GroupContents>(
                () => apiInstance.GetGroupContents(groupNameSpace, groupName, page, perPage, nameSpace,
                    search, null, tags, excludeTags, memberType, excludeMemberType));
            if (policyResult.FinalException != null)
            {
                Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        /// <summary>
        /// List owned groups in a name_space.
        /// </summary>
        /// <param name="nameSpace"></param>
        /// <param name="permissions">permissions valid values include read, read_write, write, admin (optional)</param>
        /// <param name="parent">search only the children of the groups with this uuid (optional)</param>
        /// <param name="tags">tag to search for, more than one can be included (optional)</param>
        /// <param name="excludeTags">tags to exclude matching array in results, more than one can be included (optional)</param>
        /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
        /// <param name="flat">if true, ignores the nesting of groups and searches all of them (optional)</param>
        /// <param name="page">pagination offset (optional)</param>
        /// <param name="perPage">pagination limit (optional)</param>
        /// <returns></returns>
        public static GroupBrowserData ListGroups(
            string nameSpace,
            string? permissions = null,
            string? parent = null,
            List<string>? tags = null,
            List<string>? excludeTags = null,
            string? search = null,
            bool? flat = default,
            int? page = default,
            int? perPage = default)
        {
            var apiInstance = Client.GetInstance().GetGroupsApi();

            var policyWrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policyWrap.ExecuteAndCapture<Rest.Model.GroupBrowserData>(
                () => apiInstance.ListOwnedGroups(page, perPage, search, nameSpace, null, permissions, tags,
                    excludeTags, flat, parent));
            if (policyResult.FinalException != null)
            {
                Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        /// <summary>
        /// List public groups in a name_space.
        /// </summary>
        /// <param name="nameSpace"></param>
        /// <param name="permissions">permissions valid values include read, read_write, write, admin (optional)</param>
        /// <param name="parent">search only the children of the groups with this uuid (optional)</param>
        /// <param name="tags">tag to search for, more than one can be included (optional)</param>
        /// <param name="excludeTags">tags to exclude matching array in results, more than one can be included (optional)</param>
        /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
        /// <param name="excludeFileTypes"></param>
        /// <param name="flat">if true, ignores the nesting of groups and searches all of them (optional)</param>
        /// <param name="page">pagination offset (optional)</param>
        /// <param name="perPage">pagination limit (optional)</param>
        /// <param name="fileTypes"></param>
        /// <returns></returns>
        public static GroupBrowserData ListPublicGroups(
            string nameSpace,
            string? permissions = null,
            string? parent = null,
            List<string>? tags = null,
            List<string>? excludeTags = null,
            string? search = null,
            List<string>? fileTypes = null,
            List<string>? excludeFileTypes = null,
            bool? flat = default,
            int? page = default,
            int? perPage = default)
        {
            var apiInstance = Client.GetInstance().GetGroupsApi();

            var policyWrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policyWrap.ExecuteAndCapture<Rest.Model.GroupBrowserData>(
                () => apiInstance.ListPublicGroups(page, perPage, search, nameSpace, null, permissions, tags,
                    excludeTags, flat, parent));
            if (policyResult.FinalException != null)
            {
                Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        /// <summary>
        /// List shared groups in a name_space.
        /// </summary>
        /// <param name="nameSpace"></param>
        /// <param name="permissions">permissions valid values include read, read_write, write, admin (optional)</param>
        /// <param name="parent">search only the children of the groups with this uuid (optional)</param>
        /// <param name="tags">tag to search for, more than one can be included (optional)</param>
        /// <param name="excludeTags">tags to exclude matching array in results, more than one can be included (optional)</param>
        /// <param name="search">search string that will look at name, namespace or description fields (optional)</param>
        /// <param name="flat">if true, ignores the nesting of groups and searches all of them (optional)</param>
        /// <param name="page">pagination offset (optional)</param>
        /// <param name="perPage">pagination limit (optional)</param>
        /// <returns></returns>
        public static GroupBrowserData ListSharedGroups(
            string nameSpace,
            string? permissions = null,
            string? parent = null,
            List<string>? tags = null,
            List<string>? excludeTags = null,
            string? search = null,
            bool? flat = default,
            int? page = default,
            int? perPage = default)
        {
            var apiInstance = Client.GetInstance().GetGroupsApi();

            var policyWrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policyWrap.ExecuteAndCapture<Rest.Model.GroupBrowserData>(
                () => apiInstance.ListSharedGroups(page, perPage, search, nameSpace, null, permissions, tags,
                    excludeTags, flat, parent));
            if (policyResult.FinalException != null)
            {
                Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }

            return policyResult.Result;
        }

        #endregion Groups

        #region User

        public static User GetUser()
        {
            var apiInstance = Client.GetInstance().GetUserApi();

            var policyWrap = Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policyWrap.ExecuteAndCapture<Rest.Model.User>(
                () => apiInstance.GetUser());
            if (policyResult.FinalException != null)
            {
                Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
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
                throw new ArgumentException("Invalid array uri(not starting with tiledb):" + array_uri);
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
