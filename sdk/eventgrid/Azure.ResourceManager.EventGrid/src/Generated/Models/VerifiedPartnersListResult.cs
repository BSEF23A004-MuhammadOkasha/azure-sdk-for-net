// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List verified partners operation. </summary>
    internal partial class VerifiedPartnersListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VerifiedPartnersListResult"/>. </summary>
        internal VerifiedPartnersListResult()
        {
            Value = new ChangeTrackingList<VerifiedPartnerData>();
        }

        /// <summary> Initializes a new instance of <see cref="VerifiedPartnersListResult"/>. </summary>
        /// <param name="value"> A collection of verified partners. </param>
        /// <param name="nextLink"> A link for the next page of verified partners if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VerifiedPartnersListResult(IReadOnlyList<VerifiedPartnerData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A collection of verified partners. </summary>
        public IReadOnlyList<VerifiedPartnerData> Value { get; }
        /// <summary> A link for the next page of verified partners if any. </summary>
        public string NextLink { get; }
    }
}
