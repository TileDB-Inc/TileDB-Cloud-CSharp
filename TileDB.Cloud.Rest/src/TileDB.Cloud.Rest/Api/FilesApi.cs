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
    public interface IFilesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a tiledb file at the specified location
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="fileCreate">Input/Output information to create a new TileDB file</param>
        /// <param name="X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME">Optional registered access credentials to use for creation (optional)</param>
        /// <returns>FileCreated</returns>
        FileCreated HandleCreateFile (string _namespace, FileCreate fileCreate, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a tiledb file at the specified location
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="fileCreate">Input/Output information to create a new TileDB file</param>
        /// <param name="X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME">Optional registered access credentials to use for creation (optional)</param>
        /// <returns>ApiResponse of FileCreated</returns>
        ApiResponse<FileCreated> HandleCreateFileWithHttpInfo (string _namespace, FileCreate fileCreate, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = default(string));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Export a TileDB File back to its original file format
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="file">The file identifier</param>
        /// <param name="fileExport">Export configuration information</param>
        /// <returns>FileExported</returns>
        FileExported HandleExportFile (string _namespace, string file, FileExport fileExport);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Export a TileDB File back to its original file format
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="file">The file identifier</param>
        /// <param name="fileExport">Export configuration information</param>
        /// <returns>ApiResponse of FileExported</returns>
        ApiResponse<FileExported> HandleExportFileWithHttpInfo (string _namespace, string file, FileExport fileExport);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a tiledb file at the specified location
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="fileCreate">Input/Output information to create a new TileDB file</param>
        /// <param name="X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME">Optional registered access credentials to use for creation (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FileCreated</returns>
        System.Threading.Tasks.Task<FileCreated> HandleCreateFileAsync (string _namespace, FileCreate fileCreate, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a tiledb file at the specified location
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="fileCreate">Input/Output information to create a new TileDB file</param>
        /// <param name="X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME">Optional registered access credentials to use for creation (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FileCreated)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileCreated>> HandleCreateFileWithHttpInfoAsync (string _namespace, FileCreate fileCreate, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Export a TileDB File back to its original file format
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="file">The file identifier</param>
        /// <param name="fileExport">Export configuration information</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FileExported</returns>
        System.Threading.Tasks.Task<FileExported> HandleExportFileAsync (string _namespace, string file, FileExport fileExport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Export a TileDB File back to its original file format
        /// </remarks>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="file">The file identifier</param>
        /// <param name="fileExport">Export configuration information</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FileExported)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileExported>> HandleExportFileWithHttpInfoAsync (string _namespace, string file, FileExport fileExport, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FilesApi : IFilesApi
    {
        private TileDB.Cloud.Rest.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FilesApi(String basePath)
        {
            this.Configuration = new TileDB.Cloud.Rest.Client.Configuration { BasePath = basePath };

            ExceptionFactory = TileDB.Cloud.Rest.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApi"/> class
        /// </summary>
        /// <returns></returns>
        public FilesApi()
        {
            this.Configuration = TileDB.Cloud.Rest.Client.Configuration.Default;

            ExceptionFactory = TileDB.Cloud.Rest.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FilesApi(TileDB.Cloud.Rest.Client.Configuration configuration = null)
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
        ///  Create a tiledb file at the specified location
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="fileCreate">Input/Output information to create a new TileDB file</param>
        /// <param name="X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME">Optional registered access credentials to use for creation (optional)</param>
        /// <returns>FileCreated</returns>
        public FileCreated HandleCreateFile (string _namespace, FileCreate fileCreate, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = default(string))
        {
             ApiResponse<FileCreated> localVarResponse = HandleCreateFileWithHttpInfo(_namespace, fileCreate, X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Create a tiledb file at the specified location
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="fileCreate">Input/Output information to create a new TileDB file</param>
        /// <param name="X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME">Optional registered access credentials to use for creation (optional)</param>
        /// <returns>ApiResponse of FileCreated</returns>
        public ApiResponse<FileCreated> HandleCreateFileWithHttpInfo (string _namespace, FileCreate fileCreate, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = default(string))
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null)
                throw new ApiException(400, "Missing required parameter '_namespace' when calling FilesApi->HandleCreateFile");
            // verify the required parameter 'fileCreate' is set
            if (fileCreate == null)
                throw new ApiException(400, "Missing required parameter 'fileCreate' when calling FilesApi->HandleCreateFile");

            var localVarPath = "/files/{namespace}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (_namespace != null) localVarPathParams.Add("namespace", this.Configuration.ApiClient.ParameterToString(_namespace)); // path parameter
            if (X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME != null) localVarHeaderParams.Add("X-TILEDB-CLOUD-ACCESS-CREDENTIALS-NAME", this.Configuration.ApiClient.ParameterToString(X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME)); // header parameter
            if (fileCreate != null && fileCreate.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fileCreate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fileCreate; // byte array
            }

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HandleCreateFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FileCreated>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FileCreated) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FileCreated)));
        }

        /// <summary>
        ///  Create a tiledb file at the specified location
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="fileCreate">Input/Output information to create a new TileDB file</param>
        /// <param name="X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME">Optional registered access credentials to use for creation (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FileCreated</returns>
        public async System.Threading.Tasks.Task<FileCreated> HandleCreateFileAsync (string _namespace, FileCreate fileCreate, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FileCreated> localVarResponse = await HandleCreateFileWithHttpInfoAsync(_namespace, fileCreate, X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Create a tiledb file at the specified location
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="fileCreate">Input/Output information to create a new TileDB file</param>
        /// <param name="X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME">Optional registered access credentials to use for creation (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FileCreated)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileCreated>> HandleCreateFileWithHttpInfoAsync (string _namespace, FileCreate fileCreate, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null)
                throw new ApiException(400, "Missing required parameter '_namespace' when calling FilesApi->HandleCreateFile");
            // verify the required parameter 'fileCreate' is set
            if (fileCreate == null)
                throw new ApiException(400, "Missing required parameter 'fileCreate' when calling FilesApi->HandleCreateFile");

            var localVarPath = "/files/{namespace}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (_namespace != null) localVarPathParams.Add("namespace", this.Configuration.ApiClient.ParameterToString(_namespace)); // path parameter
            if (X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME != null) localVarHeaderParams.Add("X-TILEDB-CLOUD-ACCESS-CREDENTIALS-NAME", this.Configuration.ApiClient.ParameterToString(X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME)); // header parameter
            if (fileCreate != null && fileCreate.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fileCreate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fileCreate; // byte array
            }

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HandleCreateFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FileCreated>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FileCreated) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FileCreated)));
        }

        /// <summary>
        ///  Export a TileDB File back to its original file format
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="file">The file identifier</param>
        /// <param name="fileExport">Export configuration information</param>
        /// <returns>FileExported</returns>
        public FileExported HandleExportFile (string _namespace, string file, FileExport fileExport)
        {
             ApiResponse<FileExported> localVarResponse = HandleExportFileWithHttpInfo(_namespace, file, fileExport);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Export a TileDB File back to its original file format
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="file">The file identifier</param>
        /// <param name="fileExport">Export configuration information</param>
        /// <returns>ApiResponse of FileExported</returns>
        public ApiResponse<FileExported> HandleExportFileWithHttpInfo (string _namespace, string file, FileExport fileExport)
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null)
                throw new ApiException(400, "Missing required parameter '_namespace' when calling FilesApi->HandleExportFile");
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling FilesApi->HandleExportFile");
            // verify the required parameter 'fileExport' is set
            if (fileExport == null)
                throw new ApiException(400, "Missing required parameter 'fileExport' when calling FilesApi->HandleExportFile");

            var localVarPath = "/files/{namespace}/{file}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (_namespace != null) localVarPathParams.Add("namespace", this.Configuration.ApiClient.ParameterToString(_namespace)); // path parameter
            if (file != null) localVarPathParams.Add("file", this.Configuration.ApiClient.ParameterToString(file)); // path parameter
            if (fileExport != null && fileExport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fileExport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fileExport; // byte array
            }

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HandleExportFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FileExported>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FileExported) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FileExported)));
        }

        /// <summary>
        ///  Export a TileDB File back to its original file format
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="file">The file identifier</param>
        /// <param name="fileExport">Export configuration information</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FileExported</returns>
        public async System.Threading.Tasks.Task<FileExported> HandleExportFileAsync (string _namespace, string file, FileExport fileExport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FileExported> localVarResponse = await HandleExportFileWithHttpInfoAsync(_namespace, file, fileExport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Export a TileDB File back to its original file format
        /// </summary>
        /// <exception cref="TileDB.Cloud.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">The namespace of the file</param>
        /// <param name="file">The file identifier</param>
        /// <param name="fileExport">Export configuration information</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FileExported)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileExported>> HandleExportFileWithHttpInfoAsync (string _namespace, string file, FileExport fileExport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null)
                throw new ApiException(400, "Missing required parameter '_namespace' when calling FilesApi->HandleExportFile");
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling FilesApi->HandleExportFile");
            // verify the required parameter 'fileExport' is set
            if (fileExport == null)
                throw new ApiException(400, "Missing required parameter 'fileExport' when calling FilesApi->HandleExportFile");

            var localVarPath = "/files/{namespace}/{file}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (_namespace != null) localVarPathParams.Add("namespace", this.Configuration.ApiClient.ParameterToString(_namespace)); // path parameter
            if (file != null) localVarPathParams.Add("file", this.Configuration.ApiClient.ParameterToString(file)); // path parameter
            if (fileExport != null && fileExport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fileExport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fileExport; // byte array
            }

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HandleExportFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FileExported>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FileExported) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FileExported)));
        }

    }
}
