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
    public partial class ZipDeflateReadSettings : IUtf8JsonSerializable, IModelJsonSerializable<ZipDeflateReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ZipDeflateReadSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ZipDeflateReadSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ZipDeflateReadSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PreserveZipFileNameAsFolder))
            {
                writer.WritePropertyName("preserveZipFileNameAsFolder"u8);
                JsonSerializer.Serialize(writer, PreserveZipFileNameAsFolder);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CompressionReadSettingsType);
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

        internal static ZipDeflateReadSettings DeserializeZipDeflateReadSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<bool>> preserveZipFileNameAsFolder = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preserveZipFileNameAsFolder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveZipFileNameAsFolder = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ZipDeflateReadSettings(type, additionalProperties, preserveZipFileNameAsFolder.Value);
        }

        ZipDeflateReadSettings IModelJsonSerializable<ZipDeflateReadSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ZipDeflateReadSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeZipDeflateReadSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ZipDeflateReadSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ZipDeflateReadSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ZipDeflateReadSettings IModelSerializable<ZipDeflateReadSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ZipDeflateReadSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeZipDeflateReadSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ZipDeflateReadSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ZipDeflateReadSettings"/> to convert. </param>
        public static implicit operator RequestContent(ZipDeflateReadSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ZipDeflateReadSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ZipDeflateReadSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeZipDeflateReadSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
