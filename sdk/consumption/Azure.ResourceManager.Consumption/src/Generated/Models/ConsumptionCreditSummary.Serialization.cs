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
    public partial class ConsumptionCreditSummary : IUtf8JsonSerializable, IModelJsonSerializable<ConsumptionCreditSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConsumptionCreditSummary>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConsumptionCreditSummary>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionCreditSummary>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
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

        internal static ConsumptionCreditSummary DeserializeConsumptionCreditSummary(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<CreditBalanceSummary> balanceSummary = default;
            Optional<ConsumptionAmount> pendingCreditAdjustments = default;
            Optional<ConsumptionAmount> expiredCredit = default;
            Optional<ConsumptionAmount> pendingEligibleCharges = default;
            Optional<string> creditCurrency = default;
            Optional<string> billingCurrency = default;
            Optional<ConsumptionReseller> reseller = default;
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
                        if (property0.NameEquals("balanceSummary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            balanceSummary = CreditBalanceSummary.DeserializeCreditBalanceSummary(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("pendingCreditAdjustments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pendingCreditAdjustments = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("expiredCredit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiredCredit = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("pendingEligibleCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pendingEligibleCharges = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
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
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConsumptionCreditSummary(id, name, type, systemData.Value, balanceSummary.Value, pendingCreditAdjustments.Value, expiredCredit.Value, pendingEligibleCharges.Value, creditCurrency.Value, billingCurrency.Value, reseller.Value, Optional.ToNullable(eTag), rawData);
        }

        ConsumptionCreditSummary IModelJsonSerializable<ConsumptionCreditSummary>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionCreditSummary>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionCreditSummary(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConsumptionCreditSummary>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionCreditSummary>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConsumptionCreditSummary IModelSerializable<ConsumptionCreditSummary>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsumptionCreditSummary>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConsumptionCreditSummary(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConsumptionCreditSummary"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConsumptionCreditSummary"/> to convert. </param>
        public static implicit operator RequestContent(ConsumptionCreditSummary model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConsumptionCreditSummary"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConsumptionCreditSummary(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConsumptionCreditSummary(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
