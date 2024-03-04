// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class TransportPreferences : IUtf8JsonSerializable, IJsonModel<TransportPreferences>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransportPreferences>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TransportPreferences>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportPreferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransportPreferences)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("preferredShipmentType"u8);
            writer.WriteStringValue(PreferredShipmentType.ToSerialString());
            if (options.Format != "W" && Optional.IsDefined(IsUpdated))
            {
                writer.WritePropertyName("isUpdated"u8);
                writer.WriteBooleanValue(IsUpdated.Value);
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

        TransportPreferences IJsonModel<TransportPreferences>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportPreferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransportPreferences)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransportPreferences(document.RootElement, options);
        }

        internal static TransportPreferences DeserializeTransportPreferences(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TransportShipmentType preferredShipmentType = default;
            bool? isUpdated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preferredShipmentType"u8))
                {
                    preferredShipmentType = property.Value.GetString().ToTransportShipmentType();
                    continue;
                }
                if (property.NameEquals("isUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isUpdated = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TransportPreferences(preferredShipmentType, isUpdated, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TransportPreferences>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportPreferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TransportPreferences)} does not support '{options.Format}' format.");
            }
        }

        TransportPreferences IPersistableModel<TransportPreferences>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportPreferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTransportPreferences(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TransportPreferences)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TransportPreferences>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
