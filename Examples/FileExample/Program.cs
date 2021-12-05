using System;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TileDB.Cloud.Rest.Client.Configuration cfg = new TileDB.Cloud.Rest.Client.Configuration();

            cfg.BasePath = "https://api.tiledb.com/v1";
            string rest_token = System.Environment.GetEnvironmentVariable("TILEDB_REST_TOKEN");
            cfg.AccessToken = rest_token;

             TileDB.Cloud.Rest.Model.User userprofile = TileDB.Cloud.RestUtil.GetUser(cfg);
             System.Console.WriteLine("{0}", userprofile.ToJson());

        }
    }
}
