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
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class ListBackups : IUtf8JsonSerializable, IModelJsonSerializable<ListBackups>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ListBackups>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ListBackups>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListBackups>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ListBackups DeserializeListBackups(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CassandraClusterBackupResourceData>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraClusterBackupResourceData> array = new List<CassandraClusterBackupResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraClusterBackupResourceData.DeserializeCassandraClusterBackupResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ListBackups(Optional.ToList(value), rawData);
        }

        ListBackups IModelJsonSerializable<ListBackups>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListBackups>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeListBackups(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ListBackups>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListBackups>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ListBackups IModelSerializable<ListBackups>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListBackups>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeListBackups(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ListBackups"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ListBackups"/> to convert. </param>
        public static implicit operator RequestContent(ListBackups model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ListBackups"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ListBackups(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeListBackups(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
