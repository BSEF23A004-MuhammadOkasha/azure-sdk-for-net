// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Execute pipeline activity. </summary>
    public partial class ExecutePipelineActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of ExecutePipelineActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="pipeline"> Pipeline reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="pipeline"/> is null. </exception>
        public ExecutePipelineActivity(string name, FactoryPipelineReference pipeline) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (pipeline == null)
            {
                throw new ArgumentNullException(nameof(pipeline));
            }

            Pipeline = pipeline;
            Parameters = new ChangeTrackingDictionary<string, BinaryData>();
            ActivityType = "ExecutePipeline";
        }

        /// <summary> Initializes a new instance of ExecutePipelineActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="policy"> Execute pipeline activity policy. </param>
        /// <param name="pipeline"> Pipeline reference. </param>
        /// <param name="parameters"> Pipeline parameters. </param>
        /// <param name="waitOnCompletion"> Defines whether activity execution will wait for the dependent pipeline execution to finish. Default is false. </param>
        internal ExecutePipelineActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, ExecutePipelineActivityPolicy policy, FactoryPipelineReference pipeline, IDictionary<string, BinaryData> parameters, bool? waitOnCompletion) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            Policy = policy;
            Pipeline = pipeline;
            Parameters = parameters;
            WaitOnCompletion = waitOnCompletion;
            ActivityType = activityType ?? "ExecutePipeline";
        }

        /// <summary> Execute pipeline activity policy. </summary>
        public ExecutePipelineActivityPolicy Policy { get; set; }
        /// <summary> Pipeline reference. </summary>
        public FactoryPipelineReference Pipeline { get; set; }
        /// <summary> Pipeline parameters. </summary>
        public IDictionary<string, BinaryData> Parameters { get; }
        /// <summary> Defines whether activity execution will wait for the dependent pipeline execution to finish. Default is false. </summary>
        public bool? WaitOnCompletion { get; set; }
    }
}
