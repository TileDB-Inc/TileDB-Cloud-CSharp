# TileDB.Cloud.Rest.Api.NotebookApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNotebookServerStatus**](NotebookApi.md#getnotebookserverstatus) | **GET** /notebooks/server/{namespace}/status | 
[**HandleCopyNotebook**](NotebookApi.md#handlecopynotebook) | **POST** /notebooks/{namespace}/{array}/copy | 
[**HandleUploadNotebook**](NotebookApi.md#handleuploadnotebook) | **POST** /notebooks/{namespace}/upload | 
[**ShutdownNotebookServer**](NotebookApi.md#shutdownnotebookserver) | **DELETE** /notebooks/server/{namespace} | 
[**UpdateNotebookName**](NotebookApi.md#updatenotebookname) | **PATCH** /notebooks/{namespace}/{array}/rename | 



## GetNotebookServerStatus

> NotebookStatus GetNotebookServerStatus (string _namespace)



Get status of the notebook server

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetNotebookServerStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NotebookApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | namespace notebook is in (an organization name or user's username)

            try
            {
                NotebookStatus result = apiInstance.GetNotebookServerStatus(_namespace);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotebookApi.GetNotebookServerStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| namespace notebook is in (an organization name or user&#39;s username) | 

### Return type

[**NotebookStatus**](NotebookStatus.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | status of running notebook |  -  |
| **202** | Notebook server is pending |  -  |
| **402** | Payment required |  -  |
| **404** | Notebook is not running |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HandleCopyNotebook

> NotebookCopied HandleCopyNotebook (string _namespace, string array, NotebookCopy notebookCopy, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = null, int? endTimestamp = null)



Copy a tiledb notebook at the specified location

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class HandleCopyNotebookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NotebookApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the notebook
            var array = "array_example";  // string | The name of the notebook
            var notebookCopy = new NotebookCopy(); // NotebookCopy | Input/Output information to create a new TileDB file
            var X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = "X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME_example";  // string | Optional registered access credentials to use for creation (optional) 
            var endTimestamp = 56;  // int? | Milliseconds since Unix epoch, copy will use open_at functionality to copy notebook created at the specific timestamp (optional) 

            try
            {
                NotebookCopied result = apiInstance.HandleCopyNotebook(_namespace, array, notebookCopy, X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME, endTimestamp);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotebookApi.HandleCopyNotebook: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The namespace of the notebook | 
 **array** | **string**| The name of the notebook | 
 **notebookCopy** | [**NotebookCopy**](NotebookCopy.md)| Input/Output information to create a new TileDB file | 
 **X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME** | **string**| Optional registered access credentials to use for creation | [optional] 
 **endTimestamp** | **int?**| Milliseconds since Unix epoch, copy will use open_at functionality to copy notebook created at the specific timestamp | [optional] 

### Return type

[**NotebookCopied**](NotebookCopied.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Notebook copied |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HandleUploadNotebook

> FileUploaded HandleUploadNotebook (string _namespace, System.IO.Stream inputFile, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = null, string outputUri = null, string name = null)



Upload a notebook at the specified location

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class HandleUploadNotebookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NotebookApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the notebook
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | the notebook to upload
            var X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = "X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME_example";  // string | Optional registered access credentials to use for creation (optional) 
            var outputUri = "outputUri_example";  // string | output location of the TileDB File (optional) 
            var name = "name_example";  // string | name to set for registered file (optional) 

            try
            {
                FileUploaded result = apiInstance.HandleUploadNotebook(_namespace, inputFile, X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME, outputUri, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotebookApi.HandleUploadNotebook: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The namespace of the notebook | 
 **inputFile** | **System.IO.Stream**| the notebook to upload | 
 **X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME** | **string**| Optional registered access credentials to use for creation | [optional] 
 **outputUri** | **string**| output location of the TileDB File | [optional] 
 **name** | **string**| name to set for registered file | [optional] 

### Return type

[**FileUploaded**](FileUploaded.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | File uploaded |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ShutdownNotebookServer

> void ShutdownNotebookServer (string _namespace)



Shutdown a notebook server

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ShutdownNotebookServerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NotebookApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | namespace notebook is in (an organization name or user's username)

            try
            {
                apiInstance.ShutdownNotebookServer(_namespace);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotebookApi.ShutdownNotebookServer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| namespace notebook is in (an organization name or user&#39;s username) | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Notebook shutdown successfully |  -  |
| **404** | Notebook is not running |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateNotebookName

> void UpdateNotebookName (string _namespace, string array, ArrayInfoUpdate notebookMetadata)



update name on a notebok, moving related S3 object to new location

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class UpdateNotebookNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NotebookApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | namespace array is in (an organization name or user's username)
            var array = "array_example";  // string | name/uri of notebook (array) that is url-encoded
            var notebookMetadata = new ArrayInfoUpdate(); // ArrayInfoUpdate | notebook (array) metadata to update

            try
            {
                apiInstance.UpdateNotebookName(_namespace, array, notebookMetadata);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotebookApi.UpdateNotebookName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| namespace array is in (an organization name or user&#39;s username) | 
 **array** | **string**| name/uri of notebook (array) that is url-encoded | 
 **notebookMetadata** | [**ArrayInfoUpdate**](ArrayInfoUpdate.md)| notebook (array) metadata to update | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | notebook name updated successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

