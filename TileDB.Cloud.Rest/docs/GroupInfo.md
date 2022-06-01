
# TileDB.Cloud.Rest.Model.GroupInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | unique ID of registered group | [optional] 
**Namespace** | **string** | namespace group is in | [optional] 
**Name** | **string** | name of group | [optional] 
**Description** | **string** | description of group | [optional] 
**Uri** | **string** | uri of group | [optional] 
**TiledbUri** | **string** | uri for access through TileDB cloud | [optional] 
**AssetCount** | **decimal** | A count of direct array members | [optional] 
**GroupCount** | **decimal** | A count of direct group members | [optional] 
**Size** | **decimal** | A count of direct members. This is the sum of asset_count and group_count | [optional] 
**LastAccessed** | **DateTime** | Datetime groups was last accessed in UTC | [optional] 
**AllowedActions** | [**List&lt;GroupActions&gt;**](GroupActions.md) | list of actions user is allowed to do on this group | [optional] 
**Logo** | **string** | logo (base64 encoded) for the gruop. Optional | [optional] 
**AccessCredentialsName** | **string** | the name of the access credentials to use. if unset, the default credentials will be used | [optional] 
**ShareCount** | **decimal** | number of unique namespaces this group is shared with | [optional] 
**PublicShare** | **bool** | Suggests if the group was shared to public by owner | [optional] 
**Tags** | **List&lt;string&gt;** | optional tags for group | [optional] 
**LicenseId** | **string** | License identifier from SPDX License List or Custom | [optional] 
**LicenseText** | **string** | License text | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

