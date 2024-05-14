// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class HubIPAddresses : IUtf8JsonSerializable, IJsonModel<HubIPAddresses>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HubIPAddresses>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HubIPAddresses>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubIPAddresses>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HubIPAddresses)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicIPs))
            {
                writer.WritePropertyName("publicIPs"u8);
                writer.WriteObjectValue(PublicIPs);
            }
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIPAddress"u8);
                writer.WriteStringValue(PrivateIPAddress);
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

        HubIPAddresses IJsonModel<HubIPAddresses>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubIPAddresses>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HubIPAddresses)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHubIPAddresses(document.RootElement, options);
        }

        internal static HubIPAddresses DeserializeHubIPAddresses(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HubPublicIPAddresses> publicIPs = default;
            Optional<string> privateIPAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIPs = HubPublicIPAddresses.DeserializeHubPublicIPAddresses(property.Value);
                    continue;
                }
                if (property.NameEquals("privateIPAddress"u8))
                {
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HubIPAddresses(publicIPs.Value, privateIPAddress.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HubIPAddresses>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubIPAddresses>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HubIPAddresses)} does not support '{options.Format}' format.");
            }
        }

        HubIPAddresses IPersistableModel<HubIPAddresses>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubIPAddresses>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHubIPAddresses(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HubIPAddresses)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HubIPAddresses>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
