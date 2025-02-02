/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: devex-public@okta.com
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
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Defines UserSchemaAttributeMasterType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class UserSchemaAttributeMasterType : StringEnum
    {
        /// <summary>
        /// StringEnum UserSchemaAttributeMasterType for value: OKTA
        /// </summary>
        public static UserSchemaAttributeMasterType OKTA = new UserSchemaAttributeMasterType("OKTA");
        /// <summary>
        /// StringEnum UserSchemaAttributeMasterType for value: OVERRIDE
        /// </summary>
        public static UserSchemaAttributeMasterType OVERRIDE = new UserSchemaAttributeMasterType("OVERRIDE");
        /// <summary>
        /// StringEnum UserSchemaAttributeMasterType for value: PROFILE_MASTER
        /// </summary>
        public static UserSchemaAttributeMasterType PROFILEMASTER = new UserSchemaAttributeMasterType("PROFILE_MASTER");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="UserSchemaAttributeMasterType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator UserSchemaAttributeMasterType(string value) => new UserSchemaAttributeMasterType(value);

        /// <summary>
        /// Creates a new <see cref="UserSchemaAttributeMasterType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public UserSchemaAttributeMasterType(string value)
            : base(value)
        {
        }
    }


}
