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
    /// Object including array favorites and pagination metadata
    /// </summary>
    [DataContract]
    public partial class ArrayFavoritesData :  IEquatable<ArrayFavoritesData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayFavoritesData" /> class.
        /// </summary>
        /// <param name="arrays">List of array infos.</param>
        /// <param name="paginationMetadata">paginationMetadata.</param>
        public ArrayFavoritesData(List<ArrayInfo> arrays = default(List<ArrayInfo>), PaginationMetadata paginationMetadata = default(PaginationMetadata))
        {
            this.Arrays = arrays;
            this.PaginationMetadata = paginationMetadata;
        }

        /// <summary>
        /// List of array infos
        /// </summary>
        /// <value>List of array infos</value>
        [DataMember(Name="arrays", EmitDefaultValue=false)]
        public List<ArrayInfo> Arrays { get; set; }

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
            sb.Append("class ArrayFavoritesData {\n");
            sb.Append("  Arrays: ").Append(Arrays).Append("\n");
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
            return this.Equals(input as ArrayFavoritesData);
        }

        /// <summary>
        /// Returns true if ArrayFavoritesData instances are equal
        /// </summary>
        /// <param name="input">Instance of ArrayFavoritesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArrayFavoritesData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Arrays == input.Arrays ||
                    this.Arrays != null &&
                    input.Arrays != null &&
                    this.Arrays.SequenceEqual(input.Arrays)
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
                if (this.Arrays != null)
                    hashCode = hashCode * 59 + this.Arrays.GetHashCode();
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
