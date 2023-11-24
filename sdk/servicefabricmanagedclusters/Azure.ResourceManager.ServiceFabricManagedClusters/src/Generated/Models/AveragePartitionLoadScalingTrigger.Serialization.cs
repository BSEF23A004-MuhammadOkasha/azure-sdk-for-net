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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class AveragePartitionLoadScalingTrigger : IUtf8JsonSerializable, IJsonModel<AveragePartitionLoadScalingTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AveragePartitionLoadScalingTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AveragePartitionLoadScalingTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AveragePartitionLoadScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AveragePartitionLoadScalingTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("metricName"u8);
            writer.WriteStringValue(MetricName);
            writer.WritePropertyName("lowerLoadThreshold"u8);
            writer.WriteNumberValue(LowerLoadThreshold);
            writer.WritePropertyName("upperLoadThreshold"u8);
            writer.WriteNumberValue(UpperLoadThreshold);
            writer.WritePropertyName("scaleInterval"u8);
            writer.WriteStringValue(ScaleInterval);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        AveragePartitionLoadScalingTrigger IJsonModel<AveragePartitionLoadScalingTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AveragePartitionLoadScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AveragePartitionLoadScalingTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAveragePartitionLoadScalingTrigger(document.RootElement, options);
        }

        internal static AveragePartitionLoadScalingTrigger DeserializeAveragePartitionLoadScalingTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metricName = default;
            double lowerLoadThreshold = default;
            double upperLoadThreshold = default;
            string scaleInterval = default;
            ServiceScalingTriggerKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lowerLoadThreshold"u8))
                {
                    lowerLoadThreshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("upperLoadThreshold"u8))
                {
                    upperLoadThreshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("scaleInterval"u8))
                {
                    scaleInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ServiceScalingTriggerKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AveragePartitionLoadScalingTrigger(kind, serializedAdditionalRawData, metricName, lowerLoadThreshold, upperLoadThreshold, scaleInterval);
        }

        BinaryData IPersistableModel<AveragePartitionLoadScalingTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AveragePartitionLoadScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AveragePartitionLoadScalingTrigger)} does not support '{options.Format}' format.");
            }
        }

        AveragePartitionLoadScalingTrigger IPersistableModel<AveragePartitionLoadScalingTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AveragePartitionLoadScalingTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAveragePartitionLoadScalingTrigger(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AveragePartitionLoadScalingTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AveragePartitionLoadScalingTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
