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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBCollectionInfo : IUtf8JsonSerializable, IModelJsonSerializable<MongoDBCollectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MongoDBCollectionInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MongoDBCollectionInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MongoDBCollectionInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("isCapped"u8);
            writer.WriteBooleanValue(IsCapped);
            writer.WritePropertyName("isSystemCollection"u8);
            writer.WriteBooleanValue(IsSystemCollection);
            writer.WritePropertyName("isView"u8);
            writer.WriteBooleanValue(IsView);
            if (Optional.IsDefined(ShardKey))
            {
                writer.WritePropertyName("shardKey"u8);
                if (ShardKey is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MongoDBShardKeyInfo>)ShardKey).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("supportsSharding"u8);
            writer.WriteBooleanValue(SupportsSharding);
            if (Optional.IsDefined(ViewOf))
            {
                writer.WritePropertyName("viewOf"u8);
                writer.WriteStringValue(ViewOf);
            }
            writer.WritePropertyName("averageDocumentSize"u8);
            writer.WriteNumberValue(AverageDocumentSize);
            writer.WritePropertyName("dataSize"u8);
            writer.WriteNumberValue(DataSize);
            writer.WritePropertyName("documentCount"u8);
            writer.WriteNumberValue(DocumentCount);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("qualifiedName"u8);
            writer.WriteStringValue(QualifiedName);
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

        internal static MongoDBCollectionInfo DeserializeMongoDBCollectionInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            bool isCapped = default;
            bool isSystemCollection = default;
            bool isView = default;
            Optional<MongoDBShardKeyInfo> shardKey = default;
            bool supportsSharding = default;
            Optional<string> viewOf = default;
            long averageDocumentSize = default;
            long dataSize = default;
            long documentCount = default;
            string name = default;
            string qualifiedName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCapped"u8))
                {
                    isCapped = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isSystemCollection"u8))
                {
                    isSystemCollection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isView"u8))
                {
                    isView = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("shardKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shardKey = MongoDBShardKeyInfo.DeserializeMongoDBShardKeyInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("supportsSharding"u8))
                {
                    supportsSharding = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("viewOf"u8))
                {
                    viewOf = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("averageDocumentSize"u8))
                {
                    averageDocumentSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataSize"u8))
                {
                    dataSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("documentCount"u8))
                {
                    documentCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MongoDBCollectionInfo(averageDocumentSize, dataSize, documentCount, name, qualifiedName, databaseName, isCapped, isSystemCollection, isView, shardKey.Value, supportsSharding, viewOf.Value, rawData);
        }

        MongoDBCollectionInfo IModelJsonSerializable<MongoDBCollectionInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MongoDBCollectionInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBCollectionInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MongoDBCollectionInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MongoDBCollectionInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MongoDBCollectionInfo IModelSerializable<MongoDBCollectionInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MongoDBCollectionInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMongoDBCollectionInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MongoDBCollectionInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MongoDBCollectionInfo"/> to convert. </param>
        public static implicit operator RequestContent(MongoDBCollectionInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MongoDBCollectionInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MongoDBCollectionInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMongoDBCollectionInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
