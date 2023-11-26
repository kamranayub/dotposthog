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
    [DataContract(Name = "Dashboard")]
    public partial class Dashboard : IEquatable<Dashboard>, IValidatableObject
    {
        /// <summary>
        /// Defines CreationMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreationModeEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,

            /// <summary>
            /// Enum Template for value: template
            /// </summary>
            [EnumMember(Value = "template")]
            Template = 2,

            /// <summary>
            /// Enum Duplicate for value: duplicate
            /// </summary>
            [EnumMember(Value = "duplicate")]
            Duplicate = 3
        }


        /// <summary>
        /// Gets or Sets CreationMode
        /// </summary>
        [DataMember(Name = "creation_mode", IsRequired = true, EmitDefaultValue = true)]
        public CreationModeEnum CreationMode { get; set; }

        /// <summary>
        /// Returns false as CreationMode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreationMode()
        {
            return false;
        }
        /// <summary>
        /// Defines RestrictionLevel
        /// </summary>
        public enum RestrictionLevelEnum
        {
            /// <summary>
            /// Enum NUMBER_21 for value: 21
            /// </summary>
            NUMBER_21 = 21,

            /// <summary>
            /// Enum NUMBER_37 for value: 37
            /// </summary>
            NUMBER_37 = 37
        }


        /// <summary>
        /// Gets or Sets RestrictionLevel
        /// </summary>
        [DataMember(Name = "restriction_level", EmitDefaultValue = false)]
        public RestrictionLevelEnum? RestrictionLevel { get; set; }
        /// <summary>
        /// Defines EffectiveRestrictionLevel
        /// </summary>
        public enum EffectiveRestrictionLevelEnum
        {
            /// <summary>
            /// Enum NUMBER_21 for value: 21
            /// </summary>
            NUMBER_21 = 21,

            /// <summary>
            /// Enum NUMBER_37 for value: 37
            /// </summary>
            NUMBER_37 = 37
        }


        /// <summary>
        /// Gets or Sets EffectiveRestrictionLevel
        /// </summary>
        [DataMember(Name = "effective_restriction_level", IsRequired = true, EmitDefaultValue = true)]
        public EffectiveRestrictionLevelEnum EffectiveRestrictionLevel { get; set; }

        /// <summary>
        /// Returns false as EffectiveRestrictionLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEffectiveRestrictionLevel()
        {
            return false;
        }
        /// <summary>
        /// Defines EffectivePrivilegeLevel
        /// </summary>
        public enum EffectivePrivilegeLevelEnum
        {
            /// <summary>
            /// Enum NUMBER_21 for value: 21
            /// </summary>
            NUMBER_21 = 21,

            /// <summary>
            /// Enum NUMBER_37 for value: 37
            /// </summary>
            NUMBER_37 = 37
        }


        /// <summary>
        /// Gets or Sets EffectivePrivilegeLevel
        /// </summary>
        [DataMember(Name = "effective_privilege_level", IsRequired = true, EmitDefaultValue = true)]
        public EffectivePrivilegeLevelEnum EffectivePrivilegeLevel { get; set; }

        /// <summary>
        /// Returns false as EffectivePrivilegeLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEffectivePrivilegeLevel()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dashboard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Dashboard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dashboard" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="pinned">pinned.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="useTemplate">useTemplate.</param>
        /// <param name="useDashboard">useDashboard.</param>
        /// <param name="deleteInsights">deleteInsights (default to false).</param>
        /// <param name="filters">filters.</param>
        /// <param name="tags">tags.</param>
        /// <param name="restrictionLevel">restrictionLevel.</param>
        public Dashboard(string name = default(string), string description = default(string), bool pinned = default(bool), bool deleted = default(bool), string useTemplate = default(string), int? useDashboard = default(int?), bool deleteInsights = false, Dictionary<string, Object> filters = default(Dictionary<string, Object>), List<Object> tags = default(List<Object>), RestrictionLevelEnum? restrictionLevel = default(RestrictionLevelEnum?))
        {
            this.Name = name;
            this.Description = description;
            this.Pinned = pinned;
            this.Deleted = deleted;
            this.UseTemplate = useTemplate;
            this.UseDashboard = useDashboard;
            this.DeleteInsights = deleteInsights;
            this.Filters = filters;
            this.Tags = tags;
            this.RestrictionLevel = restrictionLevel;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
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
        /// Gets or Sets Pinned
        /// </summary>
        [DataMember(Name = "pinned", EmitDefaultValue = true)]
        public bool Pinned { get; set; }

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
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", IsRequired = true, EmitDefaultValue = true)]
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
        /// Gets or Sets IsShared
        /// </summary>
        [DataMember(Name = "is_shared", IsRequired = true, EmitDefaultValue = true)]
        public bool IsShared { get; private set; }

        /// <summary>
        /// Returns false as IsShared should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsShared()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets UseTemplate
        /// </summary>
        [DataMember(Name = "use_template", EmitDefaultValue = false)]
        public string UseTemplate { get; set; }

        /// <summary>
        /// Gets or Sets UseDashboard
        /// </summary>
        [DataMember(Name = "use_dashboard", EmitDefaultValue = true)]
        public int? UseDashboard { get; set; }

        /// <summary>
        /// Gets or Sets DeleteInsights
        /// </summary>
        [DataMember(Name = "delete_insights", EmitDefaultValue = true)]
        public bool DeleteInsights { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        public Dictionary<string, Object> Filters { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<Object> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Tiles
        /// </summary>
        [DataMember(Name = "tiles", IsRequired = true, EmitDefaultValue = true)]
        public string Tiles { get; private set; }

        /// <summary>
        /// Returns false as Tiles should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTiles()
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
            sb.Append("class Dashboard {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  IsShared: ").Append(IsShared).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  CreationMode: ").Append(CreationMode).Append("\n");
            sb.Append("  UseTemplate: ").Append(UseTemplate).Append("\n");
            sb.Append("  UseDashboard: ").Append(UseDashboard).Append("\n");
            sb.Append("  DeleteInsights: ").Append(DeleteInsights).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Tiles: ").Append(Tiles).Append("\n");
            sb.Append("  RestrictionLevel: ").Append(RestrictionLevel).Append("\n");
            sb.Append("  EffectiveRestrictionLevel: ").Append(EffectiveRestrictionLevel).Append("\n");
            sb.Append("  EffectivePrivilegeLevel: ").Append(EffectivePrivilegeLevel).Append("\n");
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
            return this.Equals(input as Dashboard);
        }

        /// <summary>
        /// Returns true if Dashboard instances are equal
        /// </summary>
        /// <param name="input">Instance of Dashboard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dashboard input)
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
                    this.Pinned == input.Pinned ||
                    this.Pinned.Equals(input.Pinned)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.IsShared == input.IsShared ||
                    this.IsShared.Equals(input.IsShared)
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.CreationMode == input.CreationMode ||
                    this.CreationMode.Equals(input.CreationMode)
                ) && 
                (
                    this.UseTemplate == input.UseTemplate ||
                    (this.UseTemplate != null &&
                    this.UseTemplate.Equals(input.UseTemplate))
                ) && 
                (
                    this.UseDashboard == input.UseDashboard ||
                    (this.UseDashboard != null &&
                    this.UseDashboard.Equals(input.UseDashboard))
                ) && 
                (
                    this.DeleteInsights == input.DeleteInsights ||
                    this.DeleteInsights.Equals(input.DeleteInsights)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Tiles == input.Tiles ||
                    (this.Tiles != null &&
                    this.Tiles.Equals(input.Tiles))
                ) && 
                (
                    this.RestrictionLevel == input.RestrictionLevel ||
                    this.RestrictionLevel.Equals(input.RestrictionLevel)
                ) && 
                (
                    this.EffectiveRestrictionLevel == input.EffectiveRestrictionLevel ||
                    this.EffectiveRestrictionLevel.Equals(input.EffectiveRestrictionLevel)
                ) && 
                (
                    this.EffectivePrivilegeLevel == input.EffectivePrivilegeLevel ||
                    this.EffectivePrivilegeLevel.Equals(input.EffectivePrivilegeLevel)
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
                hashCode = (hashCode * 59) + this.Pinned.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsShared.GetHashCode();
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                hashCode = (hashCode * 59) + this.CreationMode.GetHashCode();
                if (this.UseTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.UseTemplate.GetHashCode();
                }
                if (this.UseDashboard != null)
                {
                    hashCode = (hashCode * 59) + this.UseDashboard.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeleteInsights.GetHashCode();
                if (this.Filters != null)
                {
                    hashCode = (hashCode * 59) + this.Filters.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Tiles != null)
                {
                    hashCode = (hashCode * 59) + this.Tiles.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RestrictionLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.EffectiveRestrictionLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.EffectivePrivilegeLevel.GetHashCode();
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

            yield break;
        }
    }

}
