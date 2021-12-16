﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileDB.Cloud
{
    public class RestUtil
    {
        #region Array
        public static void DeleteArray(string username, string uri, string contentType)
        {
            TileDB.Cloud.Rest.Api.ArrayApi apiInstance = TileDB.Cloud.Client.GetInstance().GetArrayApi();

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            policywrap.Execute(
                () => { apiInstance.DeleteArray(username, uri, contentType); }
                );
            return ;
        }

        public static TileDB.Cloud.Rest.Model.ArrayInfo GetArrayInfo(string username, string uri)
        {
            if(string.IsNullOrEmpty(uri))
            {
                return new Rest.Model.ArrayInfo();
            }

            TileDB.Cloud.Rest.Api.ArrayApi apiInstance = TileDB.Cloud.Client.GetInstance().GetArrayApi();

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<TileDB.Cloud.Rest.Model.ArrayInfo>(
                () => { return apiInstance.GetArrayMetadata(username, uri); }
                );
            if(policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
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
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
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
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
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
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
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
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
            return policyResult.Result;
        }

        public static TileDB.Cloud.Rest.Model.FileExported ExportFile(string username, string input_uri, string output_uri)
        {
            TileDB.Cloud.Rest.Api.FilesApi apiInstance = TileDB.Cloud.Client.GetInstance().GetFilesApi();
            TileDB.Cloud.Rest.Model.FileExport fileExport = new Rest.Model.FileExport(output_uri);

            Polly.Wrap.PolicyWrap policywrap = TileDB.Cloud.Client.GetInstance().GetRetryPolicyWrap();
            var policyResult = policywrap.ExecuteAndCapture<TileDB.Cloud.Rest.Model.FileExported>(
                () => { return apiInstance.HandleExportFile(username, input_uri, fileExport); }
             );
            if (policyResult.FinalException != null)
            {
                System.Console.WriteLine("Caught final exception! {0}", policyResult.FinalException.Message);
            }
            return policyResult.Result;  
        }

        public static void SaveLocalFileToFileArray(string uri, string local_file, string mime_type, string mime_coding, TileDB.Context ctx)
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
            TileDB.ArrayUtil.save_file_from_path(uri, local_file, mime_type, mime_coding, ctx);
        }

        public static void ExportFileArrayToLocalFile(string uri, string local_path, TileDB.Context ctx) 
        {
            if(ctx==null)
            {
                TileDB.Config cfg = new TileDB.Config();
                ctx = new TileDB.Context(cfg);
            }
            TileDB.ArrayUtil.export_file_to_path(uri, local_path, 0, ctx);
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


    }
}
