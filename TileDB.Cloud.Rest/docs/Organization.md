
# TileDB.Cloud.Rest.Model.Organization

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | unique ID of organization | [optional] 
**Role** | **OrganizationRoles** |  | [optional] 
**Name** | **string** | organization name must be unique | 
**CreatedAt** | **DateTime** | Datetime organization was created in UTC | [optional] 
**UpdatedAt** | **DateTime** | Datetime organization was updated in UTC | [optional] 
**Logo** | **string** | Organization logo | [optional] 
**Description** | **string** | Organization description | [optional] 
**Users** | [**List&lt;OrganizationUser&gt;**](OrganizationUser.md) |  | [optional] 
**AllowedActions** | [**List&lt;NamespaceActions&gt;**](NamespaceActions.md) | list of actions user is allowed to do on this organization | [optional] 
**NumOfArrays** | **decimal** | number of registered arrays for this organization | [optional] 
**EnabledFeatures** | **List&lt;string&gt;** | List of extra/optional/beta features to enable for namespace | [optional] [readonly] 
**UnpaidSubscription** | **bool** | A notice that the user has an unpaid subscription | [optional] [readonly] 
**DefaultS3Path** | **string** | default S3 path to store newly created notebooks | [optional] 
**DefaultS3PathCredentialsName** | **string** | Default S3 path credentials name is the credentials name to use along with default_s3_path | [optional] 
**StripeConnect** | **bool** | Denotes that the organization is able to apply pricing to arrays by means of Stripe Connect | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

