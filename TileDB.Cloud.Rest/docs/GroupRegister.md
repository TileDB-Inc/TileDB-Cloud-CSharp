
# TileDB.Cloud.Rest.Model.GroupRegister

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A human readable description of the contents of the group. | [optional] 
**Name** | **string** | The name of the group. If must be unique within the group. | [optional] 
**Parent** | **string** | The unique name or id of the parent of the group. If empty, then the new group will be a top level group. | [optional] 
**Uri** | **string** | uri of group. | [optional] 
**Logo** | **string** | logo (base64 encoded) for the group. Optional | [optional] 
**AccessCredentialsName** | **string** | the name of the access credentials to use. if unset, the default credentials will be used. | [optional] 
**Tags** | **List&lt;string&gt;** | optional tags for groups. | [optional] 
**LicenseId** | **string** | License identifier from SPDX License List or Custom. | [optional] 
**LicenseText** | **string** | License text | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

