// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List of available columns for sorting. </summary>
    public partial class ThreatIntelligenceSortingCriteria
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceSortingCriteria"/>. </summary>
        public ThreatIntelligenceSortingCriteria()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceSortingCriteria"/>. </summary>
        /// <param name="itemKey"> Column name. </param>
        /// <param name="sortOrder"> Sorting order (ascending/descending/unsorted). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreatIntelligenceSortingCriteria(string itemKey, ThreatIntelligenceSortingOrder? sortOrder, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ItemKey = itemKey;
            SortOrder = sortOrder;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Column name. </summary>
        public string ItemKey { get; set; }
        /// <summary> Sorting order (ascending/descending/unsorted). </summary>
        public ThreatIntelligenceSortingOrder? SortOrder { get; set; }
    }
}
