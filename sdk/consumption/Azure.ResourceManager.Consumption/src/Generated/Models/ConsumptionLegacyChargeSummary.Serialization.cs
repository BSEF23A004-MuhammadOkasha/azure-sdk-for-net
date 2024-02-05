// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionLegacyChargeSummary : IUtf8JsonSerializable, IJsonModel<ConsumptionLegacyChargeSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionLegacyChargeSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionLegacyChargeSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLegacyChargeSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionLegacyChargeSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            if (options.Format != "W" && Optional.IsDefined(BillingPeriodId))
            {
                writer.WritePropertyName("billingPeriodId"u8);
                writer.WriteStringValue(BillingPeriodId);
            }
            if (options.Format != "W" && Optional.IsDefined(UsageStart))
            {
                writer.WritePropertyName("usageStart"u8);
                writer.WriteStringValue(UsageStart);
            }
            if (options.Format != "W" && Optional.IsDefined(UsageEnd))
            {
                writer.WritePropertyName("usageEnd"u8);
                writer.WriteStringValue(UsageEnd);
            }
            if (options.Format != "W" && Optional.IsDefined(AzureCharges))
            {
                writer.WritePropertyName("azureCharges"u8);
                writer.WriteNumberValue(AzureCharges.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ChargesBilledSeparately))
            {
                writer.WritePropertyName("chargesBilledSeparately"u8);
                writer.WriteNumberValue(ChargesBilledSeparately.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MarketplaceCharges))
            {
                writer.WritePropertyName("marketplaceCharges"u8);
                writer.WriteNumberValue(MarketplaceCharges.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Currency))
            {
                writer.WritePropertyName("currency"u8);
                writer.WriteStringValue(Currency);
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

        ConsumptionLegacyChargeSummary IJsonModel<ConsumptionLegacyChargeSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLegacyChargeSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionLegacyChargeSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionLegacyChargeSummary(document.RootElement, options);
        }

        internal static ConsumptionLegacyChargeSummary DeserializeConsumptionLegacyChargeSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ChargeSummaryKind kind = default;
            Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> billingPeriodId = default;
            Optional<string> usageStart = default;
            Optional<string> usageEnd = default;
            Optional<decimal> azureCharges = default;
            Optional<decimal> chargesBilledSeparately = default;
            Optional<decimal> marketplaceCharges = default;
            Optional<string> currency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new ChargeSummaryKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("billingPeriodId"u8))
                        {
                            billingPeriodId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usageStart"u8))
                        {
                            usageStart = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usageEnd"u8))
                        {
                            usageEnd = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureCharges = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("chargesBilledSeparately"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            chargesBilledSeparately = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("marketplaceCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketplaceCharges = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("currency"u8))
                        {
                            currency = property0.Value.GetString();
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
            return new ConsumptionLegacyChargeSummary(id, name, type, systemData.Value, kind, Optional.ToNullable(eTag), serializedAdditionalRawData, billingPeriodId.Value, usageStart.Value, usageEnd.Value, Optional.ToNullable(azureCharges), Optional.ToNullable(chargesBilledSeparately), Optional.ToNullable(marketplaceCharges), currency.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind.ToString()}'");
            }

            if (Optional.IsDefined(ETag))
            {
                builder.Append("  eTag:");
                builder.AppendLine($" '{ETag.Value.ToString()}'");
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
            if (Optional.IsDefined(BillingPeriodId))
            {
                builder.Append("    billingPeriodId:");
                builder.AppendLine($" '{BillingPeriodId}'");
            }

            if (Optional.IsDefined(UsageStart))
            {
                builder.Append("    usageStart:");
                builder.AppendLine($" '{UsageStart}'");
            }

            if (Optional.IsDefined(UsageEnd))
            {
                builder.Append("    usageEnd:");
                builder.AppendLine($" '{UsageEnd}'");
            }

            if (Optional.IsDefined(AzureCharges))
            {
                builder.Append("    azureCharges:");
                builder.AppendLine($" '{AzureCharges.Value.ToString()}'");
            }

            if (Optional.IsDefined(ChargesBilledSeparately))
            {
                builder.Append("    chargesBilledSeparately:");
                builder.AppendLine($" '{ChargesBilledSeparately.Value.ToString()}'");
            }

            if (Optional.IsDefined(MarketplaceCharges))
            {
                builder.Append("    marketplaceCharges:");
                builder.AppendLine($" '{MarketplaceCharges.Value.ToString()}'");
            }

            if (Optional.IsDefined(Currency))
            {
                builder.Append("    currency:");
                builder.AppendLine($" '{Currency}'");
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

        BinaryData IPersistableModel<ConsumptionLegacyChargeSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLegacyChargeSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionLegacyChargeSummary)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionLegacyChargeSummary IPersistableModel<ConsumptionLegacyChargeSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLegacyChargeSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionLegacyChargeSummary(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ConsumptionLegacyChargeSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionLegacyChargeSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
