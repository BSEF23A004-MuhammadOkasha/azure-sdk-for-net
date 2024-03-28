// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Language.AnalyzeText
{
    /// <summary> Parameters object for a text analysis task using custom models. </summary>
    public partial class CustomTaskParameters : TaskParameters
    {
        /// <summary> Initializes a new instance of <see cref="CustomTaskParameters"/>. </summary>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="deploymentName"/> is null. </exception>
        internal CustomTaskParameters(string projectName, string deploymentName)
        {
            Argument.AssertNotNull(projectName, nameof(projectName));
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));

            ProjectName = projectName;
            DeploymentName = deploymentName;
        }

        /// <summary> Initializes a new instance of <see cref="CustomTaskParameters"/>. </summary>
        /// <param name="loggingOptOut"> logging opt out. </param>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        internal CustomTaskParameters(bool? loggingOptOut, string projectName, string deploymentName) : base(loggingOptOut)
        {
            ProjectName = projectName;
            DeploymentName = deploymentName;
        }

        /// <summary> This field indicates the project name for the model. </summary>
        public string ProjectName { get; }
        /// <summary> This field indicates the deployment name for the model. </summary>
        public string DeploymentName { get; }
    }
}
