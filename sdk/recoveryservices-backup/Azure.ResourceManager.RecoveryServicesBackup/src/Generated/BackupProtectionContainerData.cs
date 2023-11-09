// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing the BackupProtectionContainer data model.
    /// Base class for container with backup items. Containers with specific workloads are derived from this class.
    /// </summary>
    public partial class BackupProtectionContainerData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupProtectionContainerData"/>. </summary>
        /// <param name="location"> The location. </param>
        public BackupProtectionContainerData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupProtectionContainerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties">
        /// ProtectionContainerResource properties
        /// Please note <see cref="BackupGenericProtectionContainer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BackupServerContainer"/>, <see cref="SqlContainer"/>, <see cref="WorkloadContainer"/>, <see cref="DpmContainer"/>, <see cref="GenericContainer"/>, <see cref="IaasVmContainer"/>, <see cref="IaasClassicComputeVmContainer"/>, <see cref="IaasComputeVmContainer"/>, <see cref="SqlAvailabilityGroupWorkloadProtectionContainer"/>, <see cref="StorageContainer"/>, <see cref="VmAppContainerProtectionContainer"/> and <see cref="MabContainer"/>.
        /// </param>
        /// <param name="eTag"> Optional ETag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupProtectionContainerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BackupGenericProtectionContainer properties, ETag? eTag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BackupProtectionContainerData"/> for deserialization. </summary>
        internal BackupProtectionContainerData()
        {
        }

        /// <summary>
        /// ProtectionContainerResource properties
        /// Please note <see cref="BackupGenericProtectionContainer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BackupServerContainer"/>, <see cref="SqlContainer"/>, <see cref="WorkloadContainer"/>, <see cref="DpmContainer"/>, <see cref="GenericContainer"/>, <see cref="IaasVmContainer"/>, <see cref="IaasClassicComputeVmContainer"/>, <see cref="IaasComputeVmContainer"/>, <see cref="SqlAvailabilityGroupWorkloadProtectionContainer"/>, <see cref="StorageContainer"/>, <see cref="VmAppContainerProtectionContainer"/> and <see cref="MabContainer"/>.
        /// </summary>
        public BackupGenericProtectionContainer Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
