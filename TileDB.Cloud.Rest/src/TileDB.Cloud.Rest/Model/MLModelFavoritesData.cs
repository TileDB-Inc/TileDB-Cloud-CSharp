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
    /// Object including MLModel favorites and pagination metadata
    /// </summary>
    [DataContract]
    public partial class MLModelFavoritesData :  IEquatable<MLModelFavoritesData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MLModelFavoritesData" /> class.
        /// </summary>
        /// <param name="mlmodels">List of MLModel infos.</param>
        /// <param name="paginationMetadata">paginationMetadata.</param>
        public MLModelFavoritesData(List<ArrayInfo> mlmodels = default(List<ArrayInfo>), PaginationMetadata paginationMetadata = default(PaginationMetadata))
        {
            this.Mlmodels = mlmodels;
            this.PaginationMetadata = paginationMetadata;
        }

        /// <summary>
        /// List of MLModel infos
        /// </summary>
        /// <value>List of MLModel infos</value>
        [DataMember(Name="mlmodels", EmitDefaultValue=false)]
        public List<ArrayInfo> Mlmodels { get; set; }

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
            sb.Append("class MLModelFavoritesData {\n");
            sb.Append("  Mlmodels: ").Append(Mlmodels).Append("\n");
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
            return this.Equals(input as MLModelFavoritesData);
        }

        /// <summary>
        /// Returns true if MLModelFavoritesData instances are equal
        /// </summary>
        /// <param name="input">Instance of MLModelFavoritesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MLModelFavoritesData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mlmodels == input.Mlmodels ||
                    this.Mlmodels != null &&
                    input.Mlmodels != null &&
                    this.Mlmodels.SequenceEqual(input.Mlmodels)
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
                if (this.Mlmodels != null)
                    hashCode = hashCode * 59 + this.Mlmodels.GetHashCode();
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
