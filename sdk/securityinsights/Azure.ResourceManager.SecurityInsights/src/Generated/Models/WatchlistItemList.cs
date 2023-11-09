// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List all the watchlist items. </summary>
    internal partial class WatchlistItemList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WatchlistItemList"/>. </summary>
        /// <param name="value"> Array of watchlist items. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal WatchlistItemList(IEnumerable<SecurityInsightsWatchlistItemData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="WatchlistItemList"/>. </summary>
        /// <param name="nextLink"> URL to fetch the next set of watchlist items. </param>
        /// <param name="value"> Array of watchlist items. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WatchlistItemList(string nextLink, IReadOnlyList<SecurityInsightsWatchlistItemData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WatchlistItemList"/> for deserialization. </summary>
        internal WatchlistItemList()
        {
        }

        /// <summary> URL to fetch the next set of watchlist items. </summary>
        public string NextLink { get; }
        /// <summary> Array of watchlist items. </summary>
        public IReadOnlyList<SecurityInsightsWatchlistItemData> Value { get; }
    }
}
