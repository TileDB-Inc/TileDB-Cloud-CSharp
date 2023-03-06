# TileDB.Cloud.Rest.Model.RegisteredTaskGraph
The structure and metadata of a task graph that can be stored on TileDB Cloud and executed by users who have access to it. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | A server-assigned unique ID for the UDF, in UUID format. | [optional] 
**Namespace** | **string** | The namespace that owns this task graph log. | [optional] 
**Name** | **string** | The name of this graph, to appear in URLs. Must be unique per-namespace.  | [optional] 
**Readme** | **string** | Documentation for the task graph, in Markdown format. | [optional] 
**LicenseId** | **string** | SPDX license identifier. | [optional] 
**LicenseText** | **string** | Full text of the license. | [optional] 
**Tags** | **List&lt;string&gt;** | Optional tags to classify the graph. | [optional] 
**Nodes** | [**List&lt;RegisteredTaskGraphNode&gt;**](RegisteredTaskGraphNode.md) | The structure of the graph, in the form of the nodes that make it up. As with &#x60;TaskGraphLog&#x60;, nodes must topologically sorted, so that any node appears after all the nodes it depends on.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

