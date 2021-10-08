// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region AvailabilitySet
        /// <summary> Gets an object representing a AvailabilitySet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySet" /> object. </returns>
        public static AvailabilitySet GetAvailabilitySet(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AvailabilitySet(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ProximityPlacementGroup
        /// <summary> Gets an object representing a ProximityPlacementGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProximityPlacementGroup" /> object. </returns>
        public static ProximityPlacementGroup GetProximityPlacementGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ProximityPlacementGroup(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DedicatedHostGroup
        /// <summary> Gets an object representing a DedicatedHostGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DedicatedHostGroup" /> object. </returns>
        public static DedicatedHostGroup GetDedicatedHostGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DedicatedHostGroup(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DedicatedHost
        /// <summary> Gets an object representing a DedicatedHost along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DedicatedHost" /> object. </returns>
        public static DedicatedHost GetDedicatedHost(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DedicatedHost(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SshPublicKey
        /// <summary> Gets an object representing a SshPublicKey along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SshPublicKey" /> object. </returns>
        public static SshPublicKey GetSshPublicKey(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SshPublicKey(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineExtensionVirtualMachine
        /// <summary> Gets an object representing a VirtualMachineExtensionVirtualMachine along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineExtensionVirtualMachine" /> object. </returns>
        public static VirtualMachineExtensionVirtualMachine GetVirtualMachineExtensionVirtualMachine(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineExtensionVirtualMachine(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachine
        /// <summary> Gets an object representing a VirtualMachine along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachine" /> object. </returns>
        public static VirtualMachine GetVirtualMachine(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachine(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSet
        /// <summary> Gets an object representing a VirtualMachineScaleSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSet" /> object. </returns>
        public static VirtualMachineScaleSet GetVirtualMachineScaleSet(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSet(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Image
        /// <summary> Gets an object representing a Image along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Image" /> object. </returns>
        public static Image GetImage(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Image(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region RestorePointCollection
        /// <summary> Gets an object representing a RestorePointCollection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RestorePointCollection" /> object. </returns>
        public static RestorePointCollection GetRestorePointCollection(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new RestorePointCollection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region RestorePoint
        /// <summary> Gets an object representing a RestorePoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RestorePoint" /> object. </returns>
        public static RestorePoint GetRestorePoint(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new RestorePoint(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSetExtension
        /// <summary> Gets an object representing a VirtualMachineScaleSetExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetExtension" /> object. </returns>
        public static VirtualMachineScaleSetExtension GetVirtualMachineScaleSetExtension(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSetExtension(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSetRollingUpgrade
        /// <summary> Gets an object representing a VirtualMachineScaleSetRollingUpgrade along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetRollingUpgrade" /> object. </returns>
        public static VirtualMachineScaleSetRollingUpgrade GetVirtualMachineScaleSetRollingUpgrade(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSetRollingUpgrade(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet
        /// <summary> Gets an object representing a VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet" /> object. </returns>
        public static VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet GetVirtualMachineScaleSetVMExtensionVirtualMachineScaleSet(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineScaleSetVM
        /// <summary> Gets an object representing a VirtualMachineScaleSetVM along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVM" /> object. </returns>
        public static VirtualMachineScaleSetVM GetVirtualMachineScaleSetVM(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineScaleSetVM(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineRunCommandVirtualMachine
        /// <summary> Gets an object representing a VirtualMachineRunCommandVirtualMachine along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineRunCommandVirtualMachine" /> object. </returns>
        public static VirtualMachineRunCommandVirtualMachine GetVirtualMachineRunCommandVirtualMachine(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineRunCommandVirtualMachine(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VirtualMachineRunCommandVirtualMachineScaleSetVM
        /// <summary> Gets an object representing a VirtualMachineRunCommandVirtualMachineScaleSetVM along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineRunCommandVirtualMachineScaleSetVM" /> object. </returns>
        public static VirtualMachineRunCommandVirtualMachineScaleSetVM GetVirtualMachineRunCommandVirtualMachineScaleSetVM(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VirtualMachineRunCommandVirtualMachineScaleSetVM(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Disk
        /// <summary> Gets an object representing a Disk along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Disk" /> object. </returns>
        public static Disk GetDisk(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Disk(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Snapshot
        /// <summary> Gets an object representing a Snapshot along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Snapshot" /> object. </returns>
        public static Snapshot GetSnapshot(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Snapshot(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DiskEncryptionSet
        /// <summary> Gets an object representing a DiskEncryptionSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskEncryptionSet" /> object. </returns>
        public static DiskEncryptionSet GetDiskEncryptionSet(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DiskEncryptionSet(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DiskAccess
        /// <summary> Gets an object representing a DiskAccess along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskAccess" /> object. </returns>
        public static DiskAccess GetDiskAccess(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DiskAccess(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DiskRestorePoint
        /// <summary> Gets an object representing a DiskRestorePoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskRestorePoint" /> object. </returns>
        public static DiskRestorePoint GetDiskRestorePoint(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DiskRestorePoint(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Gallery
        /// <summary> Gets an object representing a Gallery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Gallery" /> object. </returns>
        public static Gallery GetGallery(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Gallery(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region GalleryImage
        /// <summary> Gets an object representing a GalleryImage along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryImage" /> object. </returns>
        public static GalleryImage GetGalleryImage(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new GalleryImage(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region GalleryImageVersion
        /// <summary> Gets an object representing a GalleryImageVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryImageVersion" /> object. </returns>
        public static GalleryImageVersion GetGalleryImageVersion(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new GalleryImageVersion(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region GalleryApplication
        /// <summary> Gets an object representing a GalleryApplication along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryApplication" /> object. </returns>
        public static GalleryApplication GetGalleryApplication(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new GalleryApplication(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region GalleryApplicationVersion
        /// <summary> Gets an object representing a GalleryApplicationVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryApplicationVersion" /> object. </returns>
        public static GalleryApplicationVersion GetGalleryApplicationVersion(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new GalleryApplicationVersion(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SharedGallery
        /// <summary> Gets an object representing a SharedGallery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedGallery" /> object. </returns>
        public static SharedGallery GetSharedGallery(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SharedGallery(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SharedGalleryImage
        /// <summary> Gets an object representing a SharedGalleryImage along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedGalleryImage" /> object. </returns>
        public static SharedGalleryImage GetSharedGalleryImage(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SharedGalleryImage(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SharedGalleryImageVersion
        /// <summary> Gets an object representing a SharedGalleryImageVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedGalleryImageVersion" /> object. </returns>
        public static SharedGalleryImageVersion GetSharedGalleryImageVersion(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SharedGalleryImageVersion(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region CloudService
        /// <summary> Gets an object representing a CloudService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudService" /> object. </returns>
        public static CloudService GetCloudService(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new CloudService(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region UpdateDomain
        /// <summary> Gets an object representing a UpdateDomain along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="UpdateDomain" /> object. </returns>
        public static UpdateDomain GetUpdateDomain(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new UpdateDomain(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
