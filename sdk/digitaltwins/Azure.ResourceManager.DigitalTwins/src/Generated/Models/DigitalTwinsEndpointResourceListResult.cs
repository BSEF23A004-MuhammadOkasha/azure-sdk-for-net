// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> A list of DigitalTwinsInstance Endpoints with a next link. </summary>
    internal partial class DigitalTwinsEndpointResourceListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEndpointResourceListResult"/>. </summary>
        internal DigitalTwinsEndpointResourceListResult()
        {
            Value = new ChangeTrackingList<DigitalTwinsEndpointResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsEndpointResourceListResult"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of DigitalTwinsInstance Endpoints. </param>
        /// <param name="value"> A list of DigitalTwinsInstance Endpoints. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DigitalTwinsEndpointResourceListResult(string nextLink, IReadOnlyList<DigitalTwinsEndpointResourceData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of DigitalTwinsInstance Endpoints. </summary>
        public string NextLink { get; }
        /// <summary> A list of DigitalTwinsInstance Endpoints. </summary>
        public IReadOnlyList<DigitalTwinsEndpointResourceData> Value { get; }
    }
}
