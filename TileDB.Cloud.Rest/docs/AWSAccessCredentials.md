# TileDB.Cloud.Rest.Model.AWSAccessCredentials
Model representing aws keys or service role, service roles are currently ignored, but will be preferred option in the future

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SecretAccessKey** | **string** | aws secret access key, never returned in get requests | [optional] 
**AccessKeyId** | **string** | aws access key | [optional] 
**ServiceRoleArn** | **string** | aws service role to use for access | [optional] 
**Name** | **string** | human readable name | [optional] 
**Default** | **bool** | true if this is the default credential to be used within this namespace | [optional] 
**Buckets** | **List&lt;string&gt;** | a whitelist of one or more buckets this key should access | [optional] 
**CreatedAt** | **DateTime** | Time when UDF dependencies were created (rfc3339) | [optional] [readonly] 
**UpdatedAt** | **DateTime** | Time when UDF dependencies was last updated (rfc3339) | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

