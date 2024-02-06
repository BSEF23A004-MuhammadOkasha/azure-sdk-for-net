// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeClusterCapacityViewInfo : IUtf8JsonSerializable, IJsonModel<EdgeClusterCapacityViewInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeClusterCapacityViewInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeClusterCapacityViewInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterCapacityViewInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeClusterCapacityViewInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (Optional.IsDefined(GpuCapacity))
            {
                writer.WritePropertyName("gpuCapacity"u8);
                BinaryData data = ModelReaderWriter.Write(GpuCapacity, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(MemoryCapacity))
            {
                writer.WritePropertyName("memoryCapacity"u8);
                BinaryData data = ModelReaderWriter.Write(MemoryCapacity, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(LastRefreshedOn))
            {
                writer.WritePropertyName("lastRefreshedTime"u8);
                writer.WriteStringValue(LastRefreshedOn.Value, "O");
            }
            if (Optional.IsDefined(TotalProvisionedNonHpnCores))
            {
                writer.WritePropertyName("totalProvisionedNonHpnCores"u8);
                writer.WriteNumberValue(TotalProvisionedNonHpnCores.Value);
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

        EdgeClusterCapacityViewInfo IJsonModel<EdgeClusterCapacityViewInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterCapacityViewInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeClusterCapacityViewInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeClusterCapacityViewInfo(document.RootElement, options);
        }

        internal static EdgeClusterCapacityViewInfo DeserializeEdgeClusterCapacityViewInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fqdn = default;
            Optional<EdgeClusterGpuCapacity> gpuCapacity = default;
            Optional<EdgeClusterMemoryCapacity> memoryCapacity = default;
            Optional<DateTimeOffset> lastRefreshedTime = default;
            Optional<long> totalProvisionedNonHpnCores = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gpuCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gpuCapacity = EdgeClusterGpuCapacity.DeserializeEdgeClusterGpuCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("memoryCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryCapacity = EdgeClusterMemoryCapacity.DeserializeEdgeClusterMemoryCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("lastRefreshedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRefreshedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("totalProvisionedNonHpnCores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalProvisionedNonHpnCores = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeClusterCapacityViewInfo(fqdn.Value, gpuCapacity.Value, memoryCapacity.Value, Optional.ToNullable(lastRefreshedTime), Optional.ToNullable(totalProvisionedNonHpnCores), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeClusterCapacityViewInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterCapacityViewInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeClusterCapacityViewInfo)} does not support '{options.Format}' format.");
            }
        }

        EdgeClusterCapacityViewInfo IPersistableModel<EdgeClusterCapacityViewInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeClusterCapacityViewInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeClusterCapacityViewInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeClusterCapacityViewInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeClusterCapacityViewInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
