# TileDB.Cloud.Rest.Api.InvitationApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcceptInvitation**](InvitationApi.md#acceptinvitation) | **POST** /invitations/{invitation} | 
[**CancelJoinOrganization**](InvitationApi.md#canceljoinorganization) | **DELETE** /invitations/{invitation}/{organization}/join | 
[**CancelShareArrayByInvite**](InvitationApi.md#cancelsharearraybyinvite) | **DELETE** /invitations/{invitation}/{namespace}/{array}/share | 
[**FetchInvitations**](InvitationApi.md#fetchinvitations) | **GET** /invitations | 
[**JoinOrganization**](InvitationApi.md#joinorganization) | **POST** /invitations/{organization}/join | 
[**ShareArrayByInvite**](InvitationApi.md#sharearraybyinvite) | **POST** /invitations/{namespace}/{array}/share | 



## AcceptInvitation

> void AcceptInvitation (string invitation)



Accepts invitation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class AcceptInvitationExample
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

            var apiInstance = new InvitationApi(Configuration.Default);
            var invitation = "invitation_example";  // string | the ID of invitation about to be accepted

            try
            {
                apiInstance.AcceptInvitation(invitation);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvitationApi.AcceptInvitation: " + e.Message );
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
 **invitation** | **string**| the ID of invitation about to be accepted | 

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
| **204** | Invitation was accepted successfully |  -  |
| **404** | Could not find invitation identifier |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CancelJoinOrganization

> void CancelJoinOrganization (string invitation, string organization)



Cancels join organization invitation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class CancelJoinOrganizationExample
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

            var apiInstance = new InvitationApi(Configuration.Default);
            var invitation = "invitation_example";  // string | the ID of invitation about to be cancelled
            var organization = "organization_example";  // string | name or UUID of organization

            try
            {
                apiInstance.CancelJoinOrganization(invitation, organization);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvitationApi.CancelJoinOrganization: " + e.Message );
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
 **invitation** | **string**| the ID of invitation about to be cancelled | 
 **organization** | **string**| name or UUID of organization | 

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
| **204** | Invitation cancelled successfully |  -  |
| **404** | No invitation was found to cancel |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CancelShareArrayByInvite

> void CancelShareArrayByInvite (string _namespace, string invitation, string array)



Cancels array sharing invitation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class CancelShareArrayByInviteExample
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

            var apiInstance = new InvitationApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | namespace array is in (an organization name or user's username)
            var invitation = "invitation_example";  // string | the ID of invitation about to be cancelled
            var array = "array_example";  // string | name/uri of array that is url-encoded

            try
            {
                apiInstance.CancelShareArrayByInvite(_namespace, invitation, array);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvitationApi.CancelShareArrayByInvite: " + e.Message );
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
 **invitation** | **string**| the ID of invitation about to be cancelled | 
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
| **204** | Invitation cancelled successfully |  -  |
| **404** | No invitation was found to cancel |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FetchInvitations

> InvitationData FetchInvitations (string organization = null, string array = null, int? start = null, int? end = null, int? page = null, int? perPage = null, string type = null, string status = null, string orderby = null)



Fetch a list of invitations

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class FetchInvitationsExample
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

            var apiInstance = new InvitationApi(Configuration.Default);
            var organization = "organization_example";  // string | name or ID of organization to filter (optional) 
            var array = "array_example";  // string | name/uri of array that is url-encoded to filter (optional) 
            var start = 56;  // int? | start time for tasks to filter by (optional) 
            var end = 56;  // int? | end time for tasks to filter by (optional) 
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 
            var type = "type_example";  // string | invitation type, \"ARRAY_SHARE\", \"JOIN_ORGANIZATION\" (optional) 
            var status = "status_example";  // string | Filter to only return \"PENDING\", \"ACCEPTED\" (optional) 
            var orderby = "orderby_example";  // string | sort by which field valid values include timestamp, array_name, organization_name (optional) 

            try
            {
                InvitationData result = apiInstance.FetchInvitations(organization, array, start, end, page, perPage, type, status, orderby);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvitationApi.FetchInvitations: " + e.Message );
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
 **organization** | **string**| name or ID of organization to filter | [optional] 
 **array** | **string**| name/uri of array that is url-encoded to filter | [optional] 
 **start** | **int?**| start time for tasks to filter by | [optional] 
 **end** | **int?**| end time for tasks to filter by | [optional] 
 **page** | **int?**| pagination offset | [optional] 
 **perPage** | **int?**| pagination limit | [optional] 
 **type** | **string**| invitation type, \&quot;ARRAY_SHARE\&quot;, \&quot;JOIN_ORGANIZATION\&quot; | [optional] 
 **status** | **string**| Filter to only return \&quot;PENDING\&quot;, \&quot;ACCEPTED\&quot; | [optional] 
 **orderby** | **string**| sort by which field valid values include timestamp, array_name, organization_name | [optional] 

### Return type

[**InvitationData**](InvitationData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of invitations and pagination metadata |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## JoinOrganization

> void JoinOrganization (string organization, InvitationOrganizationJoinEmail emailInvite)



Sends email to multiple recipients with joining information regarding an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class JoinOrganizationExample
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

            var apiInstance = new InvitationApi(Configuration.Default);
            var organization = "organization_example";  // string | name or UUID of organization
            var emailInvite = new InvitationOrganizationJoinEmail(); // InvitationOrganizationJoinEmail | list of email recipients

            try
            {
                apiInstance.JoinOrganization(organization, emailInvite);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvitationApi.JoinOrganization: " + e.Message );
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
 **organization** | **string**| name or UUID of organization | 
 **emailInvite** | [**InvitationOrganizationJoinEmail**](InvitationOrganizationJoinEmail.md)| list of email recipients | 

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
| **204** | Email sent successfully to user for email confirmation link |  -  |
| **404** | Could not reach one or more recipients |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ShareArrayByInvite

> void ShareArrayByInvite (string _namespace, string array, InvitationArrayShareEmail emailInvite)



Sends email to multiple recipients with sharing information regarding an array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ShareArrayByInviteExample
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

            var apiInstance = new InvitationApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | namespace array is in (an organization name or user's username)
            var array = "array_example";  // string | name/uri of array that is url-encoded
            var emailInvite = new InvitationArrayShareEmail(); // InvitationArrayShareEmail | list of email recipients

            try
            {
                apiInstance.ShareArrayByInvite(_namespace, array, emailInvite);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InvitationApi.ShareArrayByInvite: " + e.Message );
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
 **emailInvite** | [**InvitationArrayShareEmail**](InvitationArrayShareEmail.md)| list of email recipients | 

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
| **204** | Email sent successfully to user for email confirmation link |  -  |
| **404** | Could not reach one or more recipients |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

