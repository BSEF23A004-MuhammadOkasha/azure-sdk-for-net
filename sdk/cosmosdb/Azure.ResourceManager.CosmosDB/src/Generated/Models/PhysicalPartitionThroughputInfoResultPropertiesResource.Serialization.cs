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

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class PhysicalPartitionThroughputInfoResultPropertiesResource : IUtf8JsonSerializable, IJsonModel<PhysicalPartitionThroughputInfoResultPropertiesResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PhysicalPartitionThroughputInfoResultPropertiesResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PhysicalPartitionThroughputInfoResultPropertiesResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoResultPropertiesResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PhysicalPartitionThroughputInfoResultPropertiesResource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PhysicalPartitionThroughputInfo))
            {
                writer.WritePropertyName("physicalPartitionThroughputInfo"u8);
                writer.WriteStartArray();
                foreach (var item in PhysicalPartitionThroughputInfo)
                {
                    writer.WriteObjectValue(item);
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

        PhysicalPartitionThroughputInfoResultPropertiesResource IJsonModel<PhysicalPartitionThroughputInfoResultPropertiesResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoResultPropertiesResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PhysicalPartitionThroughputInfoResultPropertiesResource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePhysicalPartitionThroughputInfoResultPropertiesResource(document.RootElement, options);
        }

        internal static PhysicalPartitionThroughputInfoResultPropertiesResource DeserializePhysicalPartitionThroughputInfoResultPropertiesResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<PhysicalPartitionThroughputInfoResource>> physicalPartitionThroughputInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("physicalPartitionThroughputInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PhysicalPartitionThroughputInfoResource> array = new List<PhysicalPartitionThroughputInfoResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PhysicalPartitionThroughputInfoResource.DeserializePhysicalPartitionThroughputInfoResource(item));
                    }
                    physicalPartitionThroughputInfo = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PhysicalPartitionThroughputInfoResultPropertiesResource(Optional.ToList(physicalPartitionThroughputInfo), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PhysicalPartitionThroughputInfoResultPropertiesResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoResultPropertiesResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PhysicalPartitionThroughputInfoResultPropertiesResource)} does not support '{options.Format}' format.");
            }
        }

        PhysicalPartitionThroughputInfoResultPropertiesResource IPersistableModel<PhysicalPartitionThroughputInfoResultPropertiesResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoResultPropertiesResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePhysicalPartitionThroughputInfoResultPropertiesResource(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PhysicalPartitionThroughputInfoResultPropertiesResource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PhysicalPartitionThroughputInfoResultPropertiesResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
