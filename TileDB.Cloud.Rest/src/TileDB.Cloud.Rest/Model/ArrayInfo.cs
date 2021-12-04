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
    /// metadata of an array
    /// </summary>
    [DataContract]
    public partial class ArrayInfo :  IEquatable<ArrayInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets FileType
        /// </summary>
        [DataMember(Name="file_type", EmitDefaultValue=false)]
        public FileType? FileType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayInfo" /> class.
        /// </summary>
        /// <param name="id">unique id of registered array.</param>
        /// <param name="fileType">fileType.</param>
        /// <param name="fileProperties">map of file properties created for this array.</param>
        /// <param name="uri">uri of array.</param>
        /// <param name="_namespace">namespace array is in.</param>
        /// <param name="size">size in bytes of array.</param>
        /// <param name="lastAccessed">Datetime array was last accessed in UTC.</param>
        /// <param name="description">description of array.</param>
        /// <param name="name">name of array.</param>
        /// <param name="allowedActions">list of actions user is allowed to do on this array.</param>
        /// <param name="pricing">list of pricing created for this array.</param>
        /// <param name="subscriptions">list of subscriptions created for this array.</param>
        /// <param name="logo">logo (base64 encoded) for the array. Optional.</param>
        /// <param name="accessCredentialsName">the name of the access credentials to use. if unset, the default credentials will be used.</param>
        /// <param name="type">Array type (dense, key-value, sparse).</param>
        /// <param name="shareCount">number of unique namespaces this array is shared with.</param>
        /// <param name="publicShare">Suggests if the array was shared to public by owner.</param>
        /// <param name="tiledbUri">uri for access through TileDB cloud.</param>
        /// <param name="tags">optional tags for array.</param>
        /// <param name="licenseId">License identifier from SPDX License List or Custom.</param>
        /// <param name="licenseText">License text.</param>
        /// <param name="readOnly">Suggests if the array is in read_only mode.</param>
        /// <param name="isFavorite">Indicates whether the array is in user favorites.</param>
        /// <param name="favoriteUuid">The favorite UUID if the array if is_favorite is true.</param>
        public ArrayInfo(string id = default(string), FileType? fileType = default(FileType?), Dictionary<string, string> fileProperties = default(Dictionary<string, string>), string uri = default(string), string _namespace = default(string), decimal size = default(decimal), DateTime lastAccessed = default(DateTime), string description = default(string), string name = default(string), List<ArrayActions> allowedActions = default(List<ArrayActions>), List<Pricing> pricing = default(List<Pricing>), List<Subscription> subscriptions = default(List<Subscription>), string logo = default(string), string accessCredentialsName = default(string), string type = default(string), decimal shareCount = default(decimal), bool publicShare = default(bool), string tiledbUri = default(string), List<string> tags = default(List<string>), string licenseId = default(string), string licenseText = default(string), bool? readOnly = default(bool?), bool isFavorite = default(bool), string favoriteUuid = default(string))
        {
            this.Description = description;
            this.ReadOnly = readOnly;
            this.Id = id;
            this.FileType = fileType;
            this.FileProperties = fileProperties;
            this.Uri = uri;
            this.Namespace = _namespace;
            this.Size = size;
            this.LastAccessed = lastAccessed;
            this.Description = description;
            this.Name = name;
            this.AllowedActions = allowedActions;
            this.Pricing = pricing;
            this.Subscriptions = subscriptions;
            this.Logo = logo;
            this.AccessCredentialsName = accessCredentialsName;
            this.Type = type;
            this.ShareCount = shareCount;
            this.PublicShare = publicShare;
            this.TiledbUri = tiledbUri;
            this.Tags = tags;
            this.LicenseId = licenseId;
            this.LicenseText = licenseText;
            this.ReadOnly = readOnly;
            this.IsFavorite = isFavorite;
            this.FavoriteUuid = favoriteUuid;
        }

        /// <summary>
        /// unique id of registered array
        /// </summary>
        /// <value>unique id of registered array</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// map of file properties created for this array
        /// </summary>
        /// <value>map of file properties created for this array</value>
        [DataMember(Name="file_properties", EmitDefaultValue=false)]
        public Dictionary<string, string> FileProperties { get; set; }

        /// <summary>
        /// uri of array
        /// </summary>
        /// <value>uri of array</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// namespace array is in
        /// </summary>
        /// <value>namespace array is in</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// size in bytes of array
        /// </summary>
        /// <value>size in bytes of array</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal Size { get; set; }

        /// <summary>
        /// Datetime array was last accessed in UTC
        /// </summary>
        /// <value>Datetime array was last accessed in UTC</value>
        [DataMember(Name="last_accessed", EmitDefaultValue=false)]
        public DateTime LastAccessed { get; set; }

        /// <summary>
        /// description of array
        /// </summary>
        /// <value>description of array</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// name of array
        /// </summary>
        /// <value>name of array</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// list of actions user is allowed to do on this array
        /// </summary>
        /// <value>list of actions user is allowed to do on this array</value>
        [DataMember(Name="allowed_actions", EmitDefaultValue=false)]
        public List<ArrayActions> AllowedActions { get; set; }

        /// <summary>
        /// list of pricing created for this array
        /// </summary>
        /// <value>list of pricing created for this array</value>
        [DataMember(Name="pricing", EmitDefaultValue=false)]
        public List<Pricing> Pricing { get; set; }

        /// <summary>
        /// list of subscriptions created for this array
        /// </summary>
        /// <value>list of subscriptions created for this array</value>
        [DataMember(Name="subscriptions", EmitDefaultValue=false)]
        public List<Subscription> Subscriptions { get; set; }

        /// <summary>
        /// logo (base64 encoded) for the array. Optional
        /// </summary>
        /// <value>logo (base64 encoded) for the array. Optional</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// the name of the access credentials to use. if unset, the default credentials will be used
        /// </summary>
        /// <value>the name of the access credentials to use. if unset, the default credentials will be used</value>
        [DataMember(Name="access_credentials_name", EmitDefaultValue=false)]
        public string AccessCredentialsName { get; set; }

        /// <summary>
        /// Array type (dense, key-value, sparse)
        /// </summary>
        /// <value>Array type (dense, key-value, sparse)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// number of unique namespaces this array is shared with
        /// </summary>
        /// <value>number of unique namespaces this array is shared with</value>
        [DataMember(Name="share_count", EmitDefaultValue=false)]
        public decimal ShareCount { get; set; }

        /// <summary>
        /// Suggests if the array was shared to public by owner
        /// </summary>
        /// <value>Suggests if the array was shared to public by owner</value>
        [DataMember(Name="public_share", EmitDefaultValue=false)]
        public bool PublicShare { get; set; }

        /// <summary>
        /// Depends on the namespace asking, denotes the existence of subscription of namespace to this array
        /// </summary>
        /// <value>Depends on the namespace asking, denotes the existence of subscription of namespace to this array</value>
        [DataMember(Name="namespace_subscribed", EmitDefaultValue=false)]
        public bool NamespaceSubscribed { get; private set; }

        /// <summary>
        /// uri for access through TileDB cloud
        /// </summary>
        /// <value>uri for access through TileDB cloud</value>
        [DataMember(Name="tiledb_uri", EmitDefaultValue=false)]
        public string TiledbUri { get; set; }

        /// <summary>
        /// optional tags for array
        /// </summary>
        /// <value>optional tags for array</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// License identifier from SPDX License List or Custom
        /// </summary>
        /// <value>License identifier from SPDX License List or Custom</value>
        [DataMember(Name="license_id", EmitDefaultValue=false)]
        public string LicenseId { get; set; }

        /// <summary>
        /// License text
        /// </summary>
        /// <value>License text</value>
        [DataMember(Name="license_text", EmitDefaultValue=false)]
        public string LicenseText { get; set; }

        /// <summary>
        /// Suggests if the array is in read_only mode
        /// </summary>
        /// <value>Suggests if the array is in read_only mode</value>
        [DataMember(Name="read_only", EmitDefaultValue=true)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Indicates whether the array is in user favorites
        /// </summary>
        /// <value>Indicates whether the array is in user favorites</value>
        [DataMember(Name="is_favorite", EmitDefaultValue=false)]
        public bool IsFavorite { get; set; }

        /// <summary>
        /// The favorite UUID if the array if is_favorite is true
        /// </summary>
        /// <value>The favorite UUID if the array if is_favorite is true</value>
        [DataMember(Name="favorite_uuid", EmitDefaultValue=false)]
        public string FavoriteUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArrayInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  FileProperties: ").Append(FileProperties).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  LastAccessed: ").Append(LastAccessed).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AllowedActions: ").Append(AllowedActions).Append("\n");
            sb.Append("  Pricing: ").Append(Pricing).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  AccessCredentialsName: ").Append(AccessCredentialsName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ShareCount: ").Append(ShareCount).Append("\n");
            sb.Append("  PublicShare: ").Append(PublicShare).Append("\n");
            sb.Append("  NamespaceSubscribed: ").Append(NamespaceSubscribed).Append("\n");
            sb.Append("  TiledbUri: ").Append(TiledbUri).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
            sb.Append("  LicenseText: ").Append(LicenseText).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  IsFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  FavoriteUuid: ").Append(FavoriteUuid).Append("\n");
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
            return this.Equals(input as ArrayInfo);
        }

        /// <summary>
        /// Returns true if ArrayInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ArrayInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArrayInfo input)
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
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.FileProperties == input.FileProperties ||
                    this.FileProperties != null &&
                    input.FileProperties != null &&
                    this.FileProperties.SequenceEqual(input.FileProperties)
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.LastAccessed == input.LastAccessed ||
                    (this.LastAccessed != null &&
                    this.LastAccessed.Equals(input.LastAccessed))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AllowedActions == input.AllowedActions ||
                    this.AllowedActions != null &&
                    input.AllowedActions != null &&
                    this.AllowedActions.SequenceEqual(input.AllowedActions)
                ) && 
                (
                    this.Pricing == input.Pricing ||
                    this.Pricing != null &&
                    input.Pricing != null &&
                    this.Pricing.SequenceEqual(input.Pricing)
                ) && 
                (
                    this.Subscriptions == input.Subscriptions ||
                    this.Subscriptions != null &&
                    input.Subscriptions != null &&
                    this.Subscriptions.SequenceEqual(input.Subscriptions)
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.AccessCredentialsName == input.AccessCredentialsName ||
                    (this.AccessCredentialsName != null &&
                    this.AccessCredentialsName.Equals(input.AccessCredentialsName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ShareCount == input.ShareCount ||
                    (this.ShareCount != null &&
                    this.ShareCount.Equals(input.ShareCount))
                ) && 
                (
                    this.PublicShare == input.PublicShare ||
                    (this.PublicShare != null &&
                    this.PublicShare.Equals(input.PublicShare))
                ) && 
                (
                    this.NamespaceSubscribed == input.NamespaceSubscribed ||
                    (this.NamespaceSubscribed != null &&
                    this.NamespaceSubscribed.Equals(input.NamespaceSubscribed))
                ) && 
                (
                    this.TiledbUri == input.TiledbUri ||
                    (this.TiledbUri != null &&
                    this.TiledbUri.Equals(input.TiledbUri))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.LicenseId == input.LicenseId ||
                    (this.LicenseId != null &&
                    this.LicenseId.Equals(input.LicenseId))
                ) && 
                (
                    this.LicenseText == input.LicenseText ||
                    (this.LicenseText != null &&
                    this.LicenseText.Equals(input.LicenseText))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.IsFavorite == input.IsFavorite ||
                    (this.IsFavorite != null &&
                    this.IsFavorite.Equals(input.IsFavorite))
                ) && 
                (
                    this.FavoriteUuid == input.FavoriteUuid ||
                    (this.FavoriteUuid != null &&
                    this.FavoriteUuid.Equals(input.FavoriteUuid))
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
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.FileProperties != null)
                    hashCode = hashCode * 59 + this.FileProperties.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.LastAccessed != null)
                    hashCode = hashCode * 59 + this.LastAccessed.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AllowedActions != null)
                    hashCode = hashCode * 59 + this.AllowedActions.GetHashCode();
                if (this.Pricing != null)
                    hashCode = hashCode * 59 + this.Pricing.GetHashCode();
                if (this.Subscriptions != null)
                    hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.AccessCredentialsName != null)
                    hashCode = hashCode * 59 + this.AccessCredentialsName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ShareCount != null)
                    hashCode = hashCode * 59 + this.ShareCount.GetHashCode();
                if (this.PublicShare != null)
                    hashCode = hashCode * 59 + this.PublicShare.GetHashCode();
                if (this.NamespaceSubscribed != null)
                    hashCode = hashCode * 59 + this.NamespaceSubscribed.GetHashCode();
                if (this.TiledbUri != null)
                    hashCode = hashCode * 59 + this.TiledbUri.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.LicenseId != null)
                    hashCode = hashCode * 59 + this.LicenseId.GetHashCode();
                if (this.LicenseText != null)
                    hashCode = hashCode * 59 + this.LicenseText.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.IsFavorite != null)
                    hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                if (this.FavoriteUuid != null)
                    hashCode = hashCode * 59 + this.FavoriteUuid.GetHashCode();
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
