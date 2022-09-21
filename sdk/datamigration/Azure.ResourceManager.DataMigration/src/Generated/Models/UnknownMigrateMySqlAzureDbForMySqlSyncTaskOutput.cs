// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The UnknownMigrateMySqlAzureDbForMySqlSyncTaskOutput. </summary>
    internal partial class UnknownMigrateMySqlAzureDbForMySqlSyncTaskOutput : MigrateMySqlAzureDbForMySqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of UnknownMigrateMySqlAzureDbForMySqlSyncTaskOutput. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        internal UnknownMigrateMySqlAzureDbForMySqlSyncTaskOutput(string id, string resultType) : base(id, resultType)
        {
            ResultType = resultType ?? "Unknown";
        }
    }
}
