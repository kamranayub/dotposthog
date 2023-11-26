# DotPostHog.Model.PropertyItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Key of the property you&#39;re filtering on. For example &#x60;email&#x60; or &#x60;$current_url&#x60; | 
**Value** | **string** | Value of your filter. For example &#x60;test@example.com&#x60; or &#x60;https://example.com/test/&#x60;. Can be an array for an OR query, like &#x60;[\&quot;test@example.com\&quot;,\&quot;ok@example.com\&quot;]&#x60; | 
**VarOperator** | **string** |  | [optional] [default to OperatorEnum.Exact]
**Type** | **string** |  | [optional] [default to TypeEnum.Event]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

