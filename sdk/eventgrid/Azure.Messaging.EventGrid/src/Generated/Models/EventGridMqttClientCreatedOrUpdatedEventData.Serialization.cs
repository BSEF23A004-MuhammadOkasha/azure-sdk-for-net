// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(EventGridMqttClientCreatedOrUpdatedEventDataConverter))]
    public partial class EventGridMqttClientCreatedOrUpdatedEventData : IUtf8JsonSerializable, IJsonModel<EventGridMqttClientCreatedOrUpdatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridMqttClientCreatedOrUpdatedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventGridMqttClientCreatedOrUpdatedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientCreatedOrUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EventGridMqttClientCreatedOrUpdatedEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdOn"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedOn"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(Attributes))
            {
                writer.WritePropertyName("attributes"u8);
                writer.WriteStartObject();
                foreach (var item in Attributes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ClientAuthenticationName))
            {
                writer.WritePropertyName("clientAuthenticationName"u8);
                writer.WriteStringValue(ClientAuthenticationName);
            }
            if (Optional.IsDefined(ClientName))
            {
                writer.WritePropertyName("clientName"u8);
                writer.WriteStringValue(ClientName);
            }
            if (Optional.IsDefined(NamespaceName))
            {
                writer.WritePropertyName("namespaceName"u8);
                writer.WriteStringValue(NamespaceName);
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

        EventGridMqttClientCreatedOrUpdatedEventData IJsonModel<EventGridMqttClientCreatedOrUpdatedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientCreatedOrUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EventGridMqttClientCreatedOrUpdatedEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridMqttClientCreatedOrUpdatedEventData(document.RootElement, options);
        }

        internal static EventGridMqttClientCreatedOrUpdatedEventData DeserializeEventGridMqttClientCreatedOrUpdatedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EventGridMqttClientState> state = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<DateTimeOffset> updatedOn = default;
            Optional<IReadOnlyDictionary<string, string>> attributes = default;
            Optional<string> clientAuthenticationName = default;
            Optional<string> clientName = default;
            Optional<string> namespaceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new EventGridMqttClientState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    attributes = dictionary;
                    continue;
                }
                if (property.NameEquals("clientAuthenticationName"u8))
                {
                    clientAuthenticationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientName"u8))
                {
                    clientName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespaceName"u8))
                {
                    namespaceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventGridMqttClientCreatedOrUpdatedEventData(clientAuthenticationName.Value, clientName.Value, namespaceName.Value, serializedAdditionalRawData, Optional.ToNullable(state), Optional.ToNullable(createdOn), Optional.ToNullable(updatedOn), Optional.ToDictionary(attributes));
        }

        BinaryData IPersistableModel<EventGridMqttClientCreatedOrUpdatedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientCreatedOrUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(EventGridMqttClientCreatedOrUpdatedEventData)} does not support '{options.Format}' format.");
            }
        }

        EventGridMqttClientCreatedOrUpdatedEventData IPersistableModel<EventGridMqttClientCreatedOrUpdatedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientCreatedOrUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridMqttClientCreatedOrUpdatedEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(EventGridMqttClientCreatedOrUpdatedEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridMqttClientCreatedOrUpdatedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class EventGridMqttClientCreatedOrUpdatedEventDataConverter : JsonConverter<EventGridMqttClientCreatedOrUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, EventGridMqttClientCreatedOrUpdatedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventGridMqttClientCreatedOrUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventGridMqttClientCreatedOrUpdatedEventData(document.RootElement);
            }
        }
    }
}
