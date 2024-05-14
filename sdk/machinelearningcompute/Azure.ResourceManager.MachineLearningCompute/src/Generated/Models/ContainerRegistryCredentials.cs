// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Information about the Azure Container Registry which contains the images deployed to the cluster. </summary>
    public partial class ContainerRegistryCredentials
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCredentials"/>. </summary>
        internal ContainerRegistryCredentials()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCredentials"/>. </summary>
        /// <param name="loginServer"> The ACR login server name. User name is the first part of the FQDN. </param>
        /// <param name="password"> The ACR primary password. </param>
        /// <param name="password2"> The ACR secondary password. </param>
        /// <param name="username"> The ACR login username. </param>
        internal ContainerRegistryCredentials(string loginServer, string password, string password2, string username)
        {
            LoginServer = loginServer;
            Password = password;
            Password2 = password2;
            Username = username;
        }

        /// <summary> The ACR login server name. User name is the first part of the FQDN. </summary>
        public string LoginServer { get; }
        /// <summary> The ACR primary password. </summary>
        public string Password { get; }
        /// <summary> The ACR secondary password. </summary>
        public string Password2 { get; }
        /// <summary> The ACR login username. </summary>
        public string Username { get; }
    }
}
