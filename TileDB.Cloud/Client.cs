using Polly;

namespace TileDB.Cloud
{
    public class Client
    {
   
        public static void Login(string token = default(string), string username = default(string), string password = default(string), string host=default(string))
        {
            TileDB.Cloud.Config cfg = new Config();
            if(!string.IsNullOrEmpty(token))
            {
                cfg.GetConfig().AddApiKey("X-TILEDB-REST-API-KEY", token);
                cfg.GetConfig().AccessToken = token;
            }

            if(!string.IsNullOrEmpty(username)) 
            {
                cfg.GetConfig().Username = username;
            }

            if(!string.IsNullOrEmpty(password)) 
            {
                cfg.GetConfig().Password = password;
            }

            if(!string.IsNullOrEmpty(host)) 
            {
                cfg.GetConfig().BasePath = host;
            }

            //Save configuration to json
            string cloud_json_file = Config.DefaultConfigFile;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.IO.StringWriter sw = new System.IO.StringWriter(sb);
            using(Newtonsoft.Json.JsonWriter jsonWritter = new Newtonsoft.Json.JsonTextWriter(sw)) 
            {
                jsonWritter.Formatting = Newtonsoft.Json.Formatting.Indented;
                jsonWritter.WriteStartObject();
                
                if(!string.IsNullOrEmpty(cfg.GetConfig().AccessToken))
                {
                    jsonWritter.WritePropertyName("api_key");
                    jsonWritter.WriteStartObject();
                    jsonWritter.WritePropertyName("X-TILEDB-REST-API-KEY");
                    jsonWritter.WriteValue(cfg.GetConfig().AccessToken);
                    jsonWritter.WriteEndObject();
                } 

                if(!string.IsNullOrEmpty(cfg.GetConfig().BasePath)) 
                {
                    jsonWritter.WritePropertyName("host");
                    jsonWritter.WriteValue(cfg.GetConfig().BasePath);
                }

                if(!string.IsNullOrEmpty(cfg.GetConfig().Username)) 
                {
                    jsonWritter.WritePropertyName("username");
                    jsonWritter.WriteValue(cfg.GetConfig().Username);
                }

                if (!string.IsNullOrEmpty(cfg.GetConfig().Password))
                {
                    jsonWritter.WritePropertyName("password");
                    jsonWritter.WriteValue(cfg.GetConfig().Password);
                }

                jsonWritter.WritePropertyName("verify_ssl");
                jsonWritter.WriteValue(true);

                jsonWritter.WriteEndObject();

            }

            System.IO.File.WriteAllText(cloud_json_file, sb.ToString());

            _instance = new Client(cfg);

        }
        private static Client _instance = null;
        public static Client GetInstance()
        {
            if(_instance == null)
            {
                Login();
            }
            return _instance;
        }


        protected TileDB.Cloud.Config _cfg = null;
        protected TileDB.Cloud.Rest.Client.ApiClient _apiClient = null;
        protected TileDB.Cloud.Rest.Api.ArrayApi _arrayApi = null;
        protected TileDB.Cloud.Rest.Api.FilesApi _filesApi = null;
        protected TileDB.Cloud.Rest.Api.NotebookApi _notebookApi = null;
        protected TileDB.Cloud.Rest.Api.OrganizationApi _organizationApi = null;
        protected TileDB.Cloud.Rest.Api.SqlApi _sqlApi = null;
        protected TileDB.Cloud.Rest.Api.TasksApi _tasksApi = null;
        protected TileDB.Cloud.Rest.Api.UdfApi _udfApi = null;
        protected TileDB.Cloud.Rest.Api.UserApi _userApi = null;

