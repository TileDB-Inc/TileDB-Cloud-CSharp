
# TileDB.Cloud.Rest.Model.ArrayTask

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | task id | [optional] 
**Name** | **string** | Optional task name | [optional] 
**Description** | **string** | Optional task description (Tasks purpose) | [optional] 
**ArrayMetadata** | [**ArrayInfo**](ArrayInfo.md) |  | [optional] 
**Subarray** | [**DomainArray**](DomainArray.md) |  | [optional] 
**Memory** | **int** | memory allocated to task in bytes | [optional] 
**Cpu** | **int** | millicpu allocated to task | [optional] 
**Namespace** | **string** | namespace task is tied to | [optional] 
**Status** | **ArrayTaskStatus** |  | [optional] 
**StartTime** | **DateTime** | Start time RFC3339 for job | [optional] 
**FinishTime** | **DateTime** | Finish time RFC3339 for job | [optional] 
**Cost** | **double** | Total accumulated for task in USD, example is $0.12 | [optional] 
**EgressCost** | **double** | Total accumulated for egress task in USD, example is $0.12 | [optional] 
**AccessCost** | **double** | Cost accumulated for access task in USD, example is $0.12 | [optional] 
**QueryType** | **Querytype** |  | [optional] 
**UdfCode** | **string** | Optional actual code that is going to be executed | [optional] 
**UdfLanguage** | **string** | Optional actual language used to express udf_code | [optional] 
**SqlQuery** | **string** | Optional actual sql query that is going to be executed | [optional] 
**Type** | **ArrayTaskType** |  | [optional] 
**Activity** | [**List&lt;ArrayActivityLog&gt;**](ArrayActivityLog.md) | Array activity logs for task | [optional] 
**Logs** | **string** | logs from array task | [optional] 
**Duration** | **decimal** | duration in nanoseconds of an array task | [optional] 
**SqlInitCommands** | **List&lt;string&gt;** | SQL queries or commands to run before main sql query | [optional] 
**SqlParameters** | **List&lt;Object&gt;** | SQL query parameters | [optional] 
**ResultFormat** | **ResultFormat** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

