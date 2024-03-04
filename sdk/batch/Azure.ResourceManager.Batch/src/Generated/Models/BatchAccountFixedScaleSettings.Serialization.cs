// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountFixedScaleSettings : IUtf8JsonSerializable, IJsonModel<BatchAccountFixedScaleSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountFixedScaleSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchAccountFixedScaleSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountFixedScaleSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountFixedScaleSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResizeTimeout))
            {
                writer.WritePropertyName("resizeTimeout"u8);
                writer.WriteStringValue(ResizeTimeout.Value, "P");
            }
            if (Optional.IsDefined(TargetDedicatedNodes))
            {
                writer.WritePropertyName("targetDedicatedNodes"u8);
                writer.WriteNumberValue(TargetDedicatedNodes.Value);
            }
            if (Optional.IsDefined(TargetLowPriorityNodes))
            {
                writer.WritePropertyName("targetLowPriorityNodes"u8);
                writer.WriteNumberValue(TargetLowPriorityNodes.Value);
            }
            if (Optional.IsDefined(NodeDeallocationOption))
            {
                writer.WritePropertyName("nodeDeallocationOption"u8);
                writer.WriteStringValue(NodeDeallocationOption.Value.ToSerialString());
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

        BatchAccountFixedScaleSettings IJsonModel<BatchAccountFixedScaleSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountFixedScaleSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountFixedScaleSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountFixedScaleSettings(document.RootElement, options);
        }

        internal static BatchAccountFixedScaleSettings DeserializeBatchAccountFixedScaleSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan? resizeTimeout = default;
            int? targetDedicatedNodes = default;
            int? targetLowPriorityNodes = default;
            BatchNodeDeallocationOption? nodeDeallocationOption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resizeTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resizeTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("targetDedicatedNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDedicatedNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetLowPriorityNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetLowPriorityNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeDeallocationOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeDeallocationOption = property.Value.GetString().ToBatchNodeDeallocationOption();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountFixedScaleSettings(resizeTimeout, targetDedicatedNodes, targetLowPriorityNodes, nodeDeallocationOption, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountFixedScaleSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountFixedScaleSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchAccountFixedScaleSettings)} does not support '{options.Format}' format.");
            }
        }

        BatchAccountFixedScaleSettings IPersistableModel<BatchAccountFixedScaleSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountFixedScaleSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAccountFixedScaleSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchAccountFixedScaleSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAccountFixedScaleSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
