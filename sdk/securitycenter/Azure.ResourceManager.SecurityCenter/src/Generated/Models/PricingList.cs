// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of pricing configurations response. </summary>
    internal partial class PricingList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PricingList"/>. </summary>
        /// <param name="value"> List of pricing configurations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PricingList(IEnumerable<SecurityCenterPricingData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PricingList"/>. </summary>
        /// <param name="value"> List of pricing configurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PricingList(IReadOnlyList<SecurityCenterPricingData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PricingList"/> for deserialization. </summary>
        internal PricingList()
        {
        }

        /// <summary> List of pricing configurations. </summary>
        public IReadOnlyList<SecurityCenterPricingData> Value { get; }
    }
}
