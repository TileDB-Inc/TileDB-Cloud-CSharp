
# TileDB.Cloud.Rest.Model.Invitation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique id of invitation added to magic link | [optional] 
**InvitationType** | **InvitationType** |  | [optional] 
**OwnerNamespaceUuid** | **string** | Namespace of the owner of the invitation (user or organization) | [optional] 
**UserNamespaceUuid** | **string** | Unique id of the user accepted the invitation | [optional] 
**OrganizationUserUuid** | **string** | Unique id of the organization user accepted the invitation | [optional] 
**OrganizationName** | **string** | Name of the organization, does not persist in database | [optional] 
**OrganizationRole** | **OrganizationRoles** |  | [optional] 
**ArrayUuid** | **string** | Unique id of the array | [optional] 
**ArrayName** | **string** | Name of the array, does not persist in database | [optional] 
**Email** | **string** | Email of the individual we send the invitation to | [optional] 
**Actions** | **string** | A comma separated list of ArrayActions or NamespaceActions | [optional] 
**Status** | **InvitationStatus** |  | [optional] 
**CreatedAt** | **DateTime** | Datetime the invitation was created in UTC | [optional] 
**ExpiresAt** | **DateTime** | Datetime the invitation is expected to expire in UTC | [optional] 
**AcceptedAt** | **DateTime** | Datetime the invitation was accepted in UTC | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

