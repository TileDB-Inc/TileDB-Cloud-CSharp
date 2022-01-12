using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using static System.Environment;

namespace TileDB.Cloud
{
    public class RestApiKey
    {
        [JsonProperty(PropertyName = "X-TILEDB-REST-API-KEY")]
        public string Key { get; set; }
    }

    public class RestConfig
    {
        [JsonProperty(PropertyName = "api_key")]
        public RestApiKey? ApiKey { get; set; }

        [JsonProperty(PropertyName = "host")] public string Host { get; set; }

        [JsonProperty(PropertyName = "verify_ssl")]
        public string VerifySSL { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }

    public class Config
    {
        const string REST_HOST = "TILEDB_REST_HOST";
        const string REST_TOKEN = "TILEDB_REST_TOKEN";
        const string REST_USERNAME = "TILEDB_REST_USERNAME";
        const string REST_PASSWORD = "TILEDB_REST_PASSWORD";

        public static string DefaultHost = "https://api.tiledb.com";

        public static string DefaultConfigDir = Path.Join(GetFolderPath(SpecialFolder.UserProfile), ".tiledb");

        public static string DefaultConfigFile =
            Path.Join(GetFolderPath(SpecialFolder.UserProfile), ".tiledb", "cloud.json");

        private TileDB.Cloud.Rest.Client.Configuration _config;
        private string _host;

        public Config()
        {
            _host = DefaultHost;
            _config = new TileDB.Cloud.Rest.Client.Configuration();
            System.Console.WriteLine("start to load configuration...");
            LoadConfiguration();
        }

        public TileDB.Cloud.Rest.Client.Configuration GetConfig()
        {
            return _config;
        }

        public string Host { 
            get
            {
                return _host;
            } 
        }
        public string Token
        {
            get
            {
                return _config.AccessToken;
            }
        }

        public string Username
        {
            get
            {
                return _config.Username;
            }
        }

        public string Password
        {
            get
            {
                return _config.Password;
            }
        }

        private bool LoadConfiguration(string configFile = "")
        {
            if (configFile == string.Empty)
            {
                configFile = DefaultConfigFile;
            }

            string host = GetEnvironmentVariable(REST_HOST);
            string token = GetEnvironmentVariable(REST_TOKEN);
            string username = GetEnvironmentVariable(REST_USERNAME);
            string password = GetEnvironmentVariable(REST_PASSWORD);

   //         bool VerifySSL = true;

            RestConfig restConfig = new RestConfig();
            if (File.Exists(configFile))
            {
                restConfig = JsonConvert.DeserializeObject<RestConfig>(File.ReadAllText(configFile));

            }

            if (String.IsNullOrEmpty(username))
            {
                if (!String.IsNullOrEmpty(restConfig.Username))
                {
                    _config.Username = restConfig.Username;
                }
            }

            if (String.IsNullOrEmpty(password))
            {
                if (!String.IsNullOrEmpty(restConfig.Password))
                {
                    _config.Password = restConfig.Password;
                }
            }

            if (String.IsNullOrEmpty(host))
            {
                if (!String.IsNullOrEmpty(restConfig.Host))
                {
                    host = restConfig.Host;
                }
            }


            if (String.IsNullOrEmpty(token))
            {
                if (restConfig.ApiKey != null)
                {
                    if (!String.IsNullOrEmpty(restConfig.ApiKey.Key))
                    {
                        token = restConfig.ApiKey.Key;
                    }
                }
            }
            if(!String.IsNullOrEmpty(token))
            {
                _config.AddApiKey("X-TILEDB-REST-API-KEY", token);
                _config.AccessToken = token;
            }

            if (String.IsNullOrEmpty(token) && String.IsNullOrEmpty(username))
            {
                return false;
            }

            if (String.IsNullOrEmpty(host))
            {
                host = DefaultHost;
            }
            if (host.EndsWith("/v1"))
            {
                host = host.Remove(host.Length - "/v1".Length);
            }
            else if (host.EndsWith("/v1/"))
            {
                host = host.Remove(host.Length - "/v1/".Length);
            }
            _host = host;
            _config.BasePath = host + "/v1";

            return true;
        }
    }
 

}