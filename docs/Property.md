# DotPostHog.Model.Property

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |   You can use a simplified version: &#x60;&#x60;&#x60;json {     \&quot;properties\&quot;: [         {             \&quot;key\&quot;: \&quot;email\&quot;,             \&quot;value\&quot;: \&quot;x@y.com\&quot;,             \&quot;operator\&quot;: \&quot;exact\&quot;,             \&quot;type\&quot;: \&quot;event\&quot;         }     ] } &#x60;&#x60;&#x60;  Or you can create more complicated queries with AND and OR: &#x60;&#x60;&#x60;json {     \&quot;properties\&quot;: {         \&quot;type\&quot;: \&quot;AND\&quot;,         \&quot;values\&quot;: [             {                 \&quot;type\&quot;: \&quot;OR\&quot;,                 \&quot;values\&quot;: [                     {\&quot;key\&quot;: \&quot;email\&quot;, ...},                     {\&quot;key\&quot;: \&quot;email\&quot;, ...}                 ]             },             {                 \&quot;type\&quot;: \&quot;AND\&quot;,                 \&quot;values\&quot;: [                     {\&quot;key\&quot;: \&quot;email\&quot;, ...},                     {\&quot;key\&quot;: \&quot;email\&quot;, ...}                 ]             }         ]     ] } &#x60;&#x60;&#x60;  | [optional] [default to TypeEnum.AND]
**Values** | [**List&lt;PropertyItem&gt;**](PropertyItem.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

