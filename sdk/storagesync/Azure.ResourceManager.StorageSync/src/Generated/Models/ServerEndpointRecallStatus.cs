// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Server endpoint recall status object. </summary>
    public partial class ServerEndpointRecallStatus
    {
        /// <summary> Initializes a new instance of ServerEndpointRecallStatus. </summary>
        internal ServerEndpointRecallStatus()
        {
            RecallErrors = new ChangeTrackingList<ServerEndpointRecallError>();
        }

        /// <summary> Initializes a new instance of ServerEndpointRecallStatus. </summary>
        /// <param name="lastUpdatedTimestamp"> Last updated timestamp. </param>
        /// <param name="totalRecallErrorsCount"> Total count of recall errors. </param>
        /// <param name="recallErrors"> Array of recall errors. </param>
        internal ServerEndpointRecallStatus(DateTimeOffset? lastUpdatedTimestamp, long? totalRecallErrorsCount, IReadOnlyList<ServerEndpointRecallError> recallErrors)
        {
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            TotalRecallErrorsCount = totalRecallErrorsCount;
            RecallErrors = recallErrors;
        }

        /// <summary> Last updated timestamp. </summary>
        public DateTimeOffset? LastUpdatedTimestamp { get; }
        /// <summary> Total count of recall errors. </summary>
        public long? TotalRecallErrorsCount { get; }
        /// <summary> Array of recall errors. </summary>
        public IReadOnlyList<ServerEndpointRecallError> RecallErrors { get; }
    }
}
