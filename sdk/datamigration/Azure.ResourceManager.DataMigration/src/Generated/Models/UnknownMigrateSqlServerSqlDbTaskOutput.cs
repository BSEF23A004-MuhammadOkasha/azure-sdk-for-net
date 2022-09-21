// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The UnknownMigrateSqlServerSqlDbTaskOutput. </summary>
    internal partial class UnknownMigrateSqlServerSqlDbTaskOutput : MigrateSqlServerSqlDbTaskOutput
    {
        /// <summary> Initializes a new instance of UnknownMigrateSqlServerSqlDbTaskOutput. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        internal UnknownMigrateSqlServerSqlDbTaskOutput(string id, string resultType) : base(id, resultType)
        {
            ResultType = resultType ?? "Unknown";
        }
    }
}
