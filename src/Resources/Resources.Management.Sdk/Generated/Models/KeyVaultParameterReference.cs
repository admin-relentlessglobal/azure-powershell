// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System.Linq;

    /// <summary>
    /// Azure Key Vault parameter reference.
    /// </summary>
    public partial class KeyVaultParameterReference
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultParameterReference class.
        /// </summary>
        public KeyVaultParameterReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultParameterReference class.
        /// </summary>

        /// <param name="keyVault">Azure Key Vault reference.
        /// </param>

        /// <param name="secretName">Azure Key Vault secret name.
        /// </param>

        /// <param name="secretVersion">Azure Key Vault secret version.
        /// </param>
        public KeyVaultParameterReference(KeyVaultReference keyVault, string secretName, string secretVersion = default(string))

        {
            this.KeyVault = keyVault;
            this.SecretName = secretName;
            this.SecretVersion = secretVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets azure Key Vault reference.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVault")]
        public KeyVaultReference KeyVault {get; set; }

        /// <summary>
        /// Gets or sets azure Key Vault secret name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secretName")]
        public string SecretName {get; set; }

        /// <summary>
        /// Gets or sets azure Key Vault secret version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secretVersion")]
        public string SecretVersion {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.KeyVault == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "KeyVault");
            }
            if (this.SecretName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SecretName");
            }
            if (this.KeyVault != null)
            {
                this.KeyVault.Validate();
            }


        }
    }
}