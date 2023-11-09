// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List of relations. </summary>
    internal partial class RelationList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RelationList"/>. </summary>
        /// <param name="value"> Array of relations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RelationList(IEnumerable<SecurityInsightsIncidentRelationData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RelationList"/>. </summary>
        /// <param name="nextLink"> URL to fetch the next set of relations. </param>
        /// <param name="value"> Array of relations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RelationList(string nextLink, IReadOnlyList<SecurityInsightsIncidentRelationData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RelationList"/> for deserialization. </summary>
        internal RelationList()
        {
        }

        /// <summary> URL to fetch the next set of relations. </summary>
        public string NextLink { get; }
        /// <summary> Array of relations. </summary>
        public IReadOnlyList<SecurityInsightsIncidentRelationData> Value { get; }
    }
}
