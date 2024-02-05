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

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class SharedScopeBenefitRecommendationProperties : IUtf8JsonSerializable, IJsonModel<SharedScopeBenefitRecommendationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SharedScopeBenefitRecommendationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SharedScopeBenefitRecommendationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedScopeBenefitRecommendationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedScopeBenefitRecommendationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(FirstConsumptionOn))
            {
                writer.WritePropertyName("firstConsumptionDate"u8);
                writer.WriteStringValue(FirstConsumptionOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastConsumptionOn))
            {
                writer.WritePropertyName("lastConsumptionDate"u8);
                writer.WriteStringValue(LastConsumptionOn.Value, "O");
            }
            if (Optional.IsDefined(LookBackPeriod))
            {
                writer.WritePropertyName("lookBackPeriod"u8);
                writer.WriteStringValue(LookBackPeriod.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TotalHours))
            {
                writer.WritePropertyName("totalHours"u8);
                writer.WriteNumberValue(TotalHours.Value);
            }
            if (Optional.IsDefined(Usage))
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage);
            }
            if (options.Format != "W" && Optional.IsDefined(ArmSkuName))
            {
                writer.WritePropertyName("armSkuName"u8);
                writer.WriteStringValue(ArmSkuName);
            }
            if (Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (Optional.IsDefined(CommitmentGranularity))
            {
                writer.WritePropertyName("commitmentGranularity"u8);
                writer.WriteStringValue(CommitmentGranularity.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CurrencyCode))
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(CurrencyCode);
            }
            if (options.Format != "W" && Optional.IsDefined(CostWithoutBenefit))
            {
                writer.WritePropertyName("costWithoutBenefit"u8);
                writer.WriteNumberValue(CostWithoutBenefit.Value);
            }
            if (Optional.IsDefined(RecommendationDetails))
            {
                writer.WritePropertyName("recommendationDetails"u8);
                writer.WriteObjectValue(RecommendationDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(AllRecommendationDetails))
            {
                writer.WritePropertyName("allRecommendationDetails"u8);
                writer.WriteObjectValue(AllRecommendationDetails);
            }
            writer.WritePropertyName("scope"u8);
            writer.WriteStringValue(Scope.ToString());
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

        SharedScopeBenefitRecommendationProperties IJsonModel<SharedScopeBenefitRecommendationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedScopeBenefitRecommendationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedScopeBenefitRecommendationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedScopeBenefitRecommendationProperties(document.RootElement, options);
        }

        internal static SharedScopeBenefitRecommendationProperties DeserializeSharedScopeBenefitRecommendationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> firstConsumptionDate = default;
            Optional<DateTimeOffset> lastConsumptionDate = default;
            Optional<LookBackPeriod> lookBackPeriod = default;
            Optional<int> totalHours = default;
            Optional<RecommendationUsageDetails> usage = default;
            Optional<string> armSkuName = default;
            Optional<BenefitRecommendationPeriodTerm> term = default;
            Optional<BenefitRecommendationUsageGrain> commitmentGranularity = default;
            Optional<string> currencyCode = default;
            Optional<decimal> costWithoutBenefit = default;
            Optional<AllSavingsBenefitDetails> recommendationDetails = default;
            Optional<AllSavingsList> allRecommendationDetails = default;
            BenefitRecommendationScope scope = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstConsumptionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstConsumptionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastConsumptionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConsumptionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lookBackPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lookBackPeriod = new LookBackPeriod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = RecommendationUsageDetails.DeserializeRecommendationUsageDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("armSkuName"u8))
                {
                    armSkuName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("term"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    term = new BenefitRecommendationPeriodTerm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commitmentGranularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitmentGranularity = new BenefitRecommendationUsageGrain(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("costWithoutBenefit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    costWithoutBenefit = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("recommendationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendationDetails = AllSavingsBenefitDetails.DeserializeAllSavingsBenefitDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("allRecommendationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allRecommendationDetails = AllSavingsList.DeserializeAllSavingsList(property.Value);
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = new BenefitRecommendationScope(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SharedScopeBenefitRecommendationProperties(Optional.ToNullable(firstConsumptionDate), Optional.ToNullable(lastConsumptionDate), Optional.ToNullable(lookBackPeriod), Optional.ToNullable(totalHours), usage.Value, armSkuName.Value, Optional.ToNullable(term), Optional.ToNullable(commitmentGranularity), currencyCode.Value, Optional.ToNullable(costWithoutBenefit), recommendationDetails.Value, allRecommendationDetails.Value, scope, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(FirstConsumptionOn))
            {
                builder.Append("  firstConsumptionDate:");
                var formattedDateTimeString = TypeFormatters.ToString(FirstConsumptionOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LastConsumptionOn))
            {
                builder.Append("  lastConsumptionDate:");
                var formattedDateTimeString = TypeFormatters.ToString(LastConsumptionOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(LookBackPeriod))
            {
                builder.Append("  lookBackPeriod:");
                builder.AppendLine($" '{LookBackPeriod.ToString()}'");
            }

            if (Optional.IsDefined(TotalHours))
            {
                builder.Append("  totalHours:");
                builder.AppendLine($" {TotalHours.Value}");
            }

            if (Optional.IsDefined(Usage))
            {
                builder.Append("  usage:");
                AppendChildObject(builder, Usage, options, 2, false);
            }

            if (Optional.IsDefined(ArmSkuName))
            {
                builder.Append("  armSkuName:");
                builder.AppendLine($" '{ArmSkuName}'");
            }

            if (Optional.IsDefined(Term))
            {
                builder.Append("  term:");
                builder.AppendLine($" '{Term.ToString()}'");
            }

            if (Optional.IsDefined(CommitmentGranularity))
            {
                builder.Append("  commitmentGranularity:");
                builder.AppendLine($" '{CommitmentGranularity.ToString()}'");
            }

            if (Optional.IsDefined(CurrencyCode))
            {
                builder.Append("  currencyCode:");
                builder.AppendLine($" '{CurrencyCode}'");
            }

            if (Optional.IsDefined(CostWithoutBenefit))
            {
                builder.Append("  costWithoutBenefit:");
                builder.AppendLine($" '{CostWithoutBenefit.Value.ToString()}'");
            }

            if (Optional.IsDefined(RecommendationDetails))
            {
                builder.Append("  recommendationDetails:");
                AppendChildObject(builder, RecommendationDetails, options, 2, false);
            }

            if (Optional.IsDefined(AllRecommendationDetails))
            {
                builder.Append("  allRecommendationDetails:");
                AppendChildObject(builder, AllRecommendationDetails, options, 2, false);
            }

            if (Optional.IsDefined(Scope))
            {
                builder.Append("  scope:");
                builder.AppendLine($" '{Scope.ToString()}'");
            }

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

        BinaryData IPersistableModel<SharedScopeBenefitRecommendationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedScopeBenefitRecommendationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SharedScopeBenefitRecommendationProperties)} does not support '{options.Format}' format.");
            }
        }

        SharedScopeBenefitRecommendationProperties IPersistableModel<SharedScopeBenefitRecommendationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedScopeBenefitRecommendationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSharedScopeBenefitRecommendationProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SharedScopeBenefitRecommendationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SharedScopeBenefitRecommendationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
