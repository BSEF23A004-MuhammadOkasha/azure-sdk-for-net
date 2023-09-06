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

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class SingleScopeBenefitRecommendationProperties : IUtf8JsonSerializable, IModelJsonSerializable<SingleScopeBenefitRecommendationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SingleScopeBenefitRecommendationProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SingleScopeBenefitRecommendationProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SingleScopeBenefitRecommendationProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LookBackPeriod))
            {
                writer.WritePropertyName("lookBackPeriod"u8);
                writer.WriteStringValue(LookBackPeriod.Value.ToString());
            }
            if (Optional.IsDefined(Usage))
            {
                writer.WritePropertyName("usage"u8);
                if (Usage is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RecommendationUsageDetails>)Usage).Serialize(writer, options);
                }
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
            if (Optional.IsDefined(RecommendationDetails))
            {
                writer.WritePropertyName("recommendationDetails"u8);
                if (RecommendationDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AllSavingsBenefitDetails>)RecommendationDetails).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("scope"u8);
            writer.WriteStringValue(Scope.ToString());
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

        internal static SingleScopeBenefitRecommendationProperties DeserializeSingleScopeBenefitRecommendationProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
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
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SingleScopeBenefitRecommendationProperties(Optional.ToNullable(firstConsumptionDate), Optional.ToNullable(lastConsumptionDate), Optional.ToNullable(lookBackPeriod), Optional.ToNullable(totalHours), usage.Value, armSkuName.Value, Optional.ToNullable(term), Optional.ToNullable(commitmentGranularity), currencyCode.Value, Optional.ToNullable(costWithoutBenefit), recommendationDetails.Value, allRecommendationDetails.Value, scope, subscriptionId.Value, resourceGroup.Value, rawData);
        }

        SingleScopeBenefitRecommendationProperties IModelJsonSerializable<SingleScopeBenefitRecommendationProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SingleScopeBenefitRecommendationProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSingleScopeBenefitRecommendationProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SingleScopeBenefitRecommendationProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SingleScopeBenefitRecommendationProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SingleScopeBenefitRecommendationProperties IModelSerializable<SingleScopeBenefitRecommendationProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SingleScopeBenefitRecommendationProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSingleScopeBenefitRecommendationProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SingleScopeBenefitRecommendationProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SingleScopeBenefitRecommendationProperties"/> to convert. </param>
        public static implicit operator RequestContent(SingleScopeBenefitRecommendationProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SingleScopeBenefitRecommendationProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SingleScopeBenefitRecommendationProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSingleScopeBenefitRecommendationProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
