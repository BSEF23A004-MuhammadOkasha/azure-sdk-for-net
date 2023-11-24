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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class QueryStatisticsProperties : IUtf8JsonSerializable, IJsonModel<QueryStatisticsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryStatisticsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QueryStatisticsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatisticsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(QueryStatisticsProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(QueryId))
            {
                writer.WritePropertyName("queryId"u8);
                writer.WriteStringValue(QueryId);
            }
            if (options.Format != "W" && Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartTime);
            }
            if (options.Format != "W" && Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndTime);
            }
            if (Optional.IsCollectionDefined(Intervals))
            {
                writer.WritePropertyName("intervals"u8);
                writer.WriteStartArray();
                foreach (var item in Intervals)
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

        QueryStatisticsProperties IJsonModel<QueryStatisticsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatisticsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(QueryStatisticsProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryStatisticsProperties(document.RootElement, options);
        }

        internal static QueryStatisticsProperties DeserializeQueryStatisticsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> databaseName = default;
            Optional<string> queryId = default;
            Optional<string> startTime = default;
            Optional<string> endTime = default;
            Optional<IReadOnlyList<QueryMetricInterval>> intervals = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryId"u8))
                {
                    queryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("intervals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueryMetricInterval> array = new List<QueryMetricInterval>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryMetricInterval.DeserializeQueryMetricInterval(item));
                    }
                    intervals = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QueryStatisticsProperties(databaseName.Value, queryId.Value, startTime.Value, endTime.Value, Optional.ToList(intervals), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryStatisticsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatisticsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(QueryStatisticsProperties)} does not support '{options.Format}' format.");
            }
        }

        QueryStatisticsProperties IPersistableModel<QueryStatisticsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatisticsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueryStatisticsProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(QueryStatisticsProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryStatisticsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
