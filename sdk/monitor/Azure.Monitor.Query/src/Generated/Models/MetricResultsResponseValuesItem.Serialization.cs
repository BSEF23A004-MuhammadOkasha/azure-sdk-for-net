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

namespace Azure.Monitor.Query.Models
{
    public partial class MetricResultsResponseValuesItem : IUtf8JsonSerializable, IJsonModel<MetricResultsResponseValuesItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricResultsResponseValuesItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MetricResultsResponseValuesItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricResultsResponseValuesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MetricResultsResponseValuesItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("starttime"u8);
            writer.WriteStringValue(StartTime);
            writer.WritePropertyName("endtime"u8);
            writer.WriteStringValue(EndTime);
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteStringValue(Interval.Value, "P");
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(ResourceRegion))
            {
                writer.WritePropertyName("resourceregion"u8);
                writer.WriteStringValue(ResourceRegion);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceid"u8);
                writer.WriteStringValue(ResourceId);
            }
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item);
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
            writer.WriteEndObject();
        }

        MetricResultsResponseValuesItem IJsonModel<MetricResultsResponseValuesItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricResultsResponseValuesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MetricResultsResponseValuesItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricResultsResponseValuesItem(document.RootElement, options);
        }

        internal static MetricResultsResponseValuesItem DeserializeMetricResultsResponseValuesItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset starttime = default;
            DateTimeOffset endtime = default;
            Optional<TimeSpan> interval = default;
            Optional<string> @namespace = default;
            Optional<string> resourceregion = default;
            Optional<ResourceIdentifier> resourceid = default;
            IReadOnlyList<QueryBatchMetric> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("starttime"u8))
                {
                    starttime = property.Value.GetDateTimeOffset(null);
                    continue;
                }
                if (property.NameEquals("endtime"u8))
                {
                    endtime = property.Value.GetDateTimeOffset(null);
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceregion"u8))
                {
                    resourceregion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceid = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<QueryBatchMetric> array = new List<QueryBatchMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryBatchMetric.DeserializeQueryBatchMetric(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricResultsResponseValuesItem(starttime, endtime, Optional.ToNullable(interval), @namespace.Value, resourceregion.Value, resourceid.Value, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MetricResultsResponseValuesItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricResultsResponseValuesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MetricResultsResponseValuesItem)} does not support '{options.Format}' format.");
            }
        }

        MetricResultsResponseValuesItem IPersistableModel<MetricResultsResponseValuesItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricResultsResponseValuesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMetricResultsResponseValuesItem(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MetricResultsResponseValuesItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MetricResultsResponseValuesItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
