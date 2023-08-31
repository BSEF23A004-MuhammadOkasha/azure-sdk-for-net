// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Result of the network health check list operation. </summary>
    internal partial class HealthCheckStatusDetailsListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HealthCheckStatusDetailsListResult"/>. </summary>
        internal HealthCheckStatusDetailsListResult()
        {
            Value = new ChangeTrackingList<HealthCheckStatusDetailData>();
        }

        /// <summary> Initializes a new instance of <see cref="HealthCheckStatusDetailsListResult"/>. </summary>
        /// <param name="value"> Current page of results. </param>
        /// <param name="nextLink"> URL to get the next set of results if there are any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthCheckStatusDetailsListResult(IReadOnlyList<HealthCheckStatusDetailData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Current page of results. </summary>
        public IReadOnlyList<HealthCheckStatusDetailData> Value { get; }
        /// <summary> URL to get the next set of results if there are any. </summary>
        public string NextLink { get; }
    }
}
