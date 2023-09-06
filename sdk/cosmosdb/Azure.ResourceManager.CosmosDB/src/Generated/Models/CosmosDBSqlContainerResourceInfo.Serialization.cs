// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBSqlContainerResourceInfo : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBSqlContainerResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBSqlContainerResourceInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBSqlContainerResourceInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBSqlContainerResourceInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(ContainerName);
            if (Optional.IsDefined(IndexingPolicy))
            {
                writer.WritePropertyName("indexingPolicy"u8);
                if (IndexingPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CosmosDBIndexingPolicy>)IndexingPolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PartitionKey))
            {
                writer.WritePropertyName("partitionKey"u8);
                if (PartitionKey is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CosmosDBContainerPartitionKey>)PartitionKey).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DefaultTtl))
            {
                writer.WritePropertyName("defaultTtl"u8);
                writer.WriteNumberValue(DefaultTtl.Value);
            }
            if (Optional.IsDefined(UniqueKeyPolicy))
            {
                writer.WritePropertyName("uniqueKeyPolicy"u8);
                if (UniqueKeyPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CosmosDBUniqueKeyPolicy>)UniqueKeyPolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ConflictResolutionPolicy))
            {
                writer.WritePropertyName("conflictResolutionPolicy"u8);
                if (ConflictResolutionPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConflictResolutionPolicy>)ConflictResolutionPolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ClientEncryptionPolicy))
            {
                writer.WritePropertyName("clientEncryptionPolicy"u8);
                if (ClientEncryptionPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CosmosDBClientEncryptionPolicy>)ClientEncryptionPolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AnalyticalStorageTtl))
            {
                writer.WritePropertyName("analyticalStorageTtl"u8);
                writer.WriteNumberValue(AnalyticalStorageTtl.Value);
            }
            if (Optional.IsDefined(RestoreParameters))
            {
                writer.WritePropertyName("restoreParameters"u8);
                if (RestoreParameters is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ResourceRestoreParameters>)RestoreParameters).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(MaterializedViewDefinition))
            {
                writer.WritePropertyName("materializedViewDefinition"u8);
                if (MaterializedViewDefinition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MaterializedViewDefinition>)MaterializedViewDefinition).Serialize(writer, options);
                }
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBSqlContainerResourceInfo DeserializeCosmosDBSqlContainerResourceInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Optional<CosmosDBIndexingPolicy> indexingPolicy = default;
            Optional<CosmosDBContainerPartitionKey> partitionKey = default;
            Optional<int> defaultTtl = default;
            Optional<CosmosDBUniqueKeyPolicy> uniqueKeyPolicy = default;
            Optional<ConflictResolutionPolicy> conflictResolutionPolicy = default;
            Optional<CosmosDBClientEncryptionPolicy> clientEncryptionPolicy = default;
            Optional<long> analyticalStorageTtl = default;
            Optional<ResourceRestoreParameters> restoreParameters = default;
            Optional<CosmosDBAccountCreateMode> createMode = default;
            Optional<MaterializedViewDefinition> materializedViewDefinition = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    indexingPolicy = CosmosDBIndexingPolicy.DeserializeCosmosDBIndexingPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("partitionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionKey = CosmosDBContainerPartitionKey.DeserializeCosmosDBContainerPartitionKey(property.Value);
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
                    uniqueKeyPolicy = CosmosDBUniqueKeyPolicy.DeserializeCosmosDBUniqueKeyPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("conflictResolutionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conflictResolutionPolicy = ConflictResolutionPolicy.DeserializeConflictResolutionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("clientEncryptionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientEncryptionPolicy = CosmosDBClientEncryptionPolicy.DeserializeCosmosDBClientEncryptionPolicy(property.Value);
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
                    restoreParameters = ResourceRestoreParameters.DeserializeResourceRestoreParameters(property.Value);
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
                    materializedViewDefinition = MaterializedViewDefinition.DeserializeMaterializedViewDefinition(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBSqlContainerResourceInfo(id, indexingPolicy.Value, partitionKey.Value, Optional.ToNullable(defaultTtl), uniqueKeyPolicy.Value, conflictResolutionPolicy.Value, clientEncryptionPolicy.Value, Optional.ToNullable(analyticalStorageTtl), restoreParameters.Value, Optional.ToNullable(createMode), materializedViewDefinition.Value, rawData);
        }

        CosmosDBSqlContainerResourceInfo IModelJsonSerializable<CosmosDBSqlContainerResourceInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBSqlContainerResourceInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBSqlContainerResourceInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBSqlContainerResourceInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBSqlContainerResourceInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBSqlContainerResourceInfo IModelSerializable<CosmosDBSqlContainerResourceInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CosmosDBSqlContainerResourceInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBSqlContainerResourceInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CosmosDBSqlContainerResourceInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CosmosDBSqlContainerResourceInfo"/> to convert. </param>
        public static implicit operator RequestContent(CosmosDBSqlContainerResourceInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CosmosDBSqlContainerResourceInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CosmosDBSqlContainerResourceInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBSqlContainerResourceInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
