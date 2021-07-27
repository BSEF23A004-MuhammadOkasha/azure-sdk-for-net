// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines how the Video Analyzer account is (optionally) encrypted.
    /// </summary>
    public partial class AccountEncryption
    {
        /// <summary>
        /// Initializes a new instance of the AccountEncryption class.
        /// </summary>
        public AccountEncryption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountEncryption class.
        /// </summary>
        /// <param name="type">The type of key used to encrypt the Account Key.
        /// Possible values include: 'SystemKey', 'CustomerKey'</param>
        /// <param name="keyVaultProperties">The properties of the key used to
        /// encrypt the account.</param>
        /// <param name="identity">The Key Vault identity.</param>
        /// <param name="status">The current status of the Key Vault
        /// mapping.</param>
        public AccountEncryption(AccountEncryptionKeyType type, KeyVaultProperties keyVaultProperties = default(KeyVaultProperties), ResourceIdentity identity = default(ResourceIdentity), string status = default(string))
        {
            Type = type;
            KeyVaultProperties = keyVaultProperties;
            Identity = identity;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of key used to encrypt the Account Key.
        /// Possible values include: 'SystemKey', 'CustomerKey'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public AccountEncryptionKeyType Type { get; set; }

        /// <summary>
        /// Gets or sets the properties of the key used to encrypt the account.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultProperties")]
        public KeyVaultProperties KeyVaultProperties { get; set; }

        /// <summary>
        /// Gets or sets the Key Vault identity.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ResourceIdentity Identity { get; set; }

        /// <summary>
        /// Gets the current status of the Key Vault mapping.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyVaultProperties != null)
            {
                KeyVaultProperties.Validate();
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}
