// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The TaskState. </summary>
    internal partial class TaskState
    {
        /// <summary> Initializes a new instance of TaskState. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        internal TaskState(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status)
        {
            LastUpdateDateTime = lastUpdateDateTime;
            Status = status;
        }
    }
}
