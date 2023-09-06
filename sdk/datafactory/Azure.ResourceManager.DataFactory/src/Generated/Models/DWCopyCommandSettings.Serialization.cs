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
    public partial class DWCopyCommandSettings : IUtf8JsonSerializable, IModelJsonSerializable<DWCopyCommandSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DWCopyCommandSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DWCopyCommandSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DWCopyCommandSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DefaultValues))
            {
                writer.WritePropertyName("defaultValues"u8);
                writer.WriteStartArray();
                foreach (var item in DefaultValues)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DWCopyCommandDefaultValue>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdditionalOptions))
            {
                writer.WritePropertyName("additionalOptions"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalOptions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static DWCopyCommandSettings DeserializeDWCopyCommandSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DWCopyCommandDefaultValue>> defaultValues = default;
            Optional<IDictionary<string, string>> additionalOptions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DWCopyCommandDefaultValue> array = new List<DWCopyCommandDefaultValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DWCopyCommandDefaultValue.DeserializeDWCopyCommandDefaultValue(item));
                    }
                    defaultValues = array;
                    continue;
                }
                if (property.NameEquals("additionalOptions"u8))
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
                    additionalOptions = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DWCopyCommandSettings(Optional.ToList(defaultValues), Optional.ToDictionary(additionalOptions), rawData);
        }

        DWCopyCommandSettings IModelJsonSerializable<DWCopyCommandSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DWCopyCommandSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDWCopyCommandSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DWCopyCommandSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DWCopyCommandSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DWCopyCommandSettings IModelSerializable<DWCopyCommandSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DWCopyCommandSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDWCopyCommandSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DWCopyCommandSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DWCopyCommandSettings"/> to convert. </param>
        public static implicit operator RequestContent(DWCopyCommandSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DWCopyCommandSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DWCopyCommandSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDWCopyCommandSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
