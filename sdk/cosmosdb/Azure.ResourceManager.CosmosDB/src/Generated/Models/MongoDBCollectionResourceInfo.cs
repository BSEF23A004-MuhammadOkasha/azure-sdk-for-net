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
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionResourceInfo"/>. </summary>
        /// <param name="collectionName"> Name of the Cosmos DB MongoDB collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> is null. </exception>
        public MongoDBCollectionResourceInfo(string collectionName)
        {
            Argument.AssertNotNull(collectionName, nameof(collectionName));

            CollectionName = collectionName;
            ShardKey = new ChangeTrackingDictionary<string, string>();
            Indexes = new ChangeTrackingList<MongoDBIndex>();
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionResourceInfo"/>. </summary>
        /// <param name="collectionName"> Name of the Cosmos DB MongoDB collection. </param>
        /// <param name="shardKey"> A key-value pair of shard keys to be applied for the request. </param>
        /// <param name="indexes"> List of index keys. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBCollectionResourceInfo(string collectionName, IDictionary<string, string> shardKey, IList<MongoDBIndex> indexes, int? analyticalStorageTtl, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, Dictionary<string, BinaryData> rawData)
        {
            CollectionName = collectionName;
            ShardKey = shardKey;
            Indexes = indexes;
            AnalyticalStorageTtl = analyticalStorageTtl;
            RestoreParameters = restoreParameters;
            CreateMode = createMode;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionResourceInfo"/> for deserialization. </summary>
        internal MongoDBCollectionResourceInfo()
        {
        }

        /// <summary> Name of the Cosmos DB MongoDB collection. </summary>
        public string CollectionName { get; set; }
        /// <summary> A key-value pair of shard keys to be applied for the request. </summary>
        public IDictionary<string, string> ShardKey { get; }
        /// <summary> List of index keys. </summary>
        public IList<MongoDBIndex> Indexes { get; }
        /// <summary> Analytical TTL. </summary>
        public int? AnalyticalStorageTtl { get; set; }
        /// <summary> Parameters to indicate the information about the restore. </summary>
        public ResourceRestoreParameters RestoreParameters { get; set; }
        /// <summary> Enum to indicate the mode of resource creation. </summary>
        public CosmosDBAccountCreateMode? CreateMode { get; set; }
    }
}
