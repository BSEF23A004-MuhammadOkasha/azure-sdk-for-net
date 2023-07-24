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
        public ExecutePipelineActivity(string name, DataFactoryPipelineReference pipeline) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(pipeline, nameof(pipeline));

            Pipeline = pipeline;
            Parameters = new ChangeTrackingDictionary<string, BinaryData>();
            ActivityType = "ExecutePipeline";
        }

        /// <summary> Initializes a new instance of ExecutePipelineActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="policy"> Execute pipeline activity policy. </param>
        /// <param name="pipeline"> Pipeline reference. </param>
        /// <param name="parameters"> Pipeline parameters. </param>
        /// <param name="waitOnCompletion"> Defines whether activity execution will wait for the dependent pipeline execution to finish. Default is false. </param>
        internal ExecutePipelineActivity(string name, string activityType, string description, ActivityState? state, ActivityOnInactiveMarkA? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, ExecutePipelineActivityPolicy policy, DataFactoryPipelineReference pipeline, IDictionary<string, BinaryData> parameters, bool? waitOnCompletion) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
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
        public DataFactoryPipelineReference Pipeline { get; set; }
        /// <summary>
        /// Pipeline parameters.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public IDictionary<string, BinaryData> Parameters { get; }
        /// <summary> Defines whether activity execution will wait for the dependent pipeline execution to finish. Default is false. </summary>
        public bool? WaitOnCompletion { get; set; }
    }
}
