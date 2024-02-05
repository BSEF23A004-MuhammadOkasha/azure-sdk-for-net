// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionReservationDetail : IUtf8JsonSerializable, IJsonModel<ConsumptionReservationDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionReservationDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionReservationDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionReservationDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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
            if (options.Format != "W" && Optional.IsDefined(ReservationOrderId))
            {
                writer.WritePropertyName("reservationOrderId"u8);
                writer.WriteStringValue(ReservationOrderId);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceFlexibilityRatio))
            {
                writer.WritePropertyName("instanceFlexibilityRatio"u8);
                writer.WriteStringValue(InstanceFlexibilityRatio);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceFlexibilityGroup))
            {
                writer.WritePropertyName("instanceFlexibilityGroup"u8);
                writer.WriteStringValue(InstanceFlexibilityGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(ReservationId))
            {
                writer.WritePropertyName("reservationId"u8);
                writer.WriteStringValue(ReservationId);
            }
            if (options.Format != "W" && Optional.IsDefined(SkuName))
            {
                writer.WritePropertyName("skuName"u8);
                writer.WriteStringValue(SkuName);
            }
            if (options.Format != "W" && Optional.IsDefined(ReservedHours))
            {
                writer.WritePropertyName("reservedHours"u8);
                writer.WriteNumberValue(ReservedHours.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConsumptionOccurredOn))
            {
                writer.WritePropertyName("usageDate"u8);
                writer.WriteStringValue(ConsumptionOccurredOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UsedHours))
            {
                writer.WritePropertyName("usedHours"u8);
                writer.WriteNumberValue(UsedHours.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceId))
            {
                writer.WritePropertyName("instanceId"u8);
                writer.WriteStringValue(InstanceId);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalReservedQuantity))
            {
                writer.WritePropertyName("totalReservedQuantity"u8);
                writer.WriteNumberValue(TotalReservedQuantity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
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

        ConsumptionReservationDetail IJsonModel<ConsumptionReservationDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionReservationDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionReservationDetail(document.RootElement, options);
        }

        internal static ConsumptionReservationDetail DeserializeConsumptionReservationDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

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
            Optional<string> instanceFlexibilityRatio = default;
            Optional<string> instanceFlexibilityGroup = default;
            Optional<string> reservationId = default;
            Optional<string> skuName = default;
            Optional<decimal> reservedHours = default;
            Optional<DateTimeOffset> usageDate = default;
            Optional<decimal> usedHours = default;
            Optional<ResourceIdentifier> instanceId = default;
            Optional<decimal> totalReservedQuantity = default;
            Optional<string> kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("instanceFlexibilityRatio"u8))
                        {
                            instanceFlexibilityRatio = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceFlexibilityGroup"u8))
                        {
                            instanceFlexibilityGroup = property0.Value.GetString();
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
                        if (property0.NameEquals("instanceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceId = new ResourceIdentifier(property0.Value.GetString());
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
                        if (property0.NameEquals("kind"u8))
                        {
                            kind = property0.Value.GetString();
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
            return new ConsumptionReservationDetail(id, name, type, systemData.Value, reservationOrderId.Value, instanceFlexibilityRatio.Value, instanceFlexibilityGroup.Value, reservationId.Value, skuName.Value, Optional.ToNullable(reservedHours), Optional.ToNullable(usageDate), Optional.ToNullable(usedHours), instanceId.Value, Optional.ToNullable(totalReservedQuantity), kind.Value, Optional.ToNullable(etag), Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ETag))
            {
                builder.Append("  etag:");
                builder.AppendLine($" '{ETag.Value.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value}'");
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(ReservationOrderId))
            {
                builder.Append("    reservationOrderId:");
                builder.AppendLine($" '{ReservationOrderId}'");
            }

            if (Optional.IsDefined(InstanceFlexibilityRatio))
            {
                builder.Append("    instanceFlexibilityRatio:");
                builder.AppendLine($" '{InstanceFlexibilityRatio}'");
            }

            if (Optional.IsDefined(InstanceFlexibilityGroup))
            {
                builder.Append("    instanceFlexibilityGroup:");
                builder.AppendLine($" '{InstanceFlexibilityGroup}'");
            }

            if (Optional.IsDefined(ReservationId))
            {
                builder.Append("    reservationId:");
                builder.AppendLine($" '{ReservationId}'");
            }

            if (Optional.IsDefined(SkuName))
            {
                builder.Append("    skuName:");
                builder.AppendLine($" '{SkuName}'");
            }

            if (Optional.IsDefined(ReservedHours))
            {
                builder.Append("    reservedHours:");
                builder.AppendLine($" '{ReservedHours.Value.ToString()}'");
            }

            if (Optional.IsDefined(ConsumptionOccurredOn))
            {
                builder.Append("    usageDate:");
                var formattedDateTimeString = TypeFormatters.ToString(ConsumptionOccurredOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(UsedHours))
            {
                builder.Append("    usedHours:");
                builder.AppendLine($" '{UsedHours.Value.ToString()}'");
            }

            if (Optional.IsDefined(InstanceId))
            {
                builder.Append("    instanceId:");
                builder.AppendLine($" '{InstanceId.ToString()}'");
            }

            if (Optional.IsDefined(TotalReservedQuantity))
            {
                builder.Append("    totalReservedQuantity:");
                builder.AppendLine($" '{TotalReservedQuantity.Value.ToString()}'");
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("    kind:");
                builder.AppendLine($" '{Kind}'");
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ConsumptionReservationDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionReservationDetail)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionReservationDetail IPersistableModel<ConsumptionReservationDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionReservationDetail(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ConsumptionReservationDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionReservationDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
