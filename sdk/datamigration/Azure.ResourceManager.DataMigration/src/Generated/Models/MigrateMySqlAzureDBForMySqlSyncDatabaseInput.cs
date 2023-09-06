// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database specific information for MySQL to Azure Database for MySQL migration task inputs. </summary>
    public partial class MigrateMySqlAzureDBForMySqlSyncDatabaseInput
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MigrateMySqlAzureDBForMySqlSyncDatabaseInput"/>. </summary>
        public MigrateMySqlAzureDBForMySqlSyncDatabaseInput()
        {
            MigrationSetting = new ChangeTrackingDictionary<string, string>();
            SourceSetting = new ChangeTrackingDictionary<string, string>();
            TargetSetting = new ChangeTrackingDictionary<string, string>();
            TableMap = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MigrateMySqlAzureDBForMySqlSyncDatabaseInput"/>. </summary>
        /// <param name="name"> Name of the database. </param>
        /// <param name="targetDatabaseName"> Name of target database. Note: Target database will be truncated before starting migration. </param>
        /// <param name="migrationSetting"> Migration settings which tune the migration behavior. </param>
        /// <param name="sourceSetting"> Source settings to tune source endpoint migration behavior. </param>
        /// <param name="targetSetting"> Target settings to tune target endpoint migration behavior. </param>
        /// <param name="tableMap"> Mapping of source to target tables. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateMySqlAzureDBForMySqlSyncDatabaseInput(string name, string targetDatabaseName, IDictionary<string, string> migrationSetting, IDictionary<string, string> sourceSetting, IDictionary<string, string> targetSetting, IDictionary<string, string> tableMap, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            TargetDatabaseName = targetDatabaseName;
            MigrationSetting = migrationSetting;
            SourceSetting = sourceSetting;
            TargetSetting = targetSetting;
            TableMap = tableMap;
            _rawData = rawData;
        }

        /// <summary> Name of the database. </summary>
        public string Name { get; set; }
        /// <summary> Name of target database. Note: Target database will be truncated before starting migration. </summary>
        public string TargetDatabaseName { get; set; }
        /// <summary> Migration settings which tune the migration behavior. </summary>
        public IDictionary<string, string> MigrationSetting { get; }
        /// <summary> Source settings to tune source endpoint migration behavior. </summary>
        public IDictionary<string, string> SourceSetting { get; }
        /// <summary> Target settings to tune target endpoint migration behavior. </summary>
        public IDictionary<string, string> TargetSetting { get; }
        /// <summary> Mapping of source to target tables. </summary>
        public IDictionary<string, string> TableMap { get; }
    }
}
