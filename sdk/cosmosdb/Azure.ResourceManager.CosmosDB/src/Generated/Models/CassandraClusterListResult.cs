// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> List of managed Cassandra clusters. </summary>
    internal partial class CassandraClusterListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CassandraClusterListResult"/>. </summary>
        internal CassandraClusterListResult()
        {
            Value = new ChangeTrackingList<CassandraClusterData>();
        }

        /// <summary> Initializes a new instance of <see cref="CassandraClusterListResult"/>. </summary>
        /// <param name="value"> Container for the array of clusters. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraClusterListResult(IReadOnlyList<CassandraClusterData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Container for the array of clusters. </summary>
        public IReadOnlyList<CassandraClusterData> Value { get; }
    }
}
