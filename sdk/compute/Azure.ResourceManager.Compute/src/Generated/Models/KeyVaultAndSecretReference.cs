// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Key Vault Secret Url and vault id of the encryption key. </summary>
    public partial class KeyVaultAndSecretReference
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultAndSecretReference"/>. </summary>
        /// <param name="sourceVault"> Resource id of the KeyVault containing the key or secret. </param>
        /// <param name="secretUri"> Url pointing to a key or secret in KeyVault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceVault"/> or <paramref name="secretUri"/> is null. </exception>
        public KeyVaultAndSecretReference(WritableSubResource sourceVault, Uri secretUri)
        {
            Argument.AssertNotNull(sourceVault, nameof(sourceVault));
            Argument.AssertNotNull(secretUri, nameof(secretUri));

            SourceVault = sourceVault;
            SecretUri = secretUri;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultAndSecretReference"/>. </summary>
        /// <param name="sourceVault"> Resource id of the KeyVault containing the key or secret. </param>
        /// <param name="secretUri"> Url pointing to a key or secret in KeyVault. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultAndSecretReference(WritableSubResource sourceVault, Uri secretUri, Dictionary<string, BinaryData> rawData)
        {
            SourceVault = sourceVault;
            SecretUri = secretUri;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultAndSecretReference"/> for deserialization. </summary>
        internal KeyVaultAndSecretReference()
        {
        }

        /// <summary> Resource id of the KeyVault containing the key or secret. </summary>
        internal WritableSubResource SourceVault { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SourceVaultId
        {
            get => SourceVault is null ? default : SourceVault.Id;
            set
            {
                if (SourceVault is null)
                    SourceVault = new WritableSubResource();
                SourceVault.Id = value;
            }
        }

        /// <summary> Url pointing to a key or secret in KeyVault. </summary>
        public Uri SecretUri { get; set; }
    }
}
