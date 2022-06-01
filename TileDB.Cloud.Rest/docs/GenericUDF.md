
# TileDB.Cloud.Rest.Model.GenericUDF

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UdfInfoName** | **string** | name of UDFInfo to run, format is {namespace}/{udf_name}. Can not be used with exec | [optional] 
**Language** | **UDFLanguage** |  | [optional] 
**_Version** | **string** | Type-specific version | [optional] 
**ImageName** | **string** | Docker image name to use for UDF | [optional] 
**ResourceClass** | **string** | The resource class to use for the UDF execution. Resource classes define resource limits for memory and CPUs. If this is empty, then the UDF will execute in the standard resource class of the TileDB Cloud provider.  | [optional] 
**Exec** | **string** | Type-specific executable text | [optional] 
**ExecRaw** | **string** | optional raw text to store of serialized function, used for showing in UI | [optional] 
**Argument** | **string** | Argument(s) to pass to UDF function, tuple or list of args/kwargs which can be in native or JSON format | [optional] 
**StoredParamUuids** | **List&lt;string&gt;** | The UUIDs of stored input parameters (passed in a language-specific format within \&quot;argument\&quot;) to be retrieved from the server-side cache. Serialized in standard hex format with no {}. | [optional] 
**ResultFormat** | **ResultFormat** |  | [optional] 
**TaskName** | **string** | name of task, optional | [optional] 
**StoreResults** | **bool** | store results for later retrieval | [optional] 
**Timeout** | **int** | UDF-type timeout in seconds (default: 900) | [optional] 
**DontDownloadResults** | **bool** | Set to true to avoid downloading the results of this UDF. Useful for intermediate nodes in a task graph where you will not be using the results of your function. Defaults to false (\&quot;yes download results\&quot;). | [optional] 
**TaskGraphUuid** | **string** | If set, the ID of the log for the task graph that this was part of.  | [optional] 
**ClientNodeUuid** | **string** | If set, the client-defined ID of the node within this task&#39;s graph.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

