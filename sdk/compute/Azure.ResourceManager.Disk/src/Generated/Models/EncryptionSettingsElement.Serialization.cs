// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Disk.Models
{
    public partial class EncryptionSettingsElement : IUtf8JsonSerializable, IJsonModel<EncryptionSettingsElement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EncryptionSettingsElement>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EncryptionSettingsElement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettingsElement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionSettingsElement)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskEncryptionKey))
            {
                writer.WritePropertyName("diskEncryptionKey"u8);
                writer.WriteObjectValue(DiskEncryptionKey, options);
            }
            if (Optional.IsDefined(KeyEncryptionKey))
            {
                writer.WritePropertyName("keyEncryptionKey"u8);
                writer.WriteObjectValue(KeyEncryptionKey, options);
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
            writer.WriteEndObject();
        }

        EncryptionSettingsElement IJsonModel<EncryptionSettingsElement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettingsElement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionSettingsElement)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEncryptionSettingsElement(document.RootElement, options);
        }

        internal static EncryptionSettingsElement DeserializeEncryptionSettingsElement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            KeyVaultAndSecretReference diskEncryptionKey = default;
            KeyVaultAndKeyReference keyEncryptionKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionKey = KeyVaultAndSecretReference.DeserializeKeyVaultAndSecretReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKey = KeyVaultAndKeyReference.DeserializeKeyVaultAndKeyReference(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EncryptionSettingsElement(diskEncryptionKey, keyEncryptionKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EncryptionSettingsElement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettingsElement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EncryptionSettingsElement)} does not support writing '{options.Format}' format.");
            }
        }

        EncryptionSettingsElement IPersistableModel<EncryptionSettingsElement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettingsElement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEncryptionSettingsElement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EncryptionSettingsElement)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EncryptionSettingsElement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
