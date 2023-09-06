// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A list of active debug sessions. </summary>
    internal partial class DataFlowDebugSessionInfoListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugSessionInfoListResult"/>. </summary>
        internal DataFlowDebugSessionInfoListResult()
        {
            Value = new ChangeTrackingList<DataFlowDebugSessionInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugSessionInfoListResult"/>. </summary>
        /// <param name="value"> Array with all active debug sessions. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFlowDebugSessionInfoListResult(IReadOnlyList<DataFlowDebugSessionInfo> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Array with all active debug sessions. </summary>
        public IReadOnlyList<DataFlowDebugSessionInfo> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
