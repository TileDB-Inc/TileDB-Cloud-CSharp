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
    /// Pricing created by converting an array to product
    /// </summary>
    [DataContract]
    public partial class Pricing :  IEquatable<Pricing>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PricingType
        /// </summary>
        [DataMember(Name="pricing_type", EmitDefaultValue=false)]
        public PricingType? PricingType { get; set; }
        /// <summary>
        /// Gets or Sets ProductUnitLabel
        /// </summary>
        [DataMember(Name="product_unit_label", EmitDefaultValue=false)]
        public PricingUnitLabel? ProductUnitLabel { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public PricingCurrency? Currency { get; set; }
        /// <summary>
        /// Gets or Sets AggregateUsage
        /// </summary>
        [DataMember(Name="aggregate_usage", EmitDefaultValue=false)]
        public PricingAggregateUsage? AggregateUsage { get; set; }
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public PricingInterval? Interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        /// <param name="id">Unique ID of plan as defined by Stripe.</param>
        /// <param name="arrayUuid">Unique ID of registered array.</param>
        /// <param name="pricingName">Name of pricing.</param>
        /// <param name="pricingType">pricingType.</param>
        /// <param name="productName">Name of product.</param>
        /// <param name="productStatementDescriptor">Extra information about a product which will appear on the credit card statement of the customer.</param>
        /// <param name="productUnitLabel">productUnitLabel.</param>
        /// <param name="currency">currency.</param>
        /// <param name="aggregateUsage">aggregateUsage.</param>
        /// <param name="interval">interval.</param>
        /// <param name="dividedBy">Group of n product unit labels.</param>
        /// <param name="charge">Price in cents (decimal) per unitlabel.</param>
        /// <param name="activated">If pricing is activated.</param>
        public Pricing(string id = default(string), string arrayUuid = default(string), string pricingName = default(string), PricingType? pricingType = default(PricingType?), string productName = default(string), string productStatementDescriptor = default(string), PricingUnitLabel? productUnitLabel = default(PricingUnitLabel?), PricingCurrency? currency = default(PricingCurrency?), PricingAggregateUsage? aggregateUsage = default(PricingAggregateUsage?), PricingInterval? interval = default(PricingInterval?), long dividedBy = default(long), double charge = default(double), bool activated = default(bool))
        {
            this.Id = id;
            this.ArrayUuid = arrayUuid;
            this.PricingName = pricingName;
            this.PricingType = pricingType;
            this.ProductName = productName;
            this.ProductStatementDescriptor = productStatementDescriptor;
            this.ProductUnitLabel = productUnitLabel;
            this.Currency = currency;
            this.AggregateUsage = aggregateUsage;
            this.Interval = interval;
            this.DividedBy = dividedBy;
            this.Charge = charge;
            this.Activated = activated;
        }

        /// <summary>
        /// Unique ID of plan as defined by Stripe
        /// </summary>
        /// <value>Unique ID of plan as defined by Stripe</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Unique ID of registered array
        /// </summary>
        /// <value>Unique ID of registered array</value>
        [DataMember(Name="array_uuid", EmitDefaultValue=false)]
        public string ArrayUuid { get; set; }

        /// <summary>
        /// Name of pricing
        /// </summary>
        /// <value>Name of pricing</value>
        [DataMember(Name="pricing_name", EmitDefaultValue=false)]
        public string PricingName { get; set; }


        /// <summary>
        /// Name of product
        /// </summary>
        /// <value>Name of product</value>
        [DataMember(Name="product_name", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Extra information about a product which will appear on the credit card statement of the customer
        /// </summary>
        /// <value>Extra information about a product which will appear on the credit card statement of the customer</value>
        [DataMember(Name="product_statement_descriptor", EmitDefaultValue=false)]
        public string ProductStatementDescriptor { get; set; }





        /// <summary>
        /// Group of n product unit labels
        /// </summary>
        /// <value>Group of n product unit labels</value>
        [DataMember(Name="divided_by", EmitDefaultValue=false)]
        public long DividedBy { get; set; }

        /// <summary>
        /// Price in cents (decimal) per unitlabel
        /// </summary>
        /// <value>Price in cents (decimal) per unitlabel</value>
        [DataMember(Name="charge", EmitDefaultValue=false)]
        public double Charge { get; set; }

        /// <summary>
        /// If pricing is activated
        /// </summary>
        /// <value>If pricing is activated</value>
        [DataMember(Name="activated", EmitDefaultValue=false)]
        public bool Activated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pricing {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ArrayUuid: ").Append(ArrayUuid).Append("\n");
            sb.Append("  PricingName: ").Append(PricingName).Append("\n");
            sb.Append("  PricingType: ").Append(PricingType).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductStatementDescriptor: ").Append(ProductStatementDescriptor).Append("\n");
            sb.Append("  ProductUnitLabel: ").Append(ProductUnitLabel).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AggregateUsage: ").Append(AggregateUsage).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  DividedBy: ").Append(DividedBy).Append("\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("  Activated: ").Append(Activated).Append("\n");
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
            return this.Equals(input as Pricing);
        }

        /// <summary>
        /// Returns true if Pricing instances are equal
        /// </summary>
        /// <param name="input">Instance of Pricing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pricing input)
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
                    this.ArrayUuid == input.ArrayUuid ||
                    (this.ArrayUuid != null &&
                    this.ArrayUuid.Equals(input.ArrayUuid))
                ) && 
                (
                    this.PricingName == input.PricingName ||
                    (this.PricingName != null &&
                    this.PricingName.Equals(input.PricingName))
                ) && 
                (
                    this.PricingType == input.PricingType ||
                    (this.PricingType != null &&
                    this.PricingType.Equals(input.PricingType))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.ProductStatementDescriptor == input.ProductStatementDescriptor ||
                    (this.ProductStatementDescriptor != null &&
                    this.ProductStatementDescriptor.Equals(input.ProductStatementDescriptor))
                ) && 
                (
                    this.ProductUnitLabel == input.ProductUnitLabel ||
                    (this.ProductUnitLabel != null &&
                    this.ProductUnitLabel.Equals(input.ProductUnitLabel))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.AggregateUsage == input.AggregateUsage ||
                    (this.AggregateUsage != null &&
                    this.AggregateUsage.Equals(input.AggregateUsage))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.DividedBy == input.DividedBy ||
                    (this.DividedBy != null &&
                    this.DividedBy.Equals(input.DividedBy))
                ) && 
                (
                    this.Charge == input.Charge ||
                    (this.Charge != null &&
                    this.Charge.Equals(input.Charge))
                ) && 
                (
                    this.Activated == input.Activated ||
                    (this.Activated != null &&
                    this.Activated.Equals(input.Activated))
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
                if (this.ArrayUuid != null)
                    hashCode = hashCode * 59 + this.ArrayUuid.GetHashCode();
                if (this.PricingName != null)
                    hashCode = hashCode * 59 + this.PricingName.GetHashCode();
                if (this.PricingType != null)
                    hashCode = hashCode * 59 + this.PricingType.GetHashCode();
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.ProductStatementDescriptor != null)
                    hashCode = hashCode * 59 + this.ProductStatementDescriptor.GetHashCode();
                if (this.ProductUnitLabel != null)
                    hashCode = hashCode * 59 + this.ProductUnitLabel.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.AggregateUsage != null)
                    hashCode = hashCode * 59 + this.AggregateUsage.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.DividedBy != null)
                    hashCode = hashCode * 59 + this.DividedBy.GetHashCode();
                if (this.Charge != null)
                    hashCode = hashCode * 59 + this.Charge.GetHashCode();
                if (this.Activated != null)
                    hashCode = hashCode * 59 + this.Activated.GetHashCode();
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
