// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Quota;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Quota limits. </summary>
    internal partial class QuotaLimits
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QuotaLimits"/>. </summary>
        internal QuotaLimits()
        {
            Value = new ChangeTrackingList<CurrentQuotaLimitBaseData>();
        }

        /// <summary> Initializes a new instance of <see cref="QuotaLimits"/>. </summary>
        /// <param name="value"> List of quota limits. </param>
        /// <param name="nextLink"> The URI used to fetch the next page of quota limits. When there are no more pages, this string is null. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaLimits(IReadOnlyList<CurrentQuotaLimitBaseData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of quota limits. </summary>
        public IReadOnlyList<CurrentQuotaLimitBaseData> Value { get; }
        /// <summary> The URI used to fetch the next page of quota limits. When there are no more pages, this string is null. </summary>
        public string NextLink { get; }
    }
}
