// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningWorkspaceConnectionManagedIdentity. </summary>
    public partial class MachineLearningWorkspaceConnectionManagedIdentity
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceConnectionManagedIdentity"/>. </summary>
        public MachineLearningWorkspaceConnectionManagedIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningWorkspaceConnectionManagedIdentity"/>. </summary>
        /// <param name="clientId"></param>
        /// <param name="resourceId"></param>
        internal MachineLearningWorkspaceConnectionManagedIdentity(string clientId, ResourceIdentifier resourceId)
        {
            ClientId = clientId;
            ResourceId = resourceId;
        }

        /// <summary> Gets or sets the client id. </summary>
        public string ClientId { get; set; }
        /// <summary> Gets or sets the resource id. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
