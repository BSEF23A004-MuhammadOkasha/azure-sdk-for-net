// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary>
    /// Database Migration Resource properties.
    /// Please note <see cref="DatabaseMigrationProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DatabaseMigrationPropertiesSqlDb"/>, <see cref="DatabaseMigrationPropertiesSqlVm"/> and <see cref="DatabaseMigrationPropertiesSqlMi"/>.
    /// </summary>
    public abstract partial class DatabaseMigrationProperties
    {
        /// <summary> Initializes a new instance of DatabaseMigrationProperties. </summary>
        protected DatabaseMigrationProperties()
        {
        }

        /// <summary> Initializes a new instance of DatabaseMigrationProperties. </summary>
        /// <param name="kind"></param>
        /// <param name="scope"> Resource Id of the target resource (SQL VM or SQL Managed Instance). </param>
        /// <param name="provisioningState"> Provisioning State of migration. ProvisioningState as Succeeded implies that validations have been performed and migration has started. </param>
        /// <param name="migrationStatus"> Migration status. </param>
        /// <param name="startedOn"> Database migration start time. </param>
        /// <param name="endedOn"> Database migration end time. </param>
        /// <param name="sourceSqlConnection"> Source SQL Server connection details. </param>
        /// <param name="sourceDatabaseName"> Name of the source database. </param>
        /// <param name="sourceServerName"> Name of the source sql server. </param>
        /// <param name="migrationService"> Resource Id of the Migration Service. </param>
        /// <param name="migrationOperationId"> ID tracking current migration operation. </param>
        /// <param name="migrationFailureError"> Error details in case of migration failure. </param>
        /// <param name="targetDatabaseCollation"> Database collation to be used for the target database. </param>
        /// <param name="provisioningError"> Error message for migration provisioning failure, if any. </param>
        internal DatabaseMigrationProperties(ResourceType kind, string scope, string provisioningState, string migrationStatus, DateTimeOffset? startedOn, DateTimeOffset? endedOn, SqlConnectionInformation sourceSqlConnection, string sourceDatabaseName, string sourceServerName, string migrationService, string migrationOperationId, ErrorInfo migrationFailureError, string targetDatabaseCollation, string provisioningError)
        {
            Kind = kind;
            Scope = scope;
            ProvisioningState = provisioningState;
            MigrationStatus = migrationStatus;
            StartedOn = startedOn;
            EndedOn = endedOn;
            SourceSqlConnection = sourceSqlConnection;
            SourceDatabaseName = sourceDatabaseName;
            SourceServerName = sourceServerName;
            MigrationService = migrationService;
            MigrationOperationId = migrationOperationId;
            MigrationFailureError = migrationFailureError;
            TargetDatabaseCollation = targetDatabaseCollation;
            ProvisioningError = provisioningError;
        }

        /// <summary> Gets or sets the kind. </summary>
        internal ResourceType Kind { get; set; }
        /// <summary> Resource Id of the target resource (SQL VM or SQL Managed Instance). </summary>
        public string Scope { get; set; }
        /// <summary> Provisioning State of migration. ProvisioningState as Succeeded implies that validations have been performed and migration has started. </summary>
        public string ProvisioningState { get; }
        /// <summary> Migration status. </summary>
        public string MigrationStatus { get; }
        /// <summary> Database migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Database migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Source SQL Server connection details. </summary>
        public SqlConnectionInformation SourceSqlConnection { get; set; }
        /// <summary> Name of the source database. </summary>
        public string SourceDatabaseName { get; set; }
        /// <summary> Name of the source sql server. </summary>
        public string SourceServerName { get; }
        /// <summary> Resource Id of the Migration Service. </summary>
        public string MigrationService { get; set; }
        /// <summary> ID tracking current migration operation. </summary>
        public string MigrationOperationId { get; set; }
        /// <summary> Error details in case of migration failure. </summary>
        public ErrorInfo MigrationFailureError { get; }
        /// <summary> Database collation to be used for the target database. </summary>
        public string TargetDatabaseCollation { get; set; }
        /// <summary> Error message for migration provisioning failure, if any. </summary>
        public string ProvisioningError { get; set; }
    }
}
