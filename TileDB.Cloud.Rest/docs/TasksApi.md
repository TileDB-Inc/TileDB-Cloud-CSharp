# TileDB.Cloud.Rest.Api.TasksApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RunSQL**](TasksApi.md#runsql) | **POST** /sql/{namespace} | 
[**TaskIdGet**](TasksApi.md#taskidget) | **GET** /task/{id} | 
[**TaskIdResultGet**](TasksApi.md#taskidresultget) | **GET** /task/{id}/result | 
[**TasksGet**](TasksApi.md#tasksget) | **GET** /tasks | 



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
            Configuration.Default.BasePath = "/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-TILEDB-REST-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-TILEDB-REST-API-KEY", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | namespace to run task under is in (an organization name or user's username)
            var sql = new SQLParameters(); // SQLParameters | sql being submitted
            var acceptEncoding = "acceptEncoding_example";  // string | Encoding to use (optional) 

            try
            {
                List<Object> result = apiInstance.RunSQL(_namespace, sql, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TasksApi.RunSQL: " + e.Message );
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


## TaskIdGet

> ArrayTask TaskIdGet (string id)



Fetch an array task

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class TaskIdGetExample
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

            var apiInstance = new TasksApi(Configuration.Default);
            var id = "id_example";  // string | task ID to fetch

            try
            {
                ArrayTask result = apiInstance.TaskIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TasksApi.TaskIdGet: " + e.Message );
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
 **id** | **string**| task ID to fetch | 

### Return type

[**ArrayTask**](ArrayTask.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array task |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TaskIdResultGet

> string TaskIdResultGet (string id, string acceptEncoding = null)



Retrieve results of an array task

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class TaskIdResultGetExample
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

            var apiInstance = new TasksApi(Configuration.Default);
            var id = "id_example";  // string | task ID to retrieve stored results
            var acceptEncoding = "acceptEncoding_example";  // string | Encoding to use (optional) 

            try
            {
                string result = apiInstance.TaskIdResultGet(id, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TasksApi.TaskIdResultGet: " + e.Message );
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
 **id** | **string**| task ID to retrieve stored results | 
 **acceptEncoding** | **string**| Encoding to use | [optional] 

### Return type

**string**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | output and format of originating request |  * Content-Type - format results are delivered in <br>  |
| **202** | task is still executing |  -  |
| **404** | results were not saved, or results have expored |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TasksGet

> ArrayTaskData TasksGet (string _namespace = null, string createdBy = null, string array = null, int? start = null, int? end = null, int? page = null, int? perPage = null, string type = null, List<string> excludeType = null, List<string> fileType = null, List<string> excludeFileType = null, string status = null, string search = null, string orderby = null)



Fetch a list of all array tasks a user has access to

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class TasksGetExample
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

            var apiInstance = new TasksApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | namespace to filter (optional) 
            var createdBy = "createdBy_example";  // string | username to filter (optional) 
            var array = "array_example";  // string | name/uri of array that is url-encoded to filter (optional) 
            var start = 56;  // int? | start time for tasks to filter by (optional) 
            var end = 56;  // int? | end time for tasks to filter by (optional) 
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 
            var type = "type_example";  // string | task type, \"QUERY\", \"SQL\", \"UDF\", \"GENERIC_UDF\" (optional) 
            var excludeType = new List<string>(); // List<string> | task_type to exclude matching array in results, more than one can be included (optional) 
            var fileType = new List<string>(); // List<string> | match file_type of task array, more than one can be included (optional) 
            var excludeFileType = new List<string>(); // List<string> | exclude file_type of task arrays, more than one can be included (optional) 
            var status = "status_example";  // string | Filter to only return these statuses (optional) 
            var search = "search_example";  // string | search string that will look at name, namespace or description fields (optional) 
            var orderby = "orderby_example";  // string | sort by which field valid values include start_time, name (optional) 

            try
            {
                ArrayTaskData result = apiInstance.TasksGet(_namespace, createdBy, array, start, end, page, perPage, type, excludeType, fileType, excludeFileType, status, search, orderby);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TasksApi.TasksGet: " + e.Message );
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
 **_namespace** | **string**| namespace to filter | [optional] 
 **createdBy** | **string**| username to filter | [optional] 
 **array** | **string**| name/uri of array that is url-encoded to filter | [optional] 
 **start** | **int?**| start time for tasks to filter by | [optional] 
 **end** | **int?**| end time for tasks to filter by | [optional] 
 **page** | **int?**| pagination offset | [optional] 
 **perPage** | **int?**| pagination limit | [optional] 
 **type** | **string**| task type, \&quot;QUERY\&quot;, \&quot;SQL\&quot;, \&quot;UDF\&quot;, \&quot;GENERIC_UDF\&quot; | [optional] 
 **excludeType** | [**List&lt;string&gt;**](string.md)| task_type to exclude matching array in results, more than one can be included | [optional] 
 **fileType** | [**List&lt;string&gt;**](string.md)| match file_type of task array, more than one can be included | [optional] 
 **excludeFileType** | [**List&lt;string&gt;**](string.md)| exclude file_type of task arrays, more than one can be included | [optional] 
 **status** | **string**| Filter to only return these statuses | [optional] 
 **search** | **string**| search string that will look at name, namespace or description fields | [optional] 
 **orderby** | **string**| sort by which field valid values include start_time, name | [optional] 

### Return type

[**ArrayTaskData**](ArrayTaskData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of all tasks user has access too |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

