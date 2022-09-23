// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary> A class representing the CapacityPool data model. </summary>
    public partial class CapacityPoolData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of CapacityPoolData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="size"> Provisioned size of the pool (in bytes). Allowed values are in 1TiB chunks (value must be multiply of 4398046511104). </param>
        /// <param name="serviceLevel"> The service level of the file system. </param>
        public CapacityPoolData(AzureLocation location, long size, NetAppFileServiceLevel serviceLevel) : base(location)
        {
            Size = size;
            ServiceLevel = serviceLevel;
        }

        /// <summary> Initializes a new instance of CapacityPoolData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="poolId"> UUID v4 used to identify the Pool. </param>
        /// <param name="size"> Provisioned size of the pool (in bytes). Allowed values are in 1TiB chunks (value must be multiply of 4398046511104). </param>
        /// <param name="serviceLevel"> The service level of the file system. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="totalThroughputMibps"> Total throughput of pool in MiB/s. </param>
        /// <param name="utilizedThroughputMibps"> Utilized throughput of pool in MiB/s. </param>
        /// <param name="qosType"> The qos type of the pool. </param>
        /// <param name="isCoolAccessEnabled"> If enabled (true) the pool can contain cool Access enabled volumes. </param>
        /// <param name="encryptionType"> Encryption type of the capacity pool, set encryption type for data at rest for this pool and all volumes in it. This value can only be set when creating new pool. </param>
        internal CapacityPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, Guid? poolId, long size, NetAppFileServiceLevel serviceLevel, string provisioningState, float? totalThroughputMibps, float? utilizedThroughputMibps, CapacityPoolQosType? qosType, bool? isCoolAccessEnabled, CapacityPoolEncryptionType? encryptionType) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            PoolId = poolId;
            Size = size;
            ServiceLevel = serviceLevel;
            ProvisioningState = provisioningState;
            TotalThroughputMibps = totalThroughputMibps;
            UtilizedThroughputMibps = utilizedThroughputMibps;
            QosType = qosType;
            IsCoolAccessEnabled = isCoolAccessEnabled;
            EncryptionType = encryptionType;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> UUID v4 used to identify the Pool. </summary>
        public Guid? PoolId { get; }
        /// <summary> Provisioned size of the pool (in bytes). Allowed values are in 1TiB chunks (value must be multiply of 4398046511104). </summary>
        public long Size { get; set; }
        /// <summary> The service level of the file system. </summary>
        public NetAppFileServiceLevel ServiceLevel { get; set; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
        /// <summary> Total throughput of pool in MiB/s. </summary>
        public float? TotalThroughputMibps { get; }
        /// <summary> Utilized throughput of pool in MiB/s. </summary>
        public float? UtilizedThroughputMibps { get; }
        /// <summary> The qos type of the pool. </summary>
        public CapacityPoolQosType? QosType { get; set; }
        /// <summary> If enabled (true) the pool can contain cool Access enabled volumes. </summary>
        public bool? IsCoolAccessEnabled { get; set; }
        /// <summary> Encryption type of the capacity pool, set encryption type for data at rest for this pool and all volumes in it. This value can only be set when creating new pool. </summary>
        public CapacityPoolEncryptionType? EncryptionType { get; set; }
    }
}
