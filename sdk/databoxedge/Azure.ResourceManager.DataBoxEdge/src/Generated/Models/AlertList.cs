// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Collection of alerts. </summary>
    internal partial class AlertList
    {
        /// <summary> Initializes a new instance of AlertList. </summary>
        internal AlertList()
        {
            Value = new ChangeTrackingList<AlertData>();
        }

        /// <summary> Initializes a new instance of AlertList. </summary>
        /// <param name="value"> The value. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal AlertList(IReadOnlyList<AlertData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The value. </summary>
        public IReadOnlyList<AlertData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
