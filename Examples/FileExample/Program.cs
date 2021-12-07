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
            TileDB.Cloud.Client.Login();

            TileDB.Cloud.Rest.Model.User user_details = TileDB.Cloud.RestUtil.GetUser();
            Console.WriteLine("{0}", user_details.ToJson());

            string original_file = "s3://tiledb-inc-demo-data/files/original/VLDB17_TileDB.pdf";

            //TileDB File details
            string tiledb_file_name = "VLDB17_TileDB_Example";
            string tiledb_file_s3_uri = user_details.DefaultS3Path + "/" + tiledb_file_name;
            string uri = "tiledb://" + user_details.Username + "/" + tiledb_file_s3_uri;

            // Export details
            string export_local_path = "exported.pdf";
            string export_s3_uri = user_details.DefaultS3Path + "/" + "exported.pdf";
            try
            {
                var arrayinfo = TileDB.Cloud.RestUtil.GetArrayInfo(uri);
                TileDB.Cloud.RestUtil.DeleteArray(uri, "application/json");
            }
            catch(TileDB.Cloud.Rest.Client.ApiException apiexception)
            {
                System.Console.WriteLine("got exception:{0},{1} not exist!", uri,apiexception.Message);
            }

            #region File Creation
            try
            {
                var file_details = TileDB.Cloud.RestUtil.CreateFile(user_details.Username, original_file, tiledb_file_s3_uri, tiledb_file_name);
            }
            catch (TileDB.Cloud.Rest.Client.ApiException apiexception)
            {
                System.Console.WriteLine("got exception:{0}", apiexception.Message);
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

            #region Export File
            try
            {
                var file_created = TileDB.Cloud.RestUtil.ExportFile(uri, export_s3_uri);
            }
            catch (TileDB.Cloud.Rest.Client.ApiException apiexception)
            {
                System.Console.WriteLine("got exception:{0}", apiexception.Message);
            }
            #endregion Export File

        }
    }
}