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
    /// A dimension range to query
    /// </summary>
    [DataContract(Name = "UDFSubarrayRange")]
    public partial class UDFSubarrayRange : IEquatable<UDFSubarrayRange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UDFSubarrayRange" /> class.
        /// </summary>
        /// <param name="dimensionId">The dimension index.</param>
        /// <param name="rangeStart">rangeStart.</param>
        /// <param name="rangeEnd">rangeEnd.</param>
        public UDFSubarrayRange(int dimensionId = default(int), DimensionCoordinate rangeStart = default(DimensionCoordinate), DimensionCoordinate rangeEnd = default(DimensionCoordinate))
        {
            this.DimensionId = dimensionId;
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        /// <summary>
        /// The dimension index
        /// </summary>
        /// <value>The dimension index</value>
        [DataMember(Name = "dimension_id", EmitDefaultValue = false)]
        public int DimensionId { get; set; }

        /// <summary>
        /// Gets or Sets RangeStart
        /// </summary>
        [DataMember(Name = "range_start", EmitDefaultValue = false)]
        public DimensionCoordinate RangeStart { get; set; }

        /// <summary>
        /// Gets or Sets RangeEnd
        /// </summary>
        [DataMember(Name = "range_end", EmitDefaultValue = false)]
        public DimensionCoordinate RangeEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UDFSubarrayRange {\n");
            sb.Append("  DimensionId: ").Append(DimensionId).Append("\n");
            sb.Append("  RangeStart: ").Append(RangeStart).Append("\n");
            sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
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
            return this.Equals(input as UDFSubarrayRange);
        }

        /// <summary>
        /// Returns true if UDFSubarrayRange instances are equal
        /// </summary>
        /// <param name="input">Instance of UDFSubarrayRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UDFSubarrayRange input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DimensionId == input.DimensionId ||
                    this.DimensionId.Equals(input.DimensionId)
                ) && 
                (
                    this.RangeStart == input.RangeStart ||
                    (this.RangeStart != null &&
                    this.RangeStart.Equals(input.RangeStart))
                ) && 
                (
                    this.RangeEnd == input.RangeEnd ||
                    (this.RangeEnd != null &&
                    this.RangeEnd.Equals(input.RangeEnd))
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
                hashCode = (hashCode * 59) + this.DimensionId.GetHashCode();
                if (this.RangeStart != null)
                {
                    hashCode = (hashCode * 59) + this.RangeStart.GetHashCode();
                }
                if (this.RangeEnd != null)
                {
                    hashCode = (hashCode * 59) + this.RangeEnd.GetHashCode();
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
