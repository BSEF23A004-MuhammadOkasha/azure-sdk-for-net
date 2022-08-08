// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The request history. </summary>
    public partial class LogicWorkflowRequestHistoryProperties
    {
        /// <summary> Initializes a new instance of LogicWorkflowRequestHistoryProperties. </summary>
        public LogicWorkflowRequestHistoryProperties()
        {
        }

        /// <summary> Initializes a new instance of LogicWorkflowRequestHistoryProperties. </summary>
        /// <param name="startOn"> The time the request started. </param>
        /// <param name="endOn"> The time the request ended. </param>
        /// <param name="request"> The request. </param>
        /// <param name="response"> The response. </param>
        internal LogicWorkflowRequestHistoryProperties(DateTimeOffset? startOn, DateTimeOffset? endOn, LogicWorkflowRequest request, LogicWorkflowResponse response)
        {
            StartOn = startOn;
            EndOn = endOn;
            Request = request;
            Response = response;
        }

        /// <summary> The time the request started. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> The time the request ended. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> The request. </summary>
        public LogicWorkflowRequest Request { get; set; }
        /// <summary> The response. </summary>
        public LogicWorkflowResponse Response { get; set; }
    }
}
