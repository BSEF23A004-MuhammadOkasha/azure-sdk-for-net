// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes a database or collection within a MongoDB data source. </summary>
    public partial class MongoDBObjectInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MongoDBObjectInfo"/>. </summary>
        /// <param name="averageDocumentSize"> The average document size, or -1 if the average size is unknown. </param>
        /// <param name="dataSize"> The estimated total data size, in bytes, or -1 if the size is unknown. </param>
        /// <param name="documentCount"> The estimated total number of documents, or -1 if the document count is unknown. </param>
        /// <param name="name"> The unqualified name of the database or collection. </param>
        /// <param name="qualifiedName"> The qualified name of the database or collection. For a collection, this is the database-qualified name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="qualifiedName"/> is null. </exception>
        internal MongoDBObjectInfo(long averageDocumentSize, long dataSize, long documentCount, string name, string qualifiedName)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(qualifiedName, nameof(qualifiedName));

            AverageDocumentSize = averageDocumentSize;
            DataSize = dataSize;
            DocumentCount = documentCount;
            Name = name;
            QualifiedName = qualifiedName;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBObjectInfo"/>. </summary>
        /// <param name="averageDocumentSize"> The average document size, or -1 if the average size is unknown. </param>
        /// <param name="dataSize"> The estimated total data size, in bytes, or -1 if the size is unknown. </param>
        /// <param name="documentCount"> The estimated total number of documents, or -1 if the document count is unknown. </param>
        /// <param name="name"> The unqualified name of the database or collection. </param>
        /// <param name="qualifiedName"> The qualified name of the database or collection. For a collection, this is the database-qualified name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBObjectInfo(long averageDocumentSize, long dataSize, long documentCount, string name, string qualifiedName, Dictionary<string, BinaryData> rawData)
        {
            AverageDocumentSize = averageDocumentSize;
            DataSize = dataSize;
            DocumentCount = documentCount;
            Name = name;
            QualifiedName = qualifiedName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBObjectInfo"/> for deserialization. </summary>
        internal MongoDBObjectInfo()
        {
        }

        /// <summary> The average document size, or -1 if the average size is unknown. </summary>
        public long AverageDocumentSize { get; }
        /// <summary> The estimated total data size, in bytes, or -1 if the size is unknown. </summary>
        public long DataSize { get; }
        /// <summary> The estimated total number of documents, or -1 if the document count is unknown. </summary>
        public long DocumentCount { get; }
        /// <summary> The unqualified name of the database or collection. </summary>
        public string Name { get; }
        /// <summary> The qualified name of the database or collection. For a collection, this is the database-qualified name. </summary>
        public string QualifiedName { get; }
    }
}
