// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Selected tables for the migration. </summary>
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput"/>. </summary>
        public MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput"/>. </summary>
        /// <param name="name"> Name of the table to migrate. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Name of the table to migrate. </summary>
        public string Name { get; set; }
    }
}
