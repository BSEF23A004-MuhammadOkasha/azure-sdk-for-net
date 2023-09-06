// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Holds device secret either as a KeyVault reference or as an encrypted value. </summary>
    public partial class DataBoxEdgeDeviceSecret
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeDeviceSecret"/>. </summary>
        internal DataBoxEdgeDeviceSecret()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeDeviceSecret"/>. </summary>
        /// <param name="encryptedSecret"> Encrypted (using device public key) secret value. </param>
        /// <param name="keyVaultId"> Id of the Key-Vault where secret is stored (ex: secrets/AuthClientSecret/82ef4346187a4033a10d629cde07d740). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeDeviceSecret(AsymmetricEncryptedSecret encryptedSecret, string keyVaultId, Dictionary<string, BinaryData> rawData)
        {
            EncryptedSecret = encryptedSecret;
            KeyVaultId = keyVaultId;
            _rawData = rawData;
        }

        /// <summary> Encrypted (using device public key) secret value. </summary>
        public AsymmetricEncryptedSecret EncryptedSecret { get; }
        /// <summary> Id of the Key-Vault where secret is stored (ex: secrets/AuthClientSecret/82ef4346187a4033a10d629cde07d740). </summary>
        public string KeyVaultId { get; }
    }
}
