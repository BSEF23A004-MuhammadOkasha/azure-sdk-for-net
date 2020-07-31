// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Messaging.EventGrid.SystemEvents;

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    /// <summary> Job output canceled event data. </summary>
    public partial class MediaJobOutputCanceledEventData : MediaJobOutputStateChangeEventData
    {
        /// <summary> Initializes a new instance of MediaJobOutputCanceledEventData. </summary>
        internal MediaJobOutputCanceledEventData()
        {
        }

        /// <summary> Initializes a new instance of MediaJobOutputCanceledEventData. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="output"> Gets the output. </param>
        /// <param name="jobCorrelationData"> Gets the Job correlation data. </param>
        internal MediaJobOutputCanceledEventData(MediaJobState? previousState, MediaJobOutput output, IReadOnlyDictionary<string, string> jobCorrelationData) : base(previousState, output, jobCorrelationData)
        {
        }
    }
}
