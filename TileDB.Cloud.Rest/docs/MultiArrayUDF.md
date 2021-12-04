
# TileDB.Cloud.Rest.Model.MultiArrayUDF

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UdfInfoName** | **string** | name of UDFInfo to run, format is {namespace}/{udf_name}. Can not be used with exec | [optional] 
**Language** | **UDFLanguage** |  | [optional] 
**_Version** | **string** | Type-specific version | [optional] 
**ImageName** | **string** | Docker image name to use for udf | [optional] 
**Exec** | **string** | Type-specific executable text | [optional] 
**ExecRaw** | **string** | optional raw text to store of serialized function, used for showing in UI | [optional] 
**ResultFormat** | **ResultFormat** |  | [optional] 
**TaskName** | **string** | name of task, optional | [optional] 
**Argument** | **string** | Argument(s) to pass to udf function, tuple or list of args/kwargs which can be in native or json format | [optional] 
**StoredParamUuids** | **List&lt;string&gt;** | The UUIDs of stored input parameters (passed in a language-specific format within \&quot;argument\&quot;) to be retrieved from the server-side cache. Serialized in standard hex format with no {}. | [optional] 
**StoreResults** | **bool** | store results for later retrieval | [optional] 
**Ranges** | [**QueryRanges**](QueryRanges.md) |  | [optional] 
**Subarray** | [**UDFSubarray**](UDFSubarray.md) |  | [optional] 
**Buffers** | **List&lt;string&gt;** | List of buffers to fetch (attributes + dimensions). Deprecated please set arrays with UDFArrayDetails | [optional] 
**Arrays** | [**List&lt;UDFArrayDetails&gt;**](UDFArrayDetails.md) | Array ranges/buffer into to run UDF on | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

