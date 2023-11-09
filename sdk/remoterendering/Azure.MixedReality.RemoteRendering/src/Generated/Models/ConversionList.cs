// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> List of conversions. </summary>
    internal partial class ConversionList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConversionList"/>. </summary>
        /// <param name="conversions"> The list of conversions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversions"/> is null. </exception>
        internal ConversionList(IEnumerable<AssetConversion> conversions)
        {
            Argument.AssertNotNull(conversions, nameof(conversions));

            Conversions = conversions.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ConversionList"/>. </summary>
        /// <param name="conversions"> The list of conversions. </param>
        /// <param name="nextLink"> If more conversions are available this field will contain a URL where the next batch of conversions can be requested. This URL will need the same authentication as all calls to the Azure Remote Rendering API. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversionList(IReadOnlyList<AssetConversion> conversions, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Conversions = conversions;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversionList"/> for deserialization. </summary>
        internal ConversionList()
        {
        }

        /// <summary> The list of conversions. </summary>
        public IReadOnlyList<AssetConversion> Conversions { get; }
        /// <summary> If more conversions are available this field will contain a URL where the next batch of conversions can be requested. This URL will need the same authentication as all calls to the Azure Remote Rendering API. </summary>
        public string NextLink { get; }
    }
}
