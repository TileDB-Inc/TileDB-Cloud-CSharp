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
    /// PaginationMetadata
    /// </summary>
    [DataContract]
    public partial class PaginationMetadata :  IEquatable<PaginationMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationMetadata" /> class.
        /// </summary>
        /// <param name="page">pagination offset. Use it to skip the first ((page - 1) * per_page) items.</param>
        /// <param name="perPage">pagination limit (page size).</param>
        /// <param name="totalPages">number of total pages with current limit.</param>
        /// <param name="totalItems">number of total available items.</param>
        public PaginationMetadata(decimal page = default(decimal), decimal perPage = default(decimal), decimal totalPages = default(decimal), decimal totalItems = default(decimal))
        {
            this.Page = page;
            this.PerPage = perPage;
            this.TotalPages = totalPages;
            this.TotalItems = totalItems;
        }

        /// <summary>
        /// pagination offset. Use it to skip the first ((page - 1) * per_page) items
        /// </summary>
        /// <value>pagination offset. Use it to skip the first ((page - 1) * per_page) items</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public decimal Page { get; set; }

        /// <summary>
        /// pagination limit (page size)
        /// </summary>
        /// <value>pagination limit (page size)</value>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        public decimal PerPage { get; set; }

        /// <summary>
        /// number of total pages with current limit
        /// </summary>
        /// <value>number of total pages with current limit</value>
        [DataMember(Name="total_pages", EmitDefaultValue=false)]
        public decimal TotalPages { get; set; }

        /// <summary>
        /// number of total available items
        /// </summary>
        /// <value>number of total available items</value>
        [DataMember(Name="total_items", EmitDefaultValue=false)]
        public decimal TotalItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaginationMetadata {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
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
            return this.Equals(input as PaginationMetadata);
        }

        /// <summary>
        /// Returns true if PaginationMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginationMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginationMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
                ) && 
                (
                    this.TotalItems == input.TotalItems ||
                    (this.TotalItems != null &&
                    this.TotalItems.Equals(input.TotalItems))
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
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.TotalItems != null)
                    hashCode = hashCode * 59 + this.TotalItems.GetHashCode();
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
