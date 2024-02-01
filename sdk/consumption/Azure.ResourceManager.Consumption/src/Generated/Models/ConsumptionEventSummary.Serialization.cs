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
    public partial class ConsumptionEventSummary : IUtf8JsonSerializable, IJsonModel<ConsumptionEventSummary>, IPersistableModel<ConsumptionEventSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionEventSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionEventSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionEventSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionEventSummary)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(TransactOn))
            {
                writer.WritePropertyName("transactionDate"u8);
                writer.WriteStringValue(TransactOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(NewCredit))
            {
                writer.WritePropertyName("newCredit"u8);
                writer.WriteObjectValue(NewCredit);
            }
            if (options.Format != "W" && Optional.IsDefined(Adjustments))
            {
                writer.WritePropertyName("adjustments"u8);
                writer.WriteObjectValue(Adjustments);
            }
            if (options.Format != "W" && Optional.IsDefined(CreditExpired))
            {
                writer.WritePropertyName("creditExpired"u8);
                writer.WriteObjectValue(CreditExpired);
            }
            if (options.Format != "W" && Optional.IsDefined(Charges))
            {
                writer.WritePropertyName("charges"u8);
                writer.WriteObjectValue(Charges);
            }
            if (options.Format != "W" && Optional.IsDefined(ClosedBalance))
            {
                writer.WritePropertyName("closedBalance"u8);
                writer.WriteObjectValue(ClosedBalance);
            }
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteStringValue(EventType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(InvoiceNumber))
            {
                writer.WritePropertyName("invoiceNumber"u8);
                writer.WriteStringValue(InvoiceNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileId))
            {
                writer.WritePropertyName("billingProfileId"u8);
                writer.WriteStringValue(BillingProfileId);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileDisplayName))
            {
                writer.WritePropertyName("billingProfileDisplayName"u8);
                writer.WriteStringValue(BillingProfileDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(LotId))
            {
                writer.WritePropertyName("lotId"u8);
                writer.WriteStringValue(LotId);
            }
            if (options.Format != "W" && Optional.IsDefined(LotSource))
            {
                writer.WritePropertyName("lotSource"u8);
                writer.WriteStringValue(LotSource);
            }
            if (options.Format != "W" && Optional.IsDefined(CanceledCredit))
            {
                writer.WritePropertyName("canceledCredit"u8);
                writer.WriteObjectValue(CanceledCredit);
            }
            if (options.Format != "W" && Optional.IsDefined(CreditCurrency))
            {
                writer.WritePropertyName("creditCurrency"u8);
                writer.WriteStringValue(CreditCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingCurrency))
            {
                writer.WritePropertyName("billingCurrency"u8);
                writer.WriteStringValue(BillingCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(Reseller))
            {
                writer.WritePropertyName("reseller"u8);
                writer.WriteObjectValue(Reseller);
            }
            if (options.Format != "W" && Optional.IsDefined(CreditExpiredInBillingCurrency))
            {
                writer.WritePropertyName("creditExpiredInBillingCurrency"u8);
                writer.WriteObjectValue(CreditExpiredInBillingCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(NewCreditInBillingCurrency))
            {
                writer.WritePropertyName("newCreditInBillingCurrency"u8);
                writer.WriteObjectValue(NewCreditInBillingCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(AdjustmentsInBillingCurrency))
            {
                writer.WritePropertyName("adjustmentsInBillingCurrency"u8);
                writer.WriteObjectValue(AdjustmentsInBillingCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(ChargesInBillingCurrency))
            {
                writer.WritePropertyName("chargesInBillingCurrency"u8);
                writer.WriteObjectValue(ChargesInBillingCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(ClosedBalanceInBillingCurrency))
            {
                writer.WritePropertyName("closedBalanceInBillingCurrency"u8);
                writer.WriteObjectValue(ClosedBalanceInBillingCurrency);
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

        ConsumptionEventSummary IJsonModel<ConsumptionEventSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionEventSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionEventSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionEventSummary(document.RootElement, options);
        }

        internal static ConsumptionEventSummary DeserializeConsumptionEventSummary(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<DateTimeOffset> transactionDate = default;
            Optional<string> description = default;
            Optional<ConsumptionAmount> newCredit = default;
            Optional<ConsumptionAmount> adjustments = default;
            Optional<ConsumptionAmount> creditExpired = default;
            Optional<ConsumptionAmount> charges = default;
            Optional<ConsumptionAmount> closedBalance = default;
            Optional<ConsumptionEventType> eventType = default;
            Optional<string> invoiceNumber = default;
            Optional<ResourceIdentifier> billingProfileId = default;
            Optional<string> billingProfileDisplayName = default;
            Optional<ResourceIdentifier> lotId = default;
            Optional<string> lotSource = default;
            Optional<ConsumptionAmount> canceledCredit = default;
            Optional<string> creditCurrency = default;
            Optional<string> billingCurrency = default;
            Optional<ConsumptionReseller> reseller = default;
            Optional<ConsumptionAmountWithExchangeRate> creditExpiredInBillingCurrency = default;
            Optional<ConsumptionAmountWithExchangeRate> newCreditInBillingCurrency = default;
            Optional<ConsumptionAmountWithExchangeRate> adjustmentsInBillingCurrency = default;
            Optional<ConsumptionAmountWithExchangeRate> chargesInBillingCurrency = default;
            Optional<ConsumptionAmountWithExchangeRate> closedBalanceInBillingCurrency = default;
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
                        if (property0.NameEquals("transactionDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            transactionDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("newCredit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newCredit = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("adjustments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adjustments = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creditExpired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creditExpired = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("charges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            charges = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("closedBalance"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            closedBalance = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("eventType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventType = new ConsumptionEventType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("invoiceNumber"u8))
                        {
                            invoiceNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingProfileId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingProfileDisplayName"u8))
                        {
                            billingProfileDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lotId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lotId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lotSource"u8))
                        {
                            lotSource = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("canceledCredit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            canceledCredit = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creditCurrency"u8))
                        {
                            creditCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingCurrency"u8))
                        {
                            billingCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reseller"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reseller = ConsumptionReseller.DeserializeConsumptionReseller(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creditExpiredInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creditExpiredInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("newCreditInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newCreditInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("adjustmentsInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adjustmentsInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("chargesInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            chargesInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("closedBalanceInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            closedBalanceInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
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
            return new ConsumptionEventSummary(id, name, type, systemData.Value, Optional.ToNullable(transactionDate), description.Value, newCredit.Value, adjustments.Value, creditExpired.Value, charges.Value, closedBalance.Value, Optional.ToNullable(eventType), invoiceNumber.Value, billingProfileId.Value, billingProfileDisplayName.Value, lotId.Value, lotSource.Value, canceledCredit.Value, creditCurrency.Value, billingCurrency.Value, reseller.Value, creditExpiredInBillingCurrency.Value, newCreditInBillingCurrency.Value, adjustmentsInBillingCurrency.Value, chargesInBillingCurrency.Value, closedBalanceInBillingCurrency.Value, Optional.ToNullable(eTag), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(TransactOn))
            {
                builder.Append("  transactionDate:");
                builder.AppendLine($" '{TransactOn.Value.ToString()}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("  description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(NewCredit))
            {
                builder.Append("  newCredit:");
                AppendChildObject(builder, NewCredit, options, 2);
            }

            if (Optional.IsDefined(Adjustments))
            {
                builder.Append("  adjustments:");
                AppendChildObject(builder, Adjustments, options, 2);
            }

            if (Optional.IsDefined(CreditExpired))
            {
                builder.Append("  creditExpired:");
                AppendChildObject(builder, CreditExpired, options, 2);
            }

            if (Optional.IsDefined(Charges))
            {
                builder.Append("  charges:");
                AppendChildObject(builder, Charges, options, 2);
            }

            if (Optional.IsDefined(ClosedBalance))
            {
                builder.Append("  closedBalance:");
                AppendChildObject(builder, ClosedBalance, options, 2);
            }

            if (Optional.IsDefined(EventType))
            {
                builder.Append("  eventType:");
                builder.AppendLine($" '{EventType.ToString()}'");
            }

            if (Optional.IsDefined(InvoiceNumber))
            {
                builder.Append("  invoiceNumber:");
                builder.AppendLine($" '{InvoiceNumber}'");
            }

            if (Optional.IsDefined(BillingProfileId))
            {
                builder.Append("  billingProfileId:");
                builder.AppendLine($" '{BillingProfileId.ToString()}'");
            }

            if (Optional.IsDefined(BillingProfileDisplayName))
            {
                builder.Append("  billingProfileDisplayName:");
                builder.AppendLine($" '{BillingProfileDisplayName}'");
            }

            if (Optional.IsDefined(LotId))
            {
                builder.Append("  lotId:");
                builder.AppendLine($" '{LotId.ToString()}'");
            }

            if (Optional.IsDefined(LotSource))
            {
                builder.Append("  lotSource:");
                builder.AppendLine($" '{LotSource}'");
            }

            if (Optional.IsDefined(CanceledCredit))
            {
                builder.Append("  canceledCredit:");
                AppendChildObject(builder, CanceledCredit, options, 2);
            }

            if (Optional.IsDefined(CreditCurrency))
            {
                builder.Append("  creditCurrency:");
                builder.AppendLine($" '{CreditCurrency}'");
            }

            if (Optional.IsDefined(BillingCurrency))
            {
                builder.Append("  billingCurrency:");
                builder.AppendLine($" '{BillingCurrency}'");
            }

            if (Optional.IsDefined(Reseller))
            {
                builder.Append("  reseller:");
                AppendChildObject(builder, Reseller, options, 2);
            }

            if (Optional.IsDefined(CreditExpiredInBillingCurrency))
            {
                builder.Append("  creditExpiredInBillingCurrency:");
                AppendChildObject(builder, CreditExpiredInBillingCurrency, options, 2);
            }

            if (Optional.IsDefined(NewCreditInBillingCurrency))
            {
                builder.Append("  newCreditInBillingCurrency:");
                AppendChildObject(builder, NewCreditInBillingCurrency, options, 2);
            }

            if (Optional.IsDefined(AdjustmentsInBillingCurrency))
            {
                builder.Append("  adjustmentsInBillingCurrency:");
                AppendChildObject(builder, AdjustmentsInBillingCurrency, options, 2);
            }

            if (Optional.IsDefined(ChargesInBillingCurrency))
            {
                builder.Append("  chargesInBillingCurrency:");
                AppendChildObject(builder, ChargesInBillingCurrency, options, 2);
            }

            if (Optional.IsDefined(ClosedBalanceInBillingCurrency))
            {
                builder.Append("  closedBalanceInBillingCurrency:");
                AppendChildObject(builder, ClosedBalanceInBillingCurrency, options, 2);
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

        BinaryData IPersistableModel<ConsumptionEventSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionEventSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionEventSummary)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionEventSummary IPersistableModel<ConsumptionEventSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionEventSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionEventSummary(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ConsumptionEventSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionEventSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
