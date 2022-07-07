// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Snapshot Controller settings for the storage profile. </summary>
    internal partial class ManagedClusterStorageProfileSnapshotController
    {
        /// <summary> Initializes a new instance of ManagedClusterStorageProfileSnapshotController. </summary>
        public ManagedClusterStorageProfileSnapshotController()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterStorageProfileSnapshotController. </summary>
        /// <param name="enabled"> Whether to enable Snapshot Controller. The default value is true. </param>
        internal ManagedClusterStorageProfileSnapshotController(bool? enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Whether to enable Snapshot Controller. The default value is true. </summary>
        public bool? Enabled { get; set; }
    }
}
