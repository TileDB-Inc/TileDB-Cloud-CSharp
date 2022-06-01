
# TileDB.Cloud.Rest.Model.TaskGraphLog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | The server-generated UUID of the task graph. | [optional] [readonly] 
**Namespace** | **string** | The namespace that owns this task graph log. When creating a task graph log, this is used as the namespace to create the log in; thereafter it is read-only.  | [optional] 
**CreatedBy** | **string** | The name of the user who created this task graph log. | [optional] [readonly] 
**Name** | **string** | A name for this task graph log, displayed in the UI. Does not need to be unique.  | [optional] 
**CreatedAt** | **DateTime** | The date/time when this task graph log was originally created. This is distinct from the execution start_time.  | [optional] [readonly] 
**StartTime** | **DateTime?** | The start time of the task graph, recorded when the server starts executing the first node.  | [optional] [readonly] 
**EndTime** | **DateTime?** | The end time of the task graph, recorded when the client reports completion.  | [optional] [readonly] 
**Status** | **TaskGraphLogStatus** |  | [optional] 
**TotalCost** | **decimal?** | If present, the total cost of executing all nodes in this task graph.  | [optional] 
**AccessCost** | **decimal?** | If present, the total cost of access from execution of the nodes in this task graph.  | [optional] 
**EgressCost** | **decimal?** | If present, the total cost of access from execution of the nodes in this task graph.  | [optional] 
**ExecutionTime** | **string** | The total execution time of all the nodes in this graph, in ISO 8601 format with hours, minutes, and seconds.  | [optional] 
**StatusCount** | **Dictionary&lt;string, decimal&gt;** | A mapping from &#x60;ArrayTaskStatus&#x60; string value to the number of nodes in this graph that are in that status.  | [optional] 
**Nodes** | [**List&lt;TaskGraphNodeMetadata&gt;**](TaskGraphNodeMetadata.md) | The structure of the graph. This is provided by the client when first setting up the task graph. Thereafter, it is read-only. This must be topographically sorted; that is, each node must appear after all nodes that it depends upon.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

