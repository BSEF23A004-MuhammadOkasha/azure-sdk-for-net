// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> Supported parameters for a Custom Single Classification task. </summary>
    public partial class CustomSingleLabelClassificationTaskParameters : CustomTaskParameters
    {
        /// <summary> Initializes a new instance of <see cref="CustomSingleLabelClassificationTaskParameters"/>. </summary>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="deploymentName"/> is null. </exception>
        public CustomSingleLabelClassificationTaskParameters(string projectName, string deploymentName) : base(projectName, deploymentName)
        {
            Argument.AssertNotNull(projectName, nameof(projectName));
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));
        }

        /// <summary> Initializes a new instance of <see cref="CustomSingleLabelClassificationTaskParameters"/>. </summary>
        /// <param name="loggingOptOut"> logging opt out. </param>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        internal CustomSingleLabelClassificationTaskParameters(bool? loggingOptOut, string projectName, string deploymentName) : base(loggingOptOut, projectName, deploymentName)
        {
        }
    }
}
