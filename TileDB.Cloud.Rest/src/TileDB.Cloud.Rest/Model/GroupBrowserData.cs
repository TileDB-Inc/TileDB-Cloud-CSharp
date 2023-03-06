/*
 * TileDB Storage Platform API
 *
 * TileDB Storage Platform REST API
 *
 * The version of the OpenAPI document: 2.2.19
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
using OpenAPIDateConverter = TileDB.Cloud.Rest.Client.OpenAPIDateConverter;

namespace TileDB.Cloud.Rest.Model
{
    /// <summary>
    /// Object including group info and pagination metadata
    /// </summary>
    [DataContract(Name = "GroupBrowserData")]
    public partial class GroupBrowserData : IEquatable<GroupBrowserData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupBrowserData" /> class.
        /// </summary>
        /// <param name="groups">Groups Info.</param>
        /// <param name="paginationMetadata">paginationMetadata.</param>
        public GroupBrowserData(List<GroupInfo> groups = default(List<GroupInfo>), PaginationMetadata paginationMetadata = default(PaginationMetadata))
        {
            this.Groups = groups;
            this.PaginationMetadata = paginationMetadata;
        }

        /// <summary>
        /// Groups Info
        /// </summary>
        /// <value>Groups Info</value>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public List<GroupInfo> Groups { get; set; }

        /// <summary>
        /// Gets or Sets PaginationMetadata
        /// </summary>
        [DataMember(Name = "pagination_metadata", EmitDefaultValue = false)]
        public PaginationMetadata PaginationMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupBrowserData {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  PaginationMetadata: ").Append(PaginationMetadata).Append("\n");
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
            return this.Equals(input as GroupBrowserData);
        }

        /// <summary>
        /// Returns true if GroupBrowserData instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupBrowserData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupBrowserData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.PaginationMetadata == input.PaginationMetadata ||
                    (this.PaginationMetadata != null &&
                    this.PaginationMetadata.Equals(input.PaginationMetadata))
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
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                if (this.PaginationMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.PaginationMetadata.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
