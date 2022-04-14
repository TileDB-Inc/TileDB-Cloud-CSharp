using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileDB.Cloud
{
    public class RestUtil
    {
        #region Array

        /// <summary>
        /// Deleate an array.
        /// </summary>
        /// <param name="array_uri"></param>
        public static void DeleteArray(string array_uri)
        {
            if (string.IsNullOrEmpty(array_uri))
            {
                return;
            }
            var (name_space, array_name) = SplitUri(array_uri);
            TileDB.Cloud.Rest.Api.ArrayApi apiInstance = TileDB.Cloud.Client.GetInstance().GetArrayApi();
            string contentType = "application/json";
            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            policywrap.Execute(
                () => { apiInstance.DeleteArray(name_space, array_name, contentType); }
                );
            return ;
        }

        public static TileDB.Cloud.Rest.Model.ArrayInfo GetArrayInfo(string array_uri)
        {
            if(string.IsNullOrEmpty(array_uri))
            {
                return new Rest.Model.ArrayInfo();
            }
            var (name_space, array_name) = SplitUri(array_uri);

            TileDB.Cloud.Rest.Api.ArrayApi apiInstance = TileDB.Cloud.Client.GetInstance().GetArrayApi();

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<TileDB.Cloud.Rest.Model.ArrayInfo>(
                () => { return apiInstance.GetArrayMetadata(name_space, array_name); }
                );
            if(policyResult.FinalException != null)
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
            Rest.Api.ArrayApi apiInstance = TileDB.Cloud.Client.GetInstance().GetArrayApi();

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.ArrayBrowserData>(
                () => { return apiInstance.ArraysBrowserOwnedGet(page, per_page, search, name_space, null, permissions, tags, exclude_tags, file_types, exclude_file_types, null); }
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
            Rest.Api.ArrayApi apiInstance = TileDB.Cloud.Client.GetInstance().GetArrayApi();

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.ArrayBrowserData>(
                () => { return apiInstance.ArraysBrowserPublicGet(page, per_page, search, name_space, null, permissions, tags, exclude_tags, file_types, exclude_file_types, null); }
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
        public static Rest.Model.ArrayBrowserData ListSharedArrays(
            string name_space, 
            string permissions = default(string), 
            List<string> tags = default(List<string>), 
            List<string> exclude_tags = default(List<string>), 
            string search = default(string),
            List<string> file_types = default(List<string>), 
            List<string> exclude_file_types = default(List<string>), 
            int? page = default(int?), 
            int? per_page =default(int?))
        {
            Rest.Api.ArrayApi apiInstance = TileDB.Cloud.Client.GetInstance().GetArrayApi();

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<Rest.Model.ArrayBrowserData>(
                () => { return apiInstance.ArraysBrowserSharedGet(page, per_page, search, name_space, null, permissions, tags, exclude_tags, file_types, exclude_file_types, null); }
             );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
            return policyResult.Result;
        }
        #endregion Array

 

        #region Files
        public static TileDB.Cloud.Rest.Model.FileCreated CreateFile(string name_space, string input_uri, string output_uri, string name = null)
        {
            TileDB.Cloud.Rest.Api.FilesApi apiInstance = TileDB.Cloud.Client.GetInstance().GetFilesApi();
            TileDB.Cloud.Rest.Model.FileCreate fileCreate = new Rest.Model.FileCreate(input_uri, output_uri, name);

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<TileDB.Cloud.Rest.Model.FileCreated>(
                () => { return apiInstance.HandleCreateFile(name_space, fileCreate, null); }
             );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
            return policyResult.Result;
        }


        public static TileDB.Cloud.Rest.Model.FileExported ExportFile(string name_space, string input_uri, string output_uri)
        {
            TileDB.Cloud.Rest.Api.FilesApi apiInstance = TileDB.Cloud.Client.GetInstance().GetFilesApi();
            TileDB.Cloud.Rest.Model.FileExport fileExport = new Rest.Model.FileExport(output_uri);

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<TileDB.Cloud.Rest.Model.FileExported>(
                () => { return apiInstance.HandleExportFile(name_space, input_uri, fileExport); }
             );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
            return policyResult.Result;  
        }

        [Obsolete("Plase use TileDB.CoreUtil.SaveFileToArray method.", false)]
        public static void SaveLocalFileToFileArray(TileDB.Context ctx, string uri, string local_file, string mime_type, string mime_coding)
        {
            if (ctx == null)
            {
                TileDB.Config cfg = new TileDB.Config();
                ctx = new TileDB.Context(cfg);
            }
            TileDB.VFS vfs = new TileDB.VFS(ctx);
            if (vfs.is_dir(uri))
            {
                vfs.remove_dir(uri);
            }
            TileDB.ArrayUtil.save_file_from_path(ctx, uri, local_file, mime_type, mime_coding);
        }

        [Obsolete("Plase use TileDB.CoreUtil.ExportArrayToFile method.", false)]
        public static void ExportFileArrayToLocalFile(TileDB.Context ctx, string uri, string local_path) 
        {
            if(ctx==null)
            {
                TileDB.Config cfg = new TileDB.Config();
                ctx = new TileDB.Context(cfg);
            }
            TileDB.ArrayUtil.export_file_to_path(ctx, uri, local_path, 0);
        }

        #endregion Files 

        #region User
        public static Rest.Model.User GetUser() 
        {
            Rest.Api.UserApi apiInstance = TileDB.Cloud.Client.GetInstance().GetUserApi();

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult =  policywrap.ExecuteAndCapture<Rest.Model.User>(
                () => { return apiInstance.GetUser(); }
                );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
            return policyResult.Result;
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

    }
}
