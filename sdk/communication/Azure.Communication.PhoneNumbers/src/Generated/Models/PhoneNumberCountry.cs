// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents a country. </summary>
    public partial class PhoneNumberCountry
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberCountry"/>. </summary>
        /// <param name="localizedName"> Represents the name of the country. </param>
        /// <param name="countryCode"> Represents the abbreviated name of the country. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="localizedName"/> or <paramref name="countryCode"/> is null. </exception>
        internal PhoneNumberCountry(string localizedName, string countryCode)
        {
            Argument.AssertNotNull(localizedName, nameof(localizedName));
            Argument.AssertNotNull(countryCode, nameof(countryCode));

            LocalizedName = localizedName;
            CountryCode = countryCode;
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberCountry"/>. </summary>
        /// <param name="localizedName"> Represents the name of the country. </param>
        /// <param name="countryCode"> Represents the abbreviated name of the country. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PhoneNumberCountry(string localizedName, string countryCode, Dictionary<string, BinaryData> rawData)
        {
            LocalizedName = localizedName;
            CountryCode = countryCode;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberCountry"/> for deserialization. </summary>
        internal PhoneNumberCountry()
        {
        }

        /// <summary> Represents the name of the country. </summary>
        public string LocalizedName { get; }
        /// <summary> Represents the abbreviated name of the country. </summary>
        public string CountryCode { get; }
    }
}
