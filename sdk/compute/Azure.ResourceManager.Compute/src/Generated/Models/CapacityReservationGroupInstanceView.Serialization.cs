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
    public partial class CapacityReservationGroupInstanceView : IUtf8JsonSerializable, IJsonModel<CapacityReservationGroupInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CapacityReservationGroupInstanceView>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CapacityReservationGroupInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityReservationGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CapacityReservationGroupInstanceView)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(CapacityReservations))
            {
                writer.WritePropertyName("capacityReservations"u8);
                writer.WriteStartArray();
                foreach (var item in CapacityReservations)
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
            if (options.Format != "W" && Optional.IsCollectionDefined(SharedSubscriptionIds))
            {
                writer.WritePropertyName("sharedSubscriptionIds"u8);
                writer.WriteStartArray();
                foreach (var item in SharedSubscriptionIds)
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

        CapacityReservationGroupInstanceView IJsonModel<CapacityReservationGroupInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityReservationGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CapacityReservationGroupInstanceView)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCapacityReservationGroupInstanceView(document.RootElement, options);
        }

        internal static CapacityReservationGroupInstanceView DeserializeCapacityReservationGroupInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CapacityReservationInstanceViewWithName>> capacityReservations = default;
            Optional<IReadOnlyList<SubResource>> sharedSubscriptionIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capacityReservations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CapacityReservationInstanceViewWithName> array = new List<CapacityReservationInstanceViewWithName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CapacityReservationInstanceViewWithName.DeserializeCapacityReservationInstanceViewWithName(item));
                    }
                    capacityReservations = array;
                    continue;
                }
                if (property.NameEquals("sharedSubscriptionIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                    }
                    sharedSubscriptionIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CapacityReservationGroupInstanceView(Optional.ToList(capacityReservations), Optional.ToList(sharedSubscriptionIds), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CapacityReservationGroupInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityReservationGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CapacityReservationGroupInstanceView)} does not support '{options.Format}' format.");
            }
        }

        CapacityReservationGroupInstanceView IPersistableModel<CapacityReservationGroupInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityReservationGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCapacityReservationGroupInstanceView(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CapacityReservationGroupInstanceView)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CapacityReservationGroupInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
