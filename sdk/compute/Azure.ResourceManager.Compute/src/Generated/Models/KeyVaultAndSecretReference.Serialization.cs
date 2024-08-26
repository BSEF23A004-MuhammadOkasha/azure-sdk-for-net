// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class KeyVaultAndSecretReference : IUtf8JsonSerializable, IJsonModel<KeyVaultAndSecretReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeyVaultAndSecretReference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KeyVaultAndSecretReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultAndSecretReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultAndSecretReference)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourceVault"u8);
            JsonSerializer.Serialize(writer, SourceVault);
            writer.WritePropertyName("secretUrl"u8);
            writer.WriteStringValue(SecretUri.AbsoluteUri);
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

        KeyVaultAndSecretReference IJsonModel<KeyVaultAndSecretReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultAndSecretReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultAndSecretReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultAndSecretReference(document.RootElement, options);
        }

        internal static KeyVaultAndSecretReference DeserializeKeyVaultAndSecretReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource sourceVault = default;
            Uri secretUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVault"u8))
                {
                    sourceVault = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("secretUrl"u8))
                {
                    secretUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KeyVaultAndSecretReference(sourceVault, secretUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KeyVaultAndSecretReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultAndSecretReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KeyVaultAndSecretReference)} does not support writing '{options.Format}' format.");
            }
        }

        KeyVaultAndSecretReference IPersistableModel<KeyVaultAndSecretReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultAndSecretReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKeyVaultAndSecretReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KeyVaultAndSecretReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KeyVaultAndSecretReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
