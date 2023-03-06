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
    /// User
    /// </summary>
    [DataContract(Name = "User")]
    public partial class User : IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="id">unique ID of user.</param>
        /// <param name="username">username must be unique (required).</param>
        /// <param name="password">password.</param>
        /// <param name="name">the user&#39;s full, real name.</param>
        /// <param name="email">the user&#39;s email.</param>
        /// <param name="company">the user&#39;s company.</param>
        /// <param name="logo">the user&#39;s logo.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="allowedActions">list of actions user is allowed to do on this organization.</param>
        /// <param name="defaultS3Path">The default location to store newly-created notebooks and other assets like UDFs. The name &#x60;default_s3_path&#x60; is a legacy holdover; it may refer to any supported storage location. .</param>
        /// <param name="defaultS3PathCredentialsName">The name of the credentials used to create and access files in the &#x60;default_s3_path&#x60;, if needed. .</param>
        /// <param name="assetLocations">assetLocations.</param>
        /// <param name="defaultNamespaceCharged">Override the default namespace charged for actions when no namespace is specified.</param>
        public User(string id = default(string), string username = default(string), string password = default(string), string name = default(string), string email = default(string), string company = default(string), string logo = default(string), string timezone = default(string), List<NamespaceActions> allowedActions = default(List<NamespaceActions>), string defaultS3Path = default(string), Object defaultS3PathCredentialsName = default(Object), AssetLocations assetLocations = default(AssetLocations), string defaultNamespaceCharged = default(string))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new ArgumentNullException("username is a required property for User and cannot be null");
            }
            this.Username = username;
            this.Id = id;
            this.Password = password;
            this.Name = name;
            this.Email = email;
            this.Company = company;
            this.Logo = logo;
            this.Timezone = timezone;
            this.AllowedActions = allowedActions;
            this.DefaultS3Path = defaultS3Path;
            this.DefaultS3PathCredentialsName = defaultS3PathCredentialsName;
            this.AssetLocations = assetLocations;
            this.DefaultNamespaceCharged = defaultNamespaceCharged;
        }

        /// <summary>
        /// unique ID of user
        /// </summary>
        /// <value>unique ID of user</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// username must be unique
        /// </summary>
        /// <value>username must be unique</value>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// password
        /// </summary>
        /// <value>password</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// the user&#39;s full, real name
        /// </summary>
        /// <value>the user&#39;s full, real name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// the user&#39;s email
        /// </summary>
        /// <value>the user&#39;s email</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// user&#39;s email is validated to be correct
        /// </summary>
        /// <value>user&#39;s email is validated to be correct</value>
        [DataMember(Name = "is_valid_email", EmitDefaultValue = true)]
        public bool IsValidEmail { get; private set; }

        /// <summary>
        /// Returns false as IsValidEmail should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsValidEmail()
        {
            return false;
        }
        /// <summary>
        /// Denotes that the user is able to apply pricing to arrays by means of Stripe Connect
        /// </summary>
        /// <value>Denotes that the user is able to apply pricing to arrays by means of Stripe Connect</value>
        [DataMember(Name = "stripe_connect", EmitDefaultValue = true)]
        public bool StripeConnect { get; private set; }

        /// <summary>
        /// Returns false as StripeConnect should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStripeConnect()
        {
            return false;
        }
        /// <summary>
        /// the user&#39;s company
        /// </summary>
        /// <value>the user&#39;s company</value>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public string Company { get; set; }

        /// <summary>
        /// the user&#39;s logo
        /// </summary>
        /// <value>the user&#39;s logo</value>
        [DataMember(Name = "logo", EmitDefaultValue = true)]
        public string Logo { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name = "timezone", EmitDefaultValue = false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Array of organizations a user is part of and their roles
        /// </summary>
        /// <value>Array of organizations a user is part of and their roles</value>
        [DataMember(Name = "organizations", EmitDefaultValue = false)]
        public List<OrganizationUser> Organizations { get; private set; }

        /// <summary>
        /// Returns false as Organizations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrganizations()
        {
            return false;
        }
        /// <summary>
        /// list of actions user is allowed to do on this organization
        /// </summary>
        /// <value>list of actions user is allowed to do on this organization</value>
        [DataMember(Name = "allowed_actions", EmitDefaultValue = false)]
        public List<NamespaceActions> AllowedActions { get; set; }

        /// <summary>
        /// List of extra/optional/beta features to enable for namespace
        /// </summary>
        /// <value>List of extra/optional/beta features to enable for namespace</value>
        [DataMember(Name = "enabled_features", EmitDefaultValue = false)]
        public List<string> EnabledFeatures { get; private set; }

        /// <summary>
        /// Returns false as EnabledFeatures should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEnabledFeatures()
        {
            return false;
        }
        /// <summary>
        /// A notice that the user has an unpaid subscription
        /// </summary>
        /// <value>A notice that the user has an unpaid subscription</value>
        [DataMember(Name = "unpaid_subscription", EmitDefaultValue = true)]
        public bool UnpaidSubscription { get; private set; }

        /// <summary>
        /// Returns false as UnpaidSubscription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUnpaidSubscription()
        {
            return false;
        }
        /// <summary>
        /// The default location to store newly-created notebooks and other assets like UDFs. The name &#x60;default_s3_path&#x60; is a legacy holdover; it may refer to any supported storage location. 
        /// </summary>
        /// <value>The default location to store newly-created notebooks and other assets like UDFs. The name &#x60;default_s3_path&#x60; is a legacy holdover; it may refer to any supported storage location. </value>
        [DataMember(Name = "default_s3_path", EmitDefaultValue = false)]
        public string DefaultS3Path { get; set; }

        /// <summary>
        /// The name of the credentials used to create and access files in the &#x60;default_s3_path&#x60;, if needed. 
        /// </summary>
        /// <value>The name of the credentials used to create and access files in the &#x60;default_s3_path&#x60;, if needed. </value>
        [DataMember(Name = "default_s3_path_credentials_name", EmitDefaultValue = false)]
        public Object DefaultS3PathCredentialsName { get; set; }

        /// <summary>
        /// Gets or Sets AssetLocations
        /// </summary>
        [DataMember(Name = "asset_locations", EmitDefaultValue = false)]
        public AssetLocations AssetLocations { get; set; }

        /// <summary>
        /// Override the default namespace charged for actions when no namespace is specified
        /// </summary>
        /// <value>Override the default namespace charged for actions when no namespace is specified</value>
        [DataMember(Name = "default_namespace_charged", EmitDefaultValue = false)]
        public string DefaultNamespaceCharged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IsValidEmail: ").Append(IsValidEmail).Append("\n");
            sb.Append("  StripeConnect: ").Append(StripeConnect).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Organizations: ").Append(Organizations).Append("\n");
            sb.Append("  AllowedActions: ").Append(AllowedActions).Append("\n");
            sb.Append("  EnabledFeatures: ").Append(EnabledFeatures).Append("\n");
            sb.Append("  UnpaidSubscription: ").Append(UnpaidSubscription).Append("\n");
            sb.Append("  DefaultS3Path: ").Append(DefaultS3Path).Append("\n");
            sb.Append("  DefaultS3PathCredentialsName: ").Append(DefaultS3PathCredentialsName).Append("\n");
            sb.Append("  AssetLocations: ").Append(AssetLocations).Append("\n");
            sb.Append("  DefaultNamespaceCharged: ").Append(DefaultNamespaceCharged).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.IsValidEmail == input.IsValidEmail ||
                    this.IsValidEmail.Equals(input.IsValidEmail)
                ) && 
                (
                    this.StripeConnect == input.StripeConnect ||
                    this.StripeConnect.Equals(input.StripeConnect)
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Organizations == input.Organizations ||
                    this.Organizations != null &&
                    input.Organizations != null &&
                    this.Organizations.SequenceEqual(input.Organizations)
                ) && 
                (
                    this.AllowedActions == input.AllowedActions ||
                    this.AllowedActions != null &&
                    input.AllowedActions != null &&
                    this.AllowedActions.SequenceEqual(input.AllowedActions)
                ) && 
                (
                    this.EnabledFeatures == input.EnabledFeatures ||
                    this.EnabledFeatures != null &&
                    input.EnabledFeatures != null &&
                    this.EnabledFeatures.SequenceEqual(input.EnabledFeatures)
                ) && 
                (
                    this.UnpaidSubscription == input.UnpaidSubscription ||
                    this.UnpaidSubscription.Equals(input.UnpaidSubscription)
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
                    this.AssetLocations == input.AssetLocations ||
                    (this.AssetLocations != null &&
                    this.AssetLocations.Equals(input.AssetLocations))
                ) && 
                (
                    this.DefaultNamespaceCharged == input.DefaultNamespaceCharged ||
                    (this.DefaultNamespaceCharged != null &&
                    this.DefaultNamespaceCharged.Equals(input.DefaultNamespaceCharged))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsValidEmail.GetHashCode();
                hashCode = (hashCode * 59) + this.StripeConnect.GetHashCode();
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.Timezone != null)
                {
                    hashCode = (hashCode * 59) + this.Timezone.GetHashCode();
                }
                if (this.Organizations != null)
                {
                    hashCode = (hashCode * 59) + this.Organizations.GetHashCode();
                }
                if (this.AllowedActions != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedActions.GetHashCode();
                }
                if (this.EnabledFeatures != null)
                {
                    hashCode = (hashCode * 59) + this.EnabledFeatures.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnpaidSubscription.GetHashCode();
                if (this.DefaultS3Path != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultS3Path.GetHashCode();
                }
                if (this.DefaultS3PathCredentialsName != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultS3PathCredentialsName.GetHashCode();
                }
                if (this.AssetLocations != null)
                {
                    hashCode = (hashCode * 59) + this.AssetLocations.GetHashCode();
                }
                if (this.DefaultNamespaceCharged != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultNamespaceCharged.GetHashCode();
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
            // Username (string) maxLength
            if (this.Username != null && this.Username.Length > 63)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than 63.", new [] { "Username" });
            }

            // Username (string) minLength
            if (this.Username != null && this.Username.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be greater than 1.", new [] { "Username" });
            }

            // Username (string) pattern
            Regex regexUsername = new Regex(@"^[\\w.\\-]+$", RegexOptions.CultureInvariant);
            if (false == regexUsername.Match(this.Username).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, must match a pattern of " + regexUsername, new [] { "Username" });
            }

            // Password (string) minLength
            if (this.Password != null && this.Password.Length < 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 8.", new [] { "Password" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
