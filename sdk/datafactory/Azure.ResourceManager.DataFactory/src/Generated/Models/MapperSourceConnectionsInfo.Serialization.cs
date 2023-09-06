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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class MapperSourceConnectionsInfo : IUtf8JsonSerializable, IModelJsonSerializable<MapperSourceConnectionsInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MapperSourceConnectionsInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MapperSourceConnectionsInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapperSourceConnectionsInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SourceEntities))
            {
                writer.WritePropertyName("sourceEntities"u8);
                writer.WriteStartArray();
                foreach (var item in SourceEntities)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MapperTable>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Connection))
            {
                writer.WritePropertyName("connection"u8);
                if (Connection is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MapperConnection>)Connection).Serialize(writer, options);
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

        internal static MapperSourceConnectionsInfo DeserializeMapperSourceConnectionsInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<MapperTable>> sourceEntities = default;
            Optional<MapperConnection> connection = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceEntities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MapperTable> array = new List<MapperTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapperTable.DeserializeMapperTable(item));
                    }
                    sourceEntities = array;
                    continue;
                }
                if (property.NameEquals("connection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connection = MapperConnection.DeserializeMapperConnection(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MapperSourceConnectionsInfo(Optional.ToList(sourceEntities), connection.Value, rawData);
        }

        MapperSourceConnectionsInfo IModelJsonSerializable<MapperSourceConnectionsInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapperSourceConnectionsInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMapperSourceConnectionsInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MapperSourceConnectionsInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapperSourceConnectionsInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MapperSourceConnectionsInfo IModelSerializable<MapperSourceConnectionsInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MapperSourceConnectionsInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMapperSourceConnectionsInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MapperSourceConnectionsInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MapperSourceConnectionsInfo"/> to convert. </param>
        public static implicit operator RequestContent(MapperSourceConnectionsInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MapperSourceConnectionsInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MapperSourceConnectionsInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMapperSourceConnectionsInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
