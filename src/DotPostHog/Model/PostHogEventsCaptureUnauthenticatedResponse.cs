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

namespace DotPostHog.Model
{
    /// <summary>
    /// PostHogEventsCaptureUnauthenticatedResponse
    /// </summary>
    [DataContract(Name = "EventsCaptureUnauthenticatedResponse")]
    public partial class PostHogEventsCaptureUnauthenticatedResponse : IEquatable<PostHogEventsCaptureUnauthenticatedResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AuthenticationError for value: authentication_error
            /// </summary>
            [EnumMember(Value = "authentication_error")]
            AuthenticationError = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogEventsCaptureUnauthenticatedResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostHogEventsCaptureUnauthenticatedResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogEventsCaptureUnauthenticatedResponse" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="code">code (required).</param>
        /// <param name="detail">detail (required).</param>
        public PostHogEventsCaptureUnauthenticatedResponse(TypeEnum type = default(TypeEnum), string code = default(string), string detail = default(string))
        {
            this.Type = type;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for PostHogEventsCaptureUnauthenticatedResponse and cannot be null");
            }
            this.Code = code;
            // to ensure "detail" is required (not null)
            if (detail == null)
            {
                throw new ArgumentNullException("detail is a required property for PostHogEventsCaptureUnauthenticatedResponse and cannot be null");
            }
            this.Detail = detail;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        /// <example>invalid_token</example>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        /// <example>Invalid API key</example>
        [DataMember(Name = "detail", IsRequired = true, EmitDefaultValue = true)]
        public string Detail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogEventsCaptureUnauthenticatedResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostHogEventsCaptureUnauthenticatedResponse);
        }

        /// <summary>
        /// Returns true if PostHogEventsCaptureUnauthenticatedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogEventsCaptureUnauthenticatedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogEventsCaptureUnauthenticatedResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                );
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Detail != null)
                {
                    hashCode = (hashCode * 59) + this.Detail.GetHashCode();
                }
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

}
