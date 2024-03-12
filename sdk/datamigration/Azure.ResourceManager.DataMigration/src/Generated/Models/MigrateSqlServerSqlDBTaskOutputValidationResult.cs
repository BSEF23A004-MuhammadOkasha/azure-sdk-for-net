// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlDBTaskOutputValidationResult. </summary>
    public partial class MigrateSqlServerSqlDBTaskOutputValidationResult : MigrateSqlServerSqlDBTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBTaskOutputValidationResult"/>. </summary>
        internal MigrateSqlServerSqlDBTaskOutputValidationResult()
        {
            SummaryResults = new ChangeTrackingDictionary<string, MigrationValidationDatabaseSummaryResult>();
            ResultType = "MigrationValidationOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBTaskOutputValidationResult"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="migrationId"> Migration Identifier. </param>
        /// <param name="summaryResults"> Validation summary results for each database. </param>
        /// <param name="status"> Current status of validation at the migration level. Status from the database validation result status will be aggregated here. </param>
        internal MigrateSqlServerSqlDBTaskOutputValidationResult(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, string migrationId, IReadOnlyDictionary<string, MigrationValidationDatabaseSummaryResult> summaryResults, ValidationStatus? status) : base(id, resultType, serializedAdditionalRawData)
        {
            MigrationId = migrationId;
            SummaryResults = summaryResults;
            Status = status;
            ResultType = resultType ?? "MigrationValidationOutput";
        }

        /// <summary> Migration Identifier. </summary>
        public string MigrationId { get; }
        /// <summary> Validation summary results for each database. </summary>
        public IReadOnlyDictionary<string, MigrationValidationDatabaseSummaryResult> SummaryResults { get; }
        /// <summary> Current status of validation at the migration level. Status from the database validation result status will be aggregated here. </summary>
        public ValidationStatus? Status { get; }
    }
}
