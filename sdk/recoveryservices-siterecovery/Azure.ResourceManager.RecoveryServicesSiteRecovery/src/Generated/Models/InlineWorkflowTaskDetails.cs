// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class represents the inline workflow task details. </summary>
    public partial class InlineWorkflowTaskDetails : GroupTaskDetails
    {
        /// <summary> Initializes a new instance of InlineWorkflowTaskDetails. </summary>
        internal InlineWorkflowTaskDetails()
        {
            WorkflowIds = new ChangeTrackingList<string>();
            InstanceType = "InlineWorkflowTaskDetails";
        }

        /// <summary> Initializes a new instance of InlineWorkflowTaskDetails. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        /// <param name="childTasks"> The child tasks. </param>
        /// <param name="workflowIds"> The list of child workflow ids. </param>
        internal InlineWorkflowTaskDetails(string instanceType, IReadOnlyList<ASRTask> childTasks, IReadOnlyList<string> workflowIds) : base(instanceType, childTasks)
        {
            WorkflowIds = workflowIds;
            InstanceType = instanceType ?? "InlineWorkflowTaskDetails";
        }

        /// <summary> The list of child workflow ids. </summary>
        public IReadOnlyList<string> WorkflowIds { get; }
    }
}
