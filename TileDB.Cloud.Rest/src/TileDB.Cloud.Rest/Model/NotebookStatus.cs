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
    /// Status details of a notebook server
    /// </summary>
    [DataContract]
    public partial class NotebookStatus :  IEquatable<NotebookStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotebookStatus" /> class.
        /// </summary>
        /// <param name="_namespace">namespace of notebook.</param>
        /// <param name="uptime">duration notebook has been running in seconds.</param>
        /// <param name="cpuUsage">current cpu usage in millicpu.</param>
        /// <param name="memoryUsage">memory usage in bytes.</param>
        /// <param name="memoryLimit">memory allocated to notebook server in bytes.</param>
        /// <param name="cpuCount">millicpu allocated to notebook server.</param>
        public NotebookStatus(string _namespace = default(string), int uptime = default(int), int cpuUsage = default(int), int memoryUsage = default(int), int memoryLimit = default(int), int cpuCount = default(int))
        {
            this.Namespace = _namespace;
            this.Uptime = uptime;
            this.CpuUsage = cpuUsage;
            this.MemoryUsage = memoryUsage;
            this.MemoryLimit = memoryLimit;
            this.CpuCount = cpuCount;
        }

        /// <summary>
        /// namespace of notebook
        /// </summary>
        /// <value>namespace of notebook</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// duration notebook has been running in seconds
        /// </summary>
        /// <value>duration notebook has been running in seconds</value>
        [DataMember(Name="uptime", EmitDefaultValue=false)]
        public int Uptime { get; set; }

        /// <summary>
        /// current cpu usage in millicpu
        /// </summary>
        /// <value>current cpu usage in millicpu</value>
        [DataMember(Name="cpu_usage", EmitDefaultValue=false)]
        public int CpuUsage { get; set; }

        /// <summary>
        /// memory usage in bytes
        /// </summary>
        /// <value>memory usage in bytes</value>
        [DataMember(Name="memory_usage", EmitDefaultValue=false)]
        public int MemoryUsage { get; set; }

        /// <summary>
        /// memory allocated to notebook server in bytes
        /// </summary>
        /// <value>memory allocated to notebook server in bytes</value>
        [DataMember(Name="memory_limit", EmitDefaultValue=false)]
        public int MemoryLimit { get; set; }

        /// <summary>
        /// millicpu allocated to notebook server
        /// </summary>
        /// <value>millicpu allocated to notebook server</value>
        [DataMember(Name="cpu_count", EmitDefaultValue=false)]
        public int CpuCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotebookStatus {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Uptime: ").Append(Uptime).Append("\n");
            sb.Append("  CpuUsage: ").Append(CpuUsage).Append("\n");
            sb.Append("  MemoryUsage: ").Append(MemoryUsage).Append("\n");
            sb.Append("  MemoryLimit: ").Append(MemoryLimit).Append("\n");
            sb.Append("  CpuCount: ").Append(CpuCount).Append("\n");
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
            return this.Equals(input as NotebookStatus);
        }

        /// <summary>
        /// Returns true if NotebookStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of NotebookStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotebookStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Uptime == input.Uptime ||
                    (this.Uptime != null &&
                    this.Uptime.Equals(input.Uptime))
                ) && 
                (
                    this.CpuUsage == input.CpuUsage ||
                    (this.CpuUsage != null &&
                    this.CpuUsage.Equals(input.CpuUsage))
                ) && 
                (
                    this.MemoryUsage == input.MemoryUsage ||
                    (this.MemoryUsage != null &&
                    this.MemoryUsage.Equals(input.MemoryUsage))
                ) && 
                (
                    this.MemoryLimit == input.MemoryLimit ||
                    (this.MemoryLimit != null &&
                    this.MemoryLimit.Equals(input.MemoryLimit))
                ) && 
                (
                    this.CpuCount == input.CpuCount ||
                    (this.CpuCount != null &&
                    this.CpuCount.Equals(input.CpuCount))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Uptime != null)
                    hashCode = hashCode * 59 + this.Uptime.GetHashCode();
                if (this.CpuUsage != null)
                    hashCode = hashCode * 59 + this.CpuUsage.GetHashCode();
                if (this.MemoryUsage != null)
                    hashCode = hashCode * 59 + this.MemoryUsage.GetHashCode();
                if (this.MemoryLimit != null)
                    hashCode = hashCode * 59 + this.MemoryLimit.GetHashCode();
                if (this.CpuCount != null)
                    hashCode = hashCode * 59 + this.CpuCount.GetHashCode();
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
