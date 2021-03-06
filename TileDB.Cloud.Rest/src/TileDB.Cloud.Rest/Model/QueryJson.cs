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
    /// Query returning results as JSON
    /// </summary>
    [DataContract]
    public partial class QueryJson :  IEquatable<QueryJson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryJson" /> class.
        /// </summary>
        /// <param name="queryRanges">queryRanges.</param>
        /// <param name="fields">List of fields to return data from, empty means return data for all fields.</param>
        public QueryJson(QueryRanges queryRanges = default(QueryRanges), List<string> fields = default(List<string>))
        {
            this.QueryRanges = queryRanges;
            this.Fields = fields;
        }

        /// <summary>
        /// Gets or Sets QueryRanges
        /// </summary>
        [DataMember(Name="query_ranges", EmitDefaultValue=false)]
        public QueryRanges QueryRanges { get; set; }

        /// <summary>
        /// List of fields to return data from, empty means return data for all fields
        /// </summary>
        /// <value>List of fields to return data from, empty means return data for all fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryJson {\n");
            sb.Append("  QueryRanges: ").Append(QueryRanges).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as QueryJson);
        }

        /// <summary>
        /// Returns true if QueryJson instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryJson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryJson input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueryRanges == input.QueryRanges ||
                    (this.QueryRanges != null &&
                    this.QueryRanges.Equals(input.QueryRanges))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.QueryRanges != null)
                    hashCode = hashCode * 59 + this.QueryRanges.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
