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
    /// <summary> Describes a reference to Key Vault Key. </summary>
    public partial class KeyVaultKeyReference
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultKeyReference"/>. </summary>
        /// <param name="keyUri"> The URL referencing a key encryption key in Key Vault. </param>
        /// <param name="sourceVault"> The relative URL of the Key Vault containing the key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyUri"/> or <paramref name="sourceVault"/> is null. </exception>
        public KeyVaultKeyReference(Uri keyUri, WritableSubResource sourceVault)
        {
            Argument.AssertNotNull(keyUri, nameof(keyUri));
            Argument.AssertNotNull(sourceVault, nameof(sourceVault));

            KeyUri = keyUri;
            SourceVault = sourceVault;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultKeyReference"/>. </summary>
        /// <param name="keyUri"> The URL referencing a key encryption key in Key Vault. </param>
        /// <param name="sourceVault"> The relative URL of the Key Vault containing the key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultKeyReference(Uri keyUri, WritableSubResource sourceVault, Dictionary<string, BinaryData> rawData)
        {
            KeyUri = keyUri;
            SourceVault = sourceVault;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultKeyReference"/> for deserialization. </summary>
        internal KeyVaultKeyReference()
        {
        }

        /// <summary> The URL referencing a key encryption key in Key Vault. </summary>
        public Uri KeyUri { get; set; }
        /// <summary> The relative URL of the Key Vault containing the key. </summary>
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
    }
}
