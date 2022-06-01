# TileDB.Cloud.Rest.Api.TaskGraphLogsApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTaskGraphLog**](TaskGraphLogsApi.md#createtaskgraphlog) | **POST** /taskgraphs/{namespace}/log | 
[**GetTaskGraphLog**](TaskGraphLogsApi.md#gettaskgraphlog) | **GET** /taskgraphs/{namespace}/logs/{id} | 
[**ListTaskGraphLogs**](TaskGraphLogsApi.md#listtaskgraphlogs) | **GET** /taskgraphs/logs | 
[**ReportClientNode**](TaskGraphLogsApi.md#reportclientnode) | **POST** /taskgraphs/{namespace}/logs/{id}/report_client_node | 
[**UpdateTaskGraphLog**](TaskGraphLogsApi.md#updatetaskgraphlog) | **PATCH** /taskgraphs/{namespace}/logs/{id} | 



## CreateTaskGraphLog

> TaskGraphLog CreateTaskGraphLog (string _namespace, TaskGraphLog log)



Create a task graph log.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class CreateTaskGraphLogExample
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

            var apiInstance = new TaskGraphLogsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace that will own this task graph log.
            var log = new TaskGraphLog(); // TaskGraphLog | 

            try
            {
                TaskGraphLog result = apiInstance.CreateTaskGraphLog(_namespace, log);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TaskGraphLogsApi.CreateTaskGraphLog: " + e.Message );
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
 **_namespace** | **string**| The namespace that will own this task graph log. | 
 **log** | [**TaskGraphLog**](TaskGraphLog.md)|  | 

### Return type

[**TaskGraphLog**](TaskGraphLog.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The task graph was created. The returned TaskGraphLog will include the data the client sent, with the server-defined fields added in.  |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTaskGraphLog

> TaskGraphLog GetTaskGraphLog (string _namespace, string id)



Fetch information about a single task graph execution. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetTaskGraphLogExample
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

            var apiInstance = new TaskGraphLogsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace that owns this task graph log.
            var id = "id_example";  // string | The UUID of the task graph log entry.

            try
            {
                TaskGraphLog result = apiInstance.GetTaskGraphLog(_namespace, id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TaskGraphLogsApi.GetTaskGraphLog: " + e.Message );
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
 **_namespace** | **string**| The namespace that owns this task graph log. | 
 **id** | **string**| The UUID of the task graph log entry. | 

### Return type

[**TaskGraphLog**](TaskGraphLog.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Information about the execution of a single task graph. |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListTaskGraphLogs

> TaskGraphLogsData ListTaskGraphLogs (string _namespace = null, string createdBy = null, string search = null, DateTime? startTime = null, DateTime? endTime = null, int? page = null, int? perPage = null)



Fetch the task graph logs of a namespace the user has access to. The returned entries will include only summary data, and will not include information about the individual tasks that were executed. (This information is available when requesting an individual task graph log.) Entries in the response are ordered from newest to oldest. Pagination parameters work as in other API methods; see PaginationMetadata. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListTaskGraphLogsExample
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

            var apiInstance = new TaskGraphLogsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | Include logs for this namespace. (optional) 
            var createdBy = "createdBy_example";  // string | Include logs from only this user. (optional) 
            var search = "search_example";  // string | search string that will look at name. (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Include logs created after this time. (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Include logs created before this time. (optional) 
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 

            try
            {
                TaskGraphLogsData result = apiInstance.ListTaskGraphLogs(_namespace, createdBy, search, startTime, endTime, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TaskGraphLogsApi.ListTaskGraphLogs: " + e.Message );
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
 **_namespace** | **string**| Include logs for this namespace. | [optional] 
 **createdBy** | **string**| Include logs from only this user. | [optional] 
 **search** | **string**| search string that will look at name. | [optional] 
 **startTime** | **DateTime?**| Include logs created after this time. | [optional] 
 **endTime** | **DateTime?**| Include logs created before this time. | [optional] 
 **page** | **int?**| pagination offset | [optional] 
 **perPage** | **int?**| pagination limit | [optional] 

### Return type

[**TaskGraphLogsData**](TaskGraphLogsData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The task graph logs that matched the user&#39;s query. |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReportClientNode

> void ReportClientNode (string _namespace, string id, TaskGraphClientNodeStatus report)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ReportClientNodeExample
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

            var apiInstance = new TaskGraphLogsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace that owns this task graph log.
            var id = "id_example";  // string | The UUID of the task graph log entry.
            var report = new TaskGraphClientNodeStatus(); // TaskGraphClientNodeStatus | The node status to report.

            try
            {
                apiInstance.ReportClientNode(_namespace, id, report);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TaskGraphLogsApi.ReportClientNode: " + e.Message );
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
 **_namespace** | **string**| The namespace that owns this task graph log. | 
 **id** | **string**| The UUID of the task graph log entry. | 
 **report** | [**TaskGraphClientNodeStatus**](TaskGraphClientNodeStatus.md)| The node status to report. | 

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
| **204** | Status reported successfully. |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateTaskGraphLog

> void UpdateTaskGraphLog (string _namespace, string id, TaskGraphLog log)



Update information about a single task graph execution. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class UpdateTaskGraphLogExample
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

            var apiInstance = new TaskGraphLogsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace that owns this task graph log.
            var id = "id_example";  // string | The UUID of the task graph log entry.
            var log = new TaskGraphLog(); // TaskGraphLog | Updates to make to the task graph log. The only manual update that a client should need to make to a task graph log is to update its completion status to `succeeded`, `failed`, or `cancelled`. 

            try
            {
                apiInstance.UpdateTaskGraphLog(_namespace, id, log);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TaskGraphLogsApi.UpdateTaskGraphLog: " + e.Message );
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
 **_namespace** | **string**| The namespace that owns this task graph log. | 
 **id** | **string**| The UUID of the task graph log entry. | 
 **log** | [**TaskGraphLog**](TaskGraphLog.md)| Updates to make to the task graph log. The only manual update that a client should need to make to a task graph log is to update its completion status to &#x60;succeeded&#x60;, &#x60;failed&#x60;, or &#x60;cancelled&#x60;.  | 

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
| **204** | Log entry updated successfully. |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

