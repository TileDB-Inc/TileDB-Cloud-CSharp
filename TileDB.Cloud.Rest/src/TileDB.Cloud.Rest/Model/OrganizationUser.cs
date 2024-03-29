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
    /// user in an organization
    /// </summary>
    [DataContract]
    public partial class OrganizationUser :  IEquatable<OrganizationUser>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public OrganizationRoles? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUser" /> class.
        /// </summary>
        /// <param name="userId">unique ID of user.</param>
        /// <param name="organizationId">unique ID of organization.</param>
        /// <param name="username">username for user.</param>
        /// <param name="organizationName">name of organization.</param>
        /// <param name="role">role.</param>
        /// <param name="allowedActions">list of actions user is allowed to do on this organization.</param>
        public OrganizationUser(string userId = default(string), string organizationId = default(string), string username = default(string), string organizationName = default(string), OrganizationRoles? role = default(OrganizationRoles?), List<NamespaceActions> allowedActions = default(List<NamespaceActions>))
        {
            this.UserId = userId;
            this.OrganizationId = organizationId;
            this.Username = username;
            this.OrganizationName = organizationName;
            this.Role = role;
            // this.AllowedActions = allowedActions;
        }

        /// <summary>
        /// unique ID of user
        /// </summary>
        /// <value>unique ID of user</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// unique ID of organization
        /// </summary>
        /// <value>unique ID of organization</value>
        [DataMember(Name="organization_id", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// username for user
        /// </summary>
        /// <value>username for user</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// name of organization
        /// </summary>
        /// <value>name of organization</value>
        [DataMember(Name="organization_name", EmitDefaultValue=false)]
        public string OrganizationName { get; set; }


        /// <summary>
        /// list of actions user is allowed to do on this organization
        /// </summary>
        /// <value>list of actions user is allowed to do on this organization</value>
        // [DataMember(Name="allowed_actions", EmitDefaultValue=false)]
        // public List<NamespaceActions> AllowedActions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationUser {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            // sb.Append("  AllowedActions: ").Append(AllowedActions).Append("\n");
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
            return this.Equals(input as OrganizationUser);
        }

        /// <summary>
        /// Returns true if OrganizationUser instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationUser input)
        {
            if (input == null)
                return false;

            return
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                     this.UserId.Equals(input.UserId))
                ) &&
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                     this.OrganizationId.Equals(input.OrganizationId))
                ) &&
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                     this.Username.Equals(input.Username))
                ) &&
                (
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                     this.OrganizationName.Equals(input.OrganizationName))
                ) &&
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                     this.Role.Equals(input.Role))
                ); // &&
                // (
                //     this.AllowedActions == input.AllowedActions ||
                //     this.AllowedActions != null &&
                //     input.AllowedActions != null &&
                //     this.AllowedActions.SequenceEqual(input.AllowedActions)
                // );
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.OrganizationName != null)
                    hashCode = hashCode * 59 + this.OrganizationName.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                // if (this.AllowedActions != null)
                //     hashCode = hashCode * 59 + this.AllowedActions.GetHashCode();
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
