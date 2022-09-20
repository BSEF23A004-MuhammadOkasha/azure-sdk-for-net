// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The response from the ListCredentials operation. </summary>
    public partial class ContainerRegistryListCredentialsResult
    {
        /// <summary> Initializes a new instance of ContainerRegistryListCredentialsResult. </summary>
        internal ContainerRegistryListCredentialsResult()
        {
            Passwords = new ChangeTrackingList<ContainerRegistryPassword>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryListCredentialsResult. </summary>
        /// <param name="username"> The username for a container registry. </param>
        /// <param name="passwords"> The list of passwords for a container registry. </param>
        internal ContainerRegistryListCredentialsResult(string username, IReadOnlyList<ContainerRegistryPassword> passwords)
        {
            Username = username;
            Passwords = passwords;
        }

        /// <summary> The username for a container registry. </summary>
        public string Username { get; }
        /// <summary> The list of passwords for a container registry. </summary>
        public IReadOnlyList<ContainerRegistryPassword> Passwords { get; }
    }
}
