// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The encryption configuration used to update a user managed Key Vault key. </summary>
    internal partial class UpdateEncryptionConfig
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UpdateEncryptionConfig"/>. </summary>
        public UpdateEncryptionConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpdateEncryptionConfig"/>. </summary>
        /// <param name="keyVaultMetaInfo"> The updated Key Vault key to use in user managed key rotation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateEncryptionConfig(UpdateKeyVaultMetaInfo keyVaultMetaInfo, Dictionary<string, BinaryData> rawData)
        {
            KeyVaultMetaInfo = keyVaultMetaInfo;
            _rawData = rawData;
        }

        /// <summary> The updated Key Vault key to use in user managed key rotation. </summary>
        internal UpdateKeyVaultMetaInfo KeyVaultMetaInfo { get; set; }
        /// <summary> The version of the user managed encryption key to update through a key rotation. </summary>
        public string EncryptionKeyVersion
        {
            get => KeyVaultMetaInfo is null ? default : KeyVaultMetaInfo.EncryptionKeyVersion;
            set
            {
                if (KeyVaultMetaInfo is null)
                    KeyVaultMetaInfo = new UpdateKeyVaultMetaInfo();
                KeyVaultMetaInfo.EncryptionKeyVersion = value;
            }
        }
    }
}
