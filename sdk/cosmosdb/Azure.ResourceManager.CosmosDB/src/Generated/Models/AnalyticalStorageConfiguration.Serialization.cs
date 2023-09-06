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
    internal partial class AnalyticalStorageConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<AnalyticalStorageConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AnalyticalStorageConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AnalyticalStorageConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyticalStorageConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SchemaType))
            {
                writer.WritePropertyName("schemaType"u8);
                writer.WriteStringValue(SchemaType.Value.ToString());
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

        internal static AnalyticalStorageConfiguration DeserializeAnalyticalStorageConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AnalyticalStorageSchemaType> schemaType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaType = new AnalyticalStorageSchemaType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AnalyticalStorageConfiguration(Optional.ToNullable(schemaType), rawData);
        }

        AnalyticalStorageConfiguration IModelJsonSerializable<AnalyticalStorageConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyticalStorageConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyticalStorageConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AnalyticalStorageConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyticalStorageConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AnalyticalStorageConfiguration IModelSerializable<AnalyticalStorageConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AnalyticalStorageConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAnalyticalStorageConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AnalyticalStorageConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AnalyticalStorageConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(AnalyticalStorageConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AnalyticalStorageConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AnalyticalStorageConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAnalyticalStorageConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
