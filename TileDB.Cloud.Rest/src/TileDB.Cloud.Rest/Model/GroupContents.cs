/*
 * TileDB Storage Platform API
 *
 * TileDB Storage Platform REST API
 *
 * The version of the OpenAPI document: 2.2.19
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TileDB.Cloud.Rest.Client.OpenAPIDateConverter;

namespace TileDB.Cloud.Rest.Model
{
    /// <summary>
    /// Object including a page of members of a group and pagination metadata
    /// </summary>
    [DataContract]
    public partial class GroupContents :  IEquatable<GroupContents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupContents" /> class.
        /// </summary>
        /// <param name="entries">Groups members.</param>
        /// <param name="paginationMetadata">paginationMetadata.</param>
        public GroupContents(List<GroupEntry> entries = default(List<GroupEntry>), PaginationMetadata paginationMetadata = default(PaginationMetadata))
        {
            this.Entries = entries;
            this.PaginationMetadata = paginationMetadata;
        }

        /// <summary>
        /// Groups members
        /// </summary>
        /// <value>Groups members</value>
        [DataMember(Name="entries", EmitDefaultValue=false)]
        public List<GroupEntry> Entries { get; set; }

        /// <summary>
        /// Gets or Sets PaginationMetadata
        /// </summary>
        [DataMember(Name="pagination_metadata", EmitDefaultValue=false)]
        public PaginationMetadata PaginationMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupContents {\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
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
            return this.Equals(input as GroupContents);
        }

        /// <summary>
        /// Returns true if GroupContents instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupContents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupContents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entries == input.Entries ||
                    this.Entries != null &&
                    input.Entries != null &&
                    this.Entries.SequenceEqual(input.Entries)
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
                if (this.Entries != null)
                    hashCode = hashCode * 59 + this.Entries.GetHashCode();
                if (this.PaginationMetadata != null)
                    hashCode = hashCode * 59 + this.PaginationMetadata.GetHashCode();
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
