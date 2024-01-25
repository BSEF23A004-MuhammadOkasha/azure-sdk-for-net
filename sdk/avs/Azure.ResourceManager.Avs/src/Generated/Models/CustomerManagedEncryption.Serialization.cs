// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class CustomerManagedEncryption : IUtf8JsonSerializable, IJsonModel<CustomerManagedEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomerManagedEncryption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomerManagedEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerManagedEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomerManagedEncryption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                writer.WriteObjectValue(KeyVaultProperties);
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

        CustomerManagedEncryption IJsonModel<CustomerManagedEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerManagedEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomerManagedEncryption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomerManagedEncryption(document.RootElement, options);
        }

        internal static CustomerManagedEncryption DeserializeCustomerManagedEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AvsEncryptionState> status = default;
            Optional<AvsEncryptionKeyVaultProperties> keyVaultProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new AvsEncryptionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultProperties = AvsEncryptionKeyVaultProperties.DeserializeAvsEncryptionKeyVaultProperties(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomerManagedEncryption(Optional.ToNullable(status), keyVaultProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomerManagedEncryption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerManagedEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomerManagedEncryption)} does not support '{options.Format}' format.");
            }
        }

        CustomerManagedEncryption IPersistableModel<CustomerManagedEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerManagedEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomerManagedEncryption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomerManagedEncryption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomerManagedEncryption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
