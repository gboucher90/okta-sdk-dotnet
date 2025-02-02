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
    /// Defines DomainCertificateSourceType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class DomainCertificateSourceType : StringEnum
    {
        /// <summary>
        /// StringEnum DomainCertificateSourceType for value: MANUAL
        /// </summary>
        public static DomainCertificateSourceType MANUAL = new DomainCertificateSourceType("MANUAL");
        /// <summary>
        /// StringEnum DomainCertificateSourceType for value: OKTA_MANAGED
        /// </summary>
        public static DomainCertificateSourceType OKTAMANAGED = new DomainCertificateSourceType("OKTA_MANAGED");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="DomainCertificateSourceType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator DomainCertificateSourceType(string value) => new DomainCertificateSourceType(value);

        /// <summary>
        /// Creates a new <see cref="DomainCertificateSourceType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public DomainCertificateSourceType(string value)
            : base(value)
        {
        }
    }


}
