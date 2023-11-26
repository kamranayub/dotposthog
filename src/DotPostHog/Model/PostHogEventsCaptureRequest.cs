/*
 * PostHog API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = DotPostHog.Client.OpenAPIDateConverter;
using System.Reflection;

namespace DotPostHog.Model
{
    /// <summary>
    /// PostHogEventsCaptureRequest
    /// </summary>
    [JsonConverter(typeof(PostHogEventsCaptureRequestJsonConverter))]
    [DataContract(Name = "EventsCaptureRequest")]
    public partial class PostHogEventsCaptureRequest : AbstractOpenAPISchema, IEquatable<PostHogEventsCaptureRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogEventsCaptureRequest" /> class
        /// with the <see cref="PostHogEventsCaptureRequestAnyOf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PostHogEventsCaptureRequestAnyOf.</param>
        public PostHogEventsCaptureRequest(PostHogEventsCaptureRequestAnyOf actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogEventsCaptureRequest" /> class
        /// with the <see cref="PostHogEventsCaptureRequestAnyOf1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PostHogEventsCaptureRequestAnyOf1.</param>
        public PostHogEventsCaptureRequest(PostHogEventsCaptureRequestAnyOf1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogEventsCaptureRequest" /> class
        /// with the <see cref="List{PostHogEvent}" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of List&lt;PostHogEvent&gt;.</param>
        public PostHogEventsCaptureRequest(List<PostHogEvent> actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(List<PostHogEvent>))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PostHogEventsCaptureRequestAnyOf))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PostHogEventsCaptureRequestAnyOf1))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: List<PostHogEvent>, PostHogEventsCaptureRequestAnyOf, PostHogEventsCaptureRequestAnyOf1");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `PostHogEventsCaptureRequestAnyOf`. If the actual instance is not `PostHogEventsCaptureRequestAnyOf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PostHogEventsCaptureRequestAnyOf</returns>
        public PostHogEventsCaptureRequestAnyOf GetPostHogEventsCaptureRequestAnyOf()
        {
            return (PostHogEventsCaptureRequestAnyOf)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PostHogEventsCaptureRequestAnyOf1`. If the actual instance is not `PostHogEventsCaptureRequestAnyOf1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PostHogEventsCaptureRequestAnyOf1</returns>
        public PostHogEventsCaptureRequestAnyOf1 GetPostHogEventsCaptureRequestAnyOf1()
        {
            return (PostHogEventsCaptureRequestAnyOf1)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `List&lt;PostHogEvent&gt;`. If the actual instance is not `List&lt;PostHogEvent&gt;`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of List&lt;PostHogEvent&gt;</returns>
        public List<PostHogEvent> GetList()
        {
            return (List<PostHogEvent>)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostHogEventsCaptureRequest {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, PostHogEventsCaptureRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PostHogEventsCaptureRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PostHogEventsCaptureRequest</returns>
        public static PostHogEventsCaptureRequest FromJson(string jsonString)
        {
            PostHogEventsCaptureRequest newPostHogEventsCaptureRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPostHogEventsCaptureRequest;
            }

            try
            {
                newPostHogEventsCaptureRequest = new PostHogEventsCaptureRequest(JsonConvert.DeserializeObject<List<PostHogEvent>>(jsonString, PostHogEventsCaptureRequest.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newPostHogEventsCaptureRequest;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<PostHogEvent>: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newPostHogEventsCaptureRequest = new PostHogEventsCaptureRequest(JsonConvert.DeserializeObject<PostHogEventsCaptureRequestAnyOf>(jsonString, PostHogEventsCaptureRequest.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newPostHogEventsCaptureRequest;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PostHogEventsCaptureRequestAnyOf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newPostHogEventsCaptureRequest = new PostHogEventsCaptureRequest(JsonConvert.DeserializeObject<PostHogEventsCaptureRequestAnyOf1>(jsonString, PostHogEventsCaptureRequest.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newPostHogEventsCaptureRequest;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PostHogEventsCaptureRequestAnyOf1: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostHogEventsCaptureRequest);
        }

        /// <summary>
        /// Returns true if PostHogEventsCaptureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogEventsCaptureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogEventsCaptureRequest input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for PostHogEventsCaptureRequest
    /// </summary>
    public class PostHogEventsCaptureRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PostHogEventsCaptureRequest).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return PostHogEventsCaptureRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
