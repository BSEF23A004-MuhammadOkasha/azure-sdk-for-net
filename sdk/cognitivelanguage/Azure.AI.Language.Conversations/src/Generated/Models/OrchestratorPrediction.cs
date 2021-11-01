// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations
{
    /// <summary> This represents the prediction result of an Orchestrator project. </summary>
    public partial class OrchestratorPrediction : BasePrediction
    {
        /// <summary> Initializes a new instance of OrchestratorPrediction. </summary>
        /// <param name="intents"> A dictionary that contains all intents. A key is an intent name and a value is its confidence score and target type. The top intent&apos;s value also contains the actual response from the target project. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="intents"/> is null. </exception>
        internal OrchestratorPrediction(IReadOnlyDictionary<string, TargetIntentResult> intents)
        {
            if (intents == null)
            {
                throw new ArgumentNullException(nameof(intents));
            }

            Intents = intents;
            ProjectKind = ProjectKind.Workflow;
        }

        /// <summary> Initializes a new instance of OrchestratorPrediction. </summary>
        /// <param name="projectKind"> The type of the project. </param>
        /// <param name="topIntent"> The intent with the highest score. </param>
        /// <param name="intents"> A dictionary that contains all intents. A key is an intent name and a value is its confidence score and target type. The top intent&apos;s value also contains the actual response from the target project. </param>
        internal OrchestratorPrediction(ProjectKind projectKind, string topIntent, IReadOnlyDictionary<string, TargetIntentResult> intents) : base(projectKind, topIntent)
        {
            Intents = intents;
            ProjectKind = projectKind;
        }

        /// <summary> A dictionary that contains all intents. A key is an intent name and a value is its confidence score and target type. The top intent&apos;s value also contains the actual response from the target project. </summary>
        public IReadOnlyDictionary<string, TargetIntentResult> Intents { get; }
    }
}
