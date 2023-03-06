# TileDB.Cloud.Rest.Api.ArrayTasksApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetArrayTasksSidebar**](ArrayTasksApi.md#getarraytaskssidebar) | **GET** /tasks/sidebar | 


<a name="getarraytaskssidebar"></a>
# **GetArrayTasksSidebar**
> ArrayTaskBrowserSidebar GetArrayTasksSidebar (int? start = null, int? end = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArrayTasksSidebarExample
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

            var apiInstance = new ArrayTasksApi(config);
            var start = 56;  // int? | Fetch tasks created after this time, unix epoch in seconds, default 7 days ago (optional) 
            var end = 56;  // int? | Fetch tasks created before this time, unix epoch in seconds, default now (optional) 

            try
            {
                ArrayTaskBrowserSidebar result = apiInstance.GetArrayTasksSidebar(start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArrayTasksApi.GetArrayTasksSidebar: " + e.Message );
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
 **start** | **int?**| Fetch tasks created after this time, unix epoch in seconds, default 7 days ago | [optional] 
 **end** | **int?**| Fetch tasks created before this time, unix epoch in seconds, default now | [optional] 

### Return type

[**ArrayTaskBrowserSidebar**](ArrayTaskBrowserSidebar.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | sidebar metadata for task definitions for all arrays user has access to |  -  |
| **404** | array tasks not found |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

