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
    /// Specifies a usage aggregation strategy for pricings of usage_type&#x3D;metered
    /// </summary>
    /// <value>Specifies a usage aggregation strategy for pricings of usage_type&#x3D;metered</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PricingAggregateUsage
    {
        /// <summary>
        /// Enum Sum for value: sum
        /// </summary>
        [EnumMember(Value = "sum")]
        Sum = 1

    }

}
