// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App Secret. </summary>
    public partial class ContainerAppSecret
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppSecret"/>. </summary>
        internal ContainerAppSecret()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppSecret"/>. </summary>
        /// <param name="name"> Secret Name. </param>
        /// <param name="value"> Secret Value. </param>
        /// <param name="identity"> Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned identity. </param>
        /// <param name="keyVaultUri"> Azure Key Vault URL pointing to the secret referenced by the container app. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppSecret(string name, string value, string identity, Uri keyVaultUri, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            Identity = identity;
            KeyVaultUri = keyVaultUri;
            _rawData = rawData;
        }

        /// <summary> Secret Name. </summary>
        public string Name { get; }
        /// <summary> Secret Value. </summary>
        public string Value { get; }
        /// <summary> Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned identity. </summary>
        public string Identity { get; }
        /// <summary> Azure Key Vault URL pointing to the secret referenced by the container app. </summary>
        public Uri KeyVaultUri { get; }
    }
}
