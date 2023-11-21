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

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class BudgetAssociatedNotification : IUtf8JsonSerializable, IJsonModel<BudgetAssociatedNotification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BudgetAssociatedNotification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BudgetAssociatedNotification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BudgetAssociatedNotification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BudgetAssociatedNotification)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(Operator.ToString());
            writer.WritePropertyName("threshold"u8);
            writer.WriteNumberValue(Threshold);
            writer.WritePropertyName("contactEmails"u8);
            writer.WriteStartArray();
            foreach (var item in ContactEmails)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ContactRoles))
            {
                writer.WritePropertyName("contactRoles"u8);
                writer.WriteStartArray();
                foreach (var item in ContactRoles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContactGroups))
            {
                writer.WritePropertyName("contactGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ContactGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ThresholdType))
            {
                writer.WritePropertyName("thresholdType"u8);
                writer.WriteStringValue(ThresholdType.Value.ToString());
            }
            if (Optional.IsDefined(Locale))
            {
                writer.WritePropertyName("locale"u8);
                writer.WriteStringValue(Locale.Value.ToString());
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

        BudgetAssociatedNotification IJsonModel<BudgetAssociatedNotification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BudgetAssociatedNotification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BudgetAssociatedNotification)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBudgetAssociatedNotification(document.RootElement, options);
        }

        internal static BudgetAssociatedNotification DeserializeBudgetAssociatedNotification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            NotificationAlertTriggerType @operator = default;
            decimal threshold = default;
            IList<string> contactEmails = default;
            Optional<IList<string>> contactRoles = default;
            Optional<IList<string>> contactGroups = default;
            Optional<NotificationThresholdType> thresholdType = default;
            Optional<RecipientNotificationLanguageCode> locale = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = new NotificationAlertTriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    threshold = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("contactEmails"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactEmails = array;
                    continue;
                }
                if (property.NameEquals("contactRoles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactRoles = array;
                    continue;
                }
                if (property.NameEquals("contactGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactGroups = array;
                    continue;
                }
                if (property.NameEquals("thresholdType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thresholdType = new NotificationThresholdType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("locale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    locale = new RecipientNotificationLanguageCode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BudgetAssociatedNotification(enabled, @operator, threshold, contactEmails, Optional.ToList(contactRoles), Optional.ToList(contactGroups), Optional.ToNullable(thresholdType), Optional.ToNullable(locale), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BudgetAssociatedNotification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BudgetAssociatedNotification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BudgetAssociatedNotification)} does not support '{options.Format}' format.");
            }
        }

        BudgetAssociatedNotification IPersistableModel<BudgetAssociatedNotification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BudgetAssociatedNotification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBudgetAssociatedNotification(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BudgetAssociatedNotification)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BudgetAssociatedNotification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
