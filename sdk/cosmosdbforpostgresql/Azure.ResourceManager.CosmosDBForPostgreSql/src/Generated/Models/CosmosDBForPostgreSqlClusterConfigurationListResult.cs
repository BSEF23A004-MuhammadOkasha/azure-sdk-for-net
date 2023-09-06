// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    /// <summary> A list of cluster configurations. </summary>
    internal partial class CosmosDBForPostgreSqlClusterConfigurationListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlClusterConfigurationListResult"/>. </summary>
        internal CosmosDBForPostgreSqlClusterConfigurationListResult()
        {
            Value = new ChangeTrackingList<CosmosDBForPostgreSqlConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlClusterConfigurationListResult"/>. </summary>
        /// <param name="value"> The list of cluster configurations. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBForPostgreSqlClusterConfigurationListResult(IReadOnlyList<CosmosDBForPostgreSqlConfigurationData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of cluster configurations. </summary>
        public IReadOnlyList<CosmosDBForPostgreSqlConfigurationData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
