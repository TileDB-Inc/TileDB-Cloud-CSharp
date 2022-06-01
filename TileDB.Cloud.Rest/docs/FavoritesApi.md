# TileDB.Cloud.Rest.Api.FavoritesApi

All URIs are relative to */v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddArrayFavorite**](FavoritesApi.md#addarrayfavorite) | **POST** /arrays/favorites/{namespace}/{name} | 
[**AddMLModelFavorite**](FavoritesApi.md#addmlmodelfavorite) | **POST** /ml_models/favorites/{namespace}/{name} | 
[**AddNotebookFavorite**](FavoritesApi.md#addnotebookfavorite) | **POST** /notebooks/favorites/{namespace}/{name} | 
[**AddUDFFavorite**](FavoritesApi.md#addudffavorite) | **POST** /udfs/favorites/{namespace}/{name} | 
[**DeleteArrayFavorite**](FavoritesApi.md#deletearrayfavorite) | **DELETE** /arrays/favorites/{namespace}/{name} | 
[**DeleteMLModelFavorite**](FavoritesApi.md#deletemlmodelfavorite) | **DELETE** /ml_models/favorites/{namespace}/{name} | 
[**DeleteNotebookFavorite**](FavoritesApi.md#deletenotebookfavorite) | **DELETE** /notebooks/favorites/{namespace}/{name} | 
[**DeleteUDFFavorite**](FavoritesApi.md#deleteudffavorite) | **DELETE** /udfs/favorites/{namespace}/{name} | 
[**GetArrayFavorite**](FavoritesApi.md#getarrayfavorite) | **GET** /arrays/favorites/{namespace}/{name} | 
[**GetMLModelFavorite**](FavoritesApi.md#getmlmodelfavorite) | **GET** /ml_models/favorites/{namespace}/{name} | 
[**GetNotebookFavorite**](FavoritesApi.md#getnotebookfavorite) | **GET** /notebooks/favorites/{namespace}/{name} | 
[**GetUDFFavorite**](FavoritesApi.md#getudffavorite) | **GET** /udfs/favorites/{namespace}/{name} | 
[**ListArrayFavorites**](FavoritesApi.md#listarrayfavorites) | **GET** /arrays/favorites | 
[**ListArrayFavoritesUUIDs**](FavoritesApi.md#listarrayfavoritesuuids) | **GET** /arrays/favorites/uuids | 
[**ListMLModelFavorites**](FavoritesApi.md#listmlmodelfavorites) | **GET** /ml_models/favorites | 
[**ListMLModelFavoritesUUIDs**](FavoritesApi.md#listmlmodelfavoritesuuids) | **GET** /ml_models/favorites/uuids | 
[**ListNotebookFavorites**](FavoritesApi.md#listnotebookfavorites) | **GET** /notebooks/favorites | 
[**ListNotebookFavoritesUUIDs**](FavoritesApi.md#listnotebookfavoritesuuids) | **GET** /notebooks/favorites/uuids | 
[**ListUDFFavorites**](FavoritesApi.md#listudffavorites) | **GET** /udfs/favorites | 
[**ListUDFFavoritesUUIDs**](FavoritesApi.md#listudffavoritesuuids) | **GET** /udfs/favorites/uuids | 



## AddArrayFavorite

> void AddArrayFavorite (string _namespace, string name)



Add a new array favorite

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class AddArrayFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the array
            var name = "name_example";  // string | The name of the array

            try
            {
                apiInstance.AddArrayFavorite(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.AddArrayFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the array | 
 **name** | **string**| The name of the array | 

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
| **204** | Item added to favorites successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AddMLModelFavorite

> void AddMLModelFavorite (string _namespace, string name)



Add a new ML model favorite

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class AddMLModelFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the ML model
            var name = "name_example";  // string | The name of the ML model

            try
            {
                apiInstance.AddMLModelFavorite(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.AddMLModelFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the ML model | 
 **name** | **string**| The name of the ML model | 

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
| **204** | Item added to favorites successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AddNotebookFavorite

> void AddNotebookFavorite (string _namespace, string name)



Add a new notebook favorite

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class AddNotebookFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the notebook
            var name = "name_example";  // string | The name of the notebook

            try
            {
                apiInstance.AddNotebookFavorite(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.AddNotebookFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the notebook | 
 **name** | **string**| The name of the notebook | 

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
| **204** | Item added to favorites successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AddUDFFavorite

> void AddUDFFavorite (string _namespace, string name)



Add a new UDF favorite

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class AddUDFFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the UDF
            var name = "name_example";  // string | The name of the UDF

            try
            {
                apiInstance.AddUDFFavorite(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.AddUDFFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the UDF | 
 **name** | **string**| The name of the UDF | 

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
| **204** | Item added to favorites successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteArrayFavorite

> void DeleteArrayFavorite (string _namespace, string name)



Delete specific array favorite

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteArrayFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the array
            var name = "name_example";  // string | The name of the array

            try
            {
                apiInstance.DeleteArrayFavorite(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.DeleteArrayFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the array | 
 **name** | **string**| The name of the array | 

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
| **204** | array favorite item deleted successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteMLModelFavorite

> void DeleteMLModelFavorite (string _namespace, string name)



Delete specific ML model favorite

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteMLModelFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the ML model
            var name = "name_example";  // string | The name of the ML model

            try
            {
                apiInstance.DeleteMLModelFavorite(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.DeleteMLModelFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the ML model | 
 **name** | **string**| The name of the ML model | 

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
| **204** | ML model favorite item deleted successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteNotebookFavorite

> void DeleteNotebookFavorite (string _namespace, string name)



Delete specific notebook favorite

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteNotebookFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the notebook
            var name = "name_example";  // string | The name of the notebook

            try
            {
                apiInstance.DeleteNotebookFavorite(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.DeleteNotebookFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the notebook | 
 **name** | **string**| The name of the notebook | 

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
| **204** | notebook favorite item deleted successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteUDFFavorite

> void DeleteUDFFavorite (string _namespace, string name)



Delete specific UDF favorite

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class DeleteUDFFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the UDF
            var name = "name_example";  // string | The name of the UDF

            try
            {
                apiInstance.DeleteUDFFavorite(_namespace, name);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.DeleteUDFFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the UDF | 
 **name** | **string**| The name of the UDF | 

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
| **204** | UDF favorite item deleted successfully |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetArrayFavorite

> ArrayFavorite GetArrayFavorite (string _namespace, string name)



Fetch array favorite of a specific array

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetArrayFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the array
            var name = "name_example";  // string | The name of the array

            try
            {
                ArrayFavorite result = apiInstance.GetArrayFavorite(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.GetArrayFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the array | 
 **name** | **string**| The name of the array | 

### Return type

[**ArrayFavorite**](ArrayFavorite.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMLModelFavorite

> MLModelFavorite GetMLModelFavorite (string _namespace, string name)



Fetch ML model favorite of a specific ML model

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetMLModelFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the ML model
            var name = "name_example";  // string | The name of the ML model

            try
            {
                MLModelFavorite result = apiInstance.GetMLModelFavorite(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.GetMLModelFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the ML model | 
 **name** | **string**| The name of the ML model | 

### Return type

[**MLModelFavorite**](MLModelFavorite.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetNotebookFavorite

> NotebookFavorite GetNotebookFavorite (string _namespace, string name)



Fetch notebook favorite of a specific notebook

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetNotebookFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the notebook
            var name = "name_example";  // string | The name of the notebook

            try
            {
                NotebookFavorite result = apiInstance.GetNotebookFavorite(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.GetNotebookFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the notebook | 
 **name** | **string**| The name of the notebook | 

### Return type

[**NotebookFavorite**](NotebookFavorite.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUDFFavorite

> UDFFavorite GetUDFFavorite (string _namespace, string name)



Fetch UDF favorite of a specific UDF

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class GetUDFFavoriteExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var _namespace = "_namespace_example";  // string | The namespace of the UDF
            var name = "name_example";  // string | The name of the UDF

            try
            {
                UDFFavorite result = apiInstance.GetUDFFavorite(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.GetUDFFavorite: " + e.Message );
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
 **_namespace** | **string**| The namespace of the UDF | 
 **name** | **string**| The name of the UDF | 

### Return type

[**UDFFavorite**](UDFFavorite.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListArrayFavorites

> ArrayFavoritesData ListArrayFavorites (int? page = null, int? perPage = null)



Fetch a page of array favorites of connected user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListArrayFavoritesExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 

            try
            {
                ArrayFavoritesData result = apiInstance.ListArrayFavorites(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.ListArrayFavorites: " + e.Message );
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

### Return type

[**ArrayFavoritesData**](ArrayFavoritesData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available array favorites are returned |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListArrayFavoritesUUIDs

> List&lt;ArrayFavorite&gt; ListArrayFavoritesUUIDs ()



Fetch all favorite array uuids of connected user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListArrayFavoritesUUIDsExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);

            try
            {
                List<ArrayFavorite> result = apiInstance.ListArrayFavoritesUUIDs();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.ListArrayFavoritesUUIDs: " + e.Message );
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

[**List&lt;ArrayFavorite&gt;**](ArrayFavorite.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available favorites array uuids are returned |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListMLModelFavorites

> MLModelFavoritesData ListMLModelFavorites (int? page = null, int? perPage = null)



Fetch a page of ML models favorites of connected user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListMLModelFavoritesExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 

            try
            {
                MLModelFavoritesData result = apiInstance.ListMLModelFavorites(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.ListMLModelFavorites: " + e.Message );
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

### Return type

[**MLModelFavoritesData**](MLModelFavoritesData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available ML models favorites are returned |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListMLModelFavoritesUUIDs

> List&lt;MLModelFavorite&gt; ListMLModelFavoritesUUIDs ()



Fetch all favorite ML models uuids of connected user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListMLModelFavoritesUUIDsExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);

            try
            {
                List<MLModelFavorite> result = apiInstance.ListMLModelFavoritesUUIDs();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.ListMLModelFavoritesUUIDs: " + e.Message );
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

[**List&lt;MLModelFavorite&gt;**](MLModelFavorite.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available favorites ML model uuids are returned |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListNotebookFavorites

> NotebookFavoritesData ListNotebookFavorites (bool? isDashboard = null, int? page = null, int? perPage = null)



Fetch a page of notebook favorites of connected user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListNotebookFavoritesExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var isDashboard = true;  // bool? | return only dashboards (optional) 
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 

            try
            {
                NotebookFavoritesData result = apiInstance.ListNotebookFavorites(isDashboard, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.ListNotebookFavorites: " + e.Message );
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
 **isDashboard** | **bool?**| return only dashboards | [optional] 
 **page** | **int?**| pagination offset | [optional] 
 **perPage** | **int?**| pagination limit | [optional] 

### Return type

[**NotebookFavoritesData**](NotebookFavoritesData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available notebook favorites are returned |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListNotebookFavoritesUUIDs

> List&lt;NotebookFavorite&gt; ListNotebookFavoritesUUIDs ()



Fetch all favorite notebook uuids of connected user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListNotebookFavoritesUUIDsExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);

            try
            {
                List<NotebookFavorite> result = apiInstance.ListNotebookFavoritesUUIDs();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.ListNotebookFavoritesUUIDs: " + e.Message );
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

[**List&lt;NotebookFavorite&gt;**](NotebookFavorite.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available favorites notebook uuids are returned |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListUDFFavorites

> UDFFavoritesData ListUDFFavorites (int? page = null, int? perPage = null)



Fetch a page of UDF favorites of connected user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListUDFFavoritesExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);
            var page = 56;  // int? | pagination offset (optional) 
            var perPage = 56;  // int? | pagination limit (optional) 

            try
            {
                UDFFavoritesData result = apiInstance.ListUDFFavorites(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.ListUDFFavorites: " + e.Message );
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

### Return type

[**UDFFavoritesData**](UDFFavoritesData.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available UDF favorites are returned |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListUDFFavoritesUUIDs

> List&lt;UDFFavorite&gt; ListUDFFavoritesUUIDs ()



Fetch all favorite UDF uuids of connected user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Client;
using TileDB.Cloud.Rest.Model;

namespace Example
{
    public class ListUDFFavoritesUUIDsExample
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

            var apiInstance = new FavoritesApi(Configuration.Default);

            try
            {
                List<UDFFavorite> result = apiInstance.ListUDFFavoritesUUIDs();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FavoritesApi.ListUDFFavoritesUUIDs: " + e.Message );
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

[**List&lt;UDFFavorite&gt;**](UDFFavorite.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available favorites UDF uuids are returned |  -  |
| **0** | error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

