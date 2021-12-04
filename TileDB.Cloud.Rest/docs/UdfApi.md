# TileDB.Cloud.Rest.Api.UdfApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUDFInfo**](UdfApi.md#deleteudfinfo) | **DELETE** /udf/{namespace}/{name} | 
[**GetUDFInfo**](UdfApi.md#getudfinfo) | **GET** /udf/{namespace}/{name} | 
[**GetUDFInfoSharingPolicies**](UdfApi.md#getudfinfosharingpolicies) | **GET** /udf/{namespace}/{name}/share | 
[**RegisterUDFInfo**](UdfApi.md#registerudfinfo) | **POST** /udf/{namespace}/{name} | 
[**ShareUDFInfo**](UdfApi.md#shareudfinfo) | **PATCH** /udf/{namespace}/{name}/share | 
[**SubmitGenericUDF**](UdfApi.md#submitgenericudf) | **POST** /udfs/generic/{namespace} | 
[**SubmitMultiArrayUDF**](UdfApi.md#submitmultiarrayudf) | **POST** /udfs/arrays/{namespace} | 
[**SubmitUDF**](UdfApi.md#submitudf) | **POST** /arrays/{namespace}/{array}/udf/submit | 
[**UdfNamespaceArrayEndTimestampsGet**](UdfApi.md#udfnamespacearrayendtimestampsget) | **GET** /udf/{namespace}/{array}/end_timestamps | 
[**UpdateUDFInfo**](UdfApi.md#updateudfinfo) | **PATCH** /udf/{namespace}/{name} | 



## DeleteUDFInfo

> void DeleteUDFInfo (string _namespace, string name)



delete a registerd UDF, this will remove all sharing and can not be undone

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteUDFInfoExample
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

            var apiInstance = new UdfApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var name = name_example;  // string | name to register udf under

            try
            {
                apiInstance.DeleteUDFInfo(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UdfApi.DeleteUDFInfo: " + e.Message );
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
 **name** | **string**| name to register udf under | 

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
| **202** | UDF delete successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUDFInfo

> UDFInfo GetUDFInfo (string _namespace, string name)



get a specific UDF in the given namespace

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetUDFInfoExample
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

            var apiInstance = new UdfApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var name = name_example;  // string | name to register udf under

            try
            {
                UDFInfo result = apiInstance.GetUDFInfo(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UdfApi.GetUDFInfo: " + e.Message );
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
 **name** | **string**| name to register udf under | 

### Return type

[**UDFInfo**](UDFInfo.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | UDFInfo was retrieved successfully |  -  |
| **404** | udf not found |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUDFInfoSharingPolicies

> List&lt;UDFSharing&gt; GetUDFInfoSharingPolicies (string _namespace, string name)



Get all sharing details of the udf

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetUDFInfoSharingPoliciesExample
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

            var apiInstance = new UdfApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var name = name_example;  // string | name of UDFInfo

            try
            {
                List<UDFSharing> result = apiInstance.GetUDFInfoSharingPolicies(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UdfApi.GetUDFInfoSharingPolicies: " + e.Message );
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
 **name** | **string**| name of UDFInfo | 

### Return type

[**List&lt;UDFSharing&gt;**](UDFSharing.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of all specific sharing policies |  -  |
| **404** | UDF does not exist or user does not have permissions to view array sharing policies |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RegisterUDFInfo

> void RegisterUDFInfo (string _namespace, string name, UDFInfoUpdate udf)



register a UDF in the given namespace

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class RegisterUDFInfoExample
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

            var apiInstance = new UdfApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var name = name_example;  // string | name to register udf under
            var udf = new UDFInfoUpdate(); // UDFInfoUpdate | udf to register

            try
            {
                apiInstance.RegisterUDFInfo(_namespace, name, udf);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UdfApi.RegisterUDFInfo: " + e.Message );
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
 **name** | **string**| name to register udf under | 
 **udf** | [**UDFInfoUpdate**](UDFInfoUpdate.md)| udf to register | 

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
| **204** | udf registered successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ShareUDFInfo

> void ShareUDFInfo (string _namespace, string name, UDFSharing udfSharing)



Share a UDF with a user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ShareUDFInfoExample
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

            var apiInstance = new UdfApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var name = name_example;  // string | name of UDFInfo
            var udfSharing = new UDFSharing(); // UDFSharing | Namespace and list of permissions to share with. An empty list of permissions will remove the namespace, if permissions already exist they will be deleted then new ones added. In the event of a failure, the new polcies will be rolled back to prevent partial policies, and its likely the udf will not be shared with the namespace at all

            try
            {
                apiInstance.ShareUDFInfo(_namespace, name, udfSharing);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UdfApi.ShareUDFInfo: " + e.Message );
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
 **name** | **string**| name of UDFInfo | 
 **udfSharing** | [**UDFSharing**](UDFSharing.md)| Namespace and list of permissions to share with. An empty list of permissions will remove the namespace, if permissions already exist they will be deleted then new ones added. In the event of a failure, the new polcies will be rolled back to prevent partial policies, and its likely the udf will not be shared with the namespace at all | 

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
| **404** | UDF does not exist or user does not have permissions to share udf |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SubmitGenericUDF

> System.IO.Stream SubmitGenericUDF (string _namespace, GenericUDF udf, string acceptEncoding = null)



submit a generic UDF in the given namespace

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class SubmitGenericUDFExample
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

            var apiInstance = new UdfApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var udf = new GenericUDF(); // GenericUDF | udf to run
            var acceptEncoding = acceptEncoding_example;  // string | Encoding to use (optional) 

            try
            {
                System.IO.Stream result = apiInstance.SubmitGenericUDF(_namespace, udf, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UdfApi.SubmitGenericUDF: " + e.Message );
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
 **udf** | [**GenericUDF**](GenericUDF.md)| udf to run | 
 **acceptEncoding** | **string**| Encoding to use | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | udf completed and the udf-type specific result is returned |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |
| **0** | error response |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SubmitMultiArrayUDF

> System.IO.Stream SubmitMultiArrayUDF (string _namespace, MultiArrayUDF udf, string acceptEncoding = null)



submit a multi-array UDF in the given namespace

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class SubmitMultiArrayUDFExample
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

            var apiInstance = new UdfApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var udf = new MultiArrayUDF(); // MultiArrayUDF | udf to run
            var acceptEncoding = acceptEncoding_example;  // string | Encoding to use (optional) 

            try
            {
                System.IO.Stream result = apiInstance.SubmitMultiArrayUDF(_namespace, udf, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UdfApi.SubmitMultiArrayUDF: " + e.Message );
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
 **udf** | [**MultiArrayUDF**](MultiArrayUDF.md)| udf to run | 
 **acceptEncoding** | **string**| Encoding to use | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | udf completed and the udf-type specific result is returned |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |
| **0** | error response |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SubmitUDF

> System.IO.Stream SubmitUDF (string _namespace, string array, MultiArrayUDF udf, string xPayer = null, string acceptEncoding = null, string v2 = null)



send a UDF to run against a specified array/URI registered to a group/project

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class SubmitUDFExample
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

            var apiInstance = new UdfApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var udf = new MultiArrayUDF(); // MultiArrayUDF | udf to run
            var xPayer = xPayer_example;  // string | Name of organization or user who should be charged for this request (optional) 
            var acceptEncoding = acceptEncoding_example;  // string | Encoding to use (optional) 
            var v2 = v2_example;  // string | flag to indicate if v2 array udfs should be used, currently in beta testing. Setting any value will enable v2 array udfs (optional) 

            try
            {
                System.IO.Stream result = apiInstance.SubmitUDF(_namespace, array, udf, xPayer, acceptEncoding, v2);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UdfApi.SubmitUDF: " + e.Message );
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
 **udf** | [**MultiArrayUDF**](MultiArrayUDF.md)| udf to run | 
 **xPayer** | **string**| Name of organization or user who should be charged for this request | [optional] 
 **acceptEncoding** | **string**| Encoding to use | [optional] 
 **v2** | **string**| flag to indicate if v2 array udfs should be used, currently in beta testing. Setting any value will enable v2 array udfs | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | udf completed and the udf-type specific result is returned |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |
| **0** | error response |  * X-TILEDB-CLOUD-TASK-ID - Task ID for just completed request <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UdfNamespaceArrayEndTimestampsGet

> ArrayEndTimestampData UdfNamespaceArrayEndTimestampsGet (string _namespace, string array, int? page = null, int? perPage = null)



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
    public class UdfNamespaceArrayEndTimestampsGetExample
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

            var apiInstance = new UdfApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var array = array_example;  // string | name/uri of array that is url-encoded
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 

            try
            {
                ArrayEndTimestampData result = apiInstance.UdfNamespaceArrayEndTimestampsGet(_namespace, array, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UdfApi.UdfNamespaceArrayEndTimestampsGet: " + e.Message );
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


## UpdateUDFInfo

> void UpdateUDFInfo (string _namespace, string name, UDFInfoUpdate udf)



updated an existing registerd UDF in the given namespace

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class UpdateUDFInfoExample
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

            var apiInstance = new UdfApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace array is in (an organization name or user's username)
            var name = name_example;  // string | name to register udf under
            var udf = new UDFInfoUpdate(); // UDFInfoUpdate | udf to update

            try
            {
                apiInstance.UpdateUDFInfo(_namespace, name, udf);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UdfApi.UpdateUDFInfo: " + e.Message );
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
 **name** | **string**| name to register udf under | 
 **udf** | [**UDFInfoUpdate**](UDFInfoUpdate.md)| udf to update | 

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
| **204** | udf updated successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

