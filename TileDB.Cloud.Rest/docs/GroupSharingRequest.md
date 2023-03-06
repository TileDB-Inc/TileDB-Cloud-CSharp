# TileDB.Cloud.Rest.Model.GroupSharingRequest
a request to share a group and all the contents with a namespace

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupActions** | [**List&lt;GroupActions&gt;**](GroupActions.md) | List of permitted actions for the group and all subgroups | [optional] 
**ArrayActions** | [**List&lt;ArrayActions&gt;**](ArrayActions.md) | List of permitted actions for all the subarrays of the group | [optional] 
**Namespace** | **string** | namespace being granted group access can be a user or organization | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

