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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RankingsResponseTablesPropertiesItemsItem : IUtf8JsonSerializable, IJsonModel<RankingsResponseTablesPropertiesItemsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RankingsResponseTablesPropertiesItemsItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RankingsResponseTablesPropertiesItemsItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RankingsResponseTablesPropertiesItemsItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
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

        RankingsResponseTablesPropertiesItemsItem IJsonModel<RankingsResponseTablesPropertiesItemsItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RankingsResponseTablesPropertiesItemsItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRankingsResponseTablesPropertiesItemsItem(document.RootElement, options);
        }

        internal static RankingsResponseTablesPropertiesItemsItem DeserializeRankingsResponseTablesPropertiesItemsItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<RankingsResponseTablesPropertiesItemsMetricsItem>> metrics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RankingsResponseTablesPropertiesItemsMetricsItem> array = new List<RankingsResponseTablesPropertiesItemsMetricsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RankingsResponseTablesPropertiesItemsMetricsItem.DeserializeRankingsResponseTablesPropertiesItemsMetricsItem(item));
                    }
                    metrics = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RankingsResponseTablesPropertiesItemsItem(name.Value, Optional.ToList(metrics), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RankingsResponseTablesPropertiesItemsItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RankingsResponseTablesPropertiesItemsItem)} does not support '{options.Format}' format.");
            }
        }

        RankingsResponseTablesPropertiesItemsItem IPersistableModel<RankingsResponseTablesPropertiesItemsItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRankingsResponseTablesPropertiesItemsItem(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RankingsResponseTablesPropertiesItemsItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RankingsResponseTablesPropertiesItemsItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
