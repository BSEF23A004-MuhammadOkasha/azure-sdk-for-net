// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB MongoDB collection resource object. </summary>
    public partial class MongoDBCollectionResourceInfo
    {
        /// <summary> Initializes a new instance of MongoDBCollectionResourceInfo. </summary>
        /// <param name="collectionName"> Name of the Cosmos DB MongoDB collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> is null. </exception>
        public MongoDBCollectionResourceInfo(string collectionName)
        {
            if (collectionName == null)
            {
                throw new ArgumentNullException(nameof(collectionName));
            }

            CollectionName = collectionName;
            ShardKey = new ChangeTrackingDictionary<string, string>();
            Indexes = new ChangeTrackingList<MongoDBIndex>();
        }

        /// <summary> Initializes a new instance of MongoDBCollectionResourceInfo. </summary>
        /// <param name="collectionName"> Name of the Cosmos DB MongoDB collection. </param>
        /// <param name="shardKey"> A key-value pair of shard keys to be applied for the request. </param>
        /// <param name="indexes"> List of index keys. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        internal MongoDBCollectionResourceInfo(string collectionName, IDictionary<string, string> shardKey, IList<MongoDBIndex> indexes, int? analyticalStorageTtl)
        {
            CollectionName = collectionName;
            ShardKey = shardKey;
            Indexes = indexes;
            AnalyticalStorageTtl = analyticalStorageTtl;
        }

        /// <summary> Name of the Cosmos DB MongoDB collection. </summary>
        public string CollectionName { get; set; }
        /// <summary> A key-value pair of shard keys to be applied for the request. </summary>
        public IDictionary<string, string> ShardKey { get; }
        /// <summary> List of index keys. </summary>
        public IList<MongoDBIndex> Indexes { get; }
        /// <summary> Analytical TTL. </summary>
        public int? AnalyticalStorageTtl { get; set; }
    }
}
