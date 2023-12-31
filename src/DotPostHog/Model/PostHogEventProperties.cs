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
    /// PostHogEventProperties
    /// </summary>
    [DataContract(Name = "Event_properties")]
    public partial class PostHogEventProperties : Dictionary<String, Object>, IEquatable<PostHogEventProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogEventProperties" /> class.
        /// </summary>
        /// <param name="sysSet">Set person property to a given values. If the property does not  exist, it will be set. If the property already exists, it will be updated to the new value. The type of the property will be inferred from the value. .</param>
        /// <param name="sysSetOnce">Set person property to a given value, but only if it is not currently set. It will not override existing values. The type of the property will be inferred from the value. .</param>
        public PostHogEventProperties(Dictionary<string, Object> sysSet = default(Dictionary<string, Object>), Object sysSetOnce = default(Object)) : base()
        {
            this.SysSet = sysSet;
            this.SysSetOnce = sysSetOnce;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Set person property to a given values. If the property does not  exist, it will be set. If the property already exists, it will be updated to the new value. The type of the property will be inferred from the value. 
        /// </summary>
        /// <value>Set person property to a given values. If the property does not  exist, it will be set. If the property already exists, it will be updated to the new value. The type of the property will be inferred from the value. </value>
        /// <example>{&quot;$set&quot;:{&quot;country&quot;:&quot;UK&quot;,&quot;city&quot;:&quot;Cambridge&quot;}}</example>
        [DataMember(Name = "$set", EmitDefaultValue = false)]
        public Dictionary<string, Object> SysSet { get; set; }

        /// <summary>
        /// Set person property to a given value, but only if it is not currently set. It will not override existing values. The type of the property will be inferred from the value. 
        /// </summary>
        /// <value>Set person property to a given value, but only if it is not currently set. It will not override existing values. The type of the property will be inferred from the value. </value>
        /// <example>{&quot;$set_once&quot;:{&quot;initial_referrer&quot;:&quot;https://google.com&quot;}}</example>
        [DataMember(Name = "$set_once", EmitDefaultValue = false)]
        public Object SysSetOnce { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogEventProperties {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  SysSet: ").Append(SysSet).Append("\n");
            sb.Append("  SysSetOnce: ").Append(SysSetOnce).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as PostHogEventProperties);
        }

        /// <summary>
        /// Returns true if PostHogEventProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogEventProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogEventProperties input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.SysSet == input.SysSet ||
                    this.SysSet != null &&
                    input.SysSet != null &&
                    this.SysSet.SequenceEqual(input.SysSet)
                ) && base.Equals(input) && 
                (
                    this.SysSetOnce == input.SysSetOnce ||
                    (this.SysSetOnce != null &&
                    this.SysSetOnce.Equals(input.SysSetOnce))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.SysSet != null)
                {
                    hashCode = (hashCode * 59) + this.SysSet.GetHashCode();
                }
                if (this.SysSetOnce != null)
                {
                    hashCode = (hashCode * 59) + this.SysSetOnce.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
