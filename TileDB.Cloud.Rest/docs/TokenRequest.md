
# TileDB.Cloud.Rest.Model.TokenRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expires** | **DateTime** | Expiration date for token, if empty token defaults to 30 minutes | [optional] 
**Name** | **string** | Optional name for token, if the name already exists for the user it will be auto incremented (i.e. myToken-1) | [optional] 
**Scope** | **string** | Optional scope to limit token, defaults to all permissions, current supported values are password_reset or * | [optional] [default to "*"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

