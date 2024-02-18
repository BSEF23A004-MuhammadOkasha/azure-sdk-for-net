// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CosmosDBSqlClientEncryptionKeyResource : IJsonModel<CosmosDBSqlClientEncryptionKeyData>
    {
        void IJsonModel<CosmosDBSqlClientEncryptionKeyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        CosmosDBSqlClientEncryptionKeyData IJsonModel<CosmosDBSqlClientEncryptionKeyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CosmosDBSqlClientEncryptionKeyData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<CosmosDBSqlClientEncryptionKeyData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        CosmosDBSqlClientEncryptionKeyData IPersistableModel<CosmosDBSqlClientEncryptionKeyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CosmosDBSqlClientEncryptionKeyData>(data, options);
        }

        string IPersistableModel<CosmosDBSqlClientEncryptionKeyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
