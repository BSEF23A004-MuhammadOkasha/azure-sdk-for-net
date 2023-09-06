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
    public partial class ExtendedMongoDBCollectionResourceInfo : IUtf8JsonSerializable, IModelJsonSerializable<ExtendedMongoDBCollectionResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExtendedMongoDBCollectionResourceInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExtendedMongoDBCollectionResourceInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExtendedMongoDBCollectionResourceInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(CollectionName);
            if (Optional.IsCollectionDefined(ShardKey))
            {
                writer.WritePropertyName("shardKey"u8);
                writer.WriteStartObject();
                foreach (var item in ShardKey)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Indexes))
            {
                writer.WritePropertyName("indexes"u8);
                writer.WriteStartArray();
                foreach (var item in Indexes)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MongoDBIndex>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static ExtendedMongoDBCollectionResourceInfo DeserializeExtendedMongoDBCollectionResourceInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<ETag> etag = default;
            string id = default;
            Optional<IDictionary<string, string>> shardKey = default;
            Optional<IList<MongoDBIndex>> indexes = default;
            Optional<int> analyticalStorageTtl = default;
            Optional<ResourceRestoreParameters> restoreParameters = default;
            Optional<CosmosDBAccountCreateMode> createMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("shardKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    shardKey = dictionary;
                    continue;
                }
                if (property.NameEquals("indexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MongoDBIndex> array = new List<MongoDBIndex>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoDBIndex.DeserializeMongoDBIndex(item));
                    }
                    indexes = array;
                    continue;
                }
                if (property.NameEquals("analyticalStorageTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticalStorageTtl = property.Value.GetInt32();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExtendedMongoDBCollectionResourceInfo(id, Optional.ToDictionary(shardKey), Optional.ToList(indexes), Optional.ToNullable(analyticalStorageTtl), restoreParameters.Value, Optional.ToNullable(createMode), rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag), rawData);
        }

        ExtendedMongoDBCollectionResourceInfo IModelJsonSerializable<ExtendedMongoDBCollectionResourceInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExtendedMongoDBCollectionResourceInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedMongoDBCollectionResourceInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExtendedMongoDBCollectionResourceInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExtendedMongoDBCollectionResourceInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExtendedMongoDBCollectionResourceInfo IModelSerializable<ExtendedMongoDBCollectionResourceInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExtendedMongoDBCollectionResourceInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExtendedMongoDBCollectionResourceInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExtendedMongoDBCollectionResourceInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExtendedMongoDBCollectionResourceInfo"/> to convert. </param>
        public static implicit operator RequestContent(ExtendedMongoDBCollectionResourceInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExtendedMongoDBCollectionResourceInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExtendedMongoDBCollectionResourceInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExtendedMongoDBCollectionResourceInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
