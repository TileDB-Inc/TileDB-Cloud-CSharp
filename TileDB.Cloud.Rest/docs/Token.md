# TileDB.Cloud.Rest.Model.Token
A api token and its metadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_Token** | **string** | A api token | [optional] 
**Name** | **string** | Name of token to revoke | [optional] 
**IssuedAt** | **DateTime** | datetime the token was created | [optional] 
**ExpiresAt** | **DateTime** | datetime the token when token will expire | [optional] 
**Scope** | [**List&lt;TokenScope&gt;**](TokenScope.md) | Optional scope to limit token, defaults to all permissions, current supported values are password_reset or * | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

