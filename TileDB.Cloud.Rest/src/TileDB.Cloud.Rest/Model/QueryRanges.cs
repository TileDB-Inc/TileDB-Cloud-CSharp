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
    /// Subarray bounds to query
    /// </summary>
    [DataContract]
    public partial class QueryRanges :  IEquatable<QueryRanges>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name="layout", EmitDefaultValue=false)]
        public Layout? Layout { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRanges" /> class.
        /// </summary>
        /// <param name="layout">layout.</param>
        /// <param name="ranges">List of ranges,.</param>
        public QueryRanges(Layout? layout = default(Layout?), List<List<Int32>> ranges = default(List<List<Int32>>))
        {
            this.Layout = layout;
            this.Ranges = ranges;
        }


        /// <summary>
        /// List of ranges,
        /// </summary>
        /// <value>List of ranges,</value>
        [DataMember(Name="ranges", EmitDefaultValue=false)]
        public List<List<Int32>> Ranges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRanges {\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
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
            return this.Equals(input as QueryRanges);
        }

        /// <summary>
        /// Returns true if QueryRanges instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryRanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryRanges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
                ) && 
                (
                    this.Ranges == input.Ranges ||
                    this.Ranges != null &&
                    input.Ranges != null &&
                    this.Ranges.SequenceEqual(input.Ranges)
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
                if (this.Layout != null)
                    hashCode = hashCode * 59 + this.Layout.GetHashCode();
                if (this.Ranges != null)
                    hashCode = hashCode * 59 + this.Ranges.GetHashCode();
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
