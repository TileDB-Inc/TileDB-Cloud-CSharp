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
    /// List of values that InvitationType can take
    /// </summary>
    /// <value>List of values that InvitationType can take</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InvitationType
    {
        /// <summary>
        /// Enum ARRAYSHARE for value: ARRAY_SHARE
        /// </summary>
        [EnumMember(Value = "ARRAY_SHARE")]
        ARRAYSHARE = 1,

        /// <summary>
        /// Enum JOINORGANIZATION for value: JOIN_ORGANIZATION
        /// </summary>
        [EnumMember(Value = "JOIN_ORGANIZATION")]
        JOINORGANIZATION = 2

    }

}
