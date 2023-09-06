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

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerInstanceAzureFileVolume : IUtf8JsonSerializable, IModelJsonSerializable<ContainerInstanceAzureFileVolume>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerInstanceAzureFileVolume>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerInstanceAzureFileVolume>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerInstanceAzureFileVolume>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("shareName"u8);
            writer.WriteStringValue(ShareName);
            if (Optional.IsDefined(IsReadOnly))
            {
                writer.WritePropertyName("readOnly"u8);
                writer.WriteBooleanValue(IsReadOnly.Value);
            }
            writer.WritePropertyName("storageAccountName"u8);
            writer.WriteStringValue(StorageAccountName);
            if (Optional.IsDefined(StorageAccountKey))
            {
                writer.WritePropertyName("storageAccountKey"u8);
                writer.WriteStringValue(StorageAccountKey);
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

        internal static ContainerInstanceAzureFileVolume DeserializeContainerInstanceAzureFileVolume(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string shareName = default;
            Optional<bool> readOnly = default;
            string storageAccountName = default;
            Optional<string> storageAccountKey = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareName"u8))
                {
                    shareName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("storageAccountName"u8))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountKey"u8))
                {
                    storageAccountKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerInstanceAzureFileVolume(shareName, Optional.ToNullable(readOnly), storageAccountName, storageAccountKey.Value, rawData);
        }

        ContainerInstanceAzureFileVolume IModelJsonSerializable<ContainerInstanceAzureFileVolume>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerInstanceAzureFileVolume>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerInstanceAzureFileVolume(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerInstanceAzureFileVolume>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerInstanceAzureFileVolume>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerInstanceAzureFileVolume IModelSerializable<ContainerInstanceAzureFileVolume>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerInstanceAzureFileVolume>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerInstanceAzureFileVolume(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerInstanceAzureFileVolume"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerInstanceAzureFileVolume"/> to convert. </param>
        public static implicit operator RequestContent(ContainerInstanceAzureFileVolume model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerInstanceAzureFileVolume"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerInstanceAzureFileVolume(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerInstanceAzureFileVolume(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
