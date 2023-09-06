// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for task that validates migration input for SQL to Azure SQL Managed Instance. </summary>
    public partial class ValidateMigrationInputSqlServerSqlMITaskInput
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ValidateMigrationInputSqlServerSqlMITaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="backupBlobShare"> SAS URI of Azure Storage Account Container to be used for storing backup files. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/>, <paramref name="selectedDatabases"/> or <paramref name="backupBlobShare"/> is null. </exception>
        public ValidateMigrationInputSqlServerSqlMITaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, IEnumerable<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases, BlobShare backupBlobShare)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(selectedDatabases, nameof(selectedDatabases));
            Argument.AssertNotNull(backupBlobShare, nameof(backupBlobShare));

            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            SelectedDatabases = selectedDatabases.ToList();
            SelectedLogins = new ChangeTrackingList<string>();
            BackupBlobShare = backupBlobShare;
        }

        /// <summary> Initializes a new instance of <see cref="ValidateMigrationInputSqlServerSqlMITaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="selectedLogins"> Logins to migrate. </param>
        /// <param name="backupFileShare"> Backup file share information for all selected databases. </param>
        /// <param name="backupBlobShare"> SAS URI of Azure Storage Account Container to be used for storing backup files. </param>
        /// <param name="backupMode"> Backup Mode to specify whether to use existing backup or create new backup. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ValidateMigrationInputSqlServerSqlMITaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, IList<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases, IList<string> selectedLogins, FileShare backupFileShare, BlobShare backupBlobShare, BackupMode? backupMode, Dictionary<string, BinaryData> rawData)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            SelectedDatabases = selectedDatabases;
            SelectedLogins = selectedLogins;
            BackupFileShare = backupFileShare;
            BackupBlobShare = backupBlobShare;
            BackupMode = backupMode;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ValidateMigrationInputSqlServerSqlMITaskInput"/> for deserialization. </summary>
        internal ValidateMigrationInputSqlServerSqlMITaskInput()
        {
        }

        /// <summary> Information for connecting to source. </summary>
        public SqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> Information for connecting to target. </summary>
        public SqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Databases to migrate. </summary>
        public IList<MigrateSqlServerSqlMIDatabaseInput> SelectedDatabases { get; }
        /// <summary> Logins to migrate. </summary>
        public IList<string> SelectedLogins { get; }
        /// <summary> Backup file share information for all selected databases. </summary>
        public FileShare BackupFileShare { get; set; }
        /// <summary> SAS URI of Azure Storage Account Container to be used for storing backup files. </summary>
        internal BlobShare BackupBlobShare { get; set; }
        /// <summary> SAS URI of Azure Storage Account Container. </summary>
        public Uri BackupBlobShareSasUri
        {
            get => BackupBlobShare is null ? default : BackupBlobShare.SasUri;
            set
            {
                if (BackupBlobShare is null)
                    BackupBlobShare = new BlobShare();
                BackupBlobShare.SasUri = value;
            }
        }

        /// <summary> Backup Mode to specify whether to use existing backup or create new backup. </summary>
        public BackupMode? BackupMode { get; set; }
    }
}
