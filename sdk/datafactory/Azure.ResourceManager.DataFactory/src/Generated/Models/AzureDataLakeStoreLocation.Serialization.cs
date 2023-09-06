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
    public partial class AzureDataLakeStoreLocation : IUtf8JsonSerializable, IModelJsonSerializable<AzureDataLakeStoreLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureDataLakeStoreLocation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureDataLakeStoreLocation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDataLakeStoreLocation>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetLocationType);
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath"u8);
                JsonSerializer.Serialize(writer, FolderPath);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                JsonSerializer.Serialize(writer, FileName);
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

        internal static AzureDataLakeStoreLocation DeserializeAzureDataLakeStoreLocation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<DataFactoryElement<string>> folderPath = default;
            Optional<DataFactoryElement<string>> fileName = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("folderPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folderPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDataLakeStoreLocation(type, folderPath.Value, fileName.Value, additionalProperties);
        }

        AzureDataLakeStoreLocation IModelJsonSerializable<AzureDataLakeStoreLocation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDataLakeStoreLocation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDataLakeStoreLocation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureDataLakeStoreLocation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDataLakeStoreLocation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureDataLakeStoreLocation IModelSerializable<AzureDataLakeStoreLocation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDataLakeStoreLocation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureDataLakeStoreLocation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureDataLakeStoreLocation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureDataLakeStoreLocation"/> to convert. </param>
        public static implicit operator RequestContent(AzureDataLakeStoreLocation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureDataLakeStoreLocation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureDataLakeStoreLocation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureDataLakeStoreLocation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
