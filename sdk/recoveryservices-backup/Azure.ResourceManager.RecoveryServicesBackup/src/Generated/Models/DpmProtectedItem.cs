// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information on Backup engine specific backup item. </summary>
    public partial class DpmProtectedItem : ProtectedItem
    {
        /// <summary> Initializes a new instance of DpmProtectedItem. </summary>
        public DpmProtectedItem()
        {
            ProtectedItemType = "DPMProtectedItem";
        }

        /// <summary> Initializes a new instance of DpmProtectedItem. </summary>
        /// <param name="protectedItemType"> backup item type. </param>
        /// <param name="backupManagementType"> Type of backup management for the backed up item. </param>
        /// <param name="workloadType"> Type of workload this item represents. </param>
        /// <param name="containerName"> Unique name of container. </param>
        /// <param name="sourceResourceId"> ARM ID of the resource to be backed up. </param>
        /// <param name="policyId"> ID of the backup policy with which this item is backed up. </param>
        /// <param name="lastRecoveryPoint"> Timestamp when the last (latest) backup copy was created for this backup item. </param>
        /// <param name="backupSetName"> Name of the backup set the backup item belongs to. </param>
        /// <param name="createMode"> Create mode to indicate recovery of existing soft deleted data source or creation of new data source. </param>
        /// <param name="deferredDeleteTimeInUTC"> Time for deferred deletion in UTC. </param>
        /// <param name="isScheduledForDeferredDelete"> Flag to identify whether the DS is scheduled for deferred delete. </param>
        /// <param name="deferredDeleteTimeRemaining"> Time remaining before the DS marked for deferred delete is permanently deleted. </param>
        /// <param name="isDeferredDeleteScheduleUpcoming"> Flag to identify whether the deferred deleted DS is to be purged soon. </param>
        /// <param name="isRehydrate"> Flag to identify that deferred deleted DS is to be moved into Pause state. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuardOperationRequests on which LAC check will be performed. </param>
        /// <param name="isArchiveEnabled"> Flag to identify whether datasource is protected in archive. </param>
        /// <param name="policyName"> Name of the policy used for protection. </param>
        /// <param name="friendlyName"> Friendly name of the managed item. </param>
        /// <param name="backupEngineName"> Backup Management server protecting this backup item. </param>
        /// <param name="protectionState"> Protection state of the backup engine. </param>
        /// <param name="extendedInfo"> Extended info of the backup item. </param>
        internal DpmProtectedItem(string protectedItemType, BackupManagementType? backupManagementType, DataSourceType? workloadType, string containerName, string sourceResourceId, string policyId, DateTimeOffset? lastRecoveryPoint, string backupSetName, CreateMode? createMode, DateTimeOffset? deferredDeleteTimeInUTC, bool? isScheduledForDeferredDelete, string deferredDeleteTimeRemaining, bool? isDeferredDeleteScheduleUpcoming, bool? isRehydrate, IList<string> resourceGuardOperationRequests, bool? isArchiveEnabled, string policyName, string friendlyName, string backupEngineName, ProtectedItemState? protectionState, DpmProtectedItemExtendedInfo extendedInfo) : base(protectedItemType, backupManagementType, workloadType, containerName, sourceResourceId, policyId, lastRecoveryPoint, backupSetName, createMode, deferredDeleteTimeInUTC, isScheduledForDeferredDelete, deferredDeleteTimeRemaining, isDeferredDeleteScheduleUpcoming, isRehydrate, resourceGuardOperationRequests, isArchiveEnabled, policyName)
        {
            FriendlyName = friendlyName;
            BackupEngineName = backupEngineName;
            ProtectionState = protectionState;
            ExtendedInfo = extendedInfo;
            ProtectedItemType = protectedItemType ?? "DPMProtectedItem";
        }

        /// <summary> Friendly name of the managed item. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Backup Management server protecting this backup item. </summary>
        public string BackupEngineName { get; set; }
        /// <summary> Protection state of the backup engine. </summary>
        public ProtectedItemState? ProtectionState { get; set; }
        /// <summary> Extended info of the backup item. </summary>
        public DpmProtectedItemExtendedInfo ExtendedInfo { get; set; }
    }
}
