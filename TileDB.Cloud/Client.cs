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
                if (host.EndsWith("/v1"))
                {
                    host = host.Remove(host.Length - "/v1".Length);
                }
                else if (host.EndsWith("/v1/"))
                {
                    host = host.Remove(host.Length - "/v1/".Length);
                }
                cfg.GetConfig().BasePath = host + "/v1";
            }

            //Save configuration to json
            string cloud_config_dir = Config.DefaultConfigDir;
            if(!System.IO.Directory.Exists(cloud_config_dir))
            {
                try
                {
                    var dirinfo = System.IO.Directory.CreateDirectory(cloud_config_dir);
                    System.Console.WriteLine("created directory:{0}", dirinfo.ToString());
                }
                catch (System.IO.IOException ioe)
                {
                    System.Console.WriteLine("caught IOException:{0}", ioe.Message);
                }
                catch (System.UnauthorizedAccessException uae)
                {
                    System.Console.WriteLine("caught UnauthorizedAccessException:{0}", uae.Message);
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine("caught Exception:{0}", e.Message);
                }

            }

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
                    string temp_host = cfg.GetConfig().BasePath;
                    if (temp_host.EndsWith("/v1"))
                    {
                        temp_host = temp_host.Remove(temp_host.Length - "/v1".Length);
                    }
                    else if (temp_host.EndsWith("/v1/"))
                    {
                        temp_host = temp_host.Remove(temp_host.Length - "/v1/".Length);
                    }
                    jsonWritter.WritePropertyName("host");
                    jsonWritter.WriteValue(temp_host);
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

            TileDB.CSharp.Config tdb_config = new TileDB.CSharp.Config();
            if (!string.IsNullOrEmpty(cfg.GetConfig().Username))
            {
                tdb_config.Set("rest.username", cfg.GetConfig().Username);
            }
            if (!string.IsNullOrEmpty(cfg.GetConfig().Password)) {
                tdb_config.Set("rest.password", cfg.GetConfig().Password);
            }

            if (!string.IsNullOrEmpty(cfg.GetConfig().AccessToken)) {
                tdb_config.Set("rest.token", cfg.GetConfig().AccessToken);
            }

            if (!string.IsNullOrEmpty(cfg.GetConfig().BasePath)) {
                string temp_host = cfg.GetConfig().BasePath;
                if (temp_host.EndsWith("/v1"))
                {
                    temp_host = temp_host.Remove(temp_host.Length - "/v1".Length);
                }
                else if (temp_host.EndsWith("/v1/"))
                {
                    temp_host = temp_host.Remove(temp_host.Length - "/v1/".Length);
                }
                if(!string.IsNullOrEmpty(temp_host))
                {
                    tdb_config.Set("rest.server_address", temp_host);
                }

            }

            _context = new TileDB.CSharp.Context(tdb_config);
        }

        private static TileDB.CSharp.Context _context = new TileDB.CSharp.Context(new TileDB.CSharp.Config());
        public static TileDB.CSharp.Context GetContext()
        {
            return _context;
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
        protected TileDB.Cloud.Rest.Api.GroupsApi _groupsApi = null;
        protected TileDB.Cloud.Rest.Api.NotebookApi _notebookApi = null;
        protected TileDB.Cloud.Rest.Api.OrganizationApi _organizationApi = null;
        protected TileDB.Cloud.Rest.Api.SqlApi _sqlApi = null;
        protected TileDB.Cloud.Rest.Api.TasksApi _tasksApi = null;
        protected TileDB.Cloud.Rest.Api.UdfApi _udfApi = null;
        protected TileDB.Cloud.Rest.Api.UserApi _userApi = null;

        public TileDB.Cloud.Config GetConfig()
        {
            return _cfg;
        }
        public TileDB.Cloud.Rest.Client.ApiClient GetApiClient() { return _apiClient; }
        public TileDB.Cloud.Rest.Api.ArrayApi GetArrayApi() { return _arrayApi; }
        public TileDB.Cloud.Rest.Api.FilesApi GetFilesApi() { return _filesApi; }
        public TileDB.Cloud.Rest.Api.GroupsApi GetGroupsApi() { return _groupsApi; }
        public TileDB.Cloud.Rest.Api.NotebookApi GetNotebookApi() { return _notebookApi; }
        public TileDB.Cloud.Rest.Api.OrganizationApi GetOrganizationApi() { return _organizationApi; }
        public TileDB.Cloud.Rest.Api.SqlApi GetSqlApi() { return _sqlApi; }
        public TileDB.Cloud.Rest.Api.TasksApi GetTasksApi() { return _tasksApi; }
        public TileDB.Cloud.Rest.Api.UdfApi GetUdfApi() { return _udfApi; }
        public TileDB.Cloud.Rest.Api.UserApi GetUserApi() { return _userApi; }


        public Client(TileDB.Cloud.Config cfg)
        {
            _cfg = cfg;

            //Set timeout for restclient to 3600 seconds
            _cfg.GetConfig().Timeout = 3600000;

            _apiClient = new Rest.Client.ApiClient(_cfg.GetConfig());
            _arrayApi = new Rest.Api.ArrayApi(_cfg.GetConfig());
            _filesApi = new Rest.Api.FilesApi(_cfg.GetConfig());
            _groupsApi = new Rest.Api.GroupsApi(_cfg.GetConfig());
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
                .WaitAndRetryAsync(retryNumber,
                retryAttempt => System.TimeSpan.FromMilliseconds(retryNumber * retrySleep),
                (ex, timeSpan, context) =>
                {
                    System.Console.WriteLine("Caught exception and start to retry! {0}", ex.Message);
                }
                );
            var timeout = Polly.Policy.TimeoutAsync(timeoutSeconds);
            return Polly.Policy.WrapAsync(retry, timeout);
        }

        public Polly.Wrap.PolicyWrap GetRetryPolicyWrap()
        {
            int retryNumber = GetRetryNumber();
            int retrySleep = GetSleepMilliseconds();
            int timeoutSeconds = GetTimeoutSeconds();
            var retry = Polly.Policy.Handle<Rest.Client.ApiException>()
                .WaitAndRetry(retryNumber,
                retryAttempt => System.TimeSpan.FromMilliseconds( retryNumber * retrySleep),
                (ex,timeSpan,context) =>
                {
                    System.Console.WriteLine("Caught exception and start to retry! {0}",ex.Message);
                }
                );
            var timeout = Polly.Policy.Timeout(timeoutSeconds);
            return Polly.Policy.Wrap(retry, timeout);
        }

        #endregion Retry Policy

    }
}
