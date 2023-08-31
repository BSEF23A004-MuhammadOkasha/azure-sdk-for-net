// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The response of the List Namespace operation. </summary>
    internal partial class EHNamespaceListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EHNamespaceListResult"/>. </summary>
        internal EHNamespaceListResult()
        {
            Value = new ChangeTrackingList<EventHubsNamespaceData>();
        }

        /// <summary> Initializes a new instance of <see cref="EHNamespaceListResult"/>. </summary>
        /// <param name="value"> Result of the List Namespace operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of namespaces. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EHNamespaceListResult(IReadOnlyList<EventHubsNamespaceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Result of the List Namespace operation. </summary>
        public IReadOnlyList<EventHubsNamespaceData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of namespaces. </summary>
        public string NextLink { get; }
    }
}
