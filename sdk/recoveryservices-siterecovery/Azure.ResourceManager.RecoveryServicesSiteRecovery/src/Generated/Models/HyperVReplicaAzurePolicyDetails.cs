// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Hyper-V Replica Azure specific protection profile details. </summary>
    public partial class HyperVReplicaAzurePolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzurePolicyDetails"/>. </summary>
        internal HyperVReplicaAzurePolicyDetails()
        {
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzurePolicyDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="recoveryPointHistoryDurationInHours"> The duration (in hours) to which point the recovery history needs to be maintained. </param>
        /// <param name="applicationConsistentSnapshotFrequencyInHours"> The interval (in hours) at which Hyper-V Replica should create an application consistent snapshot within the VM. </param>
        /// <param name="replicationInterval"> The replication interval. </param>
        /// <param name="onlineReplicationStartTime"> The scheduled start time for the initial replication. If this parameter is Null, the initial replication starts immediately. </param>
        /// <param name="encryption"> A value indicating whether encryption is enabled for virtual machines in this cloud. </param>
        /// <param name="activeStorageAccountId"> The active storage account Id. </param>
        internal HyperVReplicaAzurePolicyDetails(string instanceType, int? recoveryPointHistoryDurationInHours, int? applicationConsistentSnapshotFrequencyInHours, int? replicationInterval, string onlineReplicationStartTime, string encryption, ResourceIdentifier activeStorageAccountId) : base(instanceType)
        {
            RecoveryPointHistoryDurationInHours = recoveryPointHistoryDurationInHours;
            ApplicationConsistentSnapshotFrequencyInHours = applicationConsistentSnapshotFrequencyInHours;
            ReplicationInterval = replicationInterval;
            OnlineReplicationStartTime = onlineReplicationStartTime;
            Encryption = encryption;
            ActiveStorageAccountId = activeStorageAccountId;
            InstanceType = instanceType ?? "HyperVReplicaAzure";
        }

        /// <summary> The duration (in hours) to which point the recovery history needs to be maintained. </summary>
        public int? RecoveryPointHistoryDurationInHours { get; }
        /// <summary> The interval (in hours) at which Hyper-V Replica should create an application consistent snapshot within the VM. </summary>
        public int? ApplicationConsistentSnapshotFrequencyInHours { get; }
        /// <summary> The replication interval. </summary>
        public int? ReplicationInterval { get; }
        /// <summary> The scheduled start time for the initial replication. If this parameter is Null, the initial replication starts immediately. </summary>
        public string OnlineReplicationStartTime { get; }
        /// <summary> A value indicating whether encryption is enabled for virtual machines in this cloud. </summary>
        public string Encryption { get; }
        /// <summary> The active storage account Id. </summary>
        public ResourceIdentifier ActiveStorageAccountId { get; }
    }
}
