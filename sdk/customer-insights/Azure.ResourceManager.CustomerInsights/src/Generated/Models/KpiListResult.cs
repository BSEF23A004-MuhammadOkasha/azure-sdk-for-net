// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list KPI operation. </summary>
    internal partial class KpiListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KpiListResult"/>. </summary>
        internal KpiListResult()
        {
            Value = new ChangeTrackingList<KpiResourceFormatData>();
        }

        /// <summary> Initializes a new instance of <see cref="KpiListResult"/>. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KpiListResult(IReadOnlyList<KpiResourceFormatData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<KpiResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
