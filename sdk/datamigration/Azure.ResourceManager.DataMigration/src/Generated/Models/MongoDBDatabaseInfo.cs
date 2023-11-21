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
    /// <summary> Describes a database within a MongoDB data source. </summary>
    public partial class MongoDBDatabaseInfo : MongoDBObjectInfo
    {
        /// <summary> Initializes a new instance of <see cref="MongoDBDatabaseInfo"/>. </summary>
        /// <param name="averageDocumentSize"> The average document size, or -1 if the average size is unknown. </param>
        /// <param name="dataSize"> The estimated total data size, in bytes, or -1 if the size is unknown. </param>
        /// <param name="documentCount"> The estimated total number of documents, or -1 if the document count is unknown. </param>
        /// <param name="name"> The unqualified name of the database or collection. </param>
        /// <param name="qualifiedName"> The qualified name of the database or collection. For a collection, this is the database-qualified name. </param>
        /// <param name="collections"> A list of supported collections in a MongoDB database. </param>
        /// <param name="supportsSharding"> Whether the database has sharding enabled. Note that the migration task will enable sharding on the target if necessary. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="qualifiedName"/> or <paramref name="collections"/> is null. </exception>
        internal MongoDBDatabaseInfo(long averageDocumentSize, long dataSize, long documentCount, string name, string qualifiedName, IEnumerable<MongoDBCollectionInfo> collections, bool supportsSharding) : base(averageDocumentSize, dataSize, documentCount, name, qualifiedName)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(qualifiedName, nameof(qualifiedName));
            Argument.AssertNotNull(collections, nameof(collections));

            Collections = collections.ToList();
            SupportsSharding = supportsSharding;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBDatabaseInfo"/>. </summary>
        /// <param name="averageDocumentSize"> The average document size, or -1 if the average size is unknown. </param>
        /// <param name="dataSize"> The estimated total data size, in bytes, or -1 if the size is unknown. </param>
        /// <param name="documentCount"> The estimated total number of documents, or -1 if the document count is unknown. </param>
        /// <param name="name"> The unqualified name of the database or collection. </param>
        /// <param name="qualifiedName"> The qualified name of the database or collection. For a collection, this is the database-qualified name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="collections"> A list of supported collections in a MongoDB database. </param>
        /// <param name="supportsSharding"> Whether the database has sharding enabled. Note that the migration task will enable sharding on the target if necessary. </param>
        internal MongoDBDatabaseInfo(long averageDocumentSize, long dataSize, long documentCount, string name, string qualifiedName, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<MongoDBCollectionInfo> collections, bool supportsSharding) : base(averageDocumentSize, dataSize, documentCount, name, qualifiedName, serializedAdditionalRawData)
        {
            Collections = collections;
            SupportsSharding = supportsSharding;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBDatabaseInfo"/> for deserialization. </summary>
        internal MongoDBDatabaseInfo()
        {
        }

        /// <summary> A list of supported collections in a MongoDB database. </summary>
        public IReadOnlyList<MongoDBCollectionInfo> Collections { get; }
        /// <summary> Whether the database has sharding enabled. Note that the migration task will enable sharding on the target if necessary. </summary>
        public bool SupportsSharding { get; }
    }
}
