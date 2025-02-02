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
    /// Defines UserSchemaAttributeScope
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class UserSchemaAttributeScope : StringEnum
    {
        /// <summary>
        /// StringEnum UserSchemaAttributeScope for value: NONE
        /// </summary>
        public static UserSchemaAttributeScope NONE = new UserSchemaAttributeScope("NONE");
        /// <summary>
        /// StringEnum UserSchemaAttributeScope for value: SELF
        /// </summary>
        public static UserSchemaAttributeScope SELF = new UserSchemaAttributeScope("SELF");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="UserSchemaAttributeScope"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator UserSchemaAttributeScope(string value) => new UserSchemaAttributeScope(value);

        /// <summary>
        /// Creates a new <see cref="UserSchemaAttributeScope"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public UserSchemaAttributeScope(string value)
            : base(value)
        {
        }
    }


}
