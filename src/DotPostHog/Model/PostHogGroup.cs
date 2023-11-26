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
    /// PostHogGroup
    /// </summary>
    [DataContract(Name = "Group")]
    public partial class PostHogGroup : IEquatable<PostHogGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostHogGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogGroup" /> class.
        /// </summary>
        /// <param name="groupTypeIndex">groupTypeIndex (required).</param>
        /// <param name="groupKey">groupKey (required).</param>
        /// <param name="groupProperties">groupProperties.</param>
        public PostHogGroup(int groupTypeIndex = default(int), string groupKey = default(string), Dictionary<string, Object> groupProperties = default(Dictionary<string, Object>))
        {
            this.GroupTypeIndex = groupTypeIndex;
            // to ensure "groupKey" is required (not null)
            if (groupKey == null)
            {
                throw new ArgumentNullException("groupKey is a required property for PostHogGroup and cannot be null");
            }
            this.GroupKey = groupKey;
            this.GroupProperties = groupProperties;
        }

        /// <summary>
        /// Gets or Sets GroupTypeIndex
        /// </summary>
        [DataMember(Name = "group_type_index", IsRequired = true, EmitDefaultValue = true)]
        public int GroupTypeIndex { get; set; }

        /// <summary>
        /// Gets or Sets GroupKey
        /// </summary>
        [DataMember(Name = "group_key", IsRequired = true, EmitDefaultValue = true)]
        public string GroupKey { get; set; }

        /// <summary>
        /// Gets or Sets GroupProperties
        /// </summary>
        [DataMember(Name = "group_properties", EmitDefaultValue = false)]
        public Dictionary<string, Object> GroupProperties { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogGroup {\n");
            sb.Append("  GroupTypeIndex: ").Append(GroupTypeIndex).Append("\n");
            sb.Append("  GroupKey: ").Append(GroupKey).Append("\n");
            sb.Append("  GroupProperties: ").Append(GroupProperties).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as PostHogGroup);
        }

        /// <summary>
        /// Returns true if PostHogGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupTypeIndex == input.GroupTypeIndex ||
                    this.GroupTypeIndex.Equals(input.GroupTypeIndex)
                ) && 
                (
                    this.GroupKey == input.GroupKey ||
                    (this.GroupKey != null &&
                    this.GroupKey.Equals(input.GroupKey))
                ) && 
                (
                    this.GroupProperties == input.GroupProperties ||
                    this.GroupProperties != null &&
                    input.GroupProperties != null &&
                    this.GroupProperties.SequenceEqual(input.GroupProperties)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                hashCode = (hashCode * 59) + this.GroupTypeIndex.GetHashCode();
                if (this.GroupKey != null)
                {
                    hashCode = (hashCode * 59) + this.GroupKey.GetHashCode();
                }
                if (this.GroupProperties != null)
                {
                    hashCode = (hashCode * 59) + this.GroupProperties.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
            // GroupTypeIndex (int) maximum
            if (this.GroupTypeIndex > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupTypeIndex, must be a value less than or equal to 2147483647.", new [] { "GroupTypeIndex" });
            }

            // GroupTypeIndex (int) minimum
            if (this.GroupTypeIndex < (int)-2147483648)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupTypeIndex, must be a value greater than or equal to -2147483648.", new [] { "GroupTypeIndex" });
            }

            // GroupKey (string) maxLength
            if (this.GroupKey != null && this.GroupKey.Length > 400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupKey, length must be less than 400.", new [] { "GroupKey" });
            }

            yield break;
        }
    }

}
