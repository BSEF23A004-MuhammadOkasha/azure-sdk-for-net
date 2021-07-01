// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Route.Models
{
    /// <summary> This object is returned from a successful Batch service call. Extend with &apos;batchItems&apos; property. </summary>
    public partial class BatchResponse
    {
        /// <summary> Initializes a new instance of BatchResponse. </summary>
        internal BatchResponse()
        {
        }

        /// <summary> Initializes a new instance of BatchResponse. </summary>
        /// <param name="summary"> Summary for the batch request. </param>
        internal BatchResponse(BatchResponseSummary summary)
        {
            Summary = summary;
        }

        /// <summary> Summary for the batch request. </summary>
        public BatchResponseSummary Summary { get; }
    }
}
