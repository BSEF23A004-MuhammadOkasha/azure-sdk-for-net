// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The list of available upgrade versions. </summary>
    public partial class ManagedClusterPoolUpgradeProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPoolUpgradeProfile"/>. </summary>
        /// <param name="kubernetesVersion"> The Kubernetes version (major.minor.patch). </param>
        /// <param name="osType"> The operating system type. The default is Linux. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesVersion"/> is null. </exception>
        internal ManagedClusterPoolUpgradeProfile(string kubernetesVersion, ContainerServiceOSType osType)
        {
            Argument.AssertNotNull(kubernetesVersion, nameof(kubernetesVersion));

            KubernetesVersion = kubernetesVersion;
            OSType = osType;
            Upgrades = new ChangeTrackingList<ManagedClusterPoolUpgradeProfileUpgradesItem>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPoolUpgradeProfile"/>. </summary>
        /// <param name="kubernetesVersion"> The Kubernetes version (major.minor.patch). </param>
        /// <param name="name"> The Agent Pool name. </param>
        /// <param name="osType"> The operating system type. The default is Linux. </param>
        /// <param name="upgrades"> List of orchestrator types and versions available for upgrade. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterPoolUpgradeProfile(string kubernetesVersion, string name, ContainerServiceOSType osType, IReadOnlyList<ManagedClusterPoolUpgradeProfileUpgradesItem> upgrades, Dictionary<string, BinaryData> rawData)
        {
            KubernetesVersion = kubernetesVersion;
            Name = name;
            OSType = osType;
            Upgrades = upgrades;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPoolUpgradeProfile"/> for deserialization. </summary>
        internal ManagedClusterPoolUpgradeProfile()
        {
        }

        /// <summary> The Kubernetes version (major.minor.patch). </summary>
        public string KubernetesVersion { get; }
        /// <summary> The Agent Pool name. </summary>
        public string Name { get; }
        /// <summary> The operating system type. The default is Linux. </summary>
        public ContainerServiceOSType OSType { get; }
        /// <summary> List of orchestrator types and versions available for upgrade. </summary>
        public IReadOnlyList<ManagedClusterPoolUpgradeProfileUpgradesItem> Upgrades { get; }
    }
}
