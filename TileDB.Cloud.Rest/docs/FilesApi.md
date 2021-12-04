# TileDB.Cloud.Rest.Api.FilesApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HandleCreateFile**](FilesApi.md#handlecreatefile) | **POST** /files/{namespace} | 
[**HandleExportFile**](FilesApi.md#handleexportfile) | **POST** /files/{namespace}/{file}/export | 



## HandleCreateFile

> FileCreated HandleCreateFile (string _namespace, FileCreate fileCreate, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = null)



Create a tiledb file at the specified location

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class HandleCreateFileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FilesApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The namespace of the file
            var fileCreate = new FileCreate(); // FileCreate | Input/Output information to create a new TileDB file
            var X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME_example;  // string | Optional registered access credentials to use for creation (optional) 

            try
            {
                FileCreated result = apiInstance.HandleCreateFile(_namespace, fileCreate, X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.HandleCreateFile: " + e.Message );
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
 **_namespace** | **string**| The namespace of the file | 
 **fileCreate** | [**FileCreate**](FileCreate.md)| Input/Output information to create a new TileDB file | 
 **X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME** | **string**| Optional registered access credentials to use for creation | [optional] 

### Return type

[**FileCreated**](FileCreated.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | File created |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HandleExportFile

> FileExported HandleExportFile (string _namespace, string file, FileExport fileExport)



Export a TileDB File back to its original file format

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class HandleExportFileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FilesApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The namespace of the file
            var file = file_example;  // string | The file identifier
            var fileExport = new FileExport(); // FileExport | Export configuration information

            try
            {
                FileExported result = apiInstance.HandleExportFile(_namespace, file, fileExport);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FilesApi.HandleExportFile: " + e.Message );
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
 **_namespace** | **string**| The namespace of the file | 
 **file** | **string**| The file identifier | 
 **fileExport** | [**FileExport**](FileExport.md)| Export configuration information | 

### Return type

[**FileExported**](FileExported.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | File exported |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

