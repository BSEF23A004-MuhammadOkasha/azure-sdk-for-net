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

namespace Azure.ResourceManager.Network.Models
{
    public partial class PropagatedRouteTable : IUtf8JsonSerializable, IJsonModel<PropagatedRouteTable>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PropagatedRouteTable>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PropagatedRouteTable>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropagatedRouteTable>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PropagatedRouteTable)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Ids))
            {
                writer.WritePropertyName("ids"u8);
                writer.WriteStartArray();
                foreach (var item in Ids)
                {
                    JsonSerializer.Serialize(writer, item);
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

        PropagatedRouteTable IJsonModel<PropagatedRouteTable>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropagatedRouteTable>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PropagatedRouteTable)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePropagatedRouteTable(document.RootElement, options);
        }

        internal static PropagatedRouteTable DeserializePropagatedRouteTable(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> labels = default;
            Optional<IList<WritableSubResource>> ids = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("ids"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    ids = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PropagatedRouteTable(Optional.ToList(labels), Optional.ToList(ids), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PropagatedRouteTable>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropagatedRouteTable>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PropagatedRouteTable)} does not support '{options.Format}' format.");
            }
        }

        PropagatedRouteTable IPersistableModel<PropagatedRouteTable>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropagatedRouteTable>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePropagatedRouteTable(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PropagatedRouteTable)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PropagatedRouteTable>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
