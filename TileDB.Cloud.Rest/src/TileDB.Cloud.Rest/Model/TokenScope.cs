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
    /// An api token scope available for creation
    /// </summary>
    /// <value>An api token scope available for creation</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TokenScope
    {
        /// <summary>
        /// Enum Passwordreset for value: password_reset
        /// </summary>
        [EnumMember(Value = "password_reset")]
        Passwordreset = 1,

        /// <summary>
        /// Enum Confirmemail for value: confirm_email
        /// </summary>
        [EnumMember(Value = "confirm_email")]
        Confirmemail = 2,

        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 3,

        /// <summary>
        /// Enum Userread for value: user:read
        /// </summary>
        [EnumMember(Value = "user:read")]
        Userread = 4,

        /// <summary>
        /// Enum UserreadWrite for value: user:read-write
        /// </summary>
        [EnumMember(Value = "user:read-write")]
        UserreadWrite = 5,

        /// <summary>
        /// Enum Useradmin for value: user:admin
        /// </summary>
        [EnumMember(Value = "user:admin")]
        Useradmin = 6,

        /// <summary>
        /// Enum Arrayread for value: array:read
        /// </summary>
        [EnumMember(Value = "array:read")]
        Arrayread = 7,

        /// <summary>
        /// Enum ArrayreadWrite for value: array:read-write
        /// </summary>
        [EnumMember(Value = "array:read-write")]
        ArrayreadWrite = 8,

        /// <summary>
        /// Enum Arrayadmin for value: array:admin
        /// </summary>
        [EnumMember(Value = "array:admin")]
        Arrayadmin = 9,

        /// <summary>
        /// Enum Organizationread for value: organization:read
        /// </summary>
        [EnumMember(Value = "organization:read")]
        Organizationread = 10,

        /// <summary>
        /// Enum OrganizationreadWrite for value: organization:read-write
        /// </summary>
        [EnumMember(Value = "organization:read-write")]
        OrganizationreadWrite = 11,

        /// <summary>
        /// Enum Organizationadmin for value: organization:admin
        /// </summary>
        [EnumMember(Value = "organization:admin")]
        Organizationadmin = 12,

        /// <summary>
        /// Enum Groupread for value: group:read
        /// </summary>
        [EnumMember(Value = "group:read")]
        Groupread = 13,

        /// <summary>
        /// Enum GroupreadWrite for value: group:read-write
        /// </summary>
        [EnumMember(Value = "group:read-write")]
        GroupreadWrite = 14,

        /// <summary>
        /// Enum Groupadmin for value: group:admin
        /// </summary>
        [EnumMember(Value = "group:admin")]
        Groupadmin = 15

    }

}
