// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> A list of private endpoint connections. </summary>
    internal partial class PostgreSqlPrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of PostgreSqlPrivateEndpointConnectionListResult. </summary>
        internal PostgreSqlPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of PostgreSqlPrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal PostgreSqlPrivateEndpointConnectionListResult(IReadOnlyList<PostgreSqlPrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<PostgreSqlPrivateEndpointConnectionData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
