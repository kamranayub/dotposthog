# DotPostHog.Model.PostHogFunnelStepsResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **int** | Number of people in this step. | 
**ActionId** | **string** | Corresponds to the &#x60;id&#x60; of the entities passed through to &#x60;events&#x60; or &#x60;actions&#x60;. | 
**AverageConversionTime** | **double** | Average conversion time of person or groups between steps. &#x60;null&#x60; for the first step. | 
**MedianConversionTime** | **double** | Median conversion time of person or groups between steps. &#x60;null&#x60; for the first step. | 
**ConvertedPeopleUrl** | **string** | Path of a URL to get a list of people that converted after this step. In this format: &#x60;/api/person/funnel?...&#x60; | 
**DroppedPeopleUrl** | **string** | Path of a URL to get a list of people that dropped after this step. In this format: &#x60;/api/person/funnel?...&#x60; | 
**Order** | **string** | Order of this step in the funnel. The API should return the steps in order anyway. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

