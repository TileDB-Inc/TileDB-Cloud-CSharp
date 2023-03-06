# TileDB.Cloud.Rest.Model.ArraySchema
ArraySchema during creation or retrieval

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | URI of schema | [optional] 
**_Version** | **List&lt;int&gt;** | file format version | 
**ArrayType** | **ArrayType** |  | 
**TileOrder** | **Layout** |  | 
**CellOrder** | **Layout** |  | 
**Capacity** | **int** | Capacity of array | 
**CoordsFilterPipeline** | [**FilterPipeline**](FilterPipeline.md) |  | 
**OffsetFilterPipeline** | [**FilterPipeline**](FilterPipeline.md) |  | 
**Domain** | [**Domain**](Domain.md) |  | 
**Attributes** | [**List&lt;Attribute&gt;**](Attribute.md) | Attributes of array | 
**AllowsDuplicates** | **bool** | True if the array allows coordinate duplicates. Applicable only to sparse arrays. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

