
# TileDB.Cloud.Rest.Model.GenericUDF

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UdfInfoName** | **string** | name of UDFInfo to run, format is {namespace}/{udf_name}. Can not be used with exec | [optional] 
**Language** | **UDFLanguage** |  | [optional] 
**_Version** | **string** | Type-specific version | [optional] 
**ImageName** | **string** | Docker image name to use for udf | [optional] 
**Exec** | **string** | Type-specific executable text | [optional] 
**ExecRaw** | **string** | optional raw text to store of serialized function, used for showing in UI | [optional] 
**Argument** | **string** | Argument(s) to pass to udf function, tuple or list of args/kwargs which can be in native or json format | [optional] 
**StoredParamUuids** | **List&lt;string&gt;** | The UUIDs of stored input parameters (passed in a language-specific format within \&quot;argument\&quot;) to be retrieved from the server-side cache. Serialized in standard hex format with no {}. | [optional] 
**ResultFormat** | **ResultFormat** |  | [optional] 
**TaskName** | **string** | name of task, optional | [optional] 
**StoreResults** | **bool** | store results for later retrieval | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

