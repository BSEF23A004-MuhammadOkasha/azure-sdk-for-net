// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure SQL workload-specific backup policy. </summary>
    public partial class SqlProtectionPolicy : BackupGenericProtectionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="SqlProtectionPolicy"/>. </summary>
        public SqlProtectionPolicy()
        {
            BackupManagementType = "AzureSql";
        }

        /// <summary> Initializes a new instance of <see cref="SqlProtectionPolicy"/>. </summary>
        /// <param name="protectedItemsCount"> Number of items associated with this policy. </param>
        /// <param name="backupManagementType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuard Operation Requests. </param>
        /// <param name="retentionPolicy">
        /// Retention policy details.
        /// Please note <see cref="BackupRetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
        /// </param>
        internal SqlProtectionPolicy(int? protectedItemsCount, string backupManagementType, IList<string> resourceGuardOperationRequests, BackupRetentionPolicy retentionPolicy) : base(protectedItemsCount, backupManagementType, resourceGuardOperationRequests)
        {
            RetentionPolicy = retentionPolicy;
            BackupManagementType = backupManagementType ?? "AzureSql";
        }

        /// <summary>
        /// Retention policy details.
        /// Please note <see cref="BackupRetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
        /// </summary>
        public BackupRetentionPolicy RetentionPolicy { get; set; }
    }
}
