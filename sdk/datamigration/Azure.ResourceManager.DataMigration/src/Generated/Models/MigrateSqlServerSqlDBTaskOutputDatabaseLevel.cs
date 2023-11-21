// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlDBTaskOutputDatabaseLevel. </summary>
    public partial class MigrateSqlServerSqlDBTaskOutputDatabaseLevel : MigrateSqlServerSqlDBTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBTaskOutputDatabaseLevel"/>. </summary>
        internal MigrateSqlServerSqlDBTaskOutputDatabaseLevel()
        {
            ExceptionsAndWarnings = new ChangeTrackingList<ReportableException>();
            ResultType = "DatabaseLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBTaskOutputDatabaseLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="databaseName"> Name of the item. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <param name="endedOn"> Migration end time. </param>
        /// <param name="state"> Current state of migration. </param>
        /// <param name="stage"> Migration stage that this database is in. </param>
        /// <param name="statusMessage"> Status message. </param>
        /// <param name="message"> Migration progress message. </param>
        /// <param name="numberOfObjects"> Number of objects. </param>
        /// <param name="numberOfObjectsCompleted"> Number of successfully completed objects. </param>
        /// <param name="errorCount"> Number of database/object errors. </param>
        /// <param name="errorPrefix"> Wildcard string prefix to use for querying all errors of the item. </param>
        /// <param name="resultPrefix"> Wildcard string prefix to use for querying all sub-tem results of the item. </param>
        /// <param name="exceptionsAndWarnings"> Migration exceptions and warnings. </param>
        /// <param name="objectSummary"> Summary of object results in the migration. </param>
        internal MigrateSqlServerSqlDBTaskOutputDatabaseLevel(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, string databaseName, DateTimeOffset? startedOn, DateTimeOffset? endedOn, MigrationState? state, DatabaseMigrationStage? stage, string statusMessage, string message, long? numberOfObjects, long? numberOfObjectsCompleted, long? errorCount, string errorPrefix, string resultPrefix, IReadOnlyList<ReportableException> exceptionsAndWarnings, string objectSummary) : base(id, resultType, serializedAdditionalRawData)
        {
            DatabaseName = databaseName;
            StartedOn = startedOn;
            EndedOn = endedOn;
            State = state;
            Stage = stage;
            StatusMessage = statusMessage;
            Message = message;
            NumberOfObjects = numberOfObjects;
            NumberOfObjectsCompleted = numberOfObjectsCompleted;
            ErrorCount = errorCount;
            ErrorPrefix = errorPrefix;
            ResultPrefix = resultPrefix;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            ObjectSummary = objectSummary;
            ResultType = resultType ?? "DatabaseLevelOutput";
        }

        /// <summary> Name of the item. </summary>
        public string DatabaseName { get; }
        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Current state of migration. </summary>
        public MigrationState? State { get; }
        /// <summary> Migration stage that this database is in. </summary>
        public DatabaseMigrationStage? Stage { get; }
        /// <summary> Status message. </summary>
        public string StatusMessage { get; }
        /// <summary> Migration progress message. </summary>
        public string Message { get; }
        /// <summary> Number of objects. </summary>
        public long? NumberOfObjects { get; }
        /// <summary> Number of successfully completed objects. </summary>
        public long? NumberOfObjectsCompleted { get; }
        /// <summary> Number of database/object errors. </summary>
        public long? ErrorCount { get; }
        /// <summary> Wildcard string prefix to use for querying all errors of the item. </summary>
        public string ErrorPrefix { get; }
        /// <summary> Wildcard string prefix to use for querying all sub-tem results of the item. </summary>
        public string ResultPrefix { get; }
        /// <summary> Migration exceptions and warnings. </summary>
        public IReadOnlyList<ReportableException> ExceptionsAndWarnings { get; }
        /// <summary> Summary of object results in the migration. </summary>
        public string ObjectSummary { get; }
    }
}
