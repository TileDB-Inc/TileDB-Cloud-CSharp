# TileDB.Cloud.Rest.Api.FilesApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HandleCreateFile**](FilesApi.md#handlecreatefile) | **POST** /files/{namespace} | 
[**HandleExportFile**](FilesApi.md#handleexportfile) | **POST** /files/{namespace}/{file}/export | 
[**HandleUploadFile**](FilesApi.md#handleuploadfile) | **POST** /files/{namespace}/upload | 


<a name="handlecreatefile"></a>
# **HandleCreateFile**
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
            Configuration config = new Configuration();
            config.BasePath = "/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new FilesApi(config);
            var _namespace = "_namespace_example";  // string | The namespace of the file
            var fileCreate = new FileCreate(); // FileCreate | Input/Output information to create a new TileDB file
            var X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = "X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME_example";  // string | Optional registered access credentials to use for creation (optional) 

            try
            {
                FileCreated result = apiInstance.HandleCreateFile(_namespace, fileCreate, X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handleexportfile"></a>
# **HandleExportFile**
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
            Configuration config = new Configuration();
            config.BasePath = "/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new FilesApi(config);
            var _namespace = "_namespace_example";  // string | The namespace of the file
            var file = "file_example";  // string | The file identifier
            var fileExport = new FileExport(); // FileExport | Export configuration information

            try
            {
                FileExported result = apiInstance.HandleExportFile(_namespace, file, fileExport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handleuploadfile"></a>
# **HandleUploadFile**
> FileUploaded HandleUploadFile (string _namespace, System.IO.Stream inputFile, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = null, string outputUri = null, string name = null)



Upload a tiledb file at the specified location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class HandleUploadFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new FilesApi(config);
            var _namespace = "_namespace_example";  // string | The namespace of the file
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | the file to upload
            var X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = "X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME_example";  // string | Optional registered access credentials to use for creation (optional) 
            var outputUri = "outputUri_example";  // string | output location of the TileDB File (optional) 
            var name = "name_example";  // string | name to set for registered file (optional) 

            try
            {
                FileUploaded result = apiInstance.HandleUploadFile(_namespace, inputFile, X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME, outputUri, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.HandleUploadFile: " + e.Message );
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
 **inputFile** | **System.IO.Stream****System.IO.Stream**| the file to upload | 
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
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

