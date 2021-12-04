using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileDB.Cloud
{
    public class File
    {
        protected static TileDB.Cloud.Rest.Api.FilesApi m_apiInstance = null;
        public static TileDB.Cloud.Rest.Api.FilesApi ApiInstance()
        {
            if (m_apiInstance == null)
            {
                m_apiInstance = new Rest.Api.FilesApi();
            }
            return m_apiInstance;
        }

        public static TileDB.Cloud.Rest.Model.FileCreated CreateFile(string name_space, string input_uri, string output_uri, string name = null)
        {
            TileDB.Cloud.Rest.Model.FileCreate fileCreate = new Rest.Model.FileCreate(input_uri, output_uri, name);
            return ApiInstance().HandleCreateFile(name_space, fileCreate, null);
        }

        public static async System.Threading.Tasks.Task<TileDB.Cloud.Rest.Model.FileCreated> CreateFileAsync(string name_space, string input_uri, string output_uri, string name = null)
        {
            TileDB.Cloud.Rest.Model.FileCreate fileCreate = new Rest.Model.FileCreate(input_uri, output_uri, name);
            return await ApiInstance().HandleCreateFileAsync(name_space, fileCreate);
        }

        public static TileDB.Cloud.Rest.Model.FileExported ExportFile(string uri, string output_uri) 
        {
            TileDB.Cloud.Rest.Model.FileExport fileExport = new Rest.Model.FileExport(output_uri);
            string name_space = uri.Split(":")[0];
            return ApiInstance().HandleExportFile(name_space, uri, fileExport);
        }

        public static async System.Threading.Tasks.Task<TileDB.Cloud.Rest.Model.FileExported> ExportFileAsync(string uri, string output_uri) 
        {
            TileDB.Cloud.Rest.Model.FileExport fileExport = new Rest.Model.FileExport(output_uri);
            string name_space = uri.Split(":")[0];
            return await ApiInstance().HandleExportFileAsync(name_space, uri, fileExport);
        }



    }
}
