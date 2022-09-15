// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataLake.Store.Models
{
    /// <summary> The encryption configuration for the account. </summary>
    public partial class EncryptionConfig
    {
        /// <summary> Initializes a new instance of EncryptionConfig. </summary>
        /// <param name="configType"> The type of encryption configuration being used. Currently the only supported types are &apos;UserManaged&apos; and &apos;ServiceManaged&apos;. </param>
        public EncryptionConfig(EncryptionConfigType configType)
        {
            ConfigType = configType;
        }

        /// <summary> Initializes a new instance of EncryptionConfig. </summary>
        /// <param name="configType"> The type of encryption configuration being used. Currently the only supported types are &apos;UserManaged&apos; and &apos;ServiceManaged&apos;. </param>
        /// <param name="keyVaultMetaInfo"> The Key Vault information for connecting to user managed encryption keys. </param>
        internal EncryptionConfig(EncryptionConfigType configType, KeyVaultMetaInfo keyVaultMetaInfo)
        {
            ConfigType = configType;
            KeyVaultMetaInfo = keyVaultMetaInfo;
        }

        /// <summary> The type of encryption configuration being used. Currently the only supported types are &apos;UserManaged&apos; and &apos;ServiceManaged&apos;. </summary>
        public EncryptionConfigType ConfigType { get; set; }
        /// <summary> The Key Vault information for connecting to user managed encryption keys. </summary>
        public KeyVaultMetaInfo KeyVaultMetaInfo { get; set; }
    }
}
