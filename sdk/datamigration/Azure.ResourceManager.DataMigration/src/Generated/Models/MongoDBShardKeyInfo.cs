// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes a MongoDB shard key. </summary>
    public partial class MongoDBShardKeyInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MongoDBShardKeyInfo"/>. </summary>
        /// <param name="fields"> The fields within the shard key. </param>
        /// <param name="isUnique"> Whether the shard key is unique. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fields"/> is null. </exception>
        internal MongoDBShardKeyInfo(IEnumerable<MongoDBShardKeyField> fields, bool isUnique)
        {
            Argument.AssertNotNull(fields, nameof(fields));

            Fields = fields.ToList();
            IsUnique = isUnique;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBShardKeyInfo"/>. </summary>
        /// <param name="fields"> The fields within the shard key. </param>
        /// <param name="isUnique"> Whether the shard key is unique. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBShardKeyInfo(IReadOnlyList<MongoDBShardKeyField> fields, bool isUnique, Dictionary<string, BinaryData> rawData)
        {
            Fields = fields;
            IsUnique = isUnique;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBShardKeyInfo"/> for deserialization. </summary>
        internal MongoDBShardKeyInfo()
        {
        }

        /// <summary> The fields within the shard key. </summary>
        public IReadOnlyList<MongoDBShardKeyField> Fields { get; }
        /// <summary> Whether the shard key is unique. </summary>
        public bool IsUnique { get; }
    }
}
