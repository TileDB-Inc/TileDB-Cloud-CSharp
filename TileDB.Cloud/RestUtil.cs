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
        public static void DeleteArray(string uri, string contentType)
        {
            string[] items = uri.Split(":", StringSplitOptions.RemoveEmptyEntries);
            if (items.Length < 2)
            {
                return;
            }
            string[] array_names = items[1].Split("/", StringSplitOptions.RemoveEmptyEntries);
            string username = array_names[0];
            string array_name = String.Join('/', array_names, 1, array_names.Length - 1);

            TileDB.Cloud.Rest.Api.ArrayApi apiInstance = TileDB.Cloud.Client.GetInstance().GetArrayApi();

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            policywrap.Execute(
                () => { apiInstance.DeleteArray(username, array_name, contentType); }
                );

            return ;
        }

        public static TileDB.Cloud.Rest.Model.ArrayInfo GetArrayInfo(string uri)
        {
            if(string.IsNullOrEmpty(uri))
            {
                return new Rest.Model.ArrayInfo();
            }
            string[] items = uri.Split(":",StringSplitOptions.RemoveEmptyEntries);
            if(items.Length<2)
            {
                return new Rest.Model.ArrayInfo();
            }
            string[] array_names = items[1].Split("/", StringSplitOptions.RemoveEmptyEntries);
            string username = array_names[0];
            string array_name = String.Join('/', array_names, 1, array_names.Length - 1);

            TileDB.Cloud.Rest.Api.ArrayApi apiInstance = TileDB.Cloud.Client.GetInstance().GetArrayApi();

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<TileDB.Cloud.Rest.Model.ArrayInfo>(
                () => { return apiInstance.GetArrayMetadata(username, array_name); }
                );

            return policyResult.Result;
        }

        public static Rest.Model.ArrayBrowserData ListArrays(
            string username, 
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
                () => { return apiInstance.ArraysBrowserOwnedGet(page, per_page, search, username, null, permissions, tags, exclude_tags, file_types, exclude_file_types, null); }
                );

            return policyResult.Result;     
        }

        public static Rest.Model.ArrayBrowserData ListPublicArrays(
            string username, 
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
                () => { return apiInstance.ArraysBrowserPublicGet(page, per_page, search, username, null, permissions, tags, exclude_tags, file_types, exclude_file_types, null); }
                );

            return policyResult.Result;
        }

        public static Rest.Model.ArrayBrowserData ListSharedArrays(
            string username, 
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
                () => { return apiInstance.ArraysBrowserSharedGet(page, per_page, search, username, null, permissions, tags, exclude_tags, file_types, exclude_file_types, null); }
             );

            return policyResult.Result;
        }
        #endregion Array

 

        #region Files
        public static TileDB.Cloud.Rest.Model.FileCreated CreateFile(string username, string input_uri, string output_uri, string name = null)
        {
            TileDB.Cloud.Rest.Api.FilesApi apiInstance = TileDB.Cloud.Client.GetInstance().GetFilesApi();
            TileDB.Cloud.Rest.Model.FileCreate fileCreate = new Rest.Model.FileCreate(input_uri, output_uri, name);

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<TileDB.Cloud.Rest.Model.FileCreated>(
                () => { return apiInstance.HandleCreateFile(username, fileCreate, null); }
             );

            return policyResult.Result;
        }

        public static TileDB.Cloud.Rest.Model.FileExported ExportFile(string uri, string output_uri)
        {
            string[] items = uri.Split(":", StringSplitOptions.RemoveEmptyEntries);
            if (items.Length < 2)
            {
                return new Rest.Model.FileExported();
            }
            string[] array_names = items[1].Split("/", StringSplitOptions.RemoveEmptyEntries);
            string username = array_names[0];
            string array_name = String.Join('/', array_names, 1, array_names.Length - 1);

            TileDB.Cloud.Rest.Api.FilesApi apiInstance = TileDB.Cloud.Client.GetInstance().GetFilesApi();
            TileDB.Cloud.Rest.Model.FileExport fileExport = new Rest.Model.FileExport(output_uri);

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<TileDB.Cloud.Rest.Model.FileExported>(
                () => { return apiInstance.HandleExportFile(username, array_name, fileExport); }
             );

            return policyResult.Result;  
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

            return policyResult.Result;
        }
 
        #endregion User


    }
}
