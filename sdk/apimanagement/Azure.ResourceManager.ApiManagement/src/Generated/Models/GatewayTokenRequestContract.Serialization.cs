// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class GatewayTokenRequestContract : IUtf8JsonSerializable, IJsonModel<GatewayTokenRequestContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GatewayTokenRequestContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GatewayTokenRequestContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayTokenRequestContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayTokenRequestContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyType"u8);
            writer.WriteStringValue(KeyType.ToSerialString());
            writer.WritePropertyName("expiry"u8);
            writer.WriteStringValue(Expiry, "O");
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

        GatewayTokenRequestContract IJsonModel<GatewayTokenRequestContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayTokenRequestContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayTokenRequestContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGatewayTokenRequestContract(document.RootElement, options);
        }

        internal static GatewayTokenRequestContract DeserializeGatewayTokenRequestContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TokenGenerationUsedKeyType keyType = default;
            DateTimeOffset expiry = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyType"u8))
                {
                    keyType = property.Value.GetString().ToTokenGenerationUsedKeyType();
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    expiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GatewayTokenRequestContract(keyType, expiry, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GatewayTokenRequestContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayTokenRequestContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GatewayTokenRequestContract)} does not support '{options.Format}' format.");
            }
        }

        GatewayTokenRequestContract IPersistableModel<GatewayTokenRequestContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayTokenRequestContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGatewayTokenRequestContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GatewayTokenRequestContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GatewayTokenRequestContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
