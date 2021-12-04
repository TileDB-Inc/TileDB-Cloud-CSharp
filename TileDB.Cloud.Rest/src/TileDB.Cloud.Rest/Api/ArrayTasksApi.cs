/*
 * TileDB Storage Platform API
 *
 * TileDB Storage Platform REST API
 *
 * The version of the OpenAPI document: 2.2.19
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace TileDB.Cloud.Rest.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IArrayTasksApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Fetch tasks created after this time, unix epoch in seconds, default 7 days ago (optional)</param>
        /// <param name="end">Fetch tasks created before this time, unix epoch in seconds, default now (optional)</param>
        /// <returns>ArrayTaskBrowserSidebar</returns>
        ArrayTaskBrowserSidebar GetArrayTasksSidebar (int? start = default(int?), int? end = default(int?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Fetch tasks created after this time, unix epoch in seconds, default 7 days ago (optional)</param>
        /// <param name="end">Fetch tasks created before this time, unix epoch in seconds, default now (optional)</param>
        /// <returns>ApiResponse of ArrayTaskBrowserSidebar</returns>
        ApiResponse<ArrayTaskBrowserSidebar> GetArrayTasksSidebarWithHttpInfo (int? start = default(int?), int? end = default(int?));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Fetch tasks created after this time, unix epoch in seconds, default 7 days ago (optional)</param>
        /// <param name="end">Fetch tasks created before this time, unix epoch in seconds, default now (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ArrayTaskBrowserSidebar</returns>
        System.Threading.Tasks.Task<ArrayTaskBrowserSidebar> GetArrayTasksSidebarAsync (int? start = default(int?), int? end = default(int?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Fetch tasks created after this time, unix epoch in seconds, default 7 days ago (optional)</param>
        /// <param name="end">Fetch tasks created before this time, unix epoch in seconds, default now (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ArrayTaskBrowserSidebar)</returns>
        System.Threading.Tasks.Task<ApiResponse<ArrayTaskBrowserSidebar>> GetArrayTasksSidebarWithHttpInfoAsync (int? start = default(int?), int? end = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ArrayTasksApi : IArrayTasksApi
    {
        private TileDB.Cloud.Rest.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayTasksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ArrayTasksApi(String basePath)
        {
            this.Configuration = new TileDB.Cloud.Rest.Client.Configuration { BasePath = basePath };

            ExceptionFactory = TileDB.Cloud.Rest.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayTasksApi"/> class
        /// </summary>
        /// <returns></returns>
        public ArrayTasksApi()
        {
            this.Configuration = TileDB.Cloud.Rest.Client.Configuration.Default;

            ExceptionFactory = TileDB.Cloud.Rest.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayTasksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ArrayTasksApi(TileDB.Cloud.Rest.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = TileDB.Cloud.Rest.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = TileDB.Cloud.Rest.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public TileDB.Cloud.Rest.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TileDB.Cloud.Rest.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Fetch tasks created after this time, unix epoch in seconds, default 7 days ago (optional)</param>
        /// <param name="end">Fetch tasks created before this time, unix epoch in seconds, default now (optional)</param>
        /// <returns>ArrayTaskBrowserSidebar</returns>
        public ArrayTaskBrowserSidebar GetArrayTasksSidebar (int? start = default(int?), int? end = default(int?))
        {
             ApiResponse<ArrayTaskBrowserSidebar> localVarResponse = GetArrayTasksSidebarWithHttpInfo(start, end);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Fetch tasks created after this time, unix epoch in seconds, default 7 days ago (optional)</param>
        /// <param name="end">Fetch tasks created before this time, unix epoch in seconds, default now (optional)</param>
        /// <returns>ApiResponse of ArrayTaskBrowserSidebar</returns>
        public ApiResponse<ArrayTaskBrowserSidebar> GetArrayTasksSidebarWithHttpInfo (int? start = default(int?), int? end = default(int?))
        {

            var localVarPath = "/tasks/sidebar";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (end != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end", end)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-TILEDB-REST-API-KEY")))
            {
                localVarHeaderParams["X-TILEDB-REST-API-KEY"] = this.Configuration.GetApiKeyWithPrefix("X-TILEDB-REST-API-KEY");
            }
            // authentication (BasicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetArrayTasksSidebar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ArrayTaskBrowserSidebar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ArrayTaskBrowserSidebar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArrayTaskBrowserSidebar)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Fetch tasks created after this time, unix epoch in seconds, default 7 days ago (optional)</param>
        /// <param name="end">Fetch tasks created before this time, unix epoch in seconds, default now (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ArrayTaskBrowserSidebar</returns>
        public async System.Threading.Tasks.Task<ArrayTaskBrowserSidebar> GetArrayTasksSidebarAsync (int? start = default(int?), int? end = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ArrayTaskBrowserSidebar> localVarResponse = await GetArrayTasksSidebarWithHttpInfoAsync(start, end, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Fetch tasks created after this time, unix epoch in seconds, default 7 days ago (optional)</param>
        /// <param name="end">Fetch tasks created before this time, unix epoch in seconds, default now (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ArrayTaskBrowserSidebar)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ArrayTaskBrowserSidebar>> GetArrayTasksSidebarWithHttpInfoAsync (int? start = default(int?), int? end = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/tasks/sidebar";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (end != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end", end)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-TILEDB-REST-API-KEY")))
            {
                localVarHeaderParams["X-TILEDB-REST-API-KEY"] = this.Configuration.GetApiKeyWithPrefix("X-TILEDB-REST-API-KEY");
            }
            // authentication (BasicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetArrayTasksSidebar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ArrayTaskBrowserSidebar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ArrayTaskBrowserSidebar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ArrayTaskBrowserSidebar)));
        }

    }
}
