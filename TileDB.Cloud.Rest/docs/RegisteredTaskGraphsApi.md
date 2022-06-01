# TileDB.Cloud.Rest.Api.RegisteredTaskGraphsApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRegisteredTaskGraph**](RegisteredTaskGraphsApi.md#deleteregisteredtaskgraph) | **DELETE** /taskgraphs/{namespace}/registered/{name} | 
[**GetRegisteredTaskGraph**](RegisteredTaskGraphsApi.md#getregisteredtaskgraph) | **GET** /taskgraphs/{namespace}/registered/{name} | 
[**GetRegisteredTaskGraphSharingPolicies**](RegisteredTaskGraphsApi.md#getregisteredtaskgraphsharingpolicies) | **GET** /taskgraphs/{namespace}/registered/{name}/share | 
[**RegisterRegisteredTaskGraph**](RegisteredTaskGraphsApi.md#registerregisteredtaskgraph) | **POST** /taskgraphs/{namespace}/registered/{name} | 
[**ShareRegisteredTaskGraph**](RegisteredTaskGraphsApi.md#shareregisteredtaskgraph) | **PATCH** /taskgraphs/{namespace}/registered/{name}/share | 
[**UpdateRegisteredTaskGraph**](RegisteredTaskGraphsApi.md#updateregisteredtaskgraph) | **PATCH** /taskgraphs/{namespace}/registered/{name} | 



## DeleteRegisteredTaskGraph

> void DeleteRegisteredTaskGraph (string _namespace, string name)



Delete the given registered task graph. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteRegisteredTaskGraphExample
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

            var apiInstance = new RegisteredTaskGraphsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace that owns this registered UDF.
            var name = "name_example";  // string | The name of the registered task graph.

            try
            {
                apiInstance.DeleteRegisteredTaskGraph(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegisteredTaskGraphsApi.DeleteRegisteredTaskGraph: " + e.Message );
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
 **_namespace** | **string**| The namespace that owns this registered UDF. | 
 **name** | **string**| The name of the registered task graph. | 

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
| **204** | Task graph successfully deleted. |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRegisteredTaskGraph

> RegisteredTaskGraph GetRegisteredTaskGraph (string _namespace, string name)



Fetch the contents of this registered task graph. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetRegisteredTaskGraphExample
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

            var apiInstance = new RegisteredTaskGraphsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace that owns this registered UDF.
            var name = "name_example";  // string | The name of the registered task graph.

            try
            {
                RegisteredTaskGraph result = apiInstance.GetRegisteredTaskGraph(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegisteredTaskGraphsApi.GetRegisteredTaskGraph: " + e.Message );
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
 **_namespace** | **string**| The namespace that owns this registered UDF. | 
 **name** | **string**| The name of the registered task graph. | 

### Return type

[**RegisteredTaskGraph**](RegisteredTaskGraph.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The contents of the registered task graph. |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRegisteredTaskGraphSharingPolicies

> List&lt;TaskGraphSharing&gt; GetRegisteredTaskGraphSharingPolicies (string _namespace, string name)



Get sharing policies for the task graph.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetRegisteredTaskGraphSharingPoliciesExample
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

            var apiInstance = new RegisteredTaskGraphsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace that owns the registered task graph.
            var name = "name_example";  // string | The name of the task graph.

            try
            {
                List<TaskGraphSharing> result = apiInstance.GetRegisteredTaskGraphSharingPolicies(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegisteredTaskGraphsApi.GetRegisteredTaskGraphSharingPolicies: " + e.Message );
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
 **_namespace** | **string**| The namespace that owns the registered task graph. | 
 **name** | **string**| The name of the task graph. | 

### Return type

[**List&lt;TaskGraphSharing&gt;**](TaskGraphSharing.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of all specific sharing policies |  -  |
| **404** | The task graph does not exist (or the user does not have permission to view policies)  |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RegisterRegisteredTaskGraph

> void RegisterRegisteredTaskGraph (string _namespace, string name, RegisteredTaskGraph graph = null)



Register a task graph in the given namespace, with the given name. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class RegisterRegisteredTaskGraphExample
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

            var apiInstance = new RegisteredTaskGraphsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace that owns this registered UDF.
            var name = "name_example";  // string | The name of the registered task graph.
            var graph = new RegisteredTaskGraph(); // RegisteredTaskGraph | Task graph to register. (optional) 

            try
            {
                apiInstance.RegisterRegisteredTaskGraph(_namespace, name, graph);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegisteredTaskGraphsApi.RegisterRegisteredTaskGraph: " + e.Message );
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
 **_namespace** | **string**| The namespace that owns this registered UDF. | 
 **name** | **string**| The name of the registered task graph. | 
 **graph** | [**RegisteredTaskGraph**](RegisteredTaskGraph.md)| Task graph to register. | [optional] 

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
| **204** | Task graph registered successfully. |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ShareRegisteredTaskGraph

> void ShareRegisteredTaskGraph (string _namespace, string name, TaskGraphSharing taskGraphSharing)



Share a task graph.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ShareRegisteredTaskGraphExample
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

            var apiInstance = new RegisteredTaskGraphsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace that owns the registered task graph.
            var name = "name_example";  // string | The name of the task graph.
            var taskGraphSharing = new TaskGraphSharing(); // TaskGraphSharing | Namespace and list of permissions to share with. An empty list of permissions will remove the namespace; if permissions already exist they will be deleted then new ones added. In the event of a failure, the new policies will be rolled back to prevent partial policies, and it's likely the UDF will not be shared with the namespace at all. 

            try
            {
                apiInstance.ShareRegisteredTaskGraph(_namespace, name, taskGraphSharing);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegisteredTaskGraphsApi.ShareRegisteredTaskGraph: " + e.Message );
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
 **_namespace** | **string**| The namespace that owns the registered task graph. | 
 **name** | **string**| The name of the task graph. | 
 **taskGraphSharing** | [**TaskGraphSharing**](TaskGraphSharing.md)| Namespace and list of permissions to share with. An empty list of permissions will remove the namespace; if permissions already exist they will be deleted then new ones added. In the event of a failure, the new policies will be rolled back to prevent partial policies, and it&#39;s likely the UDF will not be shared with the namespace at all.  | 

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
| **204** | UDF shared successfully |  -  |
| **404** | UDF does not exist or user does not have permissions to share UDF |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateRegisteredTaskGraph

> void UpdateRegisteredTaskGraph (string _namespace, string name, RegisteredTaskGraph graph = null)



Update the contents of an existing registered task graph. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class UpdateRegisteredTaskGraphExample
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

            var apiInstance = new RegisteredTaskGraphsApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace that owns this registered UDF.
            var name = "name_example";  // string | The name of the registered task graph.
            var graph = new RegisteredTaskGraph(); // RegisteredTaskGraph | The new contents of the task graph. (optional) 

            try
            {
                apiInstance.UpdateRegisteredTaskGraph(_namespace, name, graph);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegisteredTaskGraphsApi.UpdateRegisteredTaskGraph: " + e.Message );
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
 **_namespace** | **string**| The namespace that owns this registered UDF. | 
 **name** | **string**| The name of the registered task graph. | 
 **graph** | [**RegisteredTaskGraph**](RegisteredTaskGraph.md)| The new contents of the task graph. | [optional] 

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
| **204** | Task graph updated successfully. |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

