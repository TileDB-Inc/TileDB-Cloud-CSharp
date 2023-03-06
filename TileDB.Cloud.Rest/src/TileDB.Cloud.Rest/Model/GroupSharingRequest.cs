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
    /// a request to share a group and all the contents with a namespace
    /// </summary>
    [DataContract(Name = "GroupSharingRequest")]
    public partial class GroupSharingRequest : IEquatable<GroupSharingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSharingRequest" /> class.
        /// </summary>
        /// <param name="groupActions">List of permitted actions for the group and all subgroups.</param>
        /// <param name="arrayActions">List of permitted actions for all the subarrays of the group.</param>
        /// <param name="_namespace">namespace being granted group access can be a user or organization.</param>
        public GroupSharingRequest(List<GroupActions> groupActions = default(List<GroupActions>), List<ArrayActions> arrayActions = default(List<ArrayActions>), string _namespace = default(string))
        {
            this.GroupActions = groupActions;
            this.ArrayActions = arrayActions;
            this.Namespace = _namespace;
        }

        /// <summary>
        /// List of permitted actions for the group and all subgroups
        /// </summary>
        /// <value>List of permitted actions for the group and all subgroups</value>
        [DataMember(Name = "group_actions", EmitDefaultValue = false)]
        public List<GroupActions> GroupActions { get; set; }

        /// <summary>
        /// List of permitted actions for all the subarrays of the group
        /// </summary>
        /// <value>List of permitted actions for all the subarrays of the group</value>
        [DataMember(Name = "array_actions", EmitDefaultValue = false)]
        public List<ArrayActions> ArrayActions { get; set; }

        /// <summary>
        /// namespace being granted group access can be a user or organization
        /// </summary>
        /// <value>namespace being granted group access can be a user or organization</value>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupSharingRequest {\n");
            sb.Append("  GroupActions: ").Append(GroupActions).Append("\n");
            sb.Append("  ArrayActions: ").Append(ArrayActions).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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
            return this.Equals(input as GroupSharingRequest);
        }

        /// <summary>
        /// Returns true if GroupSharingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupSharingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSharingRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupActions == input.GroupActions ||
                    this.GroupActions != null &&
                    input.GroupActions != null &&
                    this.GroupActions.SequenceEqual(input.GroupActions)
                ) && 
                (
                    this.ArrayActions == input.ArrayActions ||
                    this.ArrayActions != null &&
                    input.ArrayActions != null &&
                    this.ArrayActions.SequenceEqual(input.ArrayActions)
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
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
                if (this.GroupActions != null)
                {
                    hashCode = (hashCode * 59) + this.GroupActions.GetHashCode();
                }
                if (this.ArrayActions != null)
                {
                    hashCode = (hashCode * 59) + this.ArrayActions.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
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
