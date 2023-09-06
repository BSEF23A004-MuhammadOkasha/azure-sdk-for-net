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
    public partial class CopyActivityLogSettings : IUtf8JsonSerializable, IModelJsonSerializable<CopyActivityLogSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CopyActivityLogSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CopyActivityLogSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyActivityLogSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LogLevel))
            {
                writer.WritePropertyName("logLevel"u8);
                JsonSerializer.Serialize(writer, LogLevel);
            }
            if (Optional.IsDefined(EnableReliableLogging))
            {
                writer.WritePropertyName("enableReliableLogging"u8);
                JsonSerializer.Serialize(writer, EnableReliableLogging);
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

        internal static CopyActivityLogSettings DeserializeCopyActivityLogSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> logLevel = default;
            Optional<DataFactoryElement<bool>> enableReliableLogging = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logLevel = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("enableReliableLogging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableReliableLogging = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CopyActivityLogSettings(logLevel.Value, enableReliableLogging.Value, rawData);
        }

        CopyActivityLogSettings IModelJsonSerializable<CopyActivityLogSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyActivityLogSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCopyActivityLogSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CopyActivityLogSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyActivityLogSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CopyActivityLogSettings IModelSerializable<CopyActivityLogSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyActivityLogSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCopyActivityLogSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CopyActivityLogSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CopyActivityLogSettings"/> to convert. </param>
        public static implicit operator RequestContent(CopyActivityLogSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CopyActivityLogSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CopyActivityLogSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCopyActivityLogSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
