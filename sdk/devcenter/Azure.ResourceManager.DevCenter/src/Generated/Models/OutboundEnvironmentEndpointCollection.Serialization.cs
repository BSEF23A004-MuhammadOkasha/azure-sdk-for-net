// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    internal partial class OutboundEnvironmentEndpointCollection : IUtf8JsonSerializable, IJsonModel<OutboundEnvironmentEndpointCollection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OutboundEnvironmentEndpointCollection>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OutboundEnvironmentEndpointCollection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutboundEnvironmentEndpointCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OutboundEnvironmentEndpointCollection)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(Value is ChangeTrackingList<OutboundEnvironmentEndpoint> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        OutboundEnvironmentEndpointCollection IJsonModel<OutboundEnvironmentEndpointCollection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutboundEnvironmentEndpointCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OutboundEnvironmentEndpointCollection)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOutboundEnvironmentEndpointCollection(document.RootElement, options);
        }

        internal static OutboundEnvironmentEndpointCollection DeserializeOutboundEnvironmentEndpointCollection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<OutboundEnvironmentEndpoint> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OutboundEnvironmentEndpoint> array = new List<OutboundEnvironmentEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutboundEnvironmentEndpoint.DeserializeOutboundEnvironmentEndpoint(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OutboundEnvironmentEndpointCollection(value ?? new ChangeTrackingList<OutboundEnvironmentEndpoint>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OutboundEnvironmentEndpointCollection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutboundEnvironmentEndpointCollection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OutboundEnvironmentEndpointCollection)} does not support '{options.Format}' format.");
            }
        }

        OutboundEnvironmentEndpointCollection IPersistableModel<OutboundEnvironmentEndpointCollection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutboundEnvironmentEndpointCollection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOutboundEnvironmentEndpointCollection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OutboundEnvironmentEndpointCollection)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OutboundEnvironmentEndpointCollection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
