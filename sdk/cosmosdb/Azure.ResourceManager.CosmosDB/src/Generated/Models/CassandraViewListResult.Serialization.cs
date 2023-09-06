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
    internal partial class CassandraViewListResult : IUtf8JsonSerializable, IModelJsonSerializable<CassandraViewListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CassandraViewListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CassandraViewListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CassandraViewListResult>(this, options.Format);

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

        internal static CassandraViewListResult DeserializeCassandraViewListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CassandraViewGetResultData>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraViewGetResultData> array = new List<CassandraViewGetResultData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraViewGetResultData.DeserializeCassandraViewGetResultData(item));
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
            return new CassandraViewListResult(Optional.ToList(value), rawData);
        }

        CassandraViewListResult IModelJsonSerializable<CassandraViewListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CassandraViewListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraViewListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CassandraViewListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CassandraViewListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CassandraViewListResult IModelSerializable<CassandraViewListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CassandraViewListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCassandraViewListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CassandraViewListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CassandraViewListResult"/> to convert. </param>
        public static implicit operator RequestContent(CassandraViewListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CassandraViewListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CassandraViewListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCassandraViewListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
