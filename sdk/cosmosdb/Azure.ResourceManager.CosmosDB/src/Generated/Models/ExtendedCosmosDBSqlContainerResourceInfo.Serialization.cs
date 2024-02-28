// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedCosmosDBSqlContainerResourceInfo : IUtf8JsonSerializable, IJsonModel<ExtendedCosmosDBSqlContainerResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedCosmosDBSqlContainerResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExtendedCosmosDBSqlContainerResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedCosmosDBSqlContainerResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Rid != null)
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && Timestamp.HasValue)
            {
                writer.WritePropertyName("_ts"u8);
                writer.WriteNumberValue(Timestamp.Value);
            }
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("_etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(ContainerName);
            if (IndexingPolicy != null)
            {
                writer.WritePropertyName("indexingPolicy"u8);
                writer.WriteObjectValue(IndexingPolicy);
            }
            if (PartitionKey != null)
            {
                writer.WritePropertyName("partitionKey"u8);
                writer.WriteObjectValue(PartitionKey);
            }
            if (DefaultTtl.HasValue)
            {
                writer.WritePropertyName("defaultTtl"u8);
                writer.WriteNumberValue(DefaultTtl.Value);
            }
            if (UniqueKeyPolicy != null)
            {
                writer.WritePropertyName("uniqueKeyPolicy"u8);
                writer.WriteObjectValue(UniqueKeyPolicy);
            }
            if (ConflictResolutionPolicy != null)
            {
                writer.WritePropertyName("conflictResolutionPolicy"u8);
                writer.WriteObjectValue(ConflictResolutionPolicy);
            }
            if (ClientEncryptionPolicy != null)
            {
                writer.WritePropertyName("clientEncryptionPolicy"u8);
                writer.WriteObjectValue(ClientEncryptionPolicy);
            }
            if (AnalyticalStorageTtl.HasValue)
            {
                writer.WritePropertyName("analyticalStorageTtl"u8);
                writer.WriteNumberValue(AnalyticalStorageTtl.Value);
            }
            if (RestoreParameters != null)
            {
                writer.WritePropertyName("restoreParameters"u8);
                writer.WriteObjectValue(RestoreParameters);
            }
            if (CreateMode.HasValue)
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (MaterializedViewDefinition != null)
            {
                writer.WritePropertyName("materializedViewDefinition"u8);
                writer.WriteObjectValue(MaterializedViewDefinition);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ExtendedCosmosDBSqlContainerResourceInfo IJsonModel<ExtendedCosmosDBSqlContainerResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedCosmosDBSqlContainerResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedCosmosDBSqlContainerResourceInfo(document.RootElement, options);
        }

        internal static ExtendedCosmosDBSqlContainerResourceInfo DeserializeExtendedCosmosDBSqlContainerResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string rid = default;
            float? ts = default;
            ETag? etag = default;
            string id = default;
            CosmosDBIndexingPolicy indexingPolicy = default;
            CosmosDBContainerPartitionKey partitionKey = default;
            int? defaultTtl = default;
            CosmosDBUniqueKeyPolicy uniqueKeyPolicy = default;
            ConflictResolutionPolicy conflictResolutionPolicy = default;
            CosmosDBClientEncryptionPolicy clientEncryptionPolicy = default;
            long? analyticalStorageTtl = default;
            ResourceRestoreParameters restoreParameters = default;
            CosmosDBAccountCreateMode? createMode = default;
            MaterializedViewDefinition materializedViewDefinition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexingPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    indexingPolicy = CosmosDBIndexingPolicy.DeserializeCosmosDBIndexingPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("partitionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionKey = CosmosDBContainerPartitionKey.DeserializeCosmosDBContainerPartitionKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("defaultTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultTtl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uniqueKeyPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uniqueKeyPolicy = CosmosDBUniqueKeyPolicy.DeserializeCosmosDBUniqueKeyPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("conflictResolutionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conflictResolutionPolicy = ConflictResolutionPolicy.DeserializeConflictResolutionPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("clientEncryptionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientEncryptionPolicy = CosmosDBClientEncryptionPolicy.DeserializeCosmosDBClientEncryptionPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("analyticalStorageTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticalStorageTtl = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("restoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreParameters = ResourceRestoreParameters.DeserializeResourceRestoreParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new CosmosDBAccountCreateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("materializedViewDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    materializedViewDefinition = MaterializedViewDefinition.DeserializeMaterializedViewDefinition(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExtendedCosmosDBSqlContainerResourceInfo(
                id,
                indexingPolicy,
                partitionKey,
                defaultTtl,
                uniqueKeyPolicy,
                conflictResolutionPolicy,
                clientEncryptionPolicy,
                analyticalStorageTtl,
                restoreParameters,
                createMode,
                materializedViewDefinition,
                serializedAdditionalRawData,
                rid,
                ts,
                etag);
        }

        BinaryData IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedCosmosDBSqlContainerResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        ExtendedCosmosDBSqlContainerResourceInfo IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedCosmosDBSqlContainerResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtendedCosmosDBSqlContainerResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
