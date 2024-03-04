// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class QueryStatistics : IUtf8JsonSerializable, IJsonModel<QueryStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryStatistics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QueryStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryStatistics)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
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
            writer.WriteEndObject();
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

        QueryStatistics IJsonModel<QueryStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryStatistics)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryStatistics(document.RootElement, options);
        }

        internal static QueryStatistics DeserializeQueryStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string databaseName = default;
            string queryId = default;
            string startTime = default;
            string endTime = default;
            IList<QueryMetricInterval> intervals = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryId"u8))
                        {
                            queryId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            startTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            endTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("intervals"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<QueryMetricInterval> array = new List<QueryMetricInterval>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(QueryMetricInterval.DeserializeQueryMetricInterval(item, options));
                            }
                            intervals = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QueryStatistics(
                id,
                name,
                type,
                systemData,
                databaseName,
                queryId,
                startTime,
                endTime,
                intervals ?? new ChangeTrackingList<QueryMetricInterval>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QueryStatistics)} does not support '{options.Format}' format.");
            }
        }

        QueryStatistics IPersistableModel<QueryStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueryStatistics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueryStatistics)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
