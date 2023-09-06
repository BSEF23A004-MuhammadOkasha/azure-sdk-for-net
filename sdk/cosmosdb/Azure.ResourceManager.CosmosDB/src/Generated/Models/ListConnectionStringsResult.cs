// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The connection strings for the given mongo cluster. </summary>
    public partial class ListConnectionStringsResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ListConnectionStringsResult"/>. </summary>
        internal ListConnectionStringsResult()
        {
            ConnectionStrings = new ChangeTrackingList<CosmosDBConnectionString>();
        }

        /// <summary> Initializes a new instance of <see cref="ListConnectionStringsResult"/>. </summary>
        /// <param name="connectionStrings"> An array that contains the connection strings for a mongo cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ListConnectionStringsResult(IReadOnlyList<CosmosDBConnectionString> connectionStrings, Dictionary<string, BinaryData> rawData)
        {
            ConnectionStrings = connectionStrings;
            _rawData = rawData;
        }

        /// <summary> An array that contains the connection strings for a mongo cluster. </summary>
        public IReadOnlyList<CosmosDBConnectionString> ConnectionStrings { get; }
    }
}
