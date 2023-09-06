// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB MongoDB collection index options. </summary>
    public partial class MongoDBIndexConfig
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MongoDBIndexConfig"/>. </summary>
        public MongoDBIndexConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBIndexConfig"/>. </summary>
        /// <param name="expireAfterSeconds"> Expire after seconds. </param>
        /// <param name="isUnique"> Is unique or not. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBIndexConfig(int? expireAfterSeconds, bool? isUnique, Dictionary<string, BinaryData> rawData)
        {
            ExpireAfterSeconds = expireAfterSeconds;
            IsUnique = isUnique;
            _rawData = rawData;
        }

        /// <summary> Expire after seconds. </summary>
        public int? ExpireAfterSeconds { get; set; }
        /// <summary> Is unique or not. </summary>
        public bool? IsUnique { get; set; }
    }
}
