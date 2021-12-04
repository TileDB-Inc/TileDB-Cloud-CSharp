# TileDB.Cloud.Rest.Api.QueryApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FinalizeQuery**](QueryApi.md#finalizequery) | **POST** /arrays/{namespace}/{array}/query/finalize | 
[**GetEstResultSizes**](QueryApi.md#getestresultsizes) | **POST** /arrays/{namespace}/{array}/query/est_result_sizes | 
[**GetFile**](QueryApi.md#getfile) | **GET** /arrays/{namespace}/{array}/query/get_file | 
[**SubmitQuery**](QueryApi.md#submitquery) | **POST** /arrays/{namespace}/{array}/query/submit | 
[**SubmitQueryJson**](QueryApi.md#submitqueryjson) | **POST** /arrays/{namespace}/{array}/query/submit_query_json | 



## FinalizeQuery

> Query FinalizeQuery (string _namespace, string array, string type, string contentType, Query query, string xPayer = null, int? openAt = null)



send a query to run against a specified array/URI registered to a group/project

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class FinalizeQueryExample
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

            var apiInstance = new QueryApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var type = type_example;  // string | type of query
            var contentType = contentType_example;  // string | Content Type of input and return mime (default to "application/json")
            var query = new Query(); // Query | query to run
            var xPayer = xPayer_example;  // string | Name of organization or user who should be charged for this request (optional) 
            var openAt = 56;  // int? | open_at for array in unix epoch (optional) 

            try
            {
                Query result = apiInstance.FinalizeQuery(_namespace, array, type, contentType, query, xPayer, openAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling QueryApi.FinalizeQuery: " + e.Message );
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
 **type** | **string**| type of query | 
 **contentType** | **string**| Content Type of input and return mime | [default to &quot;application/json&quot;]
 **query** | [**Query**](Query.md)| query to run | 
 **xPayer** | **string**| Name of organization or user who should be charged for this request | [optional] 
 **openAt** | **int?**| open_at for array in unix epoch | [optional] 

### Return type

[**Query**](Query.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json, application/capnp
- **Accept**: application/json, application/capnp


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | query completed and results are returned in query object |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |
| **204** | query completed successfully with no return |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEstResultSizes

> Query GetEstResultSizes (string _namespace, string array, string type, string contentType, Query query, string xPayer = null, int? openAt = null)



send a query to run against a specified array/URI registered to a group/project

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetEstResultSizesExample
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

            var apiInstance = new QueryApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var type = type_example;  // string | type of query
            var contentType = contentType_example;  // string | Content Type of input and return mime (default to "application/json")
            var query = new Query(); // Query | query to run
            var xPayer = xPayer_example;  // string | Name of organization or user who should be charged for this request (optional) 
            var openAt = 56;  // int? | open_at for array in unix epoch (optional) 

            try
            {
                Query result = apiInstance.GetEstResultSizes(_namespace, array, type, contentType, query, xPayer, openAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling QueryApi.GetEstResultSizes: " + e.Message );
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
 **type** | **string**| type of query | 
 **contentType** | **string**| Content Type of input and return mime | [default to &quot;application/json&quot;]
 **query** | [**Query**](Query.md)| query to run | 
 **xPayer** | **string**| Name of organization or user who should be charged for this request | [optional] 
 **openAt** | **int?**| open_at for array in unix epoch | [optional] 

### Return type

[**Query**](Query.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json, application/capnp
- **Accept**: application/json, application/capnp


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | query est result size computed and results are returned in query object |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |
| **204** | query completed successfully with no return |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetFile

> System.IO.Stream GetFile (string _namespace, string array, string contentType, string xPayer = null)



send a query to run against a specified array/URI registered to a group/project, returns file bytes

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetFileExample
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

            var apiInstance = new QueryApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var contentType = contentType_example;  // string | Content Type of input and return mime (default to "application/json")
            var xPayer = xPayer_example;  // string | Name of organization or user who should be charged for this request (optional) 

            try
            {
                System.IO.Stream result = apiInstance.GetFile(_namespace, array, contentType, xPayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling QueryApi.GetFile: " + e.Message );
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
 **contentType** | **string**| Content Type of input and return mime | [default to &quot;application/json&quot;]
 **xPayer** | **string**| Name of organization or user who should be charged for this request | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/x-ipynb+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | query completed and result bytes are returned |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SubmitQuery

> Query SubmitQuery (string _namespace, string array, string type, string contentType, Query query, string xPayer = null, int? openAt = null)



send a query to run against a specified array/URI registered to a group/project

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class SubmitQueryExample
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

            var apiInstance = new QueryApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var type = type_example;  // string | type of query
            var contentType = contentType_example;  // string | Content Type of input and return mime (default to "application/json")
            var query = new Query(); // Query | query to run
            var xPayer = xPayer_example;  // string | Name of organization or user who should be charged for this request (optional) 
            var openAt = 56;  // int? | open_at for array in unix epoch (optional) 

            try
            {
                Query result = apiInstance.SubmitQuery(_namespace, array, type, contentType, query, xPayer, openAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling QueryApi.SubmitQuery: " + e.Message );
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
 **type** | **string**| type of query | 
 **contentType** | **string**| Content Type of input and return mime | [default to &quot;application/json&quot;]
 **query** | [**Query**](Query.md)| query to run | 
 **xPayer** | **string**| Name of organization or user who should be charged for this request | [optional] 
 **openAt** | **int?**| open_at for array in unix epoch | [optional] 

### Return type

[**Query**](Query.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json, application/capnp
- **Accept**: application/json, application/capnp


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | query completed and results are returned in query object |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |
| **204** | query completed successfully with no return |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SubmitQueryJson

> Object SubmitQueryJson (string _namespace, string array, string contentType, QueryJson queryJson, string xPayer = null)



send a query to run against a specified array/URI registered to a group/project, returns json results

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class SubmitQueryJsonExample
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

            var apiInstance = new QueryApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var contentType = contentType_example;  // string | Content Type of input and return mime (default to "application/json")
            var queryJson = new QueryJson(); // QueryJson | query to run
            var xPayer = xPayer_example;  // string | Name of organization or user who should be charged for this request (optional) 

            try
            {
                Object result = apiInstance.SubmitQueryJson(_namespace, array, contentType, queryJson, xPayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling QueryApi.SubmitQueryJson: " + e.Message );
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
 **contentType** | **string**| Content Type of input and return mime | [default to &quot;application/json&quot;]
 **queryJson** | [**QueryJson**](QueryJson.md)| query to run | 
 **xPayer** | **string**| Name of organization or user who should be charged for this request | [optional] 

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | query completed and results are returned in json format |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

