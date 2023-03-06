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
    /// Object for ui array tasks browser page
    /// </summary>
    [DataContract(Name = "ArrayTaskBrowserSidebar")]
    public partial class ArrayTaskBrowserSidebar : IEquatable<ArrayTaskBrowserSidebar>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayTaskBrowserSidebar" /> class.
        /// </summary>
        /// <param name="organizations">list of all unique organizations the user is part of that have array tasks.</param>
        /// <param name="resultCountForAll">A count of \&quot;all\&quot;.</param>
        /// <param name="resultCountByNamespace">A map that includes the result count by namespace.</param>
        public ArrayTaskBrowserSidebar(List<string> organizations = default(List<string>), int resultCountForAll = default(int), Object resultCountByNamespace = default(Object))
        {
            this.Organizations = organizations;
            this.ResultCountForAll = resultCountForAll;
            this.ResultCountByNamespace = resultCountByNamespace;
        }

        /// <summary>
        /// list of all unique organizations the user is part of that have array tasks
        /// </summary>
        /// <value>list of all unique organizations the user is part of that have array tasks</value>
        [DataMember(Name = "organizations", EmitDefaultValue = false)]
        public List<string> Organizations { get; set; }

        /// <summary>
        /// A count of \&quot;all\&quot;
        /// </summary>
        /// <value>A count of \&quot;all\&quot;</value>
        [DataMember(Name = "result_count_for_all", EmitDefaultValue = false)]
        public int ResultCountForAll { get; set; }

        /// <summary>
        /// A map that includes the result count by namespace
        /// </summary>
        /// <value>A map that includes the result count by namespace</value>
        [DataMember(Name = "result_count_by_namespace", EmitDefaultValue = false)]
        public Object ResultCountByNamespace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArrayTaskBrowserSidebar {\n");
            sb.Append("  Organizations: ").Append(Organizations).Append("\n");
            sb.Append("  ResultCountForAll: ").Append(ResultCountForAll).Append("\n");
            sb.Append("  ResultCountByNamespace: ").Append(ResultCountByNamespace).Append("\n");
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
            return this.Equals(input as ArrayTaskBrowserSidebar);
        }

        /// <summary>
        /// Returns true if ArrayTaskBrowserSidebar instances are equal
        /// </summary>
        /// <param name="input">Instance of ArrayTaskBrowserSidebar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArrayTaskBrowserSidebar input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Organizations == input.Organizations ||
                    this.Organizations != null &&
                    input.Organizations != null &&
                    this.Organizations.SequenceEqual(input.Organizations)
                ) && 
                (
                    this.ResultCountForAll == input.ResultCountForAll ||
                    this.ResultCountForAll.Equals(input.ResultCountForAll)
                ) && 
                (
                    this.ResultCountByNamespace == input.ResultCountByNamespace ||
                    (this.ResultCountByNamespace != null &&
                    this.ResultCountByNamespace.Equals(input.ResultCountByNamespace))
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
                if (this.Organizations != null)
                {
                    hashCode = (hashCode * 59) + this.Organizations.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResultCountForAll.GetHashCode();
                if (this.ResultCountByNamespace != null)
                {
                    hashCode = (hashCode * 59) + this.ResultCountByNamespace.GetHashCode();
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
