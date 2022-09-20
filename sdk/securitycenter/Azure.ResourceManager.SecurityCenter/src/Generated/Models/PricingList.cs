// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of pricing configurations response. </summary>
    internal partial class PricingList
    {
        /// <summary> Initializes a new instance of PricingList. </summary>
        /// <param name="value"> List of pricing configurations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PricingList(IEnumerable<PricingData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of PricingList. </summary>
        /// <param name="value"> List of pricing configurations. </param>
        internal PricingList(IReadOnlyList<PricingData> value)
        {
            Value = value;
        }

        /// <summary> List of pricing configurations. </summary>
        public IReadOnlyList<PricingData> Value { get; }
    }
}
