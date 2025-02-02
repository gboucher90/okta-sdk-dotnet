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
    /// Template: ModelGeneric
    /// CapabilitiesCreateObject
    /// </summary>
    [DataContract(Name = "CapabilitiesCreateObject")]
    
    public partial class CapabilitiesCreateObject : IEquatable<CapabilitiesCreateObject>
    {
        
        /// <summary>
        /// Gets or Sets LifecycleCreate
        /// </summary>
        [DataMember(Name = "lifecycleCreate", EmitDefaultValue = false)]
        public LifecycleCreateSettingObject LifecycleCreate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CapabilitiesCreateObject {\n");
            sb.Append("  LifecycleCreate: ").Append(LifecycleCreate).Append("\n");
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
            return this.Equals(input as CapabilitiesCreateObject);
        }

        /// <summary>
        /// Returns true if CapabilitiesCreateObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CapabilitiesCreateObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapabilitiesCreateObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LifecycleCreate == input.LifecycleCreate ||
                    (this.LifecycleCreate != null &&
                    this.LifecycleCreate.Equals(input.LifecycleCreate))
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
                
                if (this.LifecycleCreate != null)
                {
                    hashCode = (hashCode * 59) + this.LifecycleCreate.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
