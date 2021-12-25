using System;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mimic python example at https://cloud.tiledb.com/notebooks/details/TileDB-Inc/File-Example/preview 

            //If you already set environment variable TILEDB_REST_TOKEN, you don't need 
            // to set any parameter for Login
            //string host = "https://api.tiledb.com";
            //string api_key = System.Environment.GetEnvironmentVariable("REST_TOKEN_KEY");
            //TileDB.Cloud.Client.Login(token:api_key,host:host);
            TileDB.Cloud.Client.Login();

            TileDB.Cloud.Rest.Model.User user_details = TileDB.Cloud.RestUtil.GetUser();
            Console.WriteLine("{0}", user_details.ToJson());

            string original_file = "s3://tiledb-inc-demo-data/files/original/VLDB17_TileDB.pdf";

            //TileDB File details
            string tiledb_file_name = "VLDB17_TileDB_Example";
            string tiledb_file_s3_uri = user_details.DefaultS3Path + "/" + tiledb_file_name;

            var arrayinfo = TileDB.Cloud.RestUtil.GetArrayInfo(user_details.Username, tiledb_file_s3_uri);
            if (arrayinfo != null)
            {
                System.Console.WriteLine("{0}", arrayinfo.ToJson());
                System.Console.WriteLine("Now start to delete {0}", tiledb_file_s3_uri);
                TileDB.Cloud.RestUtil.DeleteArray(user_details.Username, tiledb_file_s3_uri, "application/json");
            }
            else
            {
                System.Console.WriteLine("can not find uri: {0}", tiledb_file_s3_uri);
            }




            #region File Creation
            var file_details = TileDB.Cloud.RestUtil.CreateFile(user_details.Username, original_file, tiledb_file_s3_uri, tiledb_file_name);
            if (file_details == null)
            {
                System.Console.WriteLine("failed to create file:{0}", tiledb_file_s3_uri);
            }
            else
            {
                System.Console.WriteLine("{0}", file_details.ToJson());
            }
            #endregion FileCreation

            #region Searching the Catalog
            var arrayList = TileDB.Cloud.RestUtil.ListArrays(user_details.Username);
            Console.WriteLine("{0}", arrayList.ToJson());
            
            var listPublicArrays = TileDB.Cloud.RestUtil.ListPublicArrays(user_details.Username);
            Console.WriteLine("{0}", listPublicArrays.ToJson());
            
            var listSharedArrays = TileDB.Cloud.RestUtil.ListSharedArrays(user_details.Username);
            Console.WriteLine("{0}", listSharedArrays.ToJson());

            #endregion Searching the Catalog

            #region Export File Array to S3 
            // Export details
            string export_s3_uri = user_details.DefaultS3Path + "/" + "exported.pdf";

            var file_exported = TileDB.Cloud.RestUtil.ExportFile(user_details.Username, tiledb_file_s3_uri, export_s3_uri);
            if (file_exported == null)
            {
                System.Console.WriteLine("failed export from {0} to {1}", tiledb_file_s3_uri, export_s3_uri);
            }
            else
            {
                System.Console.WriteLine("{0}", file_exported.ToJson());
            }
            #endregion Export File

        }
    }
}