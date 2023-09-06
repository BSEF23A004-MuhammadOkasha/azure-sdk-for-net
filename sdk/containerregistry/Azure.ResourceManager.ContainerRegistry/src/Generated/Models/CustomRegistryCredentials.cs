// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> Describes the credentials that will be used to access a custom registry during a run. </summary>
    public partial class CustomRegistryCredentials
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CustomRegistryCredentials"/>. </summary>
        public CustomRegistryCredentials()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomRegistryCredentials"/>. </summary>
        /// <param name="userName"> The username for logging into the custom registry. </param>
        /// <param name="password">
        /// The password for logging into the custom registry. The password is a secret
        /// object that allows multiple ways of providing the value for it.
        /// </param>
        /// <param name="identity">
        /// Indicates the managed identity assigned to the custom credential. If a user-assigned identity
        /// this value is the Client ID. If a system-assigned identity, the value will be `system`. In
        /// the case of a system-assigned identity, the Client ID will be determined by the runner. This
        /// identity may be used to authenticate to key vault to retrieve credentials or it may be the only
        /// source of authentication used for accessing the registry.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomRegistryCredentials(ContainerRegistrySecretObject userName, ContainerRegistrySecretObject password, string identity, Dictionary<string, BinaryData> rawData)
        {
            UserName = userName;
            Password = password;
            Identity = identity;
            _rawData = rawData;
        }

        /// <summary> The username for logging into the custom registry. </summary>
        public ContainerRegistrySecretObject UserName { get; set; }
        /// <summary>
        /// The password for logging into the custom registry. The password is a secret
        /// object that allows multiple ways of providing the value for it.
        /// </summary>
        public ContainerRegistrySecretObject Password { get; set; }
        /// <summary>
        /// Indicates the managed identity assigned to the custom credential. If a user-assigned identity
        /// this value is the Client ID. If a system-assigned identity, the value will be `system`. In
        /// the case of a system-assigned identity, the Client ID will be determined by the runner. This
        /// identity may be used to authenticate to key vault to retrieve credentials or it may be the only
        /// source of authentication used for accessing the registry.
        /// </summary>
        public string Identity { get; set; }
    }
}
