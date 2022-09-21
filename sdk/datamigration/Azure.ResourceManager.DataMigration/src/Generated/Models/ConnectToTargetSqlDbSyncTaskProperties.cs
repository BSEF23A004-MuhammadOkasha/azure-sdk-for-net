// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the task that validates connection to SQL DB and target server requirements for online migration. </summary>
    public partial class ConnectToTargetSqlDbSyncTaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of ConnectToTargetSqlDbSyncTaskProperties. </summary>
        public ConnectToTargetSqlDbSyncTaskProperties()
        {
            Output = new ChangeTrackingList<ConnectToTargetSqlDbTaskOutput>();
            TaskType = TaskType.ConnectToTargetSqlDbSync;
        }

        /// <summary> Initializes a new instance of ConnectToTargetSqlDbSyncTaskProperties. </summary>
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
        /// <param name="output"> Task output. This is ignored if submitted. </param>
        internal ConnectToTargetSqlDbSyncTaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, ConnectToTargetSqlDbSyncTaskInput input, IReadOnlyList<ConnectToTargetSqlDbTaskOutput> output) : base(taskType, errors, state, commands, clientData)
        {
            Input = input;
            Output = output;
            TaskType = taskType;
        }

        /// <summary> Task input. </summary>
        public ConnectToTargetSqlDbSyncTaskInput Input { get; set; }
        /// <summary> Task output. This is ignored if submitted. </summary>
        public IReadOnlyList<ConnectToTargetSqlDbTaskOutput> Output { get; }
    }
}
