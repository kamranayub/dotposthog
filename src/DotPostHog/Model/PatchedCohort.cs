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
    /// PatchedCohort
    /// </summary>
    [DataContract(Name = "PatchedCohort")]
    public partial class PatchedCohort : IEquatable<PatchedCohort>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedCohort" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="groups">groups.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="filters">filters.</param>
        /// <param name="isStatic">isStatic.</param>
        public PatchedCohort(string name = default(string), string description = default(string), Dictionary<string, Object> groups = default(Dictionary<string, Object>), bool deleted = default(bool), Dictionary<string, Object> filters = default(Dictionary<string, Object>), bool isStatic = default(bool))
        {
            this.Name = name;
            this.Description = description;
            this.Groups = groups;
            this.Deleted = deleted;
            this.Filters = filters;
            this.IsStatic = isStatic;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; private set; }

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
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public Dictionary<string, Object> Groups { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = true)]
        public Dictionary<string, Object> Filters { get; set; }

        /// <summary>
        /// Gets or Sets IsCalculating
        /// </summary>
        [DataMember(Name = "is_calculating", EmitDefaultValue = true)]
        public bool IsCalculating { get; private set; }

        /// <summary>
        /// Returns false as IsCalculating should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsCalculating()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
        public UserBasic CreatedBy { get; private set; }

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
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastCalculation
        /// </summary>
        [DataMember(Name = "last_calculation", EmitDefaultValue = true)]
        public DateTime? LastCalculation { get; private set; }

        /// <summary>
        /// Returns false as LastCalculation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastCalculation()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ErrorsCalculating
        /// </summary>
        [DataMember(Name = "errors_calculating", EmitDefaultValue = false)]
        public int ErrorsCalculating { get; private set; }

        /// <summary>
        /// Returns false as ErrorsCalculating should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeErrorsCalculating()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = true)]
        public int? Count { get; private set; }

        /// <summary>
        /// Returns false as Count should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsStatic
        /// </summary>
        [DataMember(Name = "is_static", EmitDefaultValue = true)]
        public bool IsStatic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchedCohort {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  IsCalculating: ").Append(IsCalculating).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  LastCalculation: ").Append(LastCalculation).Append("\n");
            sb.Append("  ErrorsCalculating: ").Append(ErrorsCalculating).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  IsStatic: ").Append(IsStatic).Append("\n");
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
            return this.Equals(input as PatchedCohort);
        }

        /// <summary>
        /// Returns true if PatchedCohort instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchedCohort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchedCohort input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
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
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.IsCalculating == input.IsCalculating ||
                    this.IsCalculating.Equals(input.IsCalculating)
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
                    this.LastCalculation == input.LastCalculation ||
                    (this.LastCalculation != null &&
                    this.LastCalculation.Equals(input.LastCalculation))
                ) && 
                (
                    this.ErrorsCalculating == input.ErrorsCalculating ||
                    this.ErrorsCalculating.Equals(input.ErrorsCalculating)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.IsStatic == input.IsStatic ||
                    this.IsStatic.Equals(input.IsStatic)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                if (this.Filters != null)
                {
                    hashCode = (hashCode * 59) + this.Filters.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsCalculating.GetHashCode();
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.LastCalculation != null)
                {
                    hashCode = (hashCode * 59) + this.LastCalculation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ErrorsCalculating.GetHashCode();
                if (this.Count != null)
                {
                    hashCode = (hashCode * 59) + this.Count.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsStatic.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 400.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1000.", new [] { "Description" });
            }

            yield break;
        }
    }

}
