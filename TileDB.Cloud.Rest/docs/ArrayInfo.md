# TileDB.Cloud.Rest.Model.ArrayInfo
metadata of an array

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | unique ID of registered array | [optional] 
**FileType** | **FileType** |  | [optional] 
**FileProperties** | **Dictionary&lt;string, string&gt;** | map of file properties created for this array | [optional] 
**Uri** | **string** | uri of array | [optional] 
**Namespace** | **string** | namespace array is in | [optional] 
**Size** | **decimal?** | size in bytes of array | [optional] 
**LastAccessed** | **DateTime** | Datetime array was last accessed in UTC | [optional] 
**Description** | **string** | description of array | [optional] 
**Name** | **string** | name of array | [optional] 
**AllowedActions** | [**List&lt;ArrayActions&gt;**](ArrayActions.md) | list of actions user is allowed to do on this array | [optional] 
**Pricing** | [**List&lt;Pricing&gt;**](Pricing.md) | list of pricing created for this array | [optional] 
**Subscriptions** | [**List&lt;Subscription&gt;**](Subscription.md) | list of subscriptions created for this array | [optional] 
**Logo** | **string** | logo (base64 encoded) for the array. Optional | [optional] 
**AccessCredentialsName** | **string** | the name of the access credentials to use. if unset, the default credentials will be used | [optional] 
**Type** | **string** | Array type (dense, key-value, sparse) | [optional] 
**ShareCount** | **decimal** | number of unique namespaces this array is shared with | [optional] 
**PublicShare** | **bool** | Suggests if the array was shared to public by owner | [optional] 
**NamespaceSubscribed** | **bool** | Depends on the namespace asking, denotes the existence of subscription of namespace to this array | [optional] [readonly] 
**TiledbUri** | **string** | uri for access through TileDB cloud | [optional] 
**Tags** | **List&lt;string&gt;** | optional tags for array | [optional] 
**LicenseId** | **string** | License identifier from SPDX License List or Custom | [optional] 
**LicenseText** | **string** | License text | [optional] 
**ReadOnly** | **bool?** | Suggests if the array is in read_only mode | [optional] 
**IsFavorite** | **bool** | Indicates whether the array is in user favorites | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

