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
    /// Serializer mixin that resolves appropriate response for tags depending on license.
    /// </summary>
    [DataContract(Name = "EnterprisePropertyDefinition")]
    public partial class PostHogEnterprisePropertyDefinition : IEquatable<PostHogEnterprisePropertyDefinition>, IValidatableObject
    {
        /// <summary>
        /// Defines PropertyType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PropertyTypeEnum
        {
            /// <summary>
            /// Enum DateTime for value: DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 1,

            /// <summary>
            /// Enum String for value: String
            /// </summary>
            [EnumMember(Value = "String")]
            String = 2,

            /// <summary>
            /// Enum Numeric for value: Numeric
            /// </summary>
            [EnumMember(Value = "Numeric")]
            Numeric = 3,

            /// <summary>
            /// Enum Boolean for value: Boolean
            /// </summary>
            [EnumMember(Value = "Boolean")]
            Boolean = 4,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 5,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 6
        }


        /// <summary>
        /// Gets or Sets PropertyType
        /// </summary>
        [DataMember(Name = "property_type", EmitDefaultValue = true)]
        public PropertyTypeEnum? PropertyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogEnterprisePropertyDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostHogEnterprisePropertyDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogEnterprisePropertyDefinition" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="tags">tags.</param>
        /// <param name="propertyType">propertyType.</param>
        /// <param name="verified">verified.</param>
        public PostHogEnterprisePropertyDefinition(string description = default(string), List<Object> tags = default(List<Object>), PropertyTypeEnum? propertyType = default(PropertyTypeEnum?), bool verified = default(bool))
        {
            this.Description = description;
            this.Tags = tags;
            this.PropertyType = propertyType;
            this.Verified = verified;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<Object> Tags { get; set; }

        /// <summary>
        /// Gets or Sets IsNumerical
        /// </summary>
        [DataMember(Name = "is_numerical", IsRequired = true, EmitDefaultValue = true)]
        public bool IsNumerical { get; private set; }

        /// <summary>
        /// Returns false as IsNumerical should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsNumerical()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updated_by", IsRequired = true, EmitDefaultValue = true)]
        public PostHogUserBasic UpdatedBy { get; private set; }

        /// <summary>
        /// Returns false as UpdatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsSeenOnFilteredEvents
        /// </summary>
        [DataMember(Name = "is_seen_on_filtered_events", IsRequired = true, EmitDefaultValue = true)]
        public string IsSeenOnFilteredEvents { get; private set; }

        /// <summary>
        /// Returns false as IsSeenOnFilteredEvents should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsSeenOnFilteredEvents()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name = "verified", EmitDefaultValue = true)]
        public bool Verified { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedAt
        /// </summary>
        [DataMember(Name = "verified_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? VerifiedAt { get; private set; }

        /// <summary>
        /// Returns false as VerifiedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerifiedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets VerifiedBy
        /// </summary>
        [DataMember(Name = "verified_by", IsRequired = true, EmitDefaultValue = true)]
        public PostHogUserBasic VerifiedBy { get; private set; }

        /// <summary>
        /// Returns false as VerifiedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerifiedBy()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogEnterprisePropertyDefinition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  IsNumerical: ").Append(IsNumerical).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  IsSeenOnFilteredEvents: ").Append(IsSeenOnFilteredEvents).Append("\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  VerifiedAt: ").Append(VerifiedAt).Append("\n");
            sb.Append("  VerifiedBy: ").Append(VerifiedBy).Append("\n");
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
            return this.Equals(input as PostHogEnterprisePropertyDefinition);
        }

        /// <summary>
        /// Returns true if PostHogEnterprisePropertyDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogEnterprisePropertyDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogEnterprisePropertyDefinition input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.IsNumerical == input.IsNumerical ||
                    this.IsNumerical.Equals(input.IsNumerical)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.IsSeenOnFilteredEvents == input.IsSeenOnFilteredEvents ||
                    (this.IsSeenOnFilteredEvents != null &&
                    this.IsSeenOnFilteredEvents.Equals(input.IsSeenOnFilteredEvents))
                ) && 
                (
                    this.PropertyType == input.PropertyType ||
                    this.PropertyType.Equals(input.PropertyType)
                ) && 
                (
                    this.Verified == input.Verified ||
                    this.Verified.Equals(input.Verified)
                ) && 
                (
                    this.VerifiedAt == input.VerifiedAt ||
                    (this.VerifiedAt != null &&
                    this.VerifiedAt.Equals(input.VerifiedAt))
                ) && 
                (
                    this.VerifiedBy == input.VerifiedBy ||
                    (this.VerifiedBy != null &&
                    this.VerifiedBy.Equals(input.VerifiedBy))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsNumerical.GetHashCode();
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
                }
                if (this.IsSeenOnFilteredEvents != null)
                {
                    hashCode = (hashCode * 59) + this.IsSeenOnFilteredEvents.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PropertyType.GetHashCode();
                hashCode = (hashCode * 59) + this.Verified.GetHashCode();
                if (this.VerifiedAt != null)
                {
                    hashCode = (hashCode * 59) + this.VerifiedAt.GetHashCode();
                }
                if (this.VerifiedBy != null)
                {
                    hashCode = (hashCode * 59) + this.VerifiedBy.GetHashCode();
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
