// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary> A class representing the BackupResourceEncryptionConfigExtendedResource data model. </summary>
    public partial class BackupResourceEncryptionConfigExtendedResourceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of BackupResourceEncryptionConfigExtendedResourceData. </summary>
        /// <param name="location"> The location. </param>
        public BackupResourceEncryptionConfigExtendedResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of BackupResourceEncryptionConfigExtendedResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> BackupResourceEncryptionConfigExtendedResource properties. </param>
        /// <param name="eTag"> Optional ETag. </param>
        internal BackupResourceEncryptionConfigExtendedResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BackupResourceEncryptionConfigExtended properties, ETag? eTag) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary> BackupResourceEncryptionConfigExtendedResource properties. </summary>
        public BackupResourceEncryptionConfigExtended Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
