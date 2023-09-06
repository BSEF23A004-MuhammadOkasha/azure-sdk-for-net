// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> The phone number search purchase request. </summary>
    internal partial class PhoneNumberPurchaseRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberPurchaseRequest"/>. </summary>
        public PhoneNumberPurchaseRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberPurchaseRequest"/>. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PhoneNumberPurchaseRequest(string searchId, Dictionary<string, BinaryData> rawData)
        {
            SearchId = searchId;
            _rawData = rawData;
        }

        /// <summary> The search id. </summary>
        public string SearchId { get; set; }
    }
}
