# TileDB.Cloud.Rest.Api.OrganizationApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAWSAccessCredentials**](OrganizationApi.md#addawsaccesscredentials) | **POST** /credentials/{namespace}/aws | 
[**AddUserToOrganization**](OrganizationApi.md#addusertoorganization) | **POST** /organizations/{organization}/user | 
[**CheckAWSAccessCredentials**](OrganizationApi.md#checkawsaccesscredentials) | **GET** /credentials/{namespace}/aws | 
[**CheckAWSAccessCredentialsByName**](OrganizationApi.md#checkawsaccesscredentialsbyname) | **GET** /credentials/{namespace}/aws/{name} | 
[**CreateOrganization**](OrganizationApi.md#createorganization) | **POST** /organization | 
[**DeleteAWSAccessCredentials**](OrganizationApi.md#deleteawsaccesscredentials) | **DELETE** /credentials/{namespace}/aws/{name} | 
[**DeleteOrganization**](OrganizationApi.md#deleteorganization) | **DELETE** /organizations/{organization} | 
[**DeleteUserFromOrganization**](OrganizationApi.md#deleteuserfromorganization) | **DELETE** /organizations/{organization}/{username} | 
[**GetAllOrganizations**](OrganizationApi.md#getallorganizations) | **GET** /organizations | 
[**GetOrganization**](OrganizationApi.md#getorganization) | **GET** /organizations/{organization} | 
[**GetOrganizationUser**](OrganizationApi.md#getorganizationuser) | **GET** /organizations/{organization}/{username} | 
[**UpdateAWSAccessCredentials**](OrganizationApi.md#updateawsaccesscredentials) | **PATCH** /credentials/{namespace}/aws/{name} | 
[**UpdateOrganization**](OrganizationApi.md#updateorganization) | **PATCH** /organizations/{organization} | 
[**UpdateUserInOrganization**](OrganizationApi.md#updateuserinorganization) | **PATCH** /organizations/{organization}/{username} | 



## AddAWSAccessCredentials

> void AddAWSAccessCredentials (string _namespace, AWSAccessCredentials awsAccessCredentials)



Add aws keys

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class AddAWSAccessCredentialsExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace
            var awsAccessCredentials = new AWSAccessCredentials(); // AWSAccessCredentials | aws access credentials to store for a namespace

            try
            {
                apiInstance.AddAWSAccessCredentials(_namespace, awsAccessCredentials);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.AddAWSAccessCredentials: " + e.Message );
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
 **_namespace** | **string**| namespace | 
 **awsAccessCredentials** | [**AWSAccessCredentials**](AWSAccessCredentials.md)| aws access credentials to store for a namespace | 

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
| **204** | AWS keys added successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AddUserToOrganization

> void AddUserToOrganization (string organization, OrganizationUser user)



add a user to an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class AddUserToOrganizationExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var organization = organization_example;  // string | organization name
            var user = new OrganizationUser(); // OrganizationUser | user to add

            try
            {
                apiInstance.AddUserToOrganization(organization, user);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.AddUserToOrganization: " + e.Message );
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
 **organization** | **string**| organization name | 
 **user** | [**OrganizationUser**](OrganizationUser.md)| user to add | 

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
| **204** | user added to organization successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CheckAWSAccessCredentials

> List&lt;AWSAccessCredentials&gt; CheckAWSAccessCredentials (string _namespace)



Check if aws keys are set

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class CheckAWSAccessCredentialsExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace

            try
            {
                List<AWSAccessCredentials> result = apiInstance.CheckAWSAccessCredentials(_namespace);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.CheckAWSAccessCredentials: " + e.Message );
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
 **_namespace** | **string**| namespace | 

### Return type

[**List&lt;AWSAccessCredentials&gt;**](AWSAccessCredentials.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AWS keys are set |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CheckAWSAccessCredentialsByName

> AWSAccessCredentials CheckAWSAccessCredentialsByName (string _namespace, string name)



Check if aws keys are set by name

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class CheckAWSAccessCredentialsByNameExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace
            var name = name_example;  // string | name

            try
            {
                AWSAccessCredentials result = apiInstance.CheckAWSAccessCredentialsByName(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.CheckAWSAccessCredentialsByName: " + e.Message );
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
 **_namespace** | **string**| namespace | 
 **name** | **string**| name | 

### Return type

[**AWSAccessCredentials**](AWSAccessCredentials.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AWS keys are set |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateOrganization

> void CreateOrganization (Organization organization)



create a organization, the user creating will be listed as owner

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class CreateOrganizationExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var organization = new Organization(); // Organization | organization to create

            try
            {
                apiInstance.CreateOrganization(organization);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.CreateOrganization: " + e.Message );
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
 **organization** | [**Organization**](Organization.md)| organization to create | 

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
| **204** | organization created successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteAWSAccessCredentials

> void DeleteAWSAccessCredentials (string _namespace, string name)



delete a AWS Access credentials in a namespace. This will likely cause arrays to become unreachable

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteAWSAccessCredentialsExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace
            var name = name_example;  // string | name

            try
            {
                apiInstance.DeleteAWSAccessCredentials(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.DeleteAWSAccessCredentials: " + e.Message );
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
 **_namespace** | **string**| namespace | 
 **name** | **string**| name | 

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
| **204** | AWS credentials deleted |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteOrganization

> void DeleteOrganization (string organization)



delete a organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteOrganizationExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var organization = organization_example;  // string | organization name or id

            try
            {
                apiInstance.DeleteOrganization(organization);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.DeleteOrganization: " + e.Message );
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
 **organization** | **string**| organization name or id | 

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
| **204** | organization deleted |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteUserFromOrganization

> void DeleteUserFromOrganization (string organization, string username)



delete a user from an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteUserFromOrganizationExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var organization = organization_example;  // string | organization name
            var username = username_example;  // string | username to manipulate

            try
            {
                apiInstance.DeleteUserFromOrganization(organization, username);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.DeleteUserFromOrganization: " + e.Message );
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
 **organization** | **string**| organization name | 
 **username** | **string**| username to manipulate | 

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
| **204** | user delete from organization successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllOrganizations

> List&lt;Organization&gt; GetAllOrganizations ()



get all organizations that the user is member of

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetAllOrganizationsExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);

            try
            {
                List<Organization> result = apiInstance.GetAllOrganizations();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetAllOrganizations: " + e.Message );
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

[**List&lt;Organization&gt;**](Organization.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | array of organizations the user is member of |  -  |
| **400** | Error finding organizations |  -  |
| **500** | Request user not found, or has empty context |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetOrganization

> Organization GetOrganization (string organization)



get a organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetOrganizationExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var organization = organization_example;  // string | organization name or id

            try
            {
                Organization result = apiInstance.GetOrganization(organization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganization: " + e.Message );
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
 **organization** | **string**| organization name or id | 

### Return type

[**Organization**](Organization.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | organization details |  -  |
| **404** | Organization does not exist |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetOrganizationUser

> OrganizationUser GetOrganizationUser (string organization, string username)



get a user from an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetOrganizationUserExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var organization = organization_example;  // string | organization name
            var username = username_example;  // string | username to manipulate

            try
            {
                OrganizationUser result = apiInstance.GetOrganizationUser(organization, username);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationUser: " + e.Message );
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
 **organization** | **string**| organization name | 
 **username** | **string**| username to manipulate | 

### Return type

[**OrganizationUser**](OrganizationUser.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | user from organization |  -  |
| **404** | User is not in organization |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateAWSAccessCredentials

> void UpdateAWSAccessCredentials (string _namespace, string name, AWSAccessCredentials awsAccessCredentials)



Update aws keys or associated buckets. This will update the key associations for each array in the namespace

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class UpdateAWSAccessCredentialsExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | namespace
            var name = name_example;  // string | name
            var awsAccessCredentials = new AWSAccessCredentials(); // AWSAccessCredentials | aws credentials to update

            try
            {
                apiInstance.UpdateAWSAccessCredentials(_namespace, name, awsAccessCredentials);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.UpdateAWSAccessCredentials: " + e.Message );
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
 **_namespace** | **string**| namespace | 
 **name** | **string**| name | 
 **awsAccessCredentials** | [**AWSAccessCredentials**](AWSAccessCredentials.md)| aws credentials to update | 

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
| **204** | AWS keys updated successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateOrganization

> void UpdateOrganization (string organization, Organization organizationDetails)



update a organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class UpdateOrganizationExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var organization = organization_example;  // string | organization name or id
            var organizationDetails = new Organization(); // Organization | organization details to update

            try
            {
                apiInstance.UpdateOrganization(organization, organizationDetails);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.UpdateOrganization: " + e.Message );
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
 **organization** | **string**| organization name or id | 
 **organizationDetails** | [**Organization**](Organization.md)| organization details to update | 

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
| **204** | organization updated successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateUserInOrganization

> void UpdateUserInOrganization (string organization, string username, OrganizationUser user)



update a user in an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class UpdateUserInOrganizationExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var organization = organization_example;  // string | organization name
            var username = username_example;  // string | username to manipulate
            var user = new OrganizationUser(); // OrganizationUser | user details to update

            try
            {
                apiInstance.UpdateUserInOrganization(organization, username, user);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.UpdateUserInOrganization: " + e.Message );
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
 **organization** | **string**| organization name | 
 **username** | **string**| username to manipulate | 
 **user** | [**OrganizationUser**](OrganizationUser.md)| user details to update | 

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
| **204** | user update in organization successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

