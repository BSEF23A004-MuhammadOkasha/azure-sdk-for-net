// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Script activity type. </summary>
    public partial class DataFactoryScriptActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="DataFactoryScriptActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DataFactoryScriptActivity(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Scripts = new ChangeTrackingList<ScriptActivityScriptBlock>();
            ActivityType = "Script";
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryScriptActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="scriptBlockExecutionTimeout"> ScriptBlock execution timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="scripts"> Array of script blocks. Type: array. </param>
        /// <param name="logSettings"> Log settings of script activity. </param>
        internal DataFactoryScriptActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, DataFactoryElement<string> scriptBlockExecutionTimeout, IList<ScriptActivityScriptBlock> scripts, ScriptActivityTypeLogSettings logSettings) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            ScriptBlockExecutionTimeout = scriptBlockExecutionTimeout;
            Scripts = scripts;
            LogSettings = logSettings;
            ActivityType = activityType ?? "Script";
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryScriptActivity"/> for deserialization. </summary>
        internal DataFactoryScriptActivity()
        {
        }

        /// <summary> ScriptBlock execution timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public DataFactoryElement<string> ScriptBlockExecutionTimeout { get; set; }
        /// <summary> Array of script blocks. Type: array. </summary>
        public IList<ScriptActivityScriptBlock> Scripts { get; }
        /// <summary> Log settings of script activity. </summary>
        public ScriptActivityTypeLogSettings LogSettings { get; set; }
    }
}
