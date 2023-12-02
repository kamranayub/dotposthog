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
    /// PostHogPaginatedOrganizationDomainList
    /// </summary>
    [DataContract(Name = "PaginatedOrganizationDomainList")]
    public partial class PostHogPaginatedOrganizationDomainList : IEquatable<PostHogPaginatedOrganizationDomainList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostHogPaginatedOrganizationDomainList" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="next">next.</param>
        /// <param name="previous">previous.</param>
        /// <param name="results">results.</param>
        public PostHogPaginatedOrganizationDomainList(int count = default(int), string next = default(string), string previous = default(string), List<PostHogOrganizationDomain> results = default(List<PostHogOrganizationDomain>))
        {
            this.Count = count;
            this.Next = next;
            this.Previous = previous;
            this.Results = results;
        }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        /// <example>123</example>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        /// <example>http://api.example.org/accounts/?offset&#x3D;400&amp;limit&#x3D;100</example>
        [DataMember(Name = "next", EmitDefaultValue = true)]
        public string Next { get; set; }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        /// <example>http://api.example.org/accounts/?offset&#x3D;200&amp;limit&#x3D;100</example>
        [DataMember(Name = "previous", EmitDefaultValue = true)]
        public string Previous { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<PostHogOrganizationDomain> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostHogPaginatedOrganizationDomainList {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as PostHogPaginatedOrganizationDomainList);
        }

        /// <summary>
        /// Returns true if PostHogPaginatedOrganizationDomainList instances are equal
        /// </summary>
        /// <param name="input">Instance of PostHogPaginatedOrganizationDomainList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostHogPaginatedOrganizationDomainList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Previous == input.Previous ||
                    (this.Previous != null &&
                    this.Previous.Equals(input.Previous))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Next != null)
                {
                    hashCode = (hashCode * 59) + this.Next.GetHashCode();
                }
                if (this.Previous != null)
                {
                    hashCode = (hashCode * 59) + this.Previous.GetHashCode();
                }
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
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