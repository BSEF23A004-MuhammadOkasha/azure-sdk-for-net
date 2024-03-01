// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FluidRelay;

namespace Azure.ResourceManager.FluidRelay.Models
{
    public partial class FluidRelayEndpoints : IUtf8JsonSerializable, IJsonModel<FluidRelayEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FluidRelayEndpoints>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FluidRelayEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FluidRelayEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FluidRelayEndpoints)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(OrdererEndpoints is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("ordererEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in OrdererEndpoints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(StorageEndpoints is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("storageEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in StorageEndpoints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(ServiceEndpoints is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("serviceEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceEndpoints)
                {
                    writer.WriteStringValue(item);
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

        FluidRelayEndpoints IJsonModel<FluidRelayEndpoints>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FluidRelayEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FluidRelayEndpoints)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFluidRelayEndpoints(document.RootElement, options);
        }

        internal static FluidRelayEndpoints DeserializeFluidRelayEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> ordererEndpoints = default;
            IReadOnlyList<string> storageEndpoints = default;
            IReadOnlyList<string> serviceEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ordererEndpoints"u8))
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
                    ordererEndpoints = array;
                    continue;
                }
                if (property.NameEquals("storageEndpoints"u8))
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
                    storageEndpoints = array;
                    continue;
                }
                if (property.NameEquals("serviceEndpoints"u8))
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
                    serviceEndpoints = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FluidRelayEndpoints(ordererEndpoints ?? new ChangeTrackingList<string>(), storageEndpoints ?? new ChangeTrackingList<string>(), serviceEndpoints ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FluidRelayEndpoints>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FluidRelayEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FluidRelayEndpoints)} does not support '{options.Format}' format.");
            }
        }

        FluidRelayEndpoints IPersistableModel<FluidRelayEndpoints>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FluidRelayEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFluidRelayEndpoints(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FluidRelayEndpoints)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FluidRelayEndpoints>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
