// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> The incurred cost for a single phone number. </summary>
    public partial class PhoneNumberCost
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberCost"/>. </summary>
        /// <param name="amount"> The cost amount. </param>
        /// <param name="isoCurrencySymbol"> The ISO 4217 currency code for the cost amount, e.g. USD. </param>
        /// <param name="billingFrequency"> The frequency with which the cost gets billed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="isoCurrencySymbol"/> is null. </exception>
        internal PhoneNumberCost(double amount, string isoCurrencySymbol, BillingFrequency billingFrequency)
        {
            Argument.AssertNotNull(isoCurrencySymbol, nameof(isoCurrencySymbol));

            Amount = amount;
            IsoCurrencySymbol = isoCurrencySymbol;
            BillingFrequency = billingFrequency;
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberCost"/>. </summary>
        /// <param name="amount"> The cost amount. </param>
        /// <param name="isoCurrencySymbol"> The ISO 4217 currency code for the cost amount, e.g. USD. </param>
        /// <param name="billingFrequency"> The frequency with which the cost gets billed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PhoneNumberCost(double amount, string isoCurrencySymbol, BillingFrequency billingFrequency, Dictionary<string, BinaryData> rawData)
        {
            Amount = amount;
            IsoCurrencySymbol = isoCurrencySymbol;
            BillingFrequency = billingFrequency;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberCost"/> for deserialization. </summary>
        internal PhoneNumberCost()
        {
        }

        /// <summary> The cost amount. </summary>
        public double Amount { get; }
        /// <summary> The frequency with which the cost gets billed. </summary>
        public BillingFrequency BillingFrequency { get; }
    }
}
