// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents a wrapper around a list of offerings. </summary>
    internal partial class OfferingsResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OfferingsResponse"/>. </summary>
        /// <param name="phoneNumberOfferings"> Represents the underlying list of offerings. </param>
        /// <param name="nextLink"> Represents the URL link to the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OfferingsResponse(IReadOnlyList<PhoneNumberOffering> phoneNumberOfferings, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            PhoneNumberOfferings = phoneNumberOfferings;
            NextLink = nextLink;
            _rawData = rawData;
        }
    }
}
