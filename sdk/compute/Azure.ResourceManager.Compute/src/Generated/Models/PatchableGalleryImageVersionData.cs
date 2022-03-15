// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery image version that you want to update. </summary>
    public partial class PatchableGalleryImageVersionData : UpdateResourceDefinition
    {
        /// <summary> Initializes a new instance of PatchableGalleryImageVersionData. </summary>
        public PatchableGalleryImageVersionData()
        {
        }

        /// <summary> The publishing profile of a gallery image Version. </summary>
        public GalleryImageVersionPublishingProfile PublishingProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryImageVersionPropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> This is the storage profile of a Gallery Image Version. </summary>
        public GalleryImageVersionStorageProfile StorageProfile { get; set; }
        /// <summary> This is the replication status of the gallery image version. </summary>
        public ReplicationStatus ReplicationStatus { get; }
    }
}
