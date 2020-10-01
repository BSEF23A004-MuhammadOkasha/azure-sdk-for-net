// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CassandraTableGetPropertiesResource. </summary>
    public partial class CassandraTableGetPropertiesResource : CassandraTableResource
    {
        /// <summary> Initializes a new instance of CassandraTableGetPropertiesResource. </summary>
        /// <param name="id"> Name of the Cosmos DB Cassandra table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public CassandraTableGetPropertiesResource(string id) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
        }

        /// <summary> Initializes a new instance of CassandraTableGetPropertiesResource. </summary>
        /// <param name="id"> Name of the Cosmos DB Cassandra table. </param>
        /// <param name="defaultTtl"> Time to live of the Cosmos DB Cassandra table. </param>
        /// <param name="schema"> Schema of the Cosmos DB Cassandra table. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="ts"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal CassandraTableGetPropertiesResource(string id, int? defaultTtl, CassandraSchema schema, int? analyticalStorageTtl, string rid, object ts, string etag) : base(id, defaultTtl, schema, analyticalStorageTtl)
        {
            Rid = rid;
            Ts = ts;
            Etag = etag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public object Ts { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public string Etag { get; }
    }
}
