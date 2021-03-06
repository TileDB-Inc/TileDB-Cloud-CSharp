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
    /// The subarray partitioner
    /// </summary>
    [DataContract]
    public partial class SubarrayPartitioner :  IEquatable<SubarrayPartitioner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubarrayPartitioner" /> class.
        /// </summary>
        /// <param name="subarray">subarray.</param>
        /// <param name="budget">Result size budget (in bytes) for all attributes..</param>
        /// <param name="current">current.</param>
        /// <param name="state">state.</param>
        /// <param name="memoryBudget">The memory budget for the fixed-sized attributes and the offsets of the var-sized attributes.</param>
        /// <param name="memoryBudgetVar">The memory budget for the var-sized attributes.</param>
        public SubarrayPartitioner(Subarray subarray = default(Subarray), List<AttributeBufferSize> budget = default(List<AttributeBufferSize>), SubarrayPartitionerCurrent current = default(SubarrayPartitionerCurrent), SubarrayPartitionerState state = default(SubarrayPartitionerState), int memoryBudget = default(int), int memoryBudgetVar = default(int))
        {
            this.Subarray = subarray;
            this.Budget = budget;
            this.Current = current;
            this.State = state;
            this.MemoryBudget = memoryBudget;
            this.MemoryBudgetVar = memoryBudgetVar;
        }

        /// <summary>
        /// Gets or Sets Subarray
        /// </summary>
        [DataMember(Name="subarray", EmitDefaultValue=false)]
        public Subarray Subarray { get; set; }

        /// <summary>
        /// Result size budget (in bytes) for all attributes.
        /// </summary>
        /// <value>Result size budget (in bytes) for all attributes.</value>
        [DataMember(Name="budget", EmitDefaultValue=false)]
        public List<AttributeBufferSize> Budget { get; set; }

        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public SubarrayPartitionerCurrent Current { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubarrayPartitionerState State { get; set; }

        /// <summary>
        /// The memory budget for the fixed-sized attributes and the offsets of the var-sized attributes
        /// </summary>
        /// <value>The memory budget for the fixed-sized attributes and the offsets of the var-sized attributes</value>
        [DataMember(Name="memoryBudget", EmitDefaultValue=false)]
        public int MemoryBudget { get; set; }

        /// <summary>
        /// The memory budget for the var-sized attributes
        /// </summary>
        /// <value>The memory budget for the var-sized attributes</value>
        [DataMember(Name="memoryBudgetVar", EmitDefaultValue=false)]
        public int MemoryBudgetVar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubarrayPartitioner {\n");
            sb.Append("  Subarray: ").Append(Subarray).Append("\n");
            sb.Append("  Budget: ").Append(Budget).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  MemoryBudget: ").Append(MemoryBudget).Append("\n");
            sb.Append("  MemoryBudgetVar: ").Append(MemoryBudgetVar).Append("\n");
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
            return this.Equals(input as SubarrayPartitioner);
        }

        /// <summary>
        /// Returns true if SubarrayPartitioner instances are equal
        /// </summary>
        /// <param name="input">Instance of SubarrayPartitioner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubarrayPartitioner input)
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
                    this.Budget == input.Budget ||
                    this.Budget != null &&
                    input.Budget != null &&
                    this.Budget.SequenceEqual(input.Budget)
                ) && 
                (
                    this.Current == input.Current ||
                    (this.Current != null &&
                    this.Current.Equals(input.Current))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.MemoryBudget == input.MemoryBudget ||
                    (this.MemoryBudget != null &&
                    this.MemoryBudget.Equals(input.MemoryBudget))
                ) && 
                (
                    this.MemoryBudgetVar == input.MemoryBudgetVar ||
                    (this.MemoryBudgetVar != null &&
                    this.MemoryBudgetVar.Equals(input.MemoryBudgetVar))
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
                if (this.Budget != null)
                    hashCode = hashCode * 59 + this.Budget.GetHashCode();
                if (this.Current != null)
                    hashCode = hashCode * 59 + this.Current.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.MemoryBudget != null)
                    hashCode = hashCode * 59 + this.MemoryBudget.GetHashCode();
                if (this.MemoryBudgetVar != null)
                    hashCode = hashCode * 59 + this.MemoryBudgetVar.GetHashCode();
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
