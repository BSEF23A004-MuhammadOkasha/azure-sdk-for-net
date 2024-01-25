// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The status profile of the addons and other kubernetes components. </summary>
    public partial class ProvisionedClusterAddonStatusProfile
    {
        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterAddonStatusProfile"/>. </summary>
        internal ProvisionedClusterAddonStatusProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterAddonStatusProfile"/>. </summary>
        /// <param name="name"> Name of the addon or component. </param>
        /// <param name="phase"> Observed phase of the addon or component on the provisioned cluster. Possible values include: 'pending', 'provisioning', 'provisioning {HelmChartInstalled}', 'provisioning {MSICertificateDownloaded}', 'provisioned', 'deleting', 'failed', 'upgrading'. </param>
        /// <param name="ready"> Indicates whether the addon or component is ready. </param>
        /// <param name="errorMessage"> Observed error message from the addon or component. </param>
        internal ProvisionedClusterAddonStatusProfile(string name, ProvisionedClusterAddonPhase? phase, bool? ready, string errorMessage)
        {
            Name = name;
            Phase = phase;
            Ready = ready;
            ErrorMessage = errorMessage;
        }

        /// <summary> Name of the addon or component. </summary>
        public string Name { get; }
        /// <summary> Observed phase of the addon or component on the provisioned cluster. Possible values include: 'pending', 'provisioning', 'provisioning {HelmChartInstalled}', 'provisioning {MSICertificateDownloaded}', 'provisioned', 'deleting', 'failed', 'upgrading'. </summary>
        public ProvisionedClusterAddonPhase? Phase { get; }
        /// <summary> Indicates whether the addon or component is ready. </summary>
        public bool? Ready { get; }
        /// <summary> Observed error message from the addon or component. </summary>
        public string ErrorMessage { get; }
    }
}
