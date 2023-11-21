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

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class BenefitUtilizationSummariesContent : IUtf8JsonSerializable, IJsonModel<BenefitUtilizationSummariesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BenefitUtilizationSummariesContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BenefitUtilizationSummariesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitUtilizationSummariesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BenefitUtilizationSummariesContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BillingAccountId))
            {
                writer.WritePropertyName("billingAccountId"u8);
                writer.WriteStringValue(BillingAccountId);
            }
            if (Optional.IsDefined(BillingProfileId))
            {
                writer.WritePropertyName("billingProfileId"u8);
                writer.WriteStringValue(BillingProfileId);
            }
            if (Optional.IsDefined(BenefitOrderId))
            {
                writer.WritePropertyName("benefitOrderId"u8);
                writer.WriteStringValue(BenefitOrderId);
            }
            if (Optional.IsDefined(BenefitId))
            {
                writer.WritePropertyName("benefitId"u8);
                writer.WriteStringValue(BenefitId);
            }
            writer.WritePropertyName("grain"u8);
            writer.WriteStringValue(Grain.ToString());
            writer.WritePropertyName("startDate"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("endDate"u8);
            writer.WriteStringValue(EndOn, "O");
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
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

        BenefitUtilizationSummariesContent IJsonModel<BenefitUtilizationSummariesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitUtilizationSummariesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BenefitUtilizationSummariesContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBenefitUtilizationSummariesContent(document.RootElement, options);
        }

        internal static BenefitUtilizationSummariesContent DeserializeBenefitUtilizationSummariesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> billingAccountId = default;
            Optional<string> billingProfileId = default;
            Optional<string> benefitOrderId = default;
            Optional<string> benefitId = default;
            BenefitRecommendationUsageGrain grain = default;
            DateTimeOffset startDate = default;
            DateTimeOffset endDate = default;
            Optional<BillingAccountBenefitKind> kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingAccountId"u8))
                {
                    billingAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingProfileId"u8))
                {
                    billingProfileId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("benefitOrderId"u8))
                {
                    benefitOrderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("benefitId"u8))
                {
                    benefitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("grain"u8))
                {
                    grain = new BenefitRecommendationUsageGrain(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDate"u8))
                {
                    endDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new BillingAccountBenefitKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BenefitUtilizationSummariesContent(billingAccountId.Value, billingProfileId.Value, benefitOrderId.Value, benefitId.Value, grain, startDate, endDate, Optional.ToNullable(kind), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BenefitUtilizationSummariesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitUtilizationSummariesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BenefitUtilizationSummariesContent)} does not support '{options.Format}' format.");
            }
        }

        BenefitUtilizationSummariesContent IPersistableModel<BenefitUtilizationSummariesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitUtilizationSummariesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBenefitUtilizationSummariesContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BenefitUtilizationSummariesContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BenefitUtilizationSummariesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
