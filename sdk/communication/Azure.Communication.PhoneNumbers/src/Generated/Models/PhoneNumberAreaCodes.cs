// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> The list of available area codes. </summary>
    internal partial class PhoneNumberAreaCodes
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberAreaCodes"/>. </summary>
        /// <param name="areaCodes"> Represents a list of available toll-free area codes. </param>
        /// <param name="nextLink"> Represents the URL link to the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PhoneNumberAreaCodes(IReadOnlyList<PhoneNumberAreaCode> areaCodes, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            AreaCodes = areaCodes;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberAreaCodes"/> for deserialization. </summary>
        internal PhoneNumberAreaCodes()
        {
        }
    }
}
