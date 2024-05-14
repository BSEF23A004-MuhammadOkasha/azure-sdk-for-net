// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> The redundancy Settings of a Vault. </summary>
    public partial class VaultPropertiesRedundancySettings
    {
        /// <summary> Initializes a new instance of <see cref="VaultPropertiesRedundancySettings"/>. </summary>
        public VaultPropertiesRedundancySettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VaultPropertiesRedundancySettings"/>. </summary>
        /// <param name="standardTierStorageRedundancy"> The storage redundancy setting of a vault. </param>
        /// <param name="crossRegionRestore"> Flag to show if Cross Region Restore is enabled on the Vault or not. </param>
        internal VaultPropertiesRedundancySettings(StandardTierStorageRedundancy? standardTierStorageRedundancy, CrossRegionRestore? crossRegionRestore)
        {
            StandardTierStorageRedundancy = standardTierStorageRedundancy;
            CrossRegionRestore = crossRegionRestore;
        }

        /// <summary> The storage redundancy setting of a vault. </summary>
        public StandardTierStorageRedundancy? StandardTierStorageRedundancy { get; }
        /// <summary> Flag to show if Cross Region Restore is enabled on the Vault or not. </summary>
        public CrossRegionRestore? CrossRegionRestore { get; }
    }
}
