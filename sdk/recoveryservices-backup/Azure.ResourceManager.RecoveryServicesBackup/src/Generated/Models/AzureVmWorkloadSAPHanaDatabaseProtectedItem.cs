// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure VM workload-specific protected item representing SAP HANA Database. </summary>
    public partial class AzureVmWorkloadSAPHanaDatabaseProtectedItem : AzureVmWorkloadProtectedItem
    {
        /// <summary> Initializes a new instance of AzureVmWorkloadSAPHanaDatabaseProtectedItem. </summary>
        public AzureVmWorkloadSAPHanaDatabaseProtectedItem()
        {
            ProtectedItemType = "AzureVmWorkloadSAPHanaDatabase";
        }

        /// <summary> Initializes a new instance of AzureVmWorkloadSAPHanaDatabaseProtectedItem. </summary>
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
        /// <param name="friendlyName"> Friendly name of the DB represented by this backup item. </param>
        /// <param name="serverName"> Host/Cluster Name for instance or AG. </param>
        /// <param name="parentName"> Parent name of the DB such as Instance or Availability Group. </param>
        /// <param name="parentType"> Parent type of protected item, example: for a DB, standalone server or distributed. </param>
        /// <param name="protectionStatus"> Backup status of this backup item. </param>
        /// <param name="protectionState"> Backup state of this backup item. </param>
        /// <param name="lastBackupStatus"> Last backup operation status. Possible values: Healthy, Unhealthy. </param>
        /// <param name="lastBackupOn"> Timestamp of the last backup operation on this backup item. </param>
        /// <param name="lastBackupErrorDetail"> Error details in last backup. </param>
        /// <param name="protectedItemDataSourceId"> Data ID of the protected item. </param>
        /// <param name="protectedItemHealthStatus"> Health status of the backup item, evaluated based on last heartbeat received. </param>
        /// <param name="extendedInfo"> Additional information for this backup item. </param>
        /// <param name="kpisHealths"> Health details of different KPIs. </param>
        internal AzureVmWorkloadSAPHanaDatabaseProtectedItem(string protectedItemType, BackupManagementType? backupManagementType, DataSourceType? workloadType, string containerName, string sourceResourceId, string policyId, DateTimeOffset? lastRecoveryPoint, string backupSetName, CreateMode? createMode, DateTimeOffset? deferredDeleteTimeInUTC, bool? isScheduledForDeferredDelete, string deferredDeleteTimeRemaining, bool? isDeferredDeleteScheduleUpcoming, bool? isRehydrate, IList<string> resourceGuardOperationRequests, bool? isArchiveEnabled, string policyName, string friendlyName, string serverName, string parentName, string parentType, string protectionStatus, ProtectionState? protectionState, LastBackupStatus? lastBackupStatus, DateTimeOffset? lastBackupOn, ErrorDetail lastBackupErrorDetail, string protectedItemDataSourceId, ProtectedItemHealthStatus? protectedItemHealthStatus, AzureVmWorkloadProtectedItemExtendedInfo extendedInfo, IDictionary<string, KPIResourceHealthDetails> kpisHealths) : base(protectedItemType, backupManagementType, workloadType, containerName, sourceResourceId, policyId, lastRecoveryPoint, backupSetName, createMode, deferredDeleteTimeInUTC, isScheduledForDeferredDelete, deferredDeleteTimeRemaining, isDeferredDeleteScheduleUpcoming, isRehydrate, resourceGuardOperationRequests, isArchiveEnabled, policyName, friendlyName, serverName, parentName, parentType, protectionStatus, protectionState, lastBackupStatus, lastBackupOn, lastBackupErrorDetail, protectedItemDataSourceId, protectedItemHealthStatus, extendedInfo, kpisHealths)
        {
            ProtectedItemType = protectedItemType ?? "AzureVmWorkloadSAPHanaDatabase";
        }
    }
}
