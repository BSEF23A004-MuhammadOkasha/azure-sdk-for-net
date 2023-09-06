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
    /// <summary> The List operation response, that contains the Cassandra tables and their properties. </summary>
    internal partial class CassandraTableListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CassandraTableListResult"/>. </summary>
        internal CassandraTableListResult()
        {
            Value = new ChangeTrackingList<CassandraTableData>();
        }

        /// <summary> Initializes a new instance of <see cref="CassandraTableListResult"/>. </summary>
        /// <param name="value"> List of Cassandra tables and their properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraTableListResult(IReadOnlyList<CassandraTableData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> List of Cassandra tables and their properties. </summary>
        public IReadOnlyList<CassandraTableData> Value { get; }
    }
}
