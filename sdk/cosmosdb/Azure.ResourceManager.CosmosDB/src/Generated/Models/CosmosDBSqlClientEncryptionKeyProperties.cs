// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CosmosDBSqlClientEncryptionKeyProperties. </summary>
    public partial class CosmosDBSqlClientEncryptionKeyProperties : CosmosDBSqlClientEncryptionKeyResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlClientEncryptionKeyProperties"/>. </summary>
        public CosmosDBSqlClientEncryptionKeyProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlClientEncryptionKeyProperties"/>. </summary>
        /// <param name="id"> Name of the ClientEncryptionKey. </param>
        /// <param name="encryptionAlgorithm"> Encryption algorithm that will be used along with this client encryption key to encrypt/decrypt data. </param>
        /// <param name="wrappedDataEncryptionKey"> Wrapped (encrypted) form of the key represented as a byte array. </param>
        /// <param name="keyWrapMetadata"> Metadata for the wrapping provider that can be used to unwrap the wrapped client encryption key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal CosmosDBSqlClientEncryptionKeyProperties(string id, string encryptionAlgorithm, byte[] wrappedDataEncryptionKey, CosmosDBKeyWrapMetadata keyWrapMetadata, IDictionary<string, BinaryData> serializedAdditionalRawData, string rid, float? timestamp, ETag? etag) : base(id, encryptionAlgorithm, wrappedDataEncryptionKey, keyWrapMetadata, serializedAdditionalRawData)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
