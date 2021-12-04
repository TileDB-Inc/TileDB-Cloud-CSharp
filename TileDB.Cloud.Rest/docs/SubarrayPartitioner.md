
# TileDB.Cloud.Rest.Model.SubarrayPartitioner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subarray** | [**Subarray**](Subarray.md) |  | [optional] 
**Budget** | [**List&lt;AttributeBufferSize&gt;**](AttributeBufferSize.md) | Result size budget (in bytes) for all attributes. | [optional] 
**Current** | [**SubarrayPartitionerCurrent**](SubarrayPartitionerCurrent.md) |  | [optional] 
**State** | [**SubarrayPartitionerState**](SubarrayPartitionerState.md) |  | [optional] 
**MemoryBudget** | **int** | The memory budget for the fixed-sized attributes and the offsets of the var-sized attributes | [optional] 
**MemoryBudgetVar** | **int** | The memory budget for the var-sized attributes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