        public TileDB.Cloud.Rest.Client.ApiClient GetApiClient()
        {
            return _apiClient;
        }
        public TileDB.Cloud.Rest.Api.ArrayApi GetArrayApi()
        {
            return _arrayApi;
        }
        public TileDB.Cloud.Rest.Api.FilesApi GetFilesApi() { return _filesApi; }
        public TileDB.Cloud.Rest.Api.NotebookApi GetNotebookApi() { return _notebookApi; }
        public TileDB.Cloud.Rest.Api.OrganizationApi GetOrganizationApi() { return _organizationApi; }
        public TileDB.Cloud.Rest.Api.SqlApi GetSqlApi() { return _sqlApi; }
        public TileDB.Cloud.Rest.Api.TasksApi GetTasksApi() { return _tasksApi; }
        public TileDB.Cloud.Rest.Api.UdfApi GetUdfApi() { return _udfApi; }
        public TileDB.Cloud.Rest.Api.UserApi GetUserApi() { return _userApi; }


        public Client(TileDB.Cloud.Config cfg)
        {
            _cfg = cfg;

            _apiClient = new Rest.Client.ApiClient(_cfg.GetConfig());
            _arrayApi = new Rest.Api.ArrayApi(_cfg.GetConfig());
            _filesApi = new Rest.Api.FilesApi(_cfg.GetConfig());
            _notebookApi = new Rest.Api.NotebookApi(_cfg.GetConfig());
            _organizationApi = new Rest.Api.OrganizationApi(_cfg.GetConfig());
            _sqlApi = new Rest.Api.SqlApi(_cfg.GetConfig());
            _tasksApi = new Rest.Api.TasksApi(_cfg.GetConfig());
            _udfApi = new Rest.Api.UdfApi(_cfg.GetConfig());
            _userApi = new Rest.Api.UserApi(_cfg.GetConfig());

        }

        #region Retry Policy
        private int GetPositiveIntConfigValue(string key)
        {
            int result = 0;

            if (_cfg != null && _cfg.GetConfig() != null && _cfg.GetConfig().ApiKey.ContainsKey(key))
            {
                string str = _cfg.GetConfig().ApiKey[key];
                if (int.TryParse(str, out int v))
                {
                    if (v > 0)
                    {
                        result = v;
                    }
                }
            }


            return result;
        }
        public int GetRetryNumber()
        {
            int retryNumber = 3; //default value

            string key = "rest.retries";
            int v = GetPositiveIntConfigValue(key);
            if(v>0)
            {
                retryNumber = v;
            }
  
            return retryNumber;
        }

        public int GetSleepMilliseconds()
        {
            int result = 1000;
            string key = "rest.sleepmilliseconds";
            int v = GetPositiveIntConfigValue(key);
            if(v>0)
            {
                result = v;
            }
            return result;
        }

        public int GetTimeoutSeconds()
        {
            int result = 3600;
            string key = "rest.timeoutseconds";
            int v = GetPositiveIntConfigValue(key);
            if (v > 0)
            {
                result = v;
            }
            return result;
        }


   
        public Polly.Wrap.AsyncPolicyWrap GetRetryAsyncPolicyWrap()
        {
            int retryNumber = GetRetryNumber();
            int retrySleep = GetSleepMilliseconds();
            int timeoutSeconds = GetTimeoutSeconds();
            var retry = Polly.Policy.Handle<Rest.Client.ApiException>()
                .WaitAndRetryAsync(retryNumber, retryAttemp => System.TimeSpan.FromMilliseconds(retryNumber * retrySleep));
            var timeout = Polly.Policy.TimeoutAsync(timeoutSeconds);
            return Polly.Policy.WrapAsync(retry, timeout);
        }

        public Polly.Wrap.PolicyWrap GetRetryPolicyWrap()
        {
            int retryNumber = GetRetryNumber();
            int retrySleep = GetSleepMilliseconds();
            int timeoutSeconds = GetTimeoutSeconds();
            var retry = Polly.Policy.Handle<Rest.Client.ApiException>()
                .WaitAndRetry(retryNumber, retryAttemp => System.TimeSpan.FromMilliseconds( retryNumber * retrySleep));
            var timeout = Polly.Policy.Timeout(timeoutSeconds);
            return Polly.Policy.Wrap(retry, timeout);
        }

        #endregion Retry Policy

    }
}