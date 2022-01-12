using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApi
{
    public class TestTileDBUtil
    {
        public static void Login()
        {
            string tiledb_rest_host = System.Environment.GetEnvironmentVariable("TILEDB_REST_HOST");
            if(string.IsNullOrEmpty(tiledb_rest_host))
            {
                tiledb_rest_host = "https://api.tiledb.com";
            }
            string tiledb_rest_token = System.Environment.GetEnvironmentVariable("TILEDB_REST_TOKEN");
            if (string.IsNullOrEmpty(tiledb_rest_token))
            {
                tiledb_rest_token = "";//set default token here
            }

            TileDB.Cloud.Client.Login(token: tiledb_rest_token, host: tiledb_rest_host);
        }
    }
}
