// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure VM workload-specific workload item representing SAP ASE Database. </summary>
    public partial class VmWorkloadSapAseDatabaseWorkloadItem : VmWorkloadItem
    {
        /// <summary> Initializes a new instance of <see cref="VmWorkloadSapAseDatabaseWorkloadItem"/>. </summary>
        public VmWorkloadSapAseDatabaseWorkloadItem()
        {
            WorkloadItemType = "SAPAseDatabase";
        }

        /// <summary> Initializes a new instance of <see cref="VmWorkloadSapAseDatabaseWorkloadItem"/>. </summary>
        /// <param name="backupManagementType"> Type of backup management to backup an item. </param>
        /// <param name="workloadType"> Type of workload for the backup management. </param>
        /// <param name="workloadItemType"> Type of the backup item. </param>
        /// <param name="friendlyName"> Friendly name of the backup item. </param>
        /// <param name="protectionState"> State of the back up item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parentName"> Name for instance or AG. </param>
        /// <param name="serverName"> Host/Cluster Name for instance or AG. </param>
        /// <param name="isAutoProtectable"> Indicates if workload item is auto-protectable. </param>
        /// <param name="subInquiredItemCount"> For instance or AG, indicates number of DB's present. </param>
        /// <param name="subWorkloadItemCount"> For instance or AG, indicates number of DB's to be protected. </param>
        internal VmWorkloadSapAseDatabaseWorkloadItem(string backupManagementType, string workloadType, string workloadItemType, string friendlyName, BackupProtectionStatus? protectionState, IDictionary<string, BinaryData> serializedAdditionalRawData, string parentName, string serverName, bool? isAutoProtectable, int? subInquiredItemCount, int? subWorkloadItemCount) : base(backupManagementType, workloadType, workloadItemType, friendlyName, protectionState, serializedAdditionalRawData, parentName, serverName, isAutoProtectable, subInquiredItemCount, subWorkloadItemCount)
        {
            WorkloadItemType = workloadItemType ?? "SAPAseDatabase";
        }
    }
}
