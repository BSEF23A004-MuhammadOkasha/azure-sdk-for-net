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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionReservationSummary : IUtf8JsonSerializable, IModelJsonSerializable<ConsumptionReservationSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConsumptionReservationSummary>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConsumptionReservationSummary>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionReservationSummary>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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

        internal static ConsumptionReservationSummary DeserializeConsumptionReservationSummary(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> reservationOrderId = default;
            Optional<string> reservationId = default;
            Optional<string> skuName = default;
            Optional<decimal> reservedHours = default;
            Optional<DateTimeOffset> usageDate = default;
            Optional<decimal> usedHours = default;
            Optional<decimal> minUtilizationPercentage = default;
            Optional<decimal> avgUtilizationPercentage = default;
            Optional<decimal> maxUtilizationPercentage = default;
            Optional<string> kind = default;
            Optional<decimal> purchasedQuantity = default;
            Optional<decimal> remainingQuantity = default;
            Optional<decimal> totalReservedQuantity = default;
            Optional<decimal> usedQuantity = default;
            Optional<decimal> utilizedPercentage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
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
                        if (property0.NameEquals("reservationOrderId"u8))
                        {
                            reservationOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationId"u8))
                        {
                            reservationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("skuName"u8))
                        {
                            skuName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservedHours"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reservedHours = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("usageDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usageDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("usedHours"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usedHours = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("minUtilizationPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minUtilizationPercentage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("avgUtilizationPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            avgUtilizationPercentage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("maxUtilizationPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxUtilizationPercentage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("kind"u8))
                        {
                            kind = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasedQuantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchasedQuantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("remainingQuantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remainingQuantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("totalReservedQuantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalReservedQuantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("usedQuantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usedQuantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("utilizedPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            utilizedPercentage = property0.Value.GetDecimal();
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
            return new ConsumptionReservationSummary(id, name, type, systemData.Value, reservationOrderId.Value, reservationId.Value, skuName.Value, Optional.ToNullable(reservedHours), Optional.ToNullable(usageDate), Optional.ToNullable(usedHours), Optional.ToNullable(minUtilizationPercentage), Optional.ToNullable(avgUtilizationPercentage), Optional.ToNullable(maxUtilizationPercentage), kind.Value, Optional.ToNullable(purchasedQuantity), Optional.ToNullable(remainingQuantity), Optional.ToNullable(totalReservedQuantity), Optional.ToNullable(usedQuantity), Optional.ToNullable(utilizedPercentage), Optional.ToNullable(etag), Optional.ToDictionary(tags), rawData);
        }

        ConsumptionReservationSummary IModelJsonSerializable<ConsumptionReservationSummary>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionReservationSummary>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionReservationSummary(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConsumptionReservationSummary>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionReservationSummary>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConsumptionReservationSummary IModelSerializable<ConsumptionReservationSummary>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionReservationSummary>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConsumptionReservationSummary(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConsumptionReservationSummary"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConsumptionReservationSummary"/> to convert. </param>
        public static implicit operator RequestContent(ConsumptionReservationSummary model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConsumptionReservationSummary"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConsumptionReservationSummary(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConsumptionReservationSummary(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
