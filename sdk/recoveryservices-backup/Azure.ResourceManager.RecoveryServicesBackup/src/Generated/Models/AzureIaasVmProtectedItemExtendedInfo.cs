// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information on Azure IaaS VM specific backup item. </summary>
    public partial class AzureIaasVmProtectedItemExtendedInfo
    {
        /// <summary> Initializes a new instance of AzureIaasVmProtectedItemExtendedInfo. </summary>
        public AzureIaasVmProtectedItemExtendedInfo()
        {
        }

        /// <summary> Initializes a new instance of AzureIaasVmProtectedItemExtendedInfo. </summary>
        /// <param name="oldestRecoveryPoint"> The oldest backup copy available for this backup item across all tiers. </param>
        /// <param name="oldestRecoveryPointInVault"> The oldest backup copy available for this backup item in vault tier. </param>
        /// <param name="oldestRecoveryPointInArchive"> The oldest backup copy available for this backup item in archive tier. </param>
        /// <param name="newestRecoveryPointInArchive"> The latest backup copy available for this backup item in archive tier. </param>
        /// <param name="recoveryPointCount"> Number of backup copies available for this backup item. </param>
        /// <param name="policyInconsistent"> Specifies if backup policy associated with the backup item is inconsistent. </param>
        internal AzureIaasVmProtectedItemExtendedInfo(DateTimeOffset? oldestRecoveryPoint, DateTimeOffset? oldestRecoveryPointInVault, DateTimeOffset? oldestRecoveryPointInArchive, DateTimeOffset? newestRecoveryPointInArchive, int? recoveryPointCount, bool? policyInconsistent)
        {
            OldestRecoveryPoint = oldestRecoveryPoint;
            OldestRecoveryPointInVault = oldestRecoveryPointInVault;
            OldestRecoveryPointInArchive = oldestRecoveryPointInArchive;
            NewestRecoveryPointInArchive = newestRecoveryPointInArchive;
            RecoveryPointCount = recoveryPointCount;
            PolicyInconsistent = policyInconsistent;
        }

        /// <summary> The oldest backup copy available for this backup item across all tiers. </summary>
        public DateTimeOffset? OldestRecoveryPoint { get; set; }
        /// <summary> The oldest backup copy available for this backup item in vault tier. </summary>
        public DateTimeOffset? OldestRecoveryPointInVault { get; set; }
        /// <summary> The oldest backup copy available for this backup item in archive tier. </summary>
        public DateTimeOffset? OldestRecoveryPointInArchive { get; set; }
        /// <summary> The latest backup copy available for this backup item in archive tier. </summary>
        public DateTimeOffset? NewestRecoveryPointInArchive { get; set; }
        /// <summary> Number of backup copies available for this backup item. </summary>
        public int? RecoveryPointCount { get; set; }
        /// <summary> Specifies if backup policy associated with the backup item is inconsistent. </summary>
        public bool? PolicyInconsistent { get; set; }
    }
}
