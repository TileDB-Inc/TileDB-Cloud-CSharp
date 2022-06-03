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
    /// Organization
    /// </summary>
    [DataContract]
    public partial class Organization :  IEquatable<Organization>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public OrganizationRoles? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Organization() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="id">unique ID of organization.</param>
        /// <param name="role">role.</param>
        /// <param name="name">organization name must be unique (required).</param>
        /// <param name="createdAt">Datetime organization was created in UTC.</param>
        /// <param name="updatedAt">Datetime organization was updated in UTC.</param>
        /// <param name="logo">Organization logo.</param>
        /// <param name="description">Organization description.</param>
        /// <param name="users">users.</param>
        /// <param name="allowedActions">list of actions user is allowed to do on this organization.</param>
        /// <param name="numOfArrays">number of registered arrays for this organization.</param>
        /// <param name="defaultS3Path">default S3 path to store newly created notebooks.</param>
        /// <param name="defaultS3PathCredentialsName">Default S3 path credentials name is the credentials name to use along with default_s3_path.</param>
        public Organization(string id = default(string), OrganizationRoles? role = default(OrganizationRoles?), string name = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string logo = default(string), string description = default(string), List<OrganizationUser> users = default(List<OrganizationUser>), List<NamespaceActions> allowedActions = default(List<NamespaceActions>), decimal numOfArrays = default(decimal), string defaultS3Path = default(string), string defaultS3PathCredentialsName = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Organization and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Description = description;
            this.Id = id;
            this.Role = role;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Logo = logo;
            this.Description = description;
            this.Users = users;
            //this.AllowedActions = allowedActions;
            this.NumOfArrays = numOfArrays;
            this.DefaultS3Path = defaultS3Path;
            this.DefaultS3PathCredentialsName = defaultS3PathCredentialsName;
        }

        /// <summary>
        /// unique ID of organization
        /// </summary>
        /// <value>unique ID of organization</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// organization name must be unique
        /// </summary>
        /// <value>organization name must be unique</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Datetime organization was created in UTC
        /// </summary>
        /// <value>Datetime organization was created in UTC</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Datetime organization was updated in UTC
        /// </summary>
        /// <value>Datetime organization was updated in UTC</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Organization logo
        /// </summary>
        /// <value>Organization logo</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// Organization description
        /// </summary>
        /// <value>Organization description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<OrganizationUser> Users { get; set; }

        ///// <summary>
        ///// list of actions user is allowed to do on this organization
        ///// </summary>
        ///// <value>list of actions user is allowed to do on this organization</value>
        //[DataMember(Name="allowed_actions", EmitDefaultValue=false)]
        //public List<NamespaceActions> AllowedActions { get; set; }

        /// <summary>
        /// number of registered arrays for this organization
        /// </summary>
        /// <value>number of registered arrays for this organization</value>
        [DataMember(Name="num_of_arrays", EmitDefaultValue=false)]
        public decimal NumOfArrays { get; set; }

        /// <summary>
        /// List of extra/optional/beta features to enable for namespace
        /// </summary>
        /// <value>List of extra/optional/beta features to enable for namespace</value>
        [DataMember(Name="enabled_features", EmitDefaultValue=false)]
        public List<string> EnabledFeatures { get; private set; }

        /// <summary>
        /// A notice that the user has an unpaid subscription
        /// </summary>
        /// <value>A notice that the user has an unpaid subscription</value>
        [DataMember(Name="unpaid_subscription", EmitDefaultValue=false)]
        public bool UnpaidSubscription { get; private set; }

        /// <summary>
        /// default S3 path to store newly created notebooks
        /// </summary>
        /// <value>default S3 path to store newly created notebooks</value>
        [DataMember(Name="default_s3_path", EmitDefaultValue=false)]
        public string DefaultS3Path { get; set; }

        /// <summary>
        /// Default S3 path credentials name is the credentials name to use along with default_s3_path
        /// </summary>
        /// <value>Default S3 path credentials name is the credentials name to use along with default_s3_path</value>
        [DataMember(Name="default_s3_path_credentials_name", EmitDefaultValue=false)]
        public string DefaultS3PathCredentialsName { get; set; }

        /// <summary>
        /// Denotes that the organization is able to apply pricing to arrays by means of Stripe Connect
        /// </summary>
        /// <value>Denotes that the organization is able to apply pricing to arrays by means of Stripe Connect</value>
        [DataMember(Name="stripe_connect", EmitDefaultValue=false)]
        public bool StripeConnect { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Organization {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            //sb.Append("  AllowedActions: ").Append(AllowedActions).Append("\n");
            sb.Append("  NumOfArrays: ").Append(NumOfArrays).Append("\n");
            sb.Append("  EnabledFeatures: ").Append(EnabledFeatures).Append("\n");
            sb.Append("  UnpaidSubscription: ").Append(UnpaidSubscription).Append("\n");
            sb.Append("  DefaultS3Path: ").Append(DefaultS3Path).Append("\n");
            sb.Append("  DefaultS3PathCredentialsName: ").Append(DefaultS3PathCredentialsName).Append("\n");
            sb.Append("  StripeConnect: ").Append(StripeConnect).Append("\n");
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
            return this.Equals(input as Organization);
        }

        /// <summary>
        /// Returns true if Organization instances are equal
        /// </summary>
        /// <param name="input">Instance of Organization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organization input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                //(
                //    this.AllowedActions == input.AllowedActions ||
                //    this.AllowedActions != null &&
                //    input.AllowedActions != null &&
                //    this.AllowedActions.SequenceEqual(input.AllowedActions)
                //) && 
                (
                    this.NumOfArrays == input.NumOfArrays ||
                    (this.NumOfArrays != null &&
                    this.NumOfArrays.Equals(input.NumOfArrays))
                ) && 
                (
                    this.EnabledFeatures == input.EnabledFeatures ||
                    this.EnabledFeatures != null &&
                    input.EnabledFeatures != null &&
                    this.EnabledFeatures.SequenceEqual(input.EnabledFeatures)
                ) && 
                (
                    this.UnpaidSubscription == input.UnpaidSubscription ||
                    (this.UnpaidSubscription != null &&
                    this.UnpaidSubscription.Equals(input.UnpaidSubscription))
                ) && 
                (
                    this.DefaultS3Path == input.DefaultS3Path ||
                    (this.DefaultS3Path != null &&
                    this.DefaultS3Path.Equals(input.DefaultS3Path))
                ) && 
                (
                    this.DefaultS3PathCredentialsName == input.DefaultS3PathCredentialsName ||
                    (this.DefaultS3PathCredentialsName != null &&
                    this.DefaultS3PathCredentialsName.Equals(input.DefaultS3PathCredentialsName))
                ) && 
                (
                    this.StripeConnect == input.StripeConnect ||
                    (this.StripeConnect != null &&
                    this.StripeConnect.Equals(input.StripeConnect))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                //if (this.AllowedActions != null)
                //    hashCode = hashCode * 59 + this.AllowedActions.GetHashCode();
                if (this.NumOfArrays != null)
                    hashCode = hashCode * 59 + this.NumOfArrays.GetHashCode();
                if (this.EnabledFeatures != null)
                    hashCode = hashCode * 59 + this.EnabledFeatures.GetHashCode();
                if (this.UnpaidSubscription != null)
                    hashCode = hashCode * 59 + this.UnpaidSubscription.GetHashCode();
                if (this.DefaultS3Path != null)
                    hashCode = hashCode * 59 + this.DefaultS3Path.GetHashCode();
                if (this.DefaultS3PathCredentialsName != null)
                    hashCode = hashCode * 59 + this.DefaultS3PathCredentialsName.GetHashCode();
                if (this.StripeConnect != null)
                    hashCode = hashCode * 59 + this.StripeConnect.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 63)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 63.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"^[\\w.\\-]+$", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            yield break;
        }
    }

}
