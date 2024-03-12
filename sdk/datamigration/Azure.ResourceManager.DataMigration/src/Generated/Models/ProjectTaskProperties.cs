// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary>
    /// Base class for all types of DMS task properties. If task is not supported by current client, this object is returned.
    /// Please note <see cref="ProjectTaskProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ConnectToMongoDBTaskProperties"/>, <see cref="ConnectToSourceMySqlTaskProperties"/>, <see cref="ConnectToSourceOracleSyncTaskProperties"/>, <see cref="ConnectToSourcePostgreSqlSyncTaskProperties"/>, <see cref="ConnectToSourceSqlServerTaskProperties"/>, <see cref="ConnectToSourceSqlServerSyncTaskProperties"/>, <see cref="ConnectToTargetAzureDBForMySqlTaskProperties"/>, <see cref="ConnectToTargetAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="ConnectToTargetSqlMITaskProperties"/>, <see cref="ConnectToTargetSqlMISyncTaskProperties"/>, <see cref="ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="ConnectToTargetSqlDBTaskProperties"/>, <see cref="ConnectToTargetSqlDBSyncTaskProperties"/>, <see cref="GetTdeCertificatesSqlTaskProperties"/>, <see cref="GetUserTablesSqlSyncTaskProperties"/>, <see cref="GetUserTablesSqlTaskProperties"/>, <see cref="GetUserTablesMySqlTaskProperties"/>, <see cref="GetUserTablesOracleTaskProperties"/>, <see cref="GetUserTablesPostgreSqlTaskProperties"/>, <see cref="MigrateMongoDBTaskProperties"/>, <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskProperties"/>, <see cref="MigrateMySqlAzureDBForMySqlSyncTaskProperties"/>, <see cref="MigrateOracleAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="MigrateSqlServerSqlDBSyncTaskProperties"/>, <see cref="MigrateSqlServerSqlMITaskProperties"/>, <see cref="MigrateSqlServerSqlMISyncTaskProperties"/>, <see cref="MigrateSqlServerSqlDBTaskProperties"/>, <see cref="MigrateSsisTaskProperties"/>, <see cref="MigrateSchemaSqlServerSqlDBTaskProperties"/>, <see cref="CheckOciDriverTaskProperties"/>, <see cref="InstallOciDriverTaskProperties"/>, <see cref="UploadOciDriverTaskProperties"/>, <see cref="ValidateMongoDBTaskProperties"/>, <see cref="ValidateOracleAzureDBForPostgreSqlSyncTaskProperties"/>, <see cref="ValidateMigrationInputSqlServerSqlMITaskProperties"/>, <see cref="ValidateMigrationInputSqlServerSqlMISyncTaskProperties"/> and <see cref="ValidateMigrationInputSqlServerSqlDBSyncTaskProperties"/>.
    /// </summary>
    public abstract partial class ProjectTaskProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProjectTaskProperties"/>. </summary>
        protected ProjectTaskProperties()
        {
            Errors = new ChangeTrackingList<ODataError>();
            Commands = new ChangeTrackingList<CommandProperties>();
            ClientData = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ProjectTaskProperties"/>. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands">
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/>, <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/> and <see cref="MongoDBRestartCommand"/>.
        /// </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProjectTaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TaskType = taskType;
            Errors = errors;
            State = state;
            Commands = commands;
            ClientData = clientData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Task type. </summary>
        internal TaskType TaskType { get; set; }
        /// <summary> Array of errors. This is ignored if submitted. </summary>
        public IReadOnlyList<ODataError> Errors { get; }
        /// <summary> The state of the task. This is ignored if submitted. </summary>
        public TaskState? State { get; }
        /// <summary>
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/>, <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/> and <see cref="MongoDBRestartCommand"/>.
        /// </summary>
        public IReadOnlyList<CommandProperties> Commands { get; }
        /// <summary> Key value pairs of client data to attach meta data information to task. </summary>
        public IDictionary<string, string> ClientData { get; }
    }
}
