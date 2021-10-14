// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region AvailabilitySet
        /// <summary> Gets an object representing a AvailabilitySetContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="AvailabilitySetContainer" /> object. </returns>
        public static AvailabilitySetContainer GetAvailabilitySets(this ResourceGroup resourceGroup)
        {
            return new AvailabilitySetContainer(resourceGroup);
        }
        #endregion

        #region ProximityPlacementGroup
        /// <summary> Gets an object representing a ProximityPlacementGroupContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ProximityPlacementGroupContainer" /> object. </returns>
        public static ProximityPlacementGroupContainer GetProximityPlacementGroups(this ResourceGroup resourceGroup)
        {
            return new ProximityPlacementGroupContainer(resourceGroup);
        }
        #endregion

        #region DedicatedHostGroup
        /// <summary> Gets an object representing a DedicatedHostGroupContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DedicatedHostGroupContainer" /> object. </returns>
        public static DedicatedHostGroupContainer GetDedicatedHostGroups(this ResourceGroup resourceGroup)
        {
            return new DedicatedHostGroupContainer(resourceGroup);
        }
        #endregion

        #region SshPublicKey
        /// <summary> Gets an object representing a SshPublicKeyContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SshPublicKeyContainer" /> object. </returns>
        public static SshPublicKeyContainer GetSshPublicKeys(this ResourceGroup resourceGroup)
        {
            return new SshPublicKeyContainer(resourceGroup);
        }
        #endregion

        #region VirtualMachine
        /// <summary> Gets an object representing a VirtualMachineContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="VirtualMachineContainer" /> object. </returns>
        public static VirtualMachineContainer GetVirtualMachines(this ResourceGroup resourceGroup)
        {
            return new VirtualMachineContainer(resourceGroup);
        }
        #endregion

        #region VirtualMachineScaleSet
        /// <summary> Gets an object representing a VirtualMachineScaleSetContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetContainer" /> object. </returns>
        public static VirtualMachineScaleSetContainer GetVirtualMachineScaleSets(this ResourceGroup resourceGroup)
        {
            return new VirtualMachineScaleSetContainer(resourceGroup);
        }
        #endregion

        #region Image
        /// <summary> Gets an object representing a ImageContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ImageContainer" /> object. </returns>
        public static ImageContainer GetImages(this ResourceGroup resourceGroup)
        {
            return new ImageContainer(resourceGroup);
        }
        #endregion

        #region RestorePointCollection
        /// <summary> Gets an object representing a RestorePointCollectionContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RestorePointCollectionContainer" /> object. </returns>
        public static RestorePointCollectionContainer GetRestorePointCollections(this ResourceGroup resourceGroup)
        {
            return new RestorePointCollectionContainer(resourceGroup);
        }
        #endregion

        #region Disk
        /// <summary> Gets an object representing a DiskContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DiskContainer" /> object. </returns>
        public static DiskContainer GetDisks(this ResourceGroup resourceGroup)
        {
            return new DiskContainer(resourceGroup);
        }
        #endregion

        #region Snapshot
        /// <summary> Gets an object representing a SnapshotContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SnapshotContainer" /> object. </returns>
        public static SnapshotContainer GetSnapshots(this ResourceGroup resourceGroup)
        {
            return new SnapshotContainer(resourceGroup);
        }
        #endregion

        #region DiskEncryptionSet
        /// <summary> Gets an object representing a DiskEncryptionSetContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DiskEncryptionSetContainer" /> object. </returns>
        public static DiskEncryptionSetContainer GetDiskEncryptionSets(this ResourceGroup resourceGroup)
        {
            return new DiskEncryptionSetContainer(resourceGroup);
        }
        #endregion

        #region DiskAccess
        /// <summary> Gets an object representing a DiskAccessContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DiskAccessContainer" /> object. </returns>
        public static DiskAccessContainer GetDiskAccesses(this ResourceGroup resourceGroup)
        {
            return new DiskAccessContainer(resourceGroup);
        }
        #endregion

        #region Gallery
        /// <summary> Gets an object representing a GalleryContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="GalleryContainer" /> object. </returns>
        public static GalleryContainer GetGalleries(this ResourceGroup resourceGroup)
        {
            return new GalleryContainer(resourceGroup);
        }
        #endregion

        #region CloudService
        /// <summary> Gets an object representing a CloudServiceContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="CloudServiceContainer" /> object. </returns>
        public static CloudServiceContainer GetCloudServices(this ResourceGroup resourceGroup)
        {
            return new CloudServiceContainer(resourceGroup);
        }
        #endregion
    }
}
