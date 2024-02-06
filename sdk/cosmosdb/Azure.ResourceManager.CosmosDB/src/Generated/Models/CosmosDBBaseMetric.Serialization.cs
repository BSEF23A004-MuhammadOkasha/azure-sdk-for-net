// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBBaseMetric : IUtf8JsonSerializable, IJsonModel<CosmosDBBaseMetric>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBBaseMetric>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBBaseMetric>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBBaseMetric>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBBaseMetric)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TimeGrain))
            {
                writer.WritePropertyName("timeGrain"u8);
                writer.WriteStringValue(TimeGrain);
            }
            if (options.Format != "W" && Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                BinaryData data = ModelReaderWriter.Write(Name, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(MetricValues))
            {
                writer.WritePropertyName("metricValues"u8);
                writer.WriteStartArray();
                foreach (var item in MetricValues)
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

        CosmosDBBaseMetric IJsonModel<CosmosDBBaseMetric>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBBaseMetric>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBBaseMetric)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBBaseMetric(document.RootElement, options);
        }

        internal static CosmosDBBaseMetric DeserializeCosmosDBBaseMetric(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> timeGrain = default;
            Optional<CosmosDBMetricUnitType> unit = default;
            Optional<CosmosDBMetricName> name = default;
            Optional<IReadOnlyList<CosmosDBMetricValue>> metricValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeGrain"u8))
                {
                    timeGrain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new CosmosDBMetricUnitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = CosmosDBMetricName.DeserializeCosmosDBMetricName(property.Value);
                    continue;
                }
                if (property.NameEquals("metricValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBMetricValue> array = new List<CosmosDBMetricValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBMetricValue.DeserializeCosmosDBMetricValue(item));
                    }
                    metricValues = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBBaseMetric(Optional.ToNullable(startTime), Optional.ToNullable(endTime), timeGrain.Value, Optional.ToNullable(unit), name.Value, Optional.ToList(metricValues), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBBaseMetric>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBBaseMetric>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBBaseMetric)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBBaseMetric IPersistableModel<CosmosDBBaseMetric>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBBaseMetric>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBBaseMetric(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBBaseMetric)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBBaseMetric>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
