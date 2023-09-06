// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Connection string for the Cosmos DB account. </summary>
    public partial class CosmosDBAccountConnectionString
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountConnectionString"/>. </summary>
        internal CosmosDBAccountConnectionString()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountConnectionString"/>. </summary>
        /// <param name="connectionString"> Value of the connection string. </param>
        /// <param name="description"> Description of the connection string. </param>
        /// <param name="keyKind"> Kind of the connection string key. </param>
        /// <param name="keyType"> Type of the connection string. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBAccountConnectionString(string connectionString, string description, CosmosDBKind? keyKind, CosmosDBType? keyType, Dictionary<string, BinaryData> rawData)
        {
            ConnectionString = connectionString;
            Description = description;
            KeyKind = keyKind;
            KeyType = keyType;
            _rawData = rawData;
        }

        /// <summary> Value of the connection string. </summary>
        public string ConnectionString { get; }
        /// <summary> Description of the connection string. </summary>
        public string Description { get; }
        /// <summary> Kind of the connection string key. </summary>
        public CosmosDBKind? KeyKind { get; }
        /// <summary> Type of the connection string. </summary>
        public CosmosDBType? KeyType { get; }
    }
}
