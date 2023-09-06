// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A list of linked service resources. </summary>
    internal partial class DataFactoryPrivateEndpointConnectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataFactoryPrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> List of Private Endpoint Connections. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataFactoryPrivateEndpointConnectionListResult(IEnumerable<DataFactoryPrivateEndpointConnectionData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> List of Private Endpoint Connections. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryPrivateEndpointConnectionListResult(IReadOnlyList<DataFactoryPrivateEndpointConnectionData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPrivateEndpointConnectionListResult"/> for deserialization. </summary>
        internal DataFactoryPrivateEndpointConnectionListResult()
        {
        }

        /// <summary> List of Private Endpoint Connections. </summary>
        public IReadOnlyList<DataFactoryPrivateEndpointConnectionData> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
