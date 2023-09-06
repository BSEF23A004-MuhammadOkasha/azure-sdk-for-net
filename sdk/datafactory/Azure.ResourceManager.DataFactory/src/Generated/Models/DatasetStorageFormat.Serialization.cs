// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DatasetStorageFormat : IUtf8JsonSerializable, IModelJsonSerializable<DatasetStorageFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DatasetStorageFormat>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DatasetStorageFormat>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatasetStorageFormat>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetStorageFormatType);
            if (Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer"u8);
                JsonSerializer.Serialize(writer, Serializer);
            }
            if (Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer"u8);
                JsonSerializer.Serialize(writer, Deserializer);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static DatasetStorageFormat DeserializeDatasetStorageFormat(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AvroFormat": return DatasetAvroFormat.DeserializeDatasetAvroFormat(element);
                    case "JsonFormat": return DatasetJsonFormat.DeserializeDatasetJsonFormat(element);
                    case "OrcFormat": return DatasetOrcFormat.DeserializeDatasetOrcFormat(element);
                    case "ParquetFormat": return DatasetParquetFormat.DeserializeDatasetParquetFormat(element);
                    case "TextFormat": return DatasetTextFormat.DeserializeDatasetTextFormat(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string type = default;
            Optional<DataFactoryElement<string>> serializer = default;
            Optional<DataFactoryElement<string>> deserializer = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serializer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serializer = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("deserializer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deserializer = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new UnknownDatasetStorageFormat(type, serializer.Value, deserializer.Value, additionalProperties);
        }

        DatasetStorageFormat IModelJsonSerializable<DatasetStorageFormat>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatasetStorageFormat>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDatasetStorageFormat(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DatasetStorageFormat>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatasetStorageFormat>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DatasetStorageFormat IModelSerializable<DatasetStorageFormat>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatasetStorageFormat>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDatasetStorageFormat(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DatasetStorageFormat"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DatasetStorageFormat"/> to convert. </param>
        public static implicit operator RequestContent(DatasetStorageFormat model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DatasetStorageFormat"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DatasetStorageFormat(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDatasetStorageFormat(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
