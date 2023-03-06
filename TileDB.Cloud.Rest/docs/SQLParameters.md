# TileDB.Cloud.Rest.Model.SQLParameters
Parameters for running sql query

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | name of task, optional | [optional] 
**Query** | **string** | query to run | [optional] 
**OutputUri** | **string** | Output array uri | [optional] 
**StoreResults** | **bool** | store results for later retrieval | [optional] 
**DontDownloadResults** | **bool** | Set to true to avoid downloading the results of this UDF. Useful for intermediate nodes in a task graph where you will not be using the results of your function. Defaults to false (\&quot;yes download results\&quot;). | [optional] 
**ResourceClass** | **string** | The resource class to use for the SQL execution. Resource classes define resource limits for memory and CPUs. If this is empty, then the SQL will execute in the standard resource class of the TileDB Cloud provider.  | [optional] 
**ResultFormat** | **ResultFormat** |  | [optional] 
**InitCommands** | **List&lt;string&gt;** | Queries or commands to run before main query | [optional] 
**Parameters** | **List&lt;Object&gt;** | SQL query parameters | [optional] 
**TaskGraphUuid** | **string** | If set, the ID of the log for the task graph that this was part of.  | [optional] 
**ClientNodeUuid** | **string** | If set, the client-defined ID of the node within this task&#39;s graph.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

