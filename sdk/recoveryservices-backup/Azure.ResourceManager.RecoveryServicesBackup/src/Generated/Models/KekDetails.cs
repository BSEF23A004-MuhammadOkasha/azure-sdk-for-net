// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> KEK is encryption key for BEK. </summary>
    public partial class KekDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KekDetails"/>. </summary>
        public KekDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KekDetails"/>. </summary>
        /// <param name="keyUri"> Key is KEK. </param>
        /// <param name="keyVaultId"> Key Vault ID where this Key is stored. </param>
        /// <param name="keyBackupData"> KEK data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KekDetails(Uri keyUri, ResourceIdentifier keyVaultId, string keyBackupData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyUri = keyUri;
            KeyVaultId = keyVaultId;
            KeyBackupData = keyBackupData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Key is KEK. </summary>
        public Uri KeyUri { get; set; }
        /// <summary> Key Vault ID where this Key is stored. </summary>
        public ResourceIdentifier KeyVaultId { get; set; }
        /// <summary> KEK data. </summary>
        public string KeyBackupData { get; set; }
    }
}
