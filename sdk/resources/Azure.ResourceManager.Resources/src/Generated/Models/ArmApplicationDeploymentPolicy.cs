// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed application deployment policy. </summary>
    internal partial class ArmApplicationDeploymentPolicy
    {
        /// <summary> Initializes a new instance of <see cref="ArmApplicationDeploymentPolicy"/>. </summary>
        /// <param name="deploymentMode"> The managed application deployment mode. </param>
        public ArmApplicationDeploymentPolicy(ArmApplicationDeploymentMode deploymentMode)
        {
            DeploymentMode = deploymentMode;
        }

        /// <summary> The managed application deployment mode. </summary>
        public ArmApplicationDeploymentMode DeploymentMode { get; set; }
    }
}
