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

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class OrderItemPreferences : IUtf8JsonSerializable, IJsonModel<OrderItemPreferences>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OrderItemPreferences>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OrderItemPreferences>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrderItemPreferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(OrderItemPreferences)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NotificationPreferences))
            {
                writer.WritePropertyName("notificationPreferences"u8);
                writer.WriteStartArray();
                foreach (var item in NotificationPreferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TransportPreferences))
            {
                writer.WritePropertyName("transportPreferences"u8);
                writer.WriteObjectValue(TransportPreferences);
            }
            if (Optional.IsDefined(EncryptionPreferences))
            {
                writer.WritePropertyName("encryptionPreferences"u8);
                writer.WriteObjectValue(EncryptionPreferences);
            }
            if (Optional.IsDefined(ManagementResourcePreferences))
            {
                writer.WritePropertyName("managementResourcePreferences"u8);
                writer.WriteObjectValue(ManagementResourcePreferences);
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

        OrderItemPreferences IJsonModel<OrderItemPreferences>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrderItemPreferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(OrderItemPreferences)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOrderItemPreferences(document.RootElement, options);
        }

        internal static OrderItemPreferences DeserializeOrderItemPreferences(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<NotificationPreference>> notificationPreferences = default;
            Optional<TransportPreferences> transportPreferences = default;
            Optional<EncryptionPreferences> encryptionPreferences = default;
            Optional<ManagementResourcePreferences> managementResourcePreferences = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notificationPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NotificationPreference> array = new List<NotificationPreference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotificationPreference.DeserializeNotificationPreference(item));
                    }
                    notificationPreferences = array;
                    continue;
                }
                if (property.NameEquals("transportPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transportPreferences = TransportPreferences.DeserializeTransportPreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("encryptionPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionPreferences = EncryptionPreferences.DeserializeEncryptionPreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("managementResourcePreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managementResourcePreferences = ManagementResourcePreferences.DeserializeManagementResourcePreferences(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OrderItemPreferences(Optional.ToList(notificationPreferences), transportPreferences.Value, encryptionPreferences.Value, managementResourcePreferences.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OrderItemPreferences>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrderItemPreferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(OrderItemPreferences)} does not support '{options.Format}' format.");
            }
        }

        OrderItemPreferences IPersistableModel<OrderItemPreferences>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrderItemPreferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOrderItemPreferences(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(OrderItemPreferences)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OrderItemPreferences>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
