// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the task that migrates PostgreSQL databases to Azure Database for PostgreSQL for online migrations. </summary>
    public partial class MigratePostgreSqlAzureDbForPostgreSqlSyncTaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of MigratePostgreSqlAzureDbForPostgreSqlSyncTaskProperties. </summary>
        public MigratePostgreSqlAzureDbForPostgreSqlSyncTaskProperties()
        {
            Output = new ChangeTrackingList<MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput>();
            TaskType = TaskType.MigratePostgreSqlAzureDbForPostgreSqlSyncV2;
        }

        /// <summary> Initializes a new instance of MigratePostgreSqlAzureDbForPostgreSqlSyncTaskProperties. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands">
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/>, <see cref="MongoDbCancelCommand"/>, <see cref="MongoDbFinishCommand"/> and <see cref="MongoDbRestartCommand"/>.
        /// </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="input"> Task input. </param>
        /// <param name="output">
        /// Task output. This is ignored if submitted.
        /// Please note <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputDatabaseError"/>, <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputDatabaseLevel"/>, <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputError"/>, <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputMigrationLevel"/> and <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputTableLevel"/>.
        /// </param>
        /// <param name="taskId"> task id. </param>
        /// <param name="createdOn"> DateTime in UTC when the task was created. </param>
        /// <param name="isCloneable"> whether the task can be cloned or not. </param>
        internal MigratePostgreSqlAzureDbForPostgreSqlSyncTaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, MigratePostgreSqlAzureDbForPostgreSqlSyncTaskInput input, IReadOnlyList<MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput> output, string taskId, string createdOn, bool? isCloneable) : base(taskType, errors, state, commands, clientData)
        {
            Input = input;
            Output = output;
            TaskId = taskId;
            CreatedOn = createdOn;
            IsCloneable = isCloneable;
            TaskType = taskType;
        }

        /// <summary> Task input. </summary>
        public MigratePostgreSqlAzureDbForPostgreSqlSyncTaskInput Input { get; set; }
        /// <summary>
        /// Task output. This is ignored if submitted.
        /// Please note <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputDatabaseError"/>, <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputDatabaseLevel"/>, <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputError"/>, <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputMigrationLevel"/> and <see cref="MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputTableLevel"/>.
        /// </summary>
        public IReadOnlyList<MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput> Output { get; }
        /// <summary> task id. </summary>
        public string TaskId { get; set; }
        /// <summary> DateTime in UTC when the task was created. </summary>
        public string CreatedOn { get; set; }
        /// <summary> whether the task can be cloned or not. </summary>
        public bool? IsCloneable { get; set; }
    }
}
