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
    /// <summary> List of IoT Security solutions. </summary>
    internal partial class IotSecuritySolutionsList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionsList"/>. </summary>
        /// <param name="value"> List of IoT Security solutions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal IotSecuritySolutionsList(IEnumerable<IotSecuritySolutionData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionsList"/>. </summary>
        /// <param name="value"> List of IoT Security solutions. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotSecuritySolutionsList(IReadOnlyList<IotSecuritySolutionData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionsList"/> for deserialization. </summary>
        internal IotSecuritySolutionsList()
        {
        }

        /// <summary> List of IoT Security solutions. </summary>
        public IReadOnlyList<IotSecuritySolutionData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
