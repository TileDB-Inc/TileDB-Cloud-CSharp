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
    /// The current partition info
    /// </summary>
    [DataContract]
    public partial class SubarrayPartitionerCurrent :  IEquatable<SubarrayPartitionerCurrent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubarrayPartitionerCurrent" /> class.
        /// </summary>
        /// <param name="subarray">subarray.</param>
        /// <param name="start">PartitionInfo start.</param>
        /// <param name="end">PartitionInfo end.</param>
        /// <param name="splitMultiRange">PartitionInfo splitMultiRange.</param>
        public SubarrayPartitionerCurrent(Subarray subarray = default(Subarray), int start = default(int), int end = default(int), bool splitMultiRange = default(bool))
        {
            this.Subarray = subarray;
            this.Start = start;
            this.End = end;
            this.SplitMultiRange = splitMultiRange;
        }

        /// <summary>
        /// Gets or Sets Subarray
        /// </summary>
        [DataMember(Name="subarray", EmitDefaultValue=false)]
        public Subarray Subarray { get; set; }

        /// <summary>
        /// PartitionInfo start
        /// </summary>
        /// <value>PartitionInfo start</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public int Start { get; set; }

        /// <summary>
        /// PartitionInfo end
        /// </summary>
        /// <value>PartitionInfo end</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public int End { get; set; }

        /// <summary>
        /// PartitionInfo splitMultiRange
        /// </summary>
        /// <value>PartitionInfo splitMultiRange</value>
        [DataMember(Name="splitMultiRange", EmitDefaultValue=false)]
        public bool SplitMultiRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubarrayPartitionerCurrent {\n");
            sb.Append("  Subarray: ").Append(Subarray).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  SplitMultiRange: ").Append(SplitMultiRange).Append("\n");
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
            return this.Equals(input as SubarrayPartitionerCurrent);
        }

        /// <summary>
        /// Returns true if SubarrayPartitionerCurrent instances are equal
        /// </summary>
        /// <param name="input">Instance of SubarrayPartitionerCurrent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubarrayPartitionerCurrent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subarray == input.Subarray ||
                    (this.Subarray != null &&
                    this.Subarray.Equals(input.Subarray))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.SplitMultiRange == input.SplitMultiRange ||
                    (this.SplitMultiRange != null &&
                    this.SplitMultiRange.Equals(input.SplitMultiRange))
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
                if (this.Subarray != null)
                    hashCode = hashCode * 59 + this.Subarray.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.SplitMultiRange != null)
                    hashCode = hashCode * 59 + this.SplitMultiRange.GetHashCode();
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
