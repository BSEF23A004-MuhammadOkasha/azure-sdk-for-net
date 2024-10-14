// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StandbyPool.Models
{
    public partial class ContainerGroupInstanceCountSummary : IUtf8JsonSerializable, IJsonModel<ContainerGroupInstanceCountSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerGroupInstanceCountSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerGroupInstanceCountSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupInstanceCountSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupInstanceCountSummary)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("instanceCountsByState"u8);
            writer.WriteStartArray();
            foreach (var item in InstanceCountsByState)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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
        }

        ContainerGroupInstanceCountSummary IJsonModel<ContainerGroupInstanceCountSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupInstanceCountSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupInstanceCountSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerGroupInstanceCountSummary(document.RootElement, options);
        }

        internal static ContainerGroupInstanceCountSummary DeserializeContainerGroupInstanceCountSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PoolResourceStateCount> instanceCountsByState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceCountsByState"u8))
                {
                    List<PoolResourceStateCount> array = new List<PoolResourceStateCount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PoolResourceStateCount.DeserializePoolResourceStateCount(item, options));
                    }
                    instanceCountsByState = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerGroupInstanceCountSummary(instanceCountsByState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerGroupInstanceCountSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupInstanceCountSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupInstanceCountSummary)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerGroupInstanceCountSummary IPersistableModel<ContainerGroupInstanceCountSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupInstanceCountSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerGroupInstanceCountSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupInstanceCountSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerGroupInstanceCountSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
