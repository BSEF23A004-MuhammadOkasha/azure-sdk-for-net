// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class EventGridStreamInputDataSource : IUtf8JsonSerializable, IJsonModel<EventGridStreamInputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridStreamInputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventGridStreamInputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridStreamInputDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StreamInputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Subscriber != null)
            {
                writer.WritePropertyName("subscriber"u8);
                writer.WriteObjectValue(Subscriber);
            }
            if (Schema.HasValue)
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteStringValue(Schema.Value.ToString());
            }
            if (!(StorageAccounts is ChangeTrackingList<StreamAnalyticsStorageAccount> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("storageAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(EventTypes is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("eventTypes"u8);
                writer.WriteStartArray();
                foreach (var item in EventTypes)
                {
                    writer.WriteStringValue(item);
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

        EventGridStreamInputDataSource IJsonModel<EventGridStreamInputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridStreamInputDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridStreamInputDataSource(document.RootElement, options);
        }

        internal static EventGridStreamInputDataSource DeserializeEventGridStreamInputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            EventHubV2StreamInputDataSource subscriber = default;
            EventGridEventSchemaType? schema = default;
            IList<StreamAnalyticsStorageAccount> storageAccounts = default;
            IList<string> eventTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("subscriber"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriber = EventHubV2StreamInputDataSource.DeserializeEventHubV2StreamInputDataSource(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("schema"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            schema = new EventGridEventSchemaType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamAnalyticsStorageAccount> array = new List<StreamAnalyticsStorageAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamAnalyticsStorageAccount.DeserializeStreamAnalyticsStorageAccount(item, options));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("eventTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            eventTypes = array;
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
            return new EventGridStreamInputDataSource(
                type,
                serializedAdditionalRawData,
                subscriber,
                schema,
                storageAccounts ?? new ChangeTrackingList<StreamAnalyticsStorageAccount>(),
                eventTypes ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<EventGridStreamInputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventGridStreamInputDataSource)} does not support '{options.Format}' format.");
            }
        }

        EventGridStreamInputDataSource IPersistableModel<EventGridStreamInputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridStreamInputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridStreamInputDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridStreamInputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
