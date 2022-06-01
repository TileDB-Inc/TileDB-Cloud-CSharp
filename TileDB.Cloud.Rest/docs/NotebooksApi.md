# TileDB.Cloud.Rest.Api.NotebooksApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotebooksNamespaceArrayEndTimestampsGet**](NotebooksApi.md#notebooksnamespacearrayendtimestampsget) | **GET** /notebooks/{namespace}/{array}/end_timestamps | 



## NotebooksNamespaceArrayEndTimestampsGet

> ArrayEndTimestampData NotebooksNamespaceArrayEndTimestampsGet (string _namespace, string array, int? page = null, int? perPage = null)



retrieve a list of timestamps from the array fragment info listing in milliseconds, paginated

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class NotebooksNamespaceArrayEndTimestampsGetExample
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

            var apiInstance = new NotebooksApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | namespace array is in (an organization name or user's username)
            var array = "array_example";  // string | name/uri of array that is url-encoded
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 

            try
            {
                ArrayEndTimestampData result = apiInstance.NotebooksNamespaceArrayEndTimestampsGet(_namespace, array, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotebooksApi.NotebooksNamespaceArrayEndTimestampsGet: " + e.Message );
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
 **array** | **string**| name/uri of array that is url-encoded | 
 **page** | **int?**| pagination offset | [optional] 
 **perPage** | **int?**| pagination limit | [optional] 

### Return type

[**ArrayEndTimestampData**](ArrayEndTimestampData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of timestamps in milliseconds, paginated |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

