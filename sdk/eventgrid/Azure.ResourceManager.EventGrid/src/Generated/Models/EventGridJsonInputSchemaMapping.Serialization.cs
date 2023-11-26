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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridJsonInputSchemaMapping : IUtf8JsonSerializable, IJsonModel<EventGridJsonInputSchemaMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridJsonInputSchemaMapping>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventGridJsonInputSchemaMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridJsonInputSchemaMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EventGridJsonInputSchemaMapping)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("inputSchemaMappingType"u8);
            writer.WriteStringValue(InputSchemaMappingType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteObjectValue(Id);
            }
            if (Optional.IsDefined(Topic))
            {
                writer.WritePropertyName("topic"u8);
                writer.WriteObjectValue(Topic);
            }
            if (Optional.IsDefined(EventTime))
            {
                writer.WritePropertyName("eventTime"u8);
                writer.WriteObjectValue(EventTime);
            }
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteObjectValue(EventType);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteObjectValue(Subject);
            }
            if (Optional.IsDefined(DataVersion))
            {
                writer.WritePropertyName("dataVersion"u8);
                writer.WriteObjectValue(DataVersion);
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

        EventGridJsonInputSchemaMapping IJsonModel<EventGridJsonInputSchemaMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridJsonInputSchemaMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EventGridJsonInputSchemaMapping)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridJsonInputSchemaMapping(document.RootElement, options);
        }

        internal static EventGridJsonInputSchemaMapping DeserializeEventGridJsonInputSchemaMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InputSchemaMappingType inputSchemaMappingType = default;
            Optional<JsonField> id = default;
            Optional<JsonField> topic = default;
            Optional<JsonField> eventTime = default;
            Optional<JsonFieldWithDefault> eventType = default;
            Optional<JsonFieldWithDefault> subject = default;
            Optional<JsonFieldWithDefault> dataVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputSchemaMappingType"u8))
                {
                    inputSchemaMappingType = new InputSchemaMappingType(property.Value.GetString());
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
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id = JsonField.DeserializeJsonField(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("topic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            topic = JsonField.DeserializeJsonField(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("eventTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventTime = JsonField.DeserializeJsonField(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("eventType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventType = JsonFieldWithDefault.DeserializeJsonFieldWithDefault(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("subject"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subject = JsonFieldWithDefault.DeserializeJsonFieldWithDefault(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataVersion = JsonFieldWithDefault.DeserializeJsonFieldWithDefault(property0.Value);
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
            return new EventGridJsonInputSchemaMapping(inputSchemaMappingType, serializedAdditionalRawData, id.Value, topic.Value, eventTime.Value, eventType.Value, subject.Value, dataVersion.Value);
        }

        BinaryData IPersistableModel<EventGridJsonInputSchemaMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridJsonInputSchemaMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(EventGridJsonInputSchemaMapping)} does not support '{options.Format}' format.");
            }
        }

        EventGridJsonInputSchemaMapping IPersistableModel<EventGridJsonInputSchemaMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridJsonInputSchemaMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridJsonInputSchemaMapping(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(EventGridJsonInputSchemaMapping)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridJsonInputSchemaMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
