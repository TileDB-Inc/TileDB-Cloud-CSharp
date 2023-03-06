# TileDB.Cloud.Rest.Model.Pricing
Pricing created by converting an array to product

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID of plan as defined by Stripe | [optional] 
**ArrayUuid** | **string** | Unique ID of registered array | [optional] 
**PricingName** | **string** | Name of pricing | [optional] 
**PricingType** | **PricingType** |  | [optional] 
**ProductName** | **string** | Name of product | [optional] 
**ProductStatementDescriptor** | **string** | Extra information about a product which will appear on the credit card statement of the customer | [optional] 
**ProductUnitLabel** | **PricingUnitLabel** |  | [optional] 
**Currency** | **PricingCurrency** |  | [optional] 
**AggregateUsage** | **PricingAggregateUsage** |  | [optional] 
**Interval** | **PricingInterval** |  | [optional] 
**DividedBy** | **long** | Group of n product unit labels | [optional] 
**Charge** | **double** | Price in cents (decimal) per unitlabel | [optional] 
**Activated** | **bool** | If pricing is activated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

