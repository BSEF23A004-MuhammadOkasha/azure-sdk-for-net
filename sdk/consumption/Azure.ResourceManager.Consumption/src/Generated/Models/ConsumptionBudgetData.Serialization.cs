// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Consumption.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption
{
    public partial class ConsumptionBudgetData : IUtf8JsonSerializable, IModelJsonSerializable<ConsumptionBudgetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConsumptionBudgetData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConsumptionBudgetData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionBudgetData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
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
                if (TimePeriod is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BudgetTimePeriod>)TimePeriod).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                if (Filter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConsumptionBudgetFilter>)Filter).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Notifications))
            {
                writer.WritePropertyName("notifications"u8);
                writer.WriteStartObject();
                foreach (var item in Notifications)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BudgetAssociatedNotification>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ConsumptionBudgetData DeserializeConsumptionBudgetData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

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
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConsumptionBudgetData(id, name, type, systemData.Value, Optional.ToNullable(category), Optional.ToNullable(amount), Optional.ToNullable(timeGrain), timePeriod.Value, filter.Value, currentSpend.Value, Optional.ToDictionary(notifications), forecastSpend.Value, Optional.ToNullable(eTag), rawData);
        }

        ConsumptionBudgetData IModelJsonSerializable<ConsumptionBudgetData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionBudgetData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionBudgetData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConsumptionBudgetData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionBudgetData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConsumptionBudgetData IModelSerializable<ConsumptionBudgetData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionBudgetData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConsumptionBudgetData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConsumptionBudgetData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConsumptionBudgetData"/> to convert. </param>
        public static implicit operator RequestContent(ConsumptionBudgetData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConsumptionBudgetData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConsumptionBudgetData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConsumptionBudgetData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
