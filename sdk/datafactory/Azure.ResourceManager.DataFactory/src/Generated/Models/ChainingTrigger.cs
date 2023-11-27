// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Trigger that allows the referenced pipeline to depend on other pipeline runs based on runDimension Name/Value pairs. Upstream pipelines should declare the same runDimension Name and their runs should have the values for those runDimensions. The referenced pipeline run would be triggered if the values for the runDimension match for all upstream pipeline runs. </summary>
    public partial class ChainingTrigger : DataFactoryTriggerProperties
    {
        /// <summary> Initializes a new instance of <see cref="ChainingTrigger"/>. </summary>
        /// <param name="pipeline"> Pipeline for which runs are created when all upstream pipelines complete successfully. </param>
        /// <param name="dependsOn"> Upstream Pipelines. </param>
        /// <param name="runDimension"> Run Dimension property that needs to be emitted by upstream pipelines. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/>, <paramref name="dependsOn"/> or <paramref name="runDimension"/> is null. </exception>
        public ChainingTrigger(TriggerPipelineReference pipeline, IEnumerable<DataFactoryPipelineReference> dependsOn, string runDimension)
        {
            Argument.AssertNotNull(pipeline, nameof(pipeline));
            Argument.AssertNotNull(dependsOn, nameof(dependsOn));
            Argument.AssertNotNull(runDimension, nameof(runDimension));

            Pipeline = pipeline;
            DependsOn = dependsOn.ToList();
            RunDimension = runDimension;
            TriggerType = "ChainingTrigger";
        }

        /// <summary> Initializes a new instance of <see cref="ChainingTrigger"/>. </summary>
        /// <param name="triggerType"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="pipeline"> Pipeline for which runs are created when all upstream pipelines complete successfully. </param>
        /// <param name="dependsOn"> Upstream Pipelines. </param>
        /// <param name="runDimension"> Run Dimension property that needs to be emitted by upstream pipelines. </param>
        internal ChainingTrigger(string triggerType, string description, DataFactoryTriggerRuntimeState? runtimeState, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, TriggerPipelineReference pipeline, IList<DataFactoryPipelineReference> dependsOn, string runDimension) : base(triggerType, description, runtimeState, annotations, additionalProperties)
        {
            Pipeline = pipeline;
            DependsOn = dependsOn;
            RunDimension = runDimension;
            TriggerType = triggerType ?? "ChainingTrigger";
        }

        /// <summary> Pipeline for which runs are created when all upstream pipelines complete successfully. </summary>
        public TriggerPipelineReference Pipeline { get; set; }
        /// <summary> Upstream Pipelines. </summary>
        public IList<DataFactoryPipelineReference> DependsOn { get; }
        /// <summary> Run Dimension property that needs to be emitted by upstream pipelines. </summary>
        public string RunDimension { get; set; }
    }
}
