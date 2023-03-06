# TileDB.Cloud.Rest.Model.UDFInfoUpdate
User-defined function that can persist in db, used and shared multiple times

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | name of UDF | [optional] 
**Language** | **UDFLanguage** |  | [optional] 
**_Version** | **string** | Type-specific version | [optional] 
**ImageName** | **string** | Docker image name to use for UDF | [optional] 
**Type** | **UDFType** |  | [optional] 
**Exec** | **string** | Type-specific executable text | [optional] 
**ExecRaw** | **string** | optional raw text to store of serialized function, used for showing in UI | [optional] 
**Readme** | **string** | Markdown readme of UDFs | [optional] 
**LicenseId** | **string** | License identifier from SPDX License List or Custom | [optional] 
**LicenseText** | **string** | License text | [optional] 
**Tags** | **List&lt;string&gt;** | optional tags for UDF | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

