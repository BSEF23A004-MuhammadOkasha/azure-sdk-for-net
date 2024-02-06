// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class TransportAvailabilityResponse : IUtf8JsonSerializable, IJsonModel<TransportAvailabilityResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransportAvailabilityResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TransportAvailabilityResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportAvailabilityResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransportAvailabilityResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(TransportAvailabilityDetails))
            {
                writer.WritePropertyName("transportAvailabilityDetails"u8);
                writer.WriteStartArray();
                foreach (var item in TransportAvailabilityDetails)
                {
                    BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
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

        TransportAvailabilityResponse IJsonModel<TransportAvailabilityResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportAvailabilityResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransportAvailabilityResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransportAvailabilityResponse(document.RootElement, options);
        }

        internal static TransportAvailabilityResponse DeserializeTransportAvailabilityResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<TransportAvailabilityDetails>> transportAvailabilityDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transportAvailabilityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TransportAvailabilityDetails> array = new List<TransportAvailabilityDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.TransportAvailabilityDetails.DeserializeTransportAvailabilityDetails(item));
                    }
                    transportAvailabilityDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TransportAvailabilityResponse(Optional.ToList(transportAvailabilityDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TransportAvailabilityResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportAvailabilityResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TransportAvailabilityResponse)} does not support '{options.Format}' format.");
            }
        }

        TransportAvailabilityResponse IPersistableModel<TransportAvailabilityResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportAvailabilityResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTransportAvailabilityResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TransportAvailabilityResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TransportAvailabilityResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
