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
    /// PostHogDataWarehouseSavedQueryColumnsInner
    /// </summary>
    [DataContract(Name = "DataWarehouseSavedQuery_columns_inner")]
    public partial class PostHogDataWarehouseSavedQueryColumnsInner : IEquatable<PostHogDataWarehouseSavedQueryColumnsInner>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Integer for value: integer
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer = 1,

            /// <summary>
            /// Enum Float for value: float
            /// </summary>
            [EnumMember(Value = "float")]
            Float = 2,

            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 3,

            /// <summary>
            /// Enum Datetime for value: datetime
            /// </summary>
            [EnumMember(Value = "datetime")]
            Datetime = 4,

            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            [EnumMember(Value = "date")]
            Date = 5,

            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 6,

            /// <summary>
            /// Enum Array for value: array
            /// </summary>
            [EnumMember(Value = "array")]
            Array = 7,

            /// <summary>
            /// Enum Json for value: json
            /// </summary>
            [EnumMember(Value = "json")]
            Json = 8,

            /// <summary>
            /// Enum LazyTable for value: lazy_table
            /// </summary>
            [EnumMember(Value = "lazy_table")]
            LazyTable = 9,

            /// <summary>
            /// Enum VirtualTable for value: virtual_table
            /// </summary>
            [EnumMember(Value = "virtual_table")]
            VirtualTable = 10,

            /// <summary>
            /// Enum FieldTraverser for value: field_traverser
            /// </summary>
            [EnumMember(Value = "field_traverser")]
            FieldTraverser = 11
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogDataWarehouseSavedQueryColumnsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostHogDataWarehouseSavedQueryColumnsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogDataWarehouseSavedQueryColumnsInner" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="fields">fields.</param>
        /// <param name="table">table.</param>
        /// <param name="chain">chain.</param>
        public PostHogDataWarehouseSavedQueryColumnsInner(string key = default(string), TypeEnum type = default(TypeEnum), List<string> fields = default(List<string>), string table = default(string), List<string> chain = default(List<string>))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for PostHogDataWarehouseSavedQueryColumnsInner and cannot be null");
            }
            this.Key = key;
            this.Type = type;
            this.Fields = fields;
            this.Table = table;
            this.Chain = chain;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Table
        /// </summary>
        [DataMember(Name = "table", EmitDefaultValue = false)]
        public string Table { get; set; }

        /// <summary>
        /// Gets or Sets Chain
        /// </summary>
        [DataMember(Name = "chain", EmitDefaultValue = false)]
        public List<string> Chain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogDataWarehouseSavedQueryColumnsInner {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
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
            return this.Equals(input as PostHogDataWarehouseSavedQueryColumnsInner);
        }

        /// <summary>
        /// Returns true if PostHogDataWarehouseSavedQueryColumnsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogDataWarehouseSavedQueryColumnsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogDataWarehouseSavedQueryColumnsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Table == input.Table ||
                    (this.Table != null &&
                    this.Table.Equals(input.Table))
                ) && 
                (
                    this.Chain == input.Chain ||
                    this.Chain != null &&
                    input.Chain != null &&
                    this.Chain.SequenceEqual(input.Chain)
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                if (this.Table != null)
                {
                    hashCode = (hashCode * 59) + this.Table.GetHashCode();
                }
                if (this.Chain != null)
                {
                    hashCode = (hashCode * 59) + this.Chain.GetHashCode();
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
