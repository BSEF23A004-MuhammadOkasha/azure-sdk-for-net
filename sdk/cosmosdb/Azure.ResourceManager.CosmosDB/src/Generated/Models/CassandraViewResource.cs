// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Cassandra view resource object. </summary>
    public partial class CassandraViewResource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CassandraViewResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB Cassandra view. </param>
        /// <param name="viewDefinition"> View Definition of the Cosmos DB Cassandra view. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="viewDefinition"/> is null. </exception>
        public CassandraViewResource(string id, string viewDefinition)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(viewDefinition, nameof(viewDefinition));

            Id = id;
            ViewDefinition = viewDefinition;
        }

        /// <summary> Initializes a new instance of <see cref="CassandraViewResource"/>. </summary>
        /// <param name="id"> Name of the Cosmos DB Cassandra view. </param>
        /// <param name="viewDefinition"> View Definition of the Cosmos DB Cassandra view. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraViewResource(string id, string viewDefinition, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            ViewDefinition = viewDefinition;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CassandraViewResource"/> for deserialization. </summary>
        internal CassandraViewResource()
        {
        }

        /// <summary> Name of the Cosmos DB Cassandra view. </summary>
        public string Id { get; set; }
        /// <summary> View Definition of the Cosmos DB Cassandra view. </summary>
        public string ViewDefinition { get; set; }
    }
}
