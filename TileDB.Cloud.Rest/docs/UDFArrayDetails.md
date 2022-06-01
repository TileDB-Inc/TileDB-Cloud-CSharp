
# TileDB.Cloud.Rest.Model.UDFArrayDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParameterId** | **string** | An optional client-generated identifier to distinguish between multiple range/buffer requests from the same array in the same call. This may be set for MultiArrayUDFs that use the &#x60;argument_json&#x60; style of passing arrays.  | [optional] 
**Uri** | **string** | array to set ranges and buffers on, must be in tiledb:// format | [optional] 
**Ranges** | [**QueryRanges**](QueryRanges.md) |  | [optional] 
**Buffers** | **List&lt;string&gt;** | List of buffers to fetch (attributes + dimensions) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

