// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemContainerStorageInterface : IUtf8JsonSerializable, IJsonModel<AmlFileSystemContainerStorageInterface>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlFileSystemContainerStorageInterface>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AmlFileSystemContainerStorageInterface>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemContainerStorageInterface>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemContainerStorageInterface)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(PersistentVolumeClaim))
            {
                writer.WritePropertyName("persistentVolumeClaim"u8);
                writer.WriteStringValue(PersistentVolumeClaim);
            }
            if (options.Format != "W" && Optional.IsDefined(PersistentVolume))
            {
                writer.WritePropertyName("persistentVolume"u8);
                writer.WriteStringValue(PersistentVolume);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageClass))
            {
                writer.WritePropertyName("storageClass"u8);
                writer.WriteStringValue(StorageClass);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        AmlFileSystemContainerStorageInterface IJsonModel<AmlFileSystemContainerStorageInterface>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemContainerStorageInterface>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemContainerStorageInterface)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlFileSystemContainerStorageInterface(document.RootElement, options);
        }

        internal static AmlFileSystemContainerStorageInterface DeserializeAmlFileSystemContainerStorageInterface(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string persistentVolumeClaim = default;
            string persistentVolume = default;
            string storageClass = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("persistentVolumeClaim"u8))
                {
                    persistentVolumeClaim = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("persistentVolume"u8))
                {
                    persistentVolume = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageClass"u8))
                {
                    storageClass = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AmlFileSystemContainerStorageInterface(persistentVolumeClaim, persistentVolume, storageClass, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AmlFileSystemContainerStorageInterface>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemContainerStorageInterface>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemContainerStorageInterface)} does not support writing '{options.Format}' format.");
            }
        }

        AmlFileSystemContainerStorageInterface IPersistableModel<AmlFileSystemContainerStorageInterface>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemContainerStorageInterface>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmlFileSystemContainerStorageInterface(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemContainerStorageInterface)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AmlFileSystemContainerStorageInterface>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
