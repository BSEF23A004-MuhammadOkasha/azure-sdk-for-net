// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SpringAppDiscovery;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    /// <summary>
    /// List of Sites.
    /// Serialized Name: SummaryList
    /// </summary>
    internal partial class SummaryList
    {
        /// <summary> Initializes a new instance of <see cref="SummaryList"/>. </summary>
        internal SummaryList()
        {
            Value = new ChangeTrackingList<SpringBootSiteSummaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="SummaryList"/>. </summary>
        /// <param name="value">
        /// List of Sites.
        /// Serialized Name: SummaryList.value
        /// </param>
        /// <param name="nextLink">
        /// Url to follow for getting next page of resources.
        /// Serialized Name: SummaryList.nextLink
        /// </param>
        internal SummaryList(IReadOnlyList<SpringBootSiteSummaryData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// List of Sites.
        /// Serialized Name: SummaryList.value
        /// </summary>
        public IReadOnlyList<SpringBootSiteSummaryData> Value { get; }
        /// <summary>
        /// Url to follow for getting next page of resources.
        /// Serialized Name: SummaryList.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
