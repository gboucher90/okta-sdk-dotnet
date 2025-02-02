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
    /// PasswordPolicyRecoveryQuestionProperties
    /// </summary>
    [DataContract(Name = "PasswordPolicyRecoveryQuestionProperties")]
    
    public partial class PasswordPolicyRecoveryQuestionProperties : IEquatable<PasswordPolicyRecoveryQuestionProperties>
    {
        
        /// <summary>
        /// Gets or Sets Complexity
        /// </summary>
        [DataMember(Name = "complexity", EmitDefaultValue = false)]
        public PasswordPolicyRecoveryQuestionComplexity Complexity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordPolicyRecoveryQuestionProperties {\n");
            sb.Append("  Complexity: ").Append(Complexity).Append("\n");
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
            return this.Equals(input as PasswordPolicyRecoveryQuestionProperties);
        }

        /// <summary>
        /// Returns true if PasswordPolicyRecoveryQuestionProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyRecoveryQuestionProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyRecoveryQuestionProperties input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Complexity == input.Complexity ||
                    (this.Complexity != null &&
                    this.Complexity.Equals(input.Complexity))
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
                
                if (this.Complexity != null)
                {
                    hashCode = (hashCode * 59) + this.Complexity.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
