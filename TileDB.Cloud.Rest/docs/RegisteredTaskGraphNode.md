
# TileDB.Cloud.Rest.Model.RegisteredTaskGraphNode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientNodeId** | **string** | The client-generated UUID of the given graph node. | [optional] 
**Name** | **string** | A client-specified name for the node. If provided, this must be unique.  | [optional] 
**DependsOn** | **List&lt;string&gt;** | The client_node_uuid of each node that this node depends upon. Used to define the structure of the graph.  | [optional] 
**ArrayNode** | [**UDFArrayDetails**](UDFArrayDetails.md) |  | [optional] 
**InputNode** | [**TGInputNodeData**](TGInputNodeData.md) |  | [optional] 
**SqlNode** | [**TGSQLNodeData**](TGSQLNodeData.md) |  | [optional] 
**UdfNode** | [**TGUDFNodeData**](TGUDFNodeData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

