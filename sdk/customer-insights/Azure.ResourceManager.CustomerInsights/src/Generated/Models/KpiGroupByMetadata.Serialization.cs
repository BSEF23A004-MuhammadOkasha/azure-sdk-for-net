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

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class KpiGroupByMetadata : IUtf8JsonSerializable, IModelJsonSerializable<KpiGroupByMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KpiGroupByMetadata>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KpiGroupByMetadata>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KpiGroupByMetadata>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(FieldName))
            {
                writer.WritePropertyName("fieldName"u8);
                writer.WriteStringValue(FieldName);
            }
            if (Optional.IsDefined(FieldType))
            {
                writer.WritePropertyName("fieldType"u8);
                writer.WriteStringValue(FieldType);
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

        internal static KpiGroupByMetadata DeserializeKpiGroupByMetadata(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, string>> displayName = default;
            Optional<string> fieldName = default;
            Optional<string> fieldType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
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
                    displayName = dictionary;
                    continue;
                }
                if (property.NameEquals("fieldName"u8))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fieldType"u8))
                {
                    fieldType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KpiGroupByMetadata(Optional.ToDictionary(displayName), fieldName.Value, fieldType.Value, rawData);
        }

        KpiGroupByMetadata IModelJsonSerializable<KpiGroupByMetadata>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KpiGroupByMetadata>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKpiGroupByMetadata(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KpiGroupByMetadata>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KpiGroupByMetadata>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KpiGroupByMetadata IModelSerializable<KpiGroupByMetadata>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KpiGroupByMetadata>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKpiGroupByMetadata(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KpiGroupByMetadata"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KpiGroupByMetadata"/> to convert. </param>
        public static implicit operator RequestContent(KpiGroupByMetadata model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KpiGroupByMetadata"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KpiGroupByMetadata(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKpiGroupByMetadata(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
