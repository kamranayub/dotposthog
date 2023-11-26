# DotPostHog.Model.PostHogGenericInsights

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Events** | [**List&lt;PostHogFilterEvent&gt;**](PostHogFilterEvent.md) | Events to filter on. One of &#x60;events&#x60; or &#x60;actions&#x60; is required. | [optional] 
**Actions** | [**List&lt;PostHogFilterAction&gt;**](PostHogFilterAction.md) | Actions to filter on. One of &#x60;events&#x60; or &#x60;actions&#x60; is required. | [optional] 
**Properties** | [**PostHogProperty**](PostHogProperty.md) |  | [optional] 
**FilterTestAccounts** | **bool** | Whether to filter out internal and test accounts. See \&quot;project settings\&quot; in your PostHog account for the filters. | [optional] [default to false]
**DateFrom** | **string** | What date to filter the results from. Can either be a date &#x60;2021-01-01&#x60;, or a relative date, like &#x60;-7d&#x60; for last seven days, &#x60;-1m&#x60; for last month, &#x60;mStart&#x60; for start of the month or &#x60;yStart&#x60; for the start of the year. | [optional] [default to "-7d"]
**DateTo** | **string** | What date to filter the results to. Can either be a date &#x60;2021-01-01&#x60;, or a relative date, like &#x60;-7d&#x60; for last seven days, &#x60;-1m&#x60; for last month, &#x60;mStart&#x60; for start of the month or &#x60;yStart&#x60; for the start of the year. | [optional] [default to "-7d"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

