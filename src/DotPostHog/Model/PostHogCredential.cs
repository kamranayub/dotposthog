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
    /// PostHogCredential
    /// </summary>
    [DataContract(Name = "Credential")]
    public partial class PostHogCredential : IEquatable<PostHogCredential>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogCredential" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostHogCredential() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogCredential" /> class.
        /// </summary>
        /// <param name="accessKey">accessKey (required).</param>
        /// <param name="accessSecret">accessSecret (required).</param>
        public PostHogCredential(string accessKey = default(string), string accessSecret = default(string))
        {
            // to ensure "accessKey" is required (not null)
            if (accessKey == null)
            {
                throw new ArgumentNullException("accessKey is a required property for PostHogCredential and cannot be null");
            }
            this.AccessKey = accessKey;
            // to ensure "accessSecret" is required (not null)
            if (accessSecret == null)
            {
                throw new ArgumentNullException("accessSecret is a required property for PostHogCredential and cannot be null");
            }
            this.AccessSecret = accessSecret;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", IsRequired = true, EmitDefaultValue = true)]
        public PostHogUserBasic CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets AccessKey
        /// </summary>
        [DataMember(Name = "access_key", IsRequired = true, EmitDefaultValue = true)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets AccessSecret
        /// </summary>
        [DataMember(Name = "access_secret", IsRequired = true, EmitDefaultValue = true)]
        public string AccessSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogCredential {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  AccessSecret: ").Append(AccessSecret).Append("\n");
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
            return this.Equals(input as PostHogCredential);
        }

        /// <summary>
        /// Returns true if PostHogCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogCredential input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                ) && 
                (
                    this.AccessSecret == input.AccessSecret ||
                    (this.AccessSecret != null &&
                    this.AccessSecret.Equals(input.AccessSecret))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.AccessKey != null)
                {
                    hashCode = (hashCode * 59) + this.AccessKey.GetHashCode();
                }
                if (this.AccessSecret != null)
                {
                    hashCode = (hashCode * 59) + this.AccessSecret.GetHashCode();
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
            // AccessKey (string) maxLength
            if (this.AccessKey != null && this.AccessKey.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccessKey, length must be less than 500.", new [] { "AccessKey" });
            }

            // AccessSecret (string) maxLength
            if (this.AccessSecret != null && this.AccessSecret.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccessSecret, length must be less than 500.", new [] { "AccessSecret" });
            }

            yield break;
        }
    }

}
