# TileDB.Cloud.Rest.Api.GroupsApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeGroupContents**](GroupsApi.md#changegroupcontents) | **POST** /groups/{group_namespace}/{group_name}/contents | 
[**CreateGroup**](GroupsApi.md#creategroup) | **POST** /groups/{namespace}/create | 
[**DeleteGroup**](GroupsApi.md#deletegroup) | **DELETE** /groups/{group_namespace}/{group_name} | 
[**GetGroup**](GroupsApi.md#getgroup) | **GET** /groups/{group_namespace}/{group_name} | 
[**GetGroupContents**](GroupsApi.md#getgroupcontents) | **GET** /groups/{group_namespace}/{group_name}/contents | 
[**GetGroupSharingPolicies**](GroupsApi.md#getgroupsharingpolicies) | **GET** /groups/{group_namespace}/{group_name}/share | 
[**GroupsBrowserOwnedFiltersGet**](GroupsApi.md#groupsbrowserownedfiltersget) | **GET** /groups/browser/owned/filters | 
[**GroupsBrowserPublicFiltersGet**](GroupsApi.md#groupsbrowserpublicfiltersget) | **GET** /groups/browser/public/filters | 
[**GroupsBrowserSharedFiltersGet**](GroupsApi.md#groupsbrowsersharedfiltersget) | **GET** /groups/browser/shared/filters | 
[**GroupsGroupNamespaceGroupNameContentsFiltersGet**](GroupsApi.md#groupsgroupnamespacegroupnamecontentsfiltersget) | **GET** /groups/{group_namespace}/{group_name}/contents/filters | 
[**ListOwnedGroups**](GroupsApi.md#listownedgroups) | **GET** /groups/browser/owned | 
[**ListPublicGroups**](GroupsApi.md#listpublicgroups) | **GET** /groups/browser/public | 
[**ListSharedGroups**](GroupsApi.md#listsharedgroups) | **GET** /groups/browser/shared | 
[**RegisterGroup**](GroupsApi.md#registergroup) | **POST** /groups/{namespace}/{array}/register | 
[**ShareGroup**](GroupsApi.md#sharegroup) | **PATCH** /groups/{group_namespace}/{group_name}/share | 
[**UpdateGroup**](GroupsApi.md#updategroup) | **PATCH** /groups/{group_namespace}/{group_name} | 


<a name="changegroupcontents"></a>
# **ChangeGroupContents**
> void ChangeGroupContents (string groupNamespace, string groupName, GroupChanges groupChanges = null)



Changes the contents of the group by adding/removing members.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ChangeGroupContentsExample
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

            var apiInstance = new GroupsApi(config);
            var groupNamespace = "groupNamespace_example";  // string | The namespace of the group
            var groupName = "groupName_example";  // string | The unique name or id of the group
            var groupChanges = new GroupChanges(); // GroupChanges |  (optional) 

            try
            {
                apiInstance.ChangeGroupContents(groupNamespace, groupName, groupChanges);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ChangeGroupContents: " + e.Message );
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
 **groupNamespace** | **string**| The namespace of the group | 
 **groupName** | **string**| The unique name or id of the group | 
 **groupChanges** | [**GroupChanges**](GroupChanges.md)|  | [optional] 

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
| **204** | all changes applied successfully |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategroup"></a>
# **CreateGroup**
> void CreateGroup (string _namespace, GroupCreate groupCreate = null)



Creates a new group in the namespace.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class CreateGroupExample
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

            var apiInstance = new GroupsApi(config);
            var _namespace = "_namespace_example";  // string | The namespace of the group
            var groupCreate = new GroupCreate(); // GroupCreate |  (optional) 

            try
            {
                apiInstance.CreateGroup(_namespace, groupCreate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroup: " + e.Message );
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
 **_namespace** | **string**| The namespace of the group | 
 **groupCreate** | [**GroupCreate**](GroupCreate.md)|  | [optional] 

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
| **204** | group created successfully |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (string groupNamespace, string groupName)



Deletes the group. The assets are not deleted nor are not relocated to any other group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteGroupExample
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

            var apiInstance = new GroupsApi(config);
            var groupNamespace = "groupNamespace_example";  // string | The namespace of the group
            var groupName = "groupName_example";  // string | The unique name or id of the group

            try
            {
                apiInstance.DeleteGroup(groupNamespace, groupName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroup: " + e.Message );
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
 **groupNamespace** | **string**| The namespace of the group | 
 **groupName** | **string**| The unique name or id of the group | 

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
| **204** | group deleted successfully |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroup"></a>
# **GetGroup**
> GroupInfo GetGroup (string groupNamespace, string groupName)



Returns the the group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetGroupExample
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

            var apiInstance = new GroupsApi(config);
            var groupNamespace = "groupNamespace_example";  // string | The namespace of the group
            var groupName = "groupName_example";  // string | The unique name or id of the group

            try
            {
                GroupInfo result = apiInstance.GetGroup(groupNamespace, groupName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroup: " + e.Message );
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
 **groupNamespace** | **string**| The namespace of the group | 
 **groupName** | **string**| The unique name or id of the group | 

### Return type

[**GroupInfo**](GroupInfo.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the group metadata |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupcontents"></a>
# **GetGroupContents**
> GroupContents GetGroupContents (string groupNamespace, string groupName, int? page = null, int? perPage = null, string _namespace = null, string search = null, string orderby = null, List<string> tag = null, List<string> excludeTag = null, List<string> memberType = null, List<string> excludeMemberType = null)



Returns the contents of the group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetGroupContentsExample
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

            var apiInstance = new GroupsApi(config);
            var groupNamespace = "groupNamespace_example";  // string | The namespace of the group
            var groupName = "groupName_example";  // string | The unique name or id of the group
            var page = 56;  // int? | pagination offset for assets (optional) 
            var perPage = 56;  // int? | pagination limit for assets (optional) 
            var _namespace = "_namespace_example";  // string | namespace to search for (optional) 
            var search = "search_example";  // string | search string that will look at name, namespace or description fields (optional) 
            var orderby = "orderby_example";  // string | sort by which field valid values include last_accessed, size, name (optional) 
            var tag = new List<string>(); // List<string> | tag to search for, more than one can be included (optional) 
            var excludeTag = new List<string>(); // List<string> | tags to exclude matching array in results, more than one can be included (optional) 
            var memberType = new List<string>(); // List<string> | member type to search for, more than one can be included (optional) 
            var excludeMemberType = new List<string>(); // List<string> | member type to exclude matching groups in results, more than one can be included (optional) 

            try
            {
                GroupContents result = apiInstance.GetGroupContents(groupNamespace, groupName, page, perPage, _namespace, search, orderby, tag, excludeTag, memberType, excludeMemberType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupContents: " + e.Message );
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
 **groupNamespace** | **string**| The namespace of the group | 
 **groupName** | **string**| The unique name or id of the group | 
 **page** | **int?**| pagination offset for assets | [optional] 
 **perPage** | **int?**| pagination limit for assets | [optional] 
 **_namespace** | **string**| namespace to search for | [optional] 
 **search** | **string**| search string that will look at name, namespace or description fields | [optional] 
 **orderby** | **string**| sort by which field valid values include last_accessed, size, name | [optional] 
 **tag** | [**List&lt;string&gt;**](string.md)| tag to search for, more than one can be included | [optional] 
 **excludeTag** | [**List&lt;string&gt;**](string.md)| tags to exclude matching array in results, more than one can be included | [optional] 
 **memberType** | [**List&lt;string&gt;**](string.md)| member type to search for, more than one can be included | [optional] 
 **excludeMemberType** | [**List&lt;string&gt;**](string.md)| member type to exclude matching groups in results, more than one can be included | [optional] 

### Return type

[**GroupContents**](GroupContents.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the group contents |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupsharingpolicies"></a>
# **GetGroupSharingPolicies**
> List&lt;GroupSharing&gt; GetGroupSharingPolicies (string groupNamespace, string groupName)



Get all sharing details of the group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetGroupSharingPoliciesExample
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

            var apiInstance = new GroupsApi(config);
            var groupNamespace = "groupNamespace_example";  // string | The namespace of the group
            var groupName = "groupName_example";  // string | The unique name or id of the group

            try
            {
                List<GroupSharing> result = apiInstance.GetGroupSharingPolicies(groupNamespace, groupName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupSharingPolicies: " + e.Message );
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
 **groupNamespace** | **string**| The namespace of the group | 
 **groupName** | **string**| The unique name or id of the group | 

### Return type

[**List&lt;GroupSharing&gt;**](GroupSharing.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of all specific sharing policies |  -  |
| **404** | Group does not exist or user does not have permissions to view group-sharing policies |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsbrowserownedfiltersget"></a>
# **GroupsBrowserOwnedFiltersGet**
> GroupBrowserFilterData GroupsBrowserOwnedFiltersGet ()



Fetch data to initialize filters for the groups browser

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GroupsBrowserOwnedFiltersGetExample
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

            var apiInstance = new GroupsApi(config);

            try
            {
                GroupBrowserFilterData result = apiInstance.GroupsBrowserOwnedFiltersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsBrowserOwnedFiltersGet: " + e.Message );
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

[**GroupBrowserFilterData**](GroupBrowserFilterData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Filter data |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsbrowserpublicfiltersget"></a>
# **GroupsBrowserPublicFiltersGet**
> GroupBrowserFilterData GroupsBrowserPublicFiltersGet ()



Fetch data to initialize filters for the groups browser

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GroupsBrowserPublicFiltersGetExample
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

            var apiInstance = new GroupsApi(config);

            try
            {
                GroupBrowserFilterData result = apiInstance.GroupsBrowserPublicFiltersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsBrowserPublicFiltersGet: " + e.Message );
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

[**GroupBrowserFilterData**](GroupBrowserFilterData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Filter data |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsbrowsersharedfiltersget"></a>
# **GroupsBrowserSharedFiltersGet**
> GroupBrowserFilterData GroupsBrowserSharedFiltersGet ()



Fetch data to initialize filters for the groups browser

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GroupsBrowserSharedFiltersGetExample
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

            var apiInstance = new GroupsApi(config);

            try
            {
                GroupBrowserFilterData result = apiInstance.GroupsBrowserSharedFiltersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsBrowserSharedFiltersGet: " + e.Message );
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

[**GroupBrowserFilterData**](GroupBrowserFilterData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Filter data |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsgroupnamespacegroupnamecontentsfiltersget"></a>
# **GroupsGroupNamespaceGroupNameContentsFiltersGet**
> GroupContentsFilterData GroupsGroupNamespaceGroupNameContentsFiltersGet (string groupNamespace, string groupName)



Fetch data to initialize filters for the group contents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GroupsGroupNamespaceGroupNameContentsFiltersGetExample
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

            var apiInstance = new GroupsApi(config);
            var groupNamespace = "groupNamespace_example";  // string | The namespace of the group
            var groupName = "groupName_example";  // string | The unique name or id of the group

            try
            {
                GroupContentsFilterData result = apiInstance.GroupsGroupNamespaceGroupNameContentsFiltersGet(groupNamespace, groupName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GroupsGroupNamespaceGroupNameContentsFiltersGet: " + e.Message );
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
 **groupNamespace** | **string**| The namespace of the group | 
 **groupName** | **string**| The unique name or id of the group | 

### Return type

[**GroupContentsFilterData**](GroupContentsFilterData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Filter data |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listownedgroups"></a>
# **ListOwnedGroups**
> GroupBrowserData ListOwnedGroups (int? page = null, int? perPage = null, string search = null, string _namespace = null, string orderby = null, string permissions = null, List<string> tag = null, List<string> excludeTag = null, bool? flat = null, string parent = null)



Returns one page of owned groups.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListOwnedGroupsExample
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

            var apiInstance = new GroupsApi(config);
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 
            var search = "search_example";  // string | search string that will look at name, namespace or description fields (optional) 
            var _namespace = "_namespace_example";  // string | namespace (optional) 
            var orderby = "orderby_example";  // string | sort by which field valid values include last_accessed, size, name (optional) 
            var permissions = "permissions_example";  // string | permissions valid values include read, read_write, write, admin (optional) 
            var tag = new List<string>(); // List<string> | tag to search for, more than one can be included (optional) 
            var excludeTag = new List<string>(); // List<string> | tags to exclude matching array in results, more than one can be included (optional) 
            var flat = true;  // bool? | if true, ignores the nesting of groups and searches all of them (optional) 
            var parent = "parent_example";  // string | search only the children of the groups with this uuid (optional) 

            try
            {
                GroupBrowserData result = apiInstance.ListOwnedGroups(page, perPage, search, _namespace, orderby, permissions, tag, excludeTag, flat, parent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ListOwnedGroups: " + e.Message );
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
 **flat** | **bool?**| if true, ignores the nesting of groups and searches all of them | [optional] 
 **parent** | **string**| search only the children of the groups with this uuid | [optional] 

### Return type

[**GroupBrowserData**](GroupBrowserData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the group contents |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpublicgroups"></a>
# **ListPublicGroups**
> GroupBrowserData ListPublicGroups (int? page = null, int? perPage = null, string search = null, string _namespace = null, string orderby = null, string permissions = null, List<string> tag = null, List<string> excludeTag = null, bool? flat = null, string parent = null)



Returns one page of public groups.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListPublicGroupsExample
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

            var apiInstance = new GroupsApi(config);
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 
            var search = "search_example";  // string | search string that will look at name, namespace or description fields (optional) 
            var _namespace = "_namespace_example";  // string | namespace (optional) 
            var orderby = "orderby_example";  // string | sort by which field valid values include last_accessed, size, name (optional) 
            var permissions = "permissions_example";  // string | permissions valid values include read, read_write, write, admin (optional) 
            var tag = new List<string>(); // List<string> | tag to search for, more than one can be included (optional) 
            var excludeTag = new List<string>(); // List<string> | tags to exclude matching array in results, more than one can be included (optional) 
            var flat = true;  // bool? | if true, ignores the nesting of groups and searches all of them (optional) 
            var parent = "parent_example";  // string | search only the children of the groups with this uuid (optional) 

            try
            {
                GroupBrowserData result = apiInstance.ListPublicGroups(page, perPage, search, _namespace, orderby, permissions, tag, excludeTag, flat, parent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ListPublicGroups: " + e.Message );
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
 **flat** | **bool?**| if true, ignores the nesting of groups and searches all of them | [optional] 
 **parent** | **string**| search only the children of the groups with this uuid | [optional] 

### Return type

[**GroupBrowserData**](GroupBrowserData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the group contents |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsharedgroups"></a>
# **ListSharedGroups**
> GroupBrowserData ListSharedGroups (int? page = null, int? perPage = null, string search = null, string _namespace = null, string orderby = null, string permissions = null, List<string> tag = null, List<string> excludeTag = null, bool? flat = null, string parent = null, List<string> sharedTo = null)



Returns one page of shared groups.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListSharedGroupsExample
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

            var apiInstance = new GroupsApi(config);
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 
            var search = "search_example";  // string | search string that will look at name, namespace or description fields (optional) 
            var _namespace = "_namespace_example";  // string | namespace (optional) 
            var orderby = "orderby_example";  // string | sort by which field valid values include last_accessed, size, name (optional) 
            var permissions = "permissions_example";  // string | permissions valid values include read, read_write, write, admin (optional) 
            var tag = new List<string>(); // List<string> | tag to search for, more than one can be included (optional) 
            var excludeTag = new List<string>(); // List<string> | tags to exclude matching array in results, more than one can be included (optional) 
            var flat = true;  // bool? | if true, ignores the nesting of groups and searches all of them (optional) 
            var parent = "parent_example";  // string | search only the children of the groups with this uuid (optional) 
            var sharedTo = new List<string>(); // List<string> | namespaces to filter results of where there groups were shared to (optional) 

            try
            {
                GroupBrowserData result = apiInstance.ListSharedGroups(page, perPage, search, _namespace, orderby, permissions, tag, excludeTag, flat, parent, sharedTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ListSharedGroups: " + e.Message );
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
 **flat** | **bool?**| if true, ignores the nesting of groups and searches all of them | [optional] 
 **parent** | **string**| search only the children of the groups with this uuid | [optional] 
 **sharedTo** | [**List&lt;string&gt;**](string.md)| namespaces to filter results of where there groups were shared to | [optional] 

### Return type

[**GroupBrowserData**](GroupBrowserData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | the group contents |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registergroup"></a>
# **RegisterGroup**
> void RegisterGroup (string _namespace, string array, GroupRegister groupRegister = null)



Registers an existing group in the namespace.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class RegisterGroupExample
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

            var apiInstance = new GroupsApi(config);
            var _namespace = "_namespace_example";  // string | The namespace of the group
            var array = "array_example";  // string | The unique name or id of the group
            var groupRegister = new GroupRegister(); // GroupRegister |  (optional) 

            try
            {
                apiInstance.RegisterGroup(_namespace, array, groupRegister);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.RegisterGroup: " + e.Message );
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
 **_namespace** | **string**| The namespace of the group | 
 **array** | **string**| The unique name or id of the group | 
 **groupRegister** | [**GroupRegister**](GroupRegister.md)|  | [optional] 

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
| **204** | group created successfully |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharegroup"></a>
# **ShareGroup**
> void ShareGroup (string groupNamespace, string groupName, GroupSharingRequest groupSharingRequest)



Share a group with a namespace

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ShareGroupExample
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

            var apiInstance = new GroupsApi(config);
            var groupNamespace = "groupNamespace_example";  // string | The namespace of the group
            var groupName = "groupName_example";  // string | The unique name or id of the group
            var groupSharingRequest = new GroupSharingRequest(); // GroupSharingRequest | Namespace and list of permissions to share with. Sharing is recursive, it is applied to all reachable subgroups and arrays of the group. An empty list of permissions will remove the namespace; if permissions already exist they will be deleted then new ones added. In the event of a failure, the new policies will be rolled back to prevent partial policies, and it's likely the group will not be shared with the namespace at all.

            try
            {
                apiInstance.ShareGroup(groupNamespace, groupName, groupSharingRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ShareGroup: " + e.Message );
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
 **groupNamespace** | **string**| The namespace of the group | 
 **groupName** | **string**| The unique name or id of the group | 
 **groupSharingRequest** | [**GroupSharingRequest**](GroupSharingRequest.md)| Namespace and list of permissions to share with. Sharing is recursive, it is applied to all reachable subgroups and arrays of the group. An empty list of permissions will remove the namespace; if permissions already exist they will be deleted then new ones added. In the event of a failure, the new policies will be rolled back to prevent partial policies, and it&#39;s likely the group will not be shared with the namespace at all. | 

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
| **204** | Group shared successfully |  -  |
| **404** | Group does not exist or user does not have permissions to share group |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> void UpdateGroup (string groupNamespace, string groupName, GroupUpdate groupUpdate = null)



Changes attributes of the group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class UpdateGroupExample
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

            var apiInstance = new GroupsApi(config);
            var groupNamespace = "groupNamespace_example";  // string | The namespace of the group
            var groupName = "groupName_example";  // string | The unique name or id of the group
            var groupUpdate = new GroupUpdate(); // GroupUpdate |  (optional) 

            try
            {
                apiInstance.UpdateGroup(groupNamespace, groupName, groupUpdate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroup: " + e.Message );
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
 **groupNamespace** | **string**| The namespace of the group | 
 **groupName** | **string**| The unique name or id of the group | 
 **groupUpdate** | [**GroupUpdate**](GroupUpdate.md)|  | [optional] 

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
| **204** | attributes changed successfully |  -  |
| **502** | Bad Gateway |  -  |
| **0** | error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

