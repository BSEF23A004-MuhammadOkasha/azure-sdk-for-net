// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksStateTasksEntityLinkingTasksItem. </summary>
    internal partial class EntityLinkingTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of EntityLinkingTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        internal EntityLinkingTasksItem(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status) : base(lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of EntityLinkingTasksItem. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        /// <param name="results"> . </param>
        internal EntityLinkingTasksItem(DateTimeOffset lastUpdateDateTime, string name, TextAnalyticsOperationStatus status, EntityLinkingResult results) : base(lastUpdateDateTime, name, status)
        {
            Results = results;
        }

        public EntityLinkingResult Results { get; }
    }
}
