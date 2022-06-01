
# TileDB.Cloud.Rest.Model.User

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | unique ID of user | [optional] 
**Username** | **string** | username must be unique | 
**Password** | **string** | password | [optional] 
**Name** | **string** | the user&#39;s full, real name | [optional] 
**Email** | **string** | the user&#39;s email | [optional] 
**IsValidEmail** | **bool** | user&#39;s email is validated to be correct | [optional] [readonly] 
**StripeConnect** | **bool** | Denotes that the user is able to apply pricing to arrays by means of Stripe Connect | [optional] [readonly] 
**Company** | **string** | the user&#39;s company | [optional] 
**Logo** | **string** | the user&#39;s logo | [optional] 
**LastActivityDate** | **DateTime** | when the user last logged in (set by the server) | [optional] [readonly] 
**Timezone** | **string** |  | [optional] 
**Organizations** | [**List&lt;OrganizationUser&gt;**](OrganizationUser.md) | Array of organizations a user is part of and their roles | [optional] [readonly] 
**AllowedActions** | [**List&lt;NamespaceActions&gt;**](NamespaceActions.md) | list of actions user is allowed to do on this organization | [optional] 
**EnabledFeatures** | **List&lt;string&gt;** | List of extra/optional/beta features to enable for namespace | [optional] [readonly] 
**UnpaidSubscription** | **bool** | A notice that the user has an unpaid subscription | [optional] [readonly] 
**DefaultS3Path** | **string** | default S3 path to store newly created notebooks | [optional] 
**DefaultS3PathCredentialsName** | **string** | Default S3 path credentials name is the credentials name to use along with default_s3_path | [optional] 
**DefaultNamespaceCharged** | **string** | Override the default namespace charged for actions when no namespace is specified | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

