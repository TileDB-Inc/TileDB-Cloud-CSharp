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
        public static void DeleteArray(string username, string array, string contentType, Rest.Client.Configuration cfg = null)
        {
            TileDB.Cloud.Rest.Api.ArrayApi apiInstance = new Rest.Api.ArrayApi(cfg);
            apiInstance.DeleteArray(username, array, contentType);
        }

        public static TileDB.Cloud.Rest.Model.ArrayInfo GetArrayInfo(string name_space, string array, Rest.Client.Configuration cfg = null)
        {
            TileDB.Cloud.Rest.Api.ArrayApi apiInstance = new Rest.Api.ArrayApi(cfg);
            return apiInstance.GetArrayMetadata(name_space, array);
        }

        public static Rest.Model.ArrayBrowserData ListArrays(string name_space, string permissions, List<string> tags, List<string> exclude_tags, string search,
    List<string> file_types, List<string> exclude_file_types, int? page = default(int?), int? per_page = default(int?), Rest.Client.Configuration cfg = null)
        {
            Rest.Api.ArrayApi apiInstance = new Rest.Api.ArrayApi(cfg);
            return apiInstance.ArraysBrowserOwnedGet(page, per_page, search, name_space, null, permissions, tags, exclude_tags, file_types, exclude_file_types, null);
        }

        public static Rest.Model.ArrayBrowserData ListPublicArrays(string name_space, string permissions, List<string> tags, List<string> exclude_tags, string search,
    List<string> file_types, List<string> exclude_file_types, int? page = default(int?), int? per_page = default(int?), Rest.Client.Configuration cfg = null)
        {
            Rest.Api.ArrayApi apiInstance = new Rest.Api.ArrayApi(cfg);
            return apiInstance.ArraysBrowserPublicGet(page, per_page, search, name_space, null, permissions, tags, exclude_tags, file_types, exclude_file_types, null);
        }

        public static Rest.Model.ArrayBrowserData ListSharedArrays(string name_space, string permissions, List<string> tags, List<string> exclude_tags, string search,
    List<string> file_types, List<string> exclude_file_types, int? page = default(int?), int? per_page =default(int?), Rest.Client.Configuration cfg = null)
        {
            Rest.Api.ArrayApi apiInstance = new Rest.Api.ArrayApi(cfg);
            return apiInstance.ArraysBrowserSharedGet(page, per_page, search, name_space, null, permissions, tags, exclude_tags, file_types, exclude_file_types, null);
        }
        #endregion Array

        #region Client

        #endregion Client

        #region Files
        public static TileDB.Cloud.Rest.Model.FileCreated CreateFile(string name_space, string input_uri, string output_uri, string name = null, Rest.Client.Configuration cfg = null)
        {
            TileDB.Cloud.Rest.Api.FilesApi apiInstance = new Rest.Api.FilesApi(cfg);
            TileDB.Cloud.Rest.Model.FileCreate fileCreate = new Rest.Model.FileCreate(input_uri, output_uri, name);
            return apiInstance.HandleCreateFile(name_space, fileCreate, null);
        }

        public static TileDB.Cloud.Rest.Model.FileExported ExportFile(string uri, string output_uri, Rest.Client.Configuration cfg = null)
        {
            TileDB.Cloud.Rest.Api.FilesApi apiInstance = new Rest.Api.FilesApi(cfg);
            TileDB.Cloud.Rest.Model.FileExport fileExport = new Rest.Model.FileExport(output_uri);
            string name_space = uri.Split(":")[0];
            return apiInstance.HandleExportFile(name_space, uri, fileExport);
        }

        #endregion Files 

        #region User
        public static Rest.Model.User GetUser(Rest.Client.Configuration cfg = null) 
        {
            Rest.Api.UserApi apiInstance = new Rest.Api.UserApi(cfg);
            return apiInstance.GetUser();
        }
 
        #endregion User


    }
}
