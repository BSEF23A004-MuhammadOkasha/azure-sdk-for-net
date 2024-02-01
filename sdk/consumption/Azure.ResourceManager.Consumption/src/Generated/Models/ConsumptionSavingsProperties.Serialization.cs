// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionSavingsProperties : IUtf8JsonSerializable, IJsonModel<ConsumptionSavingsProperties>, IPersistableModel<ConsumptionSavingsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionSavingsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionSavingsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionSavingsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionSavingsProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CalculatedSavings))
            {
                writer.WritePropertyName("calculatedSavings"u8);
                writer.WriteStartArray();
                foreach (var item in CalculatedSavings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LookBackPeriod))
            {
                writer.WritePropertyName("lookBackPeriod"u8);
                writer.WriteNumberValue(LookBackPeriod.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RecommendedQuantity))
            {
                writer.WritePropertyName("recommendedQuantity"u8);
                writer.WriteNumberValue(RecommendedQuantity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReservationOrderTerm))
            {
                writer.WritePropertyName("reservationOrderTerm"u8);
                writer.WriteStringValue(ReservationOrderTerm);
            }
            if (options.Format != "W" && Optional.IsDefined(SavingsType))
            {
                writer.WritePropertyName("savingsType"u8);
                writer.WriteStringValue(SavingsType);
            }
            if (options.Format != "W" && Optional.IsDefined(UnitOfMeasure))
            {
                writer.WritePropertyName("unitOfMeasure"u8);
                writer.WriteStringValue(UnitOfMeasure);
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

        ConsumptionSavingsProperties IJsonModel<ConsumptionSavingsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionSavingsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionSavingsProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionSavingsProperties(document.RootElement, options);
        }

        internal static ConsumptionSavingsProperties DeserializeConsumptionSavingsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ConsumptionCalculatedSavingsProperties>> calculatedSavings = default;
            Optional<int> lookBackPeriod = default;
            Optional<float> recommendedQuantity = default;
            Optional<string> reservationOrderTerm = default;
            Optional<string> savingsType = default;
            Optional<string> unitOfMeasure = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("calculatedSavings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConsumptionCalculatedSavingsProperties> array = new List<ConsumptionCalculatedSavingsProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConsumptionCalculatedSavingsProperties.DeserializeConsumptionCalculatedSavingsProperties(item));
                    }
                    calculatedSavings = array;
                    continue;
                }
                if (property.NameEquals("lookBackPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lookBackPeriod = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recommendedQuantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendedQuantity = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("reservationOrderTerm"u8))
                {
                    reservationOrderTerm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("savingsType"u8))
                {
                    savingsType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unitOfMeasure"u8))
                {
                    unitOfMeasure = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConsumptionSavingsProperties(Optional.ToList(calculatedSavings), Optional.ToNullable(lookBackPeriod), Optional.ToNullable(recommendedQuantity), reservationOrderTerm.Value, savingsType.Value, unitOfMeasure.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(CalculatedSavings))
            {
                builder.Append("  calculatedSavings:");
                builder.AppendLine(" [");
                foreach (var item in CalculatedSavings)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(LookBackPeriod))
            {
                builder.Append("  lookBackPeriod:");
                builder.AppendLine($" '{LookBackPeriod.Value.ToString()}'");
            }

            if (Optional.IsDefined(RecommendedQuantity))
            {
                builder.Append("  recommendedQuantity:");
                builder.AppendLine($" '{RecommendedQuantity.Value.ToString()}'");
            }

            if (Optional.IsDefined(ReservationOrderTerm))
            {
                builder.Append("  reservationOrderTerm:");
                builder.AppendLine($" '{ReservationOrderTerm}'");
            }

            if (Optional.IsDefined(SavingsType))
            {
                builder.Append("  savingsType:");
                builder.AppendLine($" '{SavingsType}'");
            }

            if (Optional.IsDefined(UnitOfMeasure))
            {
                builder.Append("  unitOfMeasure:");
                builder.AppendLine($" '{UnitOfMeasure}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<ConsumptionSavingsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionSavingsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionSavingsProperties)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionSavingsProperties IPersistableModel<ConsumptionSavingsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionSavingsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionSavingsProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ConsumptionSavingsProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionSavingsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
