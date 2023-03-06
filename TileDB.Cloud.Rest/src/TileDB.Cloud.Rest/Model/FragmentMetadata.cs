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
    /// Fragment Metadata
    /// </summary>
    [DataContract(Name = "FragmentMetadata")]
    public partial class FragmentMetadata : IEquatable<FragmentMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FragmentMetadata" /> class.
        /// </summary>
        /// <param name="fileSizes">fixed sizes.</param>
        /// <param name="fileVarSizes">var length sizes.</param>
        /// <param name="fileValiditySizes">validity sizes.</param>
        /// <param name="fragmentUri">fragmentUri.</param>
        /// <param name="hasTimestamps">hasTimestamps.</param>
        /// <param name="hasDeleteMeta">hasDeleteMeta.</param>
        /// <param name="sparseTileNum">sparseTileNum.</param>
        /// <param name="tileIndexBase">tileIndexBase.</param>
        /// <param name="tileOffsets">tileOffsets.</param>
        /// <param name="tileVarOffsets">tileVarOffsets.</param>
        /// <param name="tileVarSizes">tileVarSizes.</param>
        /// <param name="tileValidityOffsets">tileValidityOffsets.</param>
        /// <param name="tileMinBuffer">tileMinBuffer.</param>
        /// <param name="tileMinVarBuffer">tileMinVarBuffer.</param>
        /// <param name="tileMaxBuffer">tileMaxBuffer.</param>
        /// <param name="tileMaxVarBuffer">tileMaxVarBuffer.</param>
        /// <param name="tileSums">tileSums.</param>
        /// <param name="tileNullCounts">tileNullCounts.</param>
        /// <param name="fragmentMins">fragmentMins.</param>
        /// <param name="fragmentMaxs">fragmentMaxs.</param>
        /// <param name="fragmentSums">fragmentSums.</param>
        /// <param name="fragmentNullCounts">fragmentNullCounts.</param>
        /// <param name="version">version.</param>
        /// <param name="timestampRange">timestampRange.</param>
        /// <param name="lastTileCellNum">lastTileCellNum.</param>
        public FragmentMetadata(List<int> fileSizes = default(List<int>), List<int> fileVarSizes = default(List<int>), List<int> fileValiditySizes = default(List<int>), string fragmentUri = default(string), bool hasTimestamps = default(bool), bool hasDeleteMeta = default(bool), int sparseTileNum = default(int), int tileIndexBase = default(int), List<List<int>> tileOffsets = default(List<List<int>>), List<List<int>> tileVarOffsets = default(List<List<int>>), List<List<int>> tileVarSizes = default(List<List<int>>), List<List<int>> tileValidityOffsets = default(List<List<int>>), List<List<int>> tileMinBuffer = default(List<List<int>>), List<List<int>> tileMinVarBuffer = default(List<List<int>>), List<List<int>> tileMaxBuffer = default(List<List<int>>), List<List<int>> tileMaxVarBuffer = default(List<List<int>>), List<List<int>> tileSums = default(List<List<int>>), List<List<int>> tileNullCounts = default(List<List<int>>), List<List<int>> fragmentMins = default(List<List<int>>), List<List<int>> fragmentMaxs = default(List<List<int>>), List<int> fragmentSums = default(List<int>), List<int> fragmentNullCounts = default(List<int>), int version = default(int), List<int> timestampRange = default(List<int>), int lastTileCellNum = default(int))
        {
            this.FileSizes = fileSizes;
            this.FileVarSizes = fileVarSizes;
            this.FileValiditySizes = fileValiditySizes;
            this.FragmentUri = fragmentUri;
            this.HasTimestamps = hasTimestamps;
            this.HasDeleteMeta = hasDeleteMeta;
            this.SparseTileNum = sparseTileNum;
            this.TileIndexBase = tileIndexBase;
            this.TileOffsets = tileOffsets;
            this.TileVarOffsets = tileVarOffsets;
            this.TileVarSizes = tileVarSizes;
            this.TileValidityOffsets = tileValidityOffsets;
            this.TileMinBuffer = tileMinBuffer;
            this.TileMinVarBuffer = tileMinVarBuffer;
            this.TileMaxBuffer = tileMaxBuffer;
            this.TileMaxVarBuffer = tileMaxVarBuffer;
            this.TileSums = tileSums;
            this.TileNullCounts = tileNullCounts;
            this.FragmentMins = fragmentMins;
            this.FragmentMaxs = fragmentMaxs;
            this.FragmentSums = fragmentSums;
            this.FragmentNullCounts = fragmentNullCounts;
            this._Version = version;
            this.TimestampRange = timestampRange;
            this.LastTileCellNum = lastTileCellNum;
        }

        /// <summary>
        /// fixed sizes
        /// </summary>
        /// <value>fixed sizes</value>
        [DataMember(Name = "fileSizes", EmitDefaultValue = false)]
        public List<int> FileSizes { get; set; }

        /// <summary>
        /// var length sizes
        /// </summary>
        /// <value>var length sizes</value>
        [DataMember(Name = "fileVarSizes", EmitDefaultValue = false)]
        public List<int> FileVarSizes { get; set; }

        /// <summary>
        /// validity sizes
        /// </summary>
        /// <value>validity sizes</value>
        [DataMember(Name = "fileValiditySizes", EmitDefaultValue = false)]
        public List<int> FileValiditySizes { get; set; }

        /// <summary>
        /// Gets or Sets FragmentUri
        /// </summary>
        [DataMember(Name = "fragmentUri", EmitDefaultValue = false)]
        public string FragmentUri { get; set; }

        /// <summary>
        /// Gets or Sets HasTimestamps
        /// </summary>
        [DataMember(Name = "hasTimestamps", EmitDefaultValue = true)]
        public bool HasTimestamps { get; set; }

        /// <summary>
        /// Gets or Sets HasDeleteMeta
        /// </summary>
        [DataMember(Name = "hasDeleteMeta", EmitDefaultValue = true)]
        public bool HasDeleteMeta { get; set; }

        /// <summary>
        /// Gets or Sets SparseTileNum
        /// </summary>
        [DataMember(Name = "sparseTileNum", EmitDefaultValue = false)]
        public int SparseTileNum { get; set; }

        /// <summary>
        /// Gets or Sets TileIndexBase
        /// </summary>
        [DataMember(Name = "tileIndexBase", EmitDefaultValue = false)]
        public int TileIndexBase { get; set; }

        /// <summary>
        /// Gets or Sets TileOffsets
        /// </summary>
        [DataMember(Name = "tileOffsets", EmitDefaultValue = false)]
        public List<List<int>> TileOffsets { get; set; }

        /// <summary>
        /// Gets or Sets TileVarOffsets
        /// </summary>
        [DataMember(Name = "tileVarOffsets", EmitDefaultValue = false)]
        public List<List<int>> TileVarOffsets { get; set; }

        /// <summary>
        /// Gets or Sets TileVarSizes
        /// </summary>
        [DataMember(Name = "tileVarSizes", EmitDefaultValue = false)]
        public List<List<int>> TileVarSizes { get; set; }

        /// <summary>
        /// Gets or Sets TileValidityOffsets
        /// </summary>
        [DataMember(Name = "tileValidityOffsets", EmitDefaultValue = false)]
        public List<List<int>> TileValidityOffsets { get; set; }

        /// <summary>
        /// Gets or Sets TileMinBuffer
        /// </summary>
        [DataMember(Name = "tileMinBuffer", EmitDefaultValue = false)]
        public List<List<int>> TileMinBuffer { get; set; }

        /// <summary>
        /// Gets or Sets TileMinVarBuffer
        /// </summary>
        [DataMember(Name = "tileMinVarBuffer", EmitDefaultValue = false)]
        public List<List<int>> TileMinVarBuffer { get; set; }

        /// <summary>
        /// Gets or Sets TileMaxBuffer
        /// </summary>
        [DataMember(Name = "tileMaxBuffer", EmitDefaultValue = false)]
        public List<List<int>> TileMaxBuffer { get; set; }

        /// <summary>
        /// Gets or Sets TileMaxVarBuffer
        /// </summary>
        [DataMember(Name = "tileMaxVarBuffer", EmitDefaultValue = false)]
        public List<List<int>> TileMaxVarBuffer { get; set; }

        /// <summary>
        /// Gets or Sets TileSums
        /// </summary>
        [DataMember(Name = "tileSums", EmitDefaultValue = false)]
        public List<List<int>> TileSums { get; set; }

        /// <summary>
        /// Gets or Sets TileNullCounts
        /// </summary>
        [DataMember(Name = "tileNullCounts", EmitDefaultValue = false)]
        public List<List<int>> TileNullCounts { get; set; }

        /// <summary>
        /// Gets or Sets FragmentMins
        /// </summary>
        [DataMember(Name = "fragmentMins", EmitDefaultValue = false)]
        public List<List<int>> FragmentMins { get; set; }

        /// <summary>
        /// Gets or Sets FragmentMaxs
        /// </summary>
        [DataMember(Name = "fragmentMaxs", EmitDefaultValue = false)]
        public List<List<int>> FragmentMaxs { get; set; }

        /// <summary>
        /// Gets or Sets FragmentSums
        /// </summary>
        [DataMember(Name = "fragmentSums", EmitDefaultValue = false)]
        public List<int> FragmentSums { get; set; }

        /// <summary>
        /// Gets or Sets FragmentNullCounts
        /// </summary>
        [DataMember(Name = "fragmentNullCounts", EmitDefaultValue = false)]
        public List<int> FragmentNullCounts { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets TimestampRange
        /// </summary>
        [DataMember(Name = "timestampRange", EmitDefaultValue = false)]
        public List<int> TimestampRange { get; set; }

        /// <summary>
        /// Gets or Sets LastTileCellNum
        /// </summary>
        [DataMember(Name = "lastTileCellNum", EmitDefaultValue = false)]
        public int LastTileCellNum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FragmentMetadata {\n");
            sb.Append("  FileSizes: ").Append(FileSizes).Append("\n");
            sb.Append("  FileVarSizes: ").Append(FileVarSizes).Append("\n");
            sb.Append("  FileValiditySizes: ").Append(FileValiditySizes).Append("\n");
            sb.Append("  FragmentUri: ").Append(FragmentUri).Append("\n");
            sb.Append("  HasTimestamps: ").Append(HasTimestamps).Append("\n");
            sb.Append("  HasDeleteMeta: ").Append(HasDeleteMeta).Append("\n");
            sb.Append("  SparseTileNum: ").Append(SparseTileNum).Append("\n");
            sb.Append("  TileIndexBase: ").Append(TileIndexBase).Append("\n");
            sb.Append("  TileOffsets: ").Append(TileOffsets).Append("\n");
            sb.Append("  TileVarOffsets: ").Append(TileVarOffsets).Append("\n");
            sb.Append("  TileVarSizes: ").Append(TileVarSizes).Append("\n");
            sb.Append("  TileValidityOffsets: ").Append(TileValidityOffsets).Append("\n");
            sb.Append("  TileMinBuffer: ").Append(TileMinBuffer).Append("\n");
            sb.Append("  TileMinVarBuffer: ").Append(TileMinVarBuffer).Append("\n");
            sb.Append("  TileMaxBuffer: ").Append(TileMaxBuffer).Append("\n");
            sb.Append("  TileMaxVarBuffer: ").Append(TileMaxVarBuffer).Append("\n");
            sb.Append("  TileSums: ").Append(TileSums).Append("\n");
            sb.Append("  TileNullCounts: ").Append(TileNullCounts).Append("\n");
            sb.Append("  FragmentMins: ").Append(FragmentMins).Append("\n");
            sb.Append("  FragmentMaxs: ").Append(FragmentMaxs).Append("\n");
            sb.Append("  FragmentSums: ").Append(FragmentSums).Append("\n");
            sb.Append("  FragmentNullCounts: ").Append(FragmentNullCounts).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  TimestampRange: ").Append(TimestampRange).Append("\n");
            sb.Append("  LastTileCellNum: ").Append(LastTileCellNum).Append("\n");
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
            return this.Equals(input as FragmentMetadata);
        }

        /// <summary>
        /// Returns true if FragmentMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of FragmentMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FragmentMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileSizes == input.FileSizes ||
                    this.FileSizes != null &&
                    input.FileSizes != null &&
                    this.FileSizes.SequenceEqual(input.FileSizes)
                ) && 
                (
                    this.FileVarSizes == input.FileVarSizes ||
                    this.FileVarSizes != null &&
                    input.FileVarSizes != null &&
                    this.FileVarSizes.SequenceEqual(input.FileVarSizes)
                ) && 
                (
                    this.FileValiditySizes == input.FileValiditySizes ||
                    this.FileValiditySizes != null &&
                    input.FileValiditySizes != null &&
                    this.FileValiditySizes.SequenceEqual(input.FileValiditySizes)
                ) && 
                (
                    this.FragmentUri == input.FragmentUri ||
                    (this.FragmentUri != null &&
                    this.FragmentUri.Equals(input.FragmentUri))
                ) && 
                (
                    this.HasTimestamps == input.HasTimestamps ||
                    this.HasTimestamps.Equals(input.HasTimestamps)
                ) && 
                (
                    this.HasDeleteMeta == input.HasDeleteMeta ||
                    this.HasDeleteMeta.Equals(input.HasDeleteMeta)
                ) && 
                (
                    this.SparseTileNum == input.SparseTileNum ||
                    this.SparseTileNum.Equals(input.SparseTileNum)
                ) && 
                (
                    this.TileIndexBase == input.TileIndexBase ||
                    this.TileIndexBase.Equals(input.TileIndexBase)
                ) && 
                (
                    this.TileOffsets == input.TileOffsets ||
                    this.TileOffsets != null &&
                    input.TileOffsets != null &&
                    this.TileOffsets.SequenceEqual(input.TileOffsets)
                ) && 
                (
                    this.TileVarOffsets == input.TileVarOffsets ||
                    this.TileVarOffsets != null &&
                    input.TileVarOffsets != null &&
                    this.TileVarOffsets.SequenceEqual(input.TileVarOffsets)
                ) && 
                (
                    this.TileVarSizes == input.TileVarSizes ||
                    this.TileVarSizes != null &&
                    input.TileVarSizes != null &&
                    this.TileVarSizes.SequenceEqual(input.TileVarSizes)
                ) && 
                (
                    this.TileValidityOffsets == input.TileValidityOffsets ||
                    this.TileValidityOffsets != null &&
                    input.TileValidityOffsets != null &&
                    this.TileValidityOffsets.SequenceEqual(input.TileValidityOffsets)
                ) && 
                (
                    this.TileMinBuffer == input.TileMinBuffer ||
                    this.TileMinBuffer != null &&
                    input.TileMinBuffer != null &&
                    this.TileMinBuffer.SequenceEqual(input.TileMinBuffer)
                ) && 
                (
                    this.TileMinVarBuffer == input.TileMinVarBuffer ||
                    this.TileMinVarBuffer != null &&
                    input.TileMinVarBuffer != null &&
                    this.TileMinVarBuffer.SequenceEqual(input.TileMinVarBuffer)
                ) && 
                (
                    this.TileMaxBuffer == input.TileMaxBuffer ||
                    this.TileMaxBuffer != null &&
                    input.TileMaxBuffer != null &&
                    this.TileMaxBuffer.SequenceEqual(input.TileMaxBuffer)
                ) && 
                (
                    this.TileMaxVarBuffer == input.TileMaxVarBuffer ||
                    this.TileMaxVarBuffer != null &&
                    input.TileMaxVarBuffer != null &&
                    this.TileMaxVarBuffer.SequenceEqual(input.TileMaxVarBuffer)
                ) && 
                (
                    this.TileSums == input.TileSums ||
                    this.TileSums != null &&
                    input.TileSums != null &&
                    this.TileSums.SequenceEqual(input.TileSums)
                ) && 
                (
                    this.TileNullCounts == input.TileNullCounts ||
                    this.TileNullCounts != null &&
                    input.TileNullCounts != null &&
                    this.TileNullCounts.SequenceEqual(input.TileNullCounts)
                ) && 
                (
                    this.FragmentMins == input.FragmentMins ||
                    this.FragmentMins != null &&
                    input.FragmentMins != null &&
                    this.FragmentMins.SequenceEqual(input.FragmentMins)
                ) && 
                (
                    this.FragmentMaxs == input.FragmentMaxs ||
                    this.FragmentMaxs != null &&
                    input.FragmentMaxs != null &&
                    this.FragmentMaxs.SequenceEqual(input.FragmentMaxs)
                ) && 
                (
                    this.FragmentSums == input.FragmentSums ||
                    this.FragmentSums != null &&
                    input.FragmentSums != null &&
                    this.FragmentSums.SequenceEqual(input.FragmentSums)
                ) && 
                (
                    this.FragmentNullCounts == input.FragmentNullCounts ||
                    this.FragmentNullCounts != null &&
                    input.FragmentNullCounts != null &&
                    this.FragmentNullCounts.SequenceEqual(input.FragmentNullCounts)
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.TimestampRange == input.TimestampRange ||
                    this.TimestampRange != null &&
                    input.TimestampRange != null &&
                    this.TimestampRange.SequenceEqual(input.TimestampRange)
                ) && 
                (
                    this.LastTileCellNum == input.LastTileCellNum ||
                    this.LastTileCellNum.Equals(input.LastTileCellNum)
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
                if (this.FileSizes != null)
                {
                    hashCode = (hashCode * 59) + this.FileSizes.GetHashCode();
                }
                if (this.FileVarSizes != null)
                {
                    hashCode = (hashCode * 59) + this.FileVarSizes.GetHashCode();
                }
                if (this.FileValiditySizes != null)
                {
                    hashCode = (hashCode * 59) + this.FileValiditySizes.GetHashCode();
                }
                if (this.FragmentUri != null)
                {
                    hashCode = (hashCode * 59) + this.FragmentUri.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasTimestamps.GetHashCode();
                hashCode = (hashCode * 59) + this.HasDeleteMeta.GetHashCode();
                hashCode = (hashCode * 59) + this.SparseTileNum.GetHashCode();
                hashCode = (hashCode * 59) + this.TileIndexBase.GetHashCode();
                if (this.TileOffsets != null)
                {
                    hashCode = (hashCode * 59) + this.TileOffsets.GetHashCode();
                }
                if (this.TileVarOffsets != null)
                {
                    hashCode = (hashCode * 59) + this.TileVarOffsets.GetHashCode();
                }
                if (this.TileVarSizes != null)
                {
                    hashCode = (hashCode * 59) + this.TileVarSizes.GetHashCode();
                }
                if (this.TileValidityOffsets != null)
                {
                    hashCode = (hashCode * 59) + this.TileValidityOffsets.GetHashCode();
                }
                if (this.TileMinBuffer != null)
                {
                    hashCode = (hashCode * 59) + this.TileMinBuffer.GetHashCode();
                }
                if (this.TileMinVarBuffer != null)
                {
                    hashCode = (hashCode * 59) + this.TileMinVarBuffer.GetHashCode();
                }
                if (this.TileMaxBuffer != null)
                {
                    hashCode = (hashCode * 59) + this.TileMaxBuffer.GetHashCode();
                }
                if (this.TileMaxVarBuffer != null)
                {
                    hashCode = (hashCode * 59) + this.TileMaxVarBuffer.GetHashCode();
                }
                if (this.TileSums != null)
                {
                    hashCode = (hashCode * 59) + this.TileSums.GetHashCode();
                }
                if (this.TileNullCounts != null)
                {
                    hashCode = (hashCode * 59) + this.TileNullCounts.GetHashCode();
                }
                if (this.FragmentMins != null)
                {
                    hashCode = (hashCode * 59) + this.FragmentMins.GetHashCode();
                }
                if (this.FragmentMaxs != null)
                {
                    hashCode = (hashCode * 59) + this.FragmentMaxs.GetHashCode();
                }
                if (this.FragmentSums != null)
                {
                    hashCode = (hashCode * 59) + this.FragmentSums.GetHashCode();
                }
                if (this.FragmentNullCounts != null)
                {
                    hashCode = (hashCode * 59) + this.FragmentNullCounts.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                if (this.TimestampRange != null)
                {
                    hashCode = (hashCode * 59) + this.TimestampRange.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LastTileCellNum.GetHashCode();
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
