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
    /// <summary> A list of DigitalTwins description objects with a next link. </summary>
    internal partial class DigitalTwinsDescriptionListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsDescriptionListResult"/>. </summary>
        internal DigitalTwinsDescriptionListResult()
        {
            Value = new ChangeTrackingList<DigitalTwinsDescriptionData>();
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsDescriptionListResult"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of DigitalTwins description objects. </param>
        /// <param name="value"> A list of DigitalTwins description objects. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DigitalTwinsDescriptionListResult(string nextLink, IReadOnlyList<DigitalTwinsDescriptionData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of DigitalTwins description objects. </summary>
        public string NextLink { get; }
        /// <summary> A list of DigitalTwins description objects. </summary>
        public IReadOnlyList<DigitalTwinsDescriptionData> Value { get; }
    }
}
