// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment What-if operation parameters. </summary>
    public partial class ArmDeploymentWhatIf
    {
        /// <summary> Initializes a new instance of ArmDeploymentWhatIf. </summary>
        /// <param name="properties"> The deployment properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public ArmDeploymentWhatIf(ArmDeploymentWhatIfProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> The location to store the deployment data, only required at the tenant and management group scope. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The deployment properties. </summary>
        public ArmDeploymentWhatIfProperties Properties { get; }
    }
}
