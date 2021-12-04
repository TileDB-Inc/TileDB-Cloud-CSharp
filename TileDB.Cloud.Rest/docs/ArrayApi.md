# TileDB.Cloud.Rest.Api.ArrayApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArrayActivityLog**](ArrayApi.md#arrayactivitylog) | **GET** /arrays/{namespace}/{array}/activity | 
[**ArraysBrowserOwnedGet**](ArrayApi.md#arraysbrowserownedget) | **GET** /arrays/browser/owned | 
[**ArraysBrowserOwnedSidebarGet**](ArrayApi.md#arraysbrowserownedsidebarget) | **GET** /arrays/browser/owned/sidebar | 
[**ArraysBrowserPublicGet**](ArrayApi.md#arraysbrowserpublicget) | **GET** /arrays/browser/public | 
[**ArraysBrowserPublicSidebarGet**](ArrayApi.md#arraysbrowserpublicsidebarget) | **GET** /arrays/browser/public/sidebar | 
[**ArraysBrowserSharedGet**](ArrayApi.md#arraysbrowsersharedget) | **GET** /arrays/browser/shared | 
[**ArraysBrowserSharedSidebarGet**](ArrayApi.md#arraysbrowsersharedsidebarget) | **GET** /arrays/browser/shared/sidebar | 
[**ArraysNamespaceArrayEndTimestampsGet**](ArrayApi.md#arraysnamespacearrayendtimestampsget) | **GET** /arrays/{namespace}/{array}/end_timestamps | 
[**ConsolidateArray**](ArrayApi.md#consolidatearray) | **POST** /arrays/{namespace}/{array}/consolidate | 
[**CreateArray**](ArrayApi.md#createarray) | **POST** /arrays/{namespace}/{array} | 
[**DeleteArray**](ArrayApi.md#deletearray) | **DELETE** /arrays/{namespace}/{array} | 
[**DeregisterArray**](ArrayApi.md#deregisterarray) | **DELETE** /arrays/{namespace}/{array}/deregister | 
[**GetActivityLogById**](ArrayApi.md#getactivitylogbyid) | **GET** /arrays/{namespace}/{array}/activity/{id} | 
[**GetAllArrayMetadata**](ArrayApi.md#getallarraymetadata) | **GET** /arrays | 
[**GetArray**](ArrayApi.md#getarray) | **GET** /arrays/{namespace}/{array} | 
[**GetArrayMaxBufferSizes**](ArrayApi.md#getarraymaxbuffersizes) | **GET** /arrays/{namespace}/{array}/max_buffer_sizes | 
[**GetArrayMetaDataJson**](ArrayApi.md#getarraymetadatajson) | **GET** /arrays/{namespace}/{array}/metadata_json | 
[**GetArrayMetadata**](ArrayApi.md#getarraymetadata) | **GET** /arrays/{namespace}/{array}/metadata | 
[**GetArrayMetadataCapnp**](ArrayApi.md#getarraymetadatacapnp) | **GET** /arrays/{namespace}/{array}/array_metadata | 
[**GetArrayNonEmptyDomain**](ArrayApi.md#getarraynonemptydomain) | **GET** /arrays/{namespace}/{array}/non_empty_domain | 
[**GetArrayNonEmptyDomainJson**](ArrayApi.md#getarraynonemptydomainjson) | **GET** /arrays/{namespace}/{array}/non_empty_domain_json | 
[**GetArraySampleData**](ArrayApi.md#getarraysampledata) | **GET** /arrays/{namespace}/{array}/sample | 
[**GetArraySharingPolicies**](ArrayApi.md#getarraysharingpolicies) | **GET** /arrays/{namespace}/{array}/share | 
[**GetArraysInNamespace**](ArrayApi.md#getarraysinnamespace) | **GET** /arrays/{namespace} | 
[**GetFragmentEndTimestamp**](ArrayApi.md#getfragmentendtimestamp) | **GET** /arrays/{namespace}/{array}/fragment_end_timestamp | 
[**GetLastAccessedArrays**](ArrayApi.md#getlastaccessedarrays) | **GET** /arrays/last_accessed | 
[**RegisterArray**](ArrayApi.md#registerarray) | **POST** /arrays/{namespace}/{array}/register | 
[**ShareArray**](ArrayApi.md#sharearray) | **PATCH** /arrays/{namespace}/{array}/share | 
[**UpdateArrayMetadata**](ArrayApi.md#updatearraymetadata) | **PATCH** /arrays/{namespace}/{array}/metadata | 
[**UpdateArrayMetadataCapnp**](ArrayApi.md#updatearraymetadatacapnp) | **POST** /arrays/{namespace}/{array}/array_metadata | 
[**VacuumArray**](ArrayApi.md#vacuumarray) | **POST** /arrays/{namespace}/{array}/vacuum | 



## ArrayActivityLog

> List&lt;ArrayActivityLog&gt; ArrayActivityLog (string _namespace, string array, int? start = null, int? end = null, string eventTypes = null, string taskId = null, bool? hasTaskId = null)



get array activity logs

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ArrayActivityLogExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var start = 56;  // int? | Start time of window of fetch logs, unix epoch in seconds (default: seven days ago) (optional) 
            var end = 56;  // int? | End time of window of fetch logs, unix epoch in seconds (default: current utc timestamp) (optional) 
            var eventTypes = eventTypes_example;  // string | Event values can be one or more of the following read, write, create, delete, register, deregister, comma separated (optional) 
            var taskId = taskId_example;  // string | Array task id To filter activity to (optional) 
            var hasTaskId = true;  // bool? | Excludes activity log results that does not contain an array task uuid (optional) 

            try
            {
                List<ArrayActivityLog> result = apiInstance.ArrayActivityLog(_namespace, array, start, end, eventTypes, taskId, hasTaskId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.ArrayActivityLog: " + e.Message );
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
 **start** | **int?**| Start time of window of fetch logs, unix epoch in seconds (default: seven days ago) | [optional] 
 **end** | **int?**| End time of window of fetch logs, unix epoch in seconds (default: current utc timestamp) | [optional] 
 **eventTypes** | **string**| Event values can be one or more of the following read, write, create, delete, register, deregister, comma separated | [optional] 
 **taskId** | **string**| Array task id To filter activity to | [optional] 
 **hasTaskId** | **bool?**| Excludes activity log results that does not contain an array task uuid | [optional] 

### Return type

[**List&lt;ArrayActivityLog&gt;**](ArrayActivityLog.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | log of array activity |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ArraysBrowserOwnedGet

> ArrayBrowserData ArraysBrowserOwnedGet (int? page = null, int? perPage = null, string search = null, string _namespace = null, string orderby = null, string permissions = null, List<string> tag = null, List<string> excludeTag = null, List<string> fileType = null, List<string> excludeFileType = null, List<string> fileProperty = null)



Fetch a list of all arrays that are owned directly by user or user's organizations

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ArraysBrowserOwnedGetExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 
            var search = search_example;  // string | search string that will look at name, namespace or description fields (optional) 
            var _namespace = _namespace_example;  // string | namespace (optional) 
            var orderby = orderby_example;  // string | sort by which field valid values include last_accessed, size, name (optional) 
            var permissions = permissions_example;  // string | permissions valid values include read, read_write, write, admin (optional) 
            var tag = new List<string>(); // List<string> | tag to search for, more than one can be included (optional) 
            var excludeTag = new List<string>(); // List<string> | tags to exclude matching array in results, more than one can be included (optional) 
            var fileType = new List<string>(); // List<string> | file_type to search for, more than one can be included (optional) 
            var excludeFileType = new List<string>(); // List<string> | file_type to exclude matching array in results, more than one can be included (optional) 
            var fileProperty = new List<string>(); // List<string> | file_property key-value pair (comma separated, i.e. key,value) to search for, more than one can be included (optional) 

            try
            {
                ArrayBrowserData result = apiInstance.ArraysBrowserOwnedGet(page, perPage, search, _namespace, orderby, permissions, tag, excludeTag, fileType, excludeFileType, fileProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.ArraysBrowserOwnedGet: " + e.Message );
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
 **page** | **int?**| pagination offset | [optional] 
 **perPage** | **int?**| pagination limit | [optional] 
 **search** | **string**| search string that will look at name, namespace or description fields | [optional] 
 **_namespace** | **string**| namespace | [optional] 
 **orderby** | **string**| sort by which field valid values include last_accessed, size, name | [optional] 
 **permissions** | **string**| permissions valid values include read, read_write, write, admin | [optional] 
 **tag** | [**List&lt;string&gt;**](string.md)| tag to search for, more than one can be included | [optional] 
 **excludeTag** | [**List&lt;string&gt;**](string.md)| tags to exclude matching array in results, more than one can be included | [optional] 
 **fileType** | [**List&lt;string&gt;**](string.md)| file_type to search for, more than one can be included | [optional] 
 **excludeFileType** | [**List&lt;string&gt;**](string.md)| file_type to exclude matching array in results, more than one can be included | [optional] 
 **fileProperty** | [**List&lt;string&gt;**](string.md)| file_property key-value pair (comma separated, i.e. key,value) to search for, more than one can be included | [optional] 

### Return type

[**ArrayBrowserData**](ArrayBrowserData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of array info that are owned directly by user or user&#39;s organizations |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ArraysBrowserOwnedSidebarGet

> ArrayBrowserSidebar ArraysBrowserOwnedSidebarGet ()



Fetch a sidebar for arrays that are owned directly by user or user's organizations

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ArraysBrowserOwnedSidebarGetExample
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

            var apiInstance = new ArrayApi(Configuration.Default);

            try
            {
                ArrayBrowserSidebar result = apiInstance.ArraysBrowserOwnedSidebarGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.ArraysBrowserOwnedSidebarGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ArrayBrowserSidebar**](ArrayBrowserSidebar.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of array info that are owned directly by user or user&#39;s organizations |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ArraysBrowserPublicGet

> ArrayBrowserData ArraysBrowserPublicGet (int? page = null, int? perPage = null, string search = null, string _namespace = null, string orderby = null, string permissions = null, List<string> tag = null, List<string> excludeTag = null, List<string> fileType = null, List<string> excludeFileType = null, List<string> fileProperty = null)



Fetch a list of all arrays that have been shared publically

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ArraysBrowserPublicGetExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 
            var search = search_example;  // string | search string that will look at name, namespace or description fields (optional) 
            var _namespace = _namespace_example;  // string | namespace (optional) 
            var orderby = orderby_example;  // string | sort by which field valid values include last_accessed, size, name (optional) 
            var permissions = permissions_example;  // string | permissions valid values include read, read_write, write, admin (optional) 
            var tag = new List<string>(); // List<string> | tag to search for, more than one can be included (optional) 
            var excludeTag = new List<string>(); // List<string> | tags to exclude matching array in results, more than one can be included (optional) 
            var fileType = new List<string>(); // List<string> | file_type to search for, more than one can be included (optional) 
            var excludeFileType = new List<string>(); // List<string> | file_type to exclude matching array in results, more than one can be included (optional) 
            var fileProperty = new List<string>(); // List<string> | file_property key-value pair (comma separated, i.e. key,value) to search for, more than one can be included (optional) 

            try
            {
                ArrayBrowserData result = apiInstance.ArraysBrowserPublicGet(page, perPage, search, _namespace, orderby, permissions, tag, excludeTag, fileType, excludeFileType, fileProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.ArraysBrowserPublicGet: " + e.Message );
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
 **page** | **int?**| pagination offset | [optional] 
 **perPage** | **int?**| pagination limit | [optional] 
 **search** | **string**| search string that will look at name, namespace or description fields | [optional] 
 **_namespace** | **string**| namespace | [optional] 
 **orderby** | **string**| sort by which field valid values include last_accessed, size, name | [optional] 
 **permissions** | **string**| permissions valid values include read, read_write, write, admin | [optional] 
 **tag** | [**List&lt;string&gt;**](string.md)| tag to search for, more than one can be included | [optional] 
 **excludeTag** | [**List&lt;string&gt;**](string.md)| tags to exclude matching array in results, more than one can be included | [optional] 
 **fileType** | [**List&lt;string&gt;**](string.md)| file_type to search for, more than one can be included | [optional] 
 **excludeFileType** | [**List&lt;string&gt;**](string.md)| file_type to exclude matching array in results, more than one can be included | [optional] 
 **fileProperty** | [**List&lt;string&gt;**](string.md)| file_property key-value pair (comma separated, i.e. key,value) to search for, more than one can be included | [optional] 

### Return type

[**ArrayBrowserData**](ArrayBrowserData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of array info that has been shared publically |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ArraysBrowserPublicSidebarGet

> ArrayBrowserSidebar ArraysBrowserPublicSidebarGet ()



Fetch a sidebar of all arrays that have been shared publically

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ArraysBrowserPublicSidebarGetExample
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

            var apiInstance = new ArrayApi(Configuration.Default);

            try
            {
                ArrayBrowserSidebar result = apiInstance.ArraysBrowserPublicSidebarGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.ArraysBrowserPublicSidebarGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ArrayBrowserSidebar**](ArrayBrowserSidebar.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of array info that has been shared publically |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ArraysBrowserSharedGet

> ArrayBrowserData ArraysBrowserSharedGet (int? page = null, int? perPage = null, string search = null, string _namespace = null, string orderby = null, string permissions = null, List<string> tag = null, List<string> excludeTag = null, List<string> fileType = null, List<string> excludeFileType = null, List<string> fileProperty = null)



Fetch a list of all arrays that have been shared with the user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ArraysBrowserSharedGetExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 
            var search = search_example;  // string | search string that will look at name, namespace or description fields (optional) 
            var _namespace = _namespace_example;  // string | namespace (optional) 
            var orderby = orderby_example;  // string | sort by which field valid values include last_accessed, size, name (optional) 
            var permissions = permissions_example;  // string | permissions valid values include read, read_write, write, admin (optional) 
            var tag = new List<string>(); // List<string> | tag to search for, more than one can be included (optional) 
            var excludeTag = new List<string>(); // List<string> | tags to exclude matching array in results, more than one can be included (optional) 
            var fileType = new List<string>(); // List<string> | file_type to search for, more than one can be included (optional) 
            var excludeFileType = new List<string>(); // List<string> | file_type to exclude matching array in results, more than one can be included (optional) 
            var fileProperty = new List<string>(); // List<string> | file_property key-value pair (comma separated, i.e. key,value) to search for, more than one can be included (optional) 

            try
            {
                ArrayBrowserData result = apiInstance.ArraysBrowserSharedGet(page, perPage, search, _namespace, orderby, permissions, tag, excludeTag, fileType, excludeFileType, fileProperty);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.ArraysBrowserSharedGet: " + e.Message );
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
 **page** | **int?**| pagination offset | [optional] 
 **perPage** | **int?**| pagination limit | [optional] 
 **search** | **string**| search string that will look at name, namespace or description fields | [optional] 
 **_namespace** | **string**| namespace | [optional] 
 **orderby** | **string**| sort by which field valid values include last_accessed, size, name | [optional] 
 **permissions** | **string**| permissions valid values include read, read_write, write, admin | [optional] 
 **tag** | [**List&lt;string&gt;**](string.md)| tag to search for, more than one can be included | [optional] 
 **excludeTag** | [**List&lt;string&gt;**](string.md)| tags to exclude matching array in results, more than one can be included | [optional] 
 **fileType** | [**List&lt;string&gt;**](string.md)| file_type to search for, more than one can be included | [optional] 
 **excludeFileType** | [**List&lt;string&gt;**](string.md)| file_type to exclude matching array in results, more than one can be included | [optional] 
 **fileProperty** | [**List&lt;string&gt;**](string.md)| file_property key-value pair (comma separated, i.e. key,value) to search for, more than one can be included | [optional] 

### Return type

[**ArrayBrowserData**](ArrayBrowserData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of array info that has been shared with the user |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ArraysBrowserSharedSidebarGet

> ArrayBrowserSidebar ArraysBrowserSharedSidebarGet ()



Fetch a list of all arrays that have been shared with the user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ArraysBrowserSharedSidebarGetExample
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

            var apiInstance = new ArrayApi(Configuration.Default);

            try
            {
                ArrayBrowserSidebar result = apiInstance.ArraysBrowserSharedSidebarGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.ArraysBrowserSharedSidebarGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ArrayBrowserSidebar**](ArrayBrowserSidebar.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of array info that has been shared with the user |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ArraysNamespaceArrayEndTimestampsGet

> ArrayEndTimestampData ArraysNamespaceArrayEndTimestampsGet (string _namespace, string array, int? page = null, int? perPage = null)



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
    public class ArraysNamespaceArrayEndTimestampsGetExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 

            try
            {
                ArrayEndTimestampData result = apiInstance.ArraysNamespaceArrayEndTimestampsGet(_namespace, array, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.ArraysNamespaceArrayEndTimestampsGet: " + e.Message );
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


## ConsolidateArray

> void ConsolidateArray (string _namespace, string array, TileDBConfig tiledbConfig)



consolidate an array at a specified URI

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ConsolidateArrayExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var tiledbConfig = new TileDBConfig(); // TileDBConfig | tiledb configuration

            try
            {
                apiInstance.ConsolidateArray(_namespace, array, tiledbConfig);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.ConsolidateArray: " + e.Message );
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
 **tiledbConfig** | [**TileDBConfig**](TileDBConfig.md)| tiledb configuration | 

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
| **204** | array consolidated successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateArray

> void CreateArray (string _namespace, string array, string contentType, ArraySchema arraySchema, string X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = null)



create a array schema at a specified URI registered to a group/project

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class CreateArrayExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var contentType = contentType_example;  // string | Content Type of input and return mime (default to "application/json")
            var arraySchema = new ArraySchema(); // ArraySchema | ArraySchema being created
            var X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME = X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME_example;  // string | Optional registered access credentials to use for creation (optional) 

            try
            {
                apiInstance.CreateArray(_namespace, array, contentType, arraySchema, X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.CreateArray: " + e.Message );
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
 **arraySchema** | [**ArraySchema**](ArraySchema.md)| ArraySchema being created | 
 **X_TILEDB_CLOUD_ACCESS_CREDENTIALS_NAME** | **string**| Optional registered access credentials to use for creation | [optional] 

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
| **204** | schema created successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteArray

> void DeleteArray (string _namespace, string array, string contentType)



delete a array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteArrayExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var contentType = contentType_example;  // string | Content Type of input and return mime (default to "application/json")

            try
            {
                apiInstance.DeleteArray(_namespace, array, contentType);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.DeleteArray: " + e.Message );
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
| **204** | delete array successful |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeregisterArray

> void DeregisterArray (string _namespace, string array)



deregister a array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeregisterArrayExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded

            try
            {
                apiInstance.DeregisterArray(_namespace, array);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.DeregisterArray: " + e.Message );
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
| **204** | deregistered array successful |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetActivityLogById

> ArrayActivityLog GetActivityLogById (string _namespace, string array, string id)



get activity log by id

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetActivityLogByIdExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var id = id_example;  // string | id of the activity

            try
            {
                ArrayActivityLog result = apiInstance.GetActivityLogById(_namespace, array, id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetActivityLogById: " + e.Message );
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
 **id** | **string**| id of the activity | 

### Return type

[**ArrayActivityLog**](ArrayActivityLog.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | array activity |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllArrayMetadata

> List&lt;ArrayInfo&gt; GetAllArrayMetadata (string publicShare = null)



get all array metadata user has access to

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetAllArrayMetadataExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var publicShare = publicShare_example;  // string | Public share values can be one of exclude, only (optional) 

            try
            {
                List<ArrayInfo> result = apiInstance.GetAllArrayMetadata(publicShare);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetAllArrayMetadata: " + e.Message );
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
 **publicShare** | **string**| Public share values can be one of exclude, only | [optional] 

### Return type

[**List&lt;ArrayInfo&gt;**](ArrayInfo.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | array metadata for all arrays user has access to |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArray

> ArraySchema GetArray (string _namespace, string array, string contentType)



get an ArraySchema using a url encoded uri

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArrayExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var contentType = contentType_example;  // string | Content Type of input and return mime (default to "application/json")

            try
            {
                ArraySchema result = apiInstance.GetArray(_namespace, array, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetArray: " + e.Message );
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

### Return type

[**ArraySchema**](ArraySchema.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/capnp


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | get ArraySchema |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArrayMaxBufferSizes

> MaxBufferSizes GetArrayMaxBufferSizes (string _namespace, string array, string subarray, string contentType, string xPayer = null)



get the max buffer sizes of an array for a subarray

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArrayMaxBufferSizesExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var subarray = subarray_example;  // string | CSV string of subarray to get max buffer sizes for
            var contentType = contentType_example;  // string | Content Type of input and return mime (default to "application/json")
            var xPayer = xPayer_example;  // string | Name of organization or user who should be charged for this request (optional) 

            try
            {
                MaxBufferSizes result = apiInstance.GetArrayMaxBufferSizes(_namespace, array, subarray, contentType, xPayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetArrayMaxBufferSizes: " + e.Message );
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
 **subarray** | **string**| CSV string of subarray to get max buffer sizes for | 
 **contentType** | **string**| Content Type of input and return mime | [default to &quot;application/json&quot;]
 **xPayer** | **string**| Name of organization or user who should be charged for this request | [optional] 

### Return type

[**MaxBufferSizes**](MaxBufferSizes.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | get the max buffer sizes of an array for a subarray |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArrayMetaDataJson

> Object GetArrayMetaDataJson (string _namespace, string array, int? length = null, int? endTimestamp = null)



get metadata from the array in json format

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArrayMetaDataJsonExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var length = 56;  // int? | (optional) limit character length of returned values (optional) 
            var endTimestamp = 56;  // int? | Milliseconds since Unix epoch, metadata will use open_at functionality to open array at the specific timestamp (optional) 

            try
            {
                Object result = apiInstance.GetArrayMetaDataJson(_namespace, array, length, endTimestamp);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetArrayMetaDataJson: " + e.Message );
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
 **length** | **int?**| (optional) limit character length of returned values | [optional] 
 **endTimestamp** | **int?**| Milliseconds since Unix epoch, metadata will use open_at functionality to open array at the specific timestamp | [optional] 

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | get array metadata |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArrayMetadata

> ArrayInfo GetArrayMetadata (string _namespace, string array)



get metadata on an array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArrayMetadataExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded

            try
            {
                ArrayInfo result = apiInstance.GetArrayMetadata(_namespace, array);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetArrayMetadata: " + e.Message );
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

### Return type

[**ArrayInfo**](ArrayInfo.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | array metadata for an array |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArrayMetadataCapnp

> ArrayMetadata GetArrayMetadataCapnp (string _namespace, string array)



get metadata on an array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArrayMetadataCapnpExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded

            try
            {
                ArrayMetadata result = apiInstance.GetArrayMetadataCapnp(_namespace, array);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetArrayMetadataCapnp: " + e.Message );
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

### Return type

[**ArrayMetadata**](ArrayMetadata.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/capnp


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | array metadata for an array |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArrayNonEmptyDomain

> NonEmptyDomain GetArrayNonEmptyDomain (string _namespace, string array, string contentType, string xPayer = null)



get the non empty domain of an array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArrayNonEmptyDomainExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var contentType = contentType_example;  // string | Content Type of input and return mime (default to "application/json")
            var xPayer = xPayer_example;  // string | Name of organization or user who should be charged for this request (optional) 

            try
            {
                NonEmptyDomain result = apiInstance.GetArrayNonEmptyDomain(_namespace, array, contentType, xPayer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetArrayNonEmptyDomain: " + e.Message );
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

[**NonEmptyDomain**](NonEmptyDomain.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | get the non empty domain of an array |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArrayNonEmptyDomainJson

> Object GetArrayNonEmptyDomainJson (string _namespace, string array)



get non-empty domain from the array in json format

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArrayNonEmptyDomainJsonExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded

            try
            {
                Object result = apiInstance.GetArrayNonEmptyDomainJson(_namespace, array);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetArrayNonEmptyDomainJson: " + e.Message );
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

### Return type

**Object**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | get array non-empty domaim |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArraySampleData

> ArraySample GetArraySampleData (string _namespace, string array, decimal? samples = null)



get an sample set of data from the array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArraySampleDataExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var samples = 8.14;  // decimal? | Number of sample results to return (optional)  (default to 5.0M)

            try
            {
                ArraySample result = apiInstance.GetArraySampleData(_namespace, array, samples);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetArraySampleData: " + e.Message );
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
 **samples** | **decimal?**| Number of sample results to return | [optional] [default to 5.0M]

### Return type

[**ArraySample**](ArraySample.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | get array sample data |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArraySharingPolicies

> List&lt;ArraySharing&gt; GetArraySharingPolicies (string _namespace, string array)



Get all sharing details of the array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArraySharingPoliciesExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded

            try
            {
                List<ArraySharing> result = apiInstance.GetArraySharingPolicies(_namespace, array);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetArraySharingPolicies: " + e.Message );
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

### Return type

[**List&lt;ArraySharing&gt;**](ArraySharing.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of all specific sharing policies |  -  |
| **404** | Array does not exist or user does not have permissions to view array sharing policies |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArraysInNamespace

> List&lt;ArrayInfo&gt; GetArraysInNamespace (string _namespace)



get metadata on all arrays in a namespace

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArraysInNamespaceExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)

            try
            {
                List<ArrayInfo> result = apiInstance.GetArraysInNamespace(_namespace);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetArraysInNamespace: " + e.Message );
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

### Return type

[**List&lt;ArrayInfo&gt;**](ArrayInfo.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | array metadata for all arrays in a namespace |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetFragmentEndTimestamp

> int GetFragmentEndTimestamp (string _namespace, string array, int? endTimestamp = null)



Get fragment end_timestamp on an array, will search for the closest end_timestamp to the timestamp asked

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetFragmentEndTimestampExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var endTimestamp = 56;  // int? | Milliseconds since Unix epoch (optional) 

            try
            {
                int result = apiInstance.GetFragmentEndTimestamp(_namespace, array, endTimestamp);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetFragmentEndTimestamp: " + e.Message );
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
 **endTimestamp** | **int?**| Milliseconds since Unix epoch | [optional] 

### Return type

**int**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | fragment end_timestamp on an array |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLastAccessedArrays

> List&lt;LastAccessedArray&gt; GetLastAccessedArrays ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetLastAccessedArraysExample
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

            var apiInstance = new ArrayApi(Configuration.Default);

            try
            {
                List<LastAccessedArray> result = apiInstance.GetLastAccessedArrays();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.GetLastAccessedArrays: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List&lt;LastAccessedArray&gt;**](LastAccessedArray.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | gets last accessed arrays |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RegisterArray

> void RegisterArray (string _namespace, string array, ArrayInfoUpdate arrayMetadata)



register an array at a specified URI registered to the given namespace

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class RegisterArrayExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var arrayMetadata = new ArrayInfoUpdate(); // ArrayInfoUpdate | metadata associated with array

            try
            {
                apiInstance.RegisterArray(_namespace, array, arrayMetadata);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.RegisterArray: " + e.Message );
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
 **arrayMetadata** | [**ArrayInfoUpdate**](ArrayInfoUpdate.md)| metadata associated with array | 

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
| **204** | schema registered successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ShareArray

> void ShareArray (string _namespace, string array, ArraySharing arraySharing)



Share an array with a user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ShareArrayExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var arraySharing = new ArraySharing(); // ArraySharing | Namespace and list of permissions to share with. An empty list of permissions will remove the namespace, if permissions already exist they will be deleted then new ones added. In the event of a failure, the new polcies will be rolled back to prevent partial policies, and its likely the array will not be shared with the namespace at all

            try
            {
                apiInstance.ShareArray(_namespace, array, arraySharing);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.ShareArray: " + e.Message );
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
 **arraySharing** | [**ArraySharing**](ArraySharing.md)| Namespace and list of permissions to share with. An empty list of permissions will remove the namespace, if permissions already exist they will be deleted then new ones added. In the event of a failure, the new polcies will be rolled back to prevent partial policies, and its likely the array will not be shared with the namespace at all | 

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
| **204** | Array shared successfully |  -  |
| **404** | Array does not exist or user does not have permissions to share array |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateArrayMetadata

> void UpdateArrayMetadata (string _namespace, string array, ArrayInfoUpdate arrayMetadata)



update metadata on an array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class UpdateArrayMetadataExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var arrayMetadata = new ArrayInfoUpdate(); // ArrayInfoUpdate | array metadata to update

            try
            {
                apiInstance.UpdateArrayMetadata(_namespace, array, arrayMetadata);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.UpdateArrayMetadata: " + e.Message );
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
 **arrayMetadata** | [**ArrayInfoUpdate**](ArrayInfoUpdate.md)| array metadata to update | 

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
| **204** | array metadata updated successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateArrayMetadataCapnp

> void UpdateArrayMetadataCapnp (string _namespace, string array, ArrayMetadata arrayMetadataEntries)



update metadata on an array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class UpdateArrayMetadataCapnpExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var arrayMetadataEntries = new ArrayMetadata(); // ArrayMetadata | List of metadata entries

            try
            {
                apiInstance.UpdateArrayMetadataCapnp(_namespace, array, arrayMetadataEntries);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.UpdateArrayMetadataCapnp: " + e.Message );
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
 **arrayMetadataEntries** | [**ArrayMetadata**](ArrayMetadata.md)| List of metadata entries | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json, application/capnp
- **Accept**: application/json, application/capnp


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | array metadata updated successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## VacuumArray

> void VacuumArray (string _namespace, string array, TileDBConfig tiledbConfig)



vacuum an array at a specified URI

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class VacuumArrayExample
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

            var apiInstance = new ArrayApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var tiledbConfig = new TileDBConfig(); // TileDBConfig | tiledb configuration

            try
            {
                apiInstance.VacuumArray(_namespace, array, tiledbConfig);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArrayApi.VacuumArray: " + e.Message );
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
 **tiledbConfig** | [**TileDBConfig**](TileDBConfig.md)| tiledb configuration | 

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
| **204** | array vacuumed successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

