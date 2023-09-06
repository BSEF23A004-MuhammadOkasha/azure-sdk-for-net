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
    public partial class GoogleCloudStorageLocation : IUtf8JsonSerializable, IModelJsonSerializable<GoogleCloudStorageLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GoogleCloudStorageLocation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GoogleCloudStorageLocation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GoogleCloudStorageLocation>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BucketName))
            {
                writer.WritePropertyName("bucketName"u8);
                JsonSerializer.Serialize(writer, BucketName);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                JsonSerializer.Serialize(writer, Version);
            }
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

        internal static GoogleCloudStorageLocation DeserializeGoogleCloudStorageLocation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> bucketName = default;
            Optional<DataFactoryElement<string>> version = default;
            string type = default;
            Optional<DataFactoryElement<string>> folderPath = default;
            Optional<DataFactoryElement<string>> fileName = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bucketName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bucketName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
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
            return new GoogleCloudStorageLocation(type, folderPath.Value, fileName.Value, additionalProperties, bucketName.Value, version.Value);
        }

        GoogleCloudStorageLocation IModelJsonSerializable<GoogleCloudStorageLocation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GoogleCloudStorageLocation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGoogleCloudStorageLocation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GoogleCloudStorageLocation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GoogleCloudStorageLocation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GoogleCloudStorageLocation IModelSerializable<GoogleCloudStorageLocation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GoogleCloudStorageLocation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGoogleCloudStorageLocation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GoogleCloudStorageLocation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GoogleCloudStorageLocation"/> to convert. </param>
        public static implicit operator RequestContent(GoogleCloudStorageLocation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GoogleCloudStorageLocation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GoogleCloudStorageLocation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGoogleCloudStorageLocation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
