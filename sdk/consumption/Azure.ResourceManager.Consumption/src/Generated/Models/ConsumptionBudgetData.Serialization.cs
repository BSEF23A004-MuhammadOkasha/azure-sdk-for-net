// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Consumption.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption
{
    public partial class ConsumptionBudgetData : IUtf8JsonSerializable, IJsonModel<ConsumptionBudgetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionBudgetData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionBudgetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionBudgetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionBudgetData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
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
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
            }
            if (Optional.IsDefined(TimeGrain))
            {
                writer.WritePropertyName("timeGrain"u8);
                writer.WriteStringValue(TimeGrain.Value.ToString());
            }
            if (Optional.IsDefined(TimePeriod))
            {
                writer.WritePropertyName("timePeriod"u8);
                BinaryData data = ModelReaderWriter.Write(TimePeriod, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                BinaryData data = ModelReaderWriter.Write(Filter, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentSpend))
            {
                writer.WritePropertyName("currentSpend"u8);
                BinaryData data = ModelReaderWriter.Write(CurrentSpend, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Notifications))
            {
                writer.WritePropertyName("notifications"u8);
                writer.WriteStartObject();
                foreach (var item in Notifications)
                {
                    writer.WritePropertyName(item.Key);
                    BinaryData data = ModelReaderWriter.Write(item.Value, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(ForecastSpend))
            {
                writer.WritePropertyName("forecastSpend"u8);
                BinaryData data = ModelReaderWriter.Write(ForecastSpend, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        ConsumptionBudgetData IJsonModel<ConsumptionBudgetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionBudgetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionBudgetData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionBudgetData(document.RootElement, options);
        }

        internal static ConsumptionBudgetData DeserializeConsumptionBudgetData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<BudgetCategory> category = default;
            Optional<decimal> amount = default;
            Optional<BudgetTimeGrainType> timeGrain = default;
            Optional<BudgetTimePeriod> timePeriod = default;
            Optional<ConsumptionBudgetFilter> filter = default;
            Optional<BudgetCurrentSpend> currentSpend = default;
            Optional<IDictionary<string, BudgetAssociatedNotification>> notifications = default;
            Optional<BudgetForecastSpend> forecastSpend = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("category"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            category = new BudgetCategory(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("amount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            amount = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("timeGrain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeGrain = new BudgetTimeGrainType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timePeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timePeriod = BudgetTimePeriod.DeserializeBudgetTimePeriod(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("filter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            filter = ConsumptionBudgetFilter.DeserializeConsumptionBudgetFilter(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("currentSpend"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentSpend = BudgetCurrentSpend.DeserializeBudgetCurrentSpend(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("notifications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BudgetAssociatedNotification> dictionary = new Dictionary<string, BudgetAssociatedNotification>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BudgetAssociatedNotification.DeserializeBudgetAssociatedNotification(property1.Value));
                            }
                            notifications = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("forecastSpend"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            forecastSpend = BudgetForecastSpend.DeserializeBudgetForecastSpend(property0.Value);
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
            return new ConsumptionBudgetData(id, name, type, systemData.Value, Optional.ToNullable(category), Optional.ToNullable(amount), Optional.ToNullable(timeGrain), timePeriod.Value, filter.Value, currentSpend.Value, Optional.ToDictionary(notifications), forecastSpend.Value, Optional.ToNullable(eTag), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionBudgetData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionBudgetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionBudgetData)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionBudgetData IPersistableModel<ConsumptionBudgetData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionBudgetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionBudgetData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionBudgetData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionBudgetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
