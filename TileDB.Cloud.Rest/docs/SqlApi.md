# TileDB.Cloud.Rest.Api.SqlApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RunSQL**](SqlApi.md#runsql) | **POST** /sql/{namespace} | 



## RunSQL

> List&lt;Object&gt; RunSQL (string _namespace, SQLParameters sql, string acceptEncoding = null)



Run a sql query

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class RunSQLExample
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

            var apiInstance = new SqlApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace to run task under is in (an organization name or user's username)
            var sql = new SQLParameters(); // SQLParameters | sql being submitted
            var acceptEncoding = acceptEncoding_example;  // string | Encoding to use (optional) 

            try
            {
                List<Object> result = apiInstance.RunSQL(_namespace, sql, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SqlApi.RunSQL: " + e.Message );
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
 **_namespace** | **string**| namespace to run task under is in (an organization name or user&#39;s username) | 
 **sql** | [**SQLParameters**](SQLParameters.md)| sql being submitted | 
 **acceptEncoding** | **string**| Encoding to use | [optional] 

### Return type

**List<Object>**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON results in array of objects form, if the query returns results |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |
| **204** | SQL executed successfully |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

