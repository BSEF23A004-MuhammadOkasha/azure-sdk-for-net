// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BastionHostIPRule : IUtf8JsonSerializable, IJsonModel<BastionHostIPRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BastionHostIPRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BastionHostIPRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BastionHostIPRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BastionHostIPRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
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

        BastionHostIPRule IJsonModel<BastionHostIPRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BastionHostIPRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BastionHostIPRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBastionHostIPRule(document.RootElement, options);
        }

        internal static BastionHostIPRule DeserializeBastionHostIPRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> addressPrefix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefix"u8))
                {
                    addressPrefix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BastionHostIPRule(addressPrefix.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BastionHostIPRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BastionHostIPRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BastionHostIPRule)} does not support '{options.Format}' format.");
            }
        }

        BastionHostIPRule IPersistableModel<BastionHostIPRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BastionHostIPRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBastionHostIPRule(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BastionHostIPRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BastionHostIPRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
