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

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class SavingsPlanPurchase : IUtf8JsonSerializable, IJsonModel<SavingsPlanPurchase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SavingsPlanPurchase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SavingsPlanPurchase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanPurchase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SavingsPlanPurchase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(BillingScopeId))
            {
                writer.WritePropertyName("billingScopeId"u8);
                writer.WriteStringValue(BillingScopeId);
            }
            if (Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (Optional.IsDefined(BillingPlan))
            {
                writer.WritePropertyName("billingPlan"u8);
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (Optional.IsDefined(AppliedScopeType))
            {
                writer.WritePropertyName("appliedScopeType"u8);
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (Optional.IsDefined(AppliedScopeProperties))
            {
                writer.WritePropertyName("appliedScopeProperties"u8);
                writer.WriteObjectValue(AppliedScopeProperties);
            }
            if (Optional.IsDefined(Commitment))
            {
                writer.WritePropertyName("commitment"u8);
                writer.WriteObjectValue(Commitment);
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

        SavingsPlanPurchase IJsonModel<SavingsPlanPurchase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanPurchase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SavingsPlanPurchase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanPurchase(document.RootElement, options);
        }

        internal static SavingsPlanPurchase DeserializeSavingsPlanPurchase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReservationsSkuName> sku = default;
            Optional<string> displayName = default;
            Optional<ResourceIdentifier> billingScopeId = default;
            Optional<SavingsPlanTerm> term = default;
            Optional<SavingsPlanBillingPlan> billingPlan = default;
            Optional<AppliedScopeType> appliedScopeType = default;
            Optional<AppliedScopeProperties> appliedScopeProperties = default;
            Optional<BenefitsCommitment> commitment = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ReservationsSkuName.DeserializeReservationsSkuName(property.Value);
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingScopeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingScopeId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            term = new SavingsPlanTerm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingPlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingPlan = new SavingsPlanBillingPlan(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeType = new AppliedScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeProperties = AppliedScopeProperties.DeserializeAppliedScopeProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("commitment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            commitment = BenefitsCommitment.DeserializeBenefitsCommitment(property0.Value);
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
            return new SavingsPlanPurchase(sku.Value, displayName.Value, billingScopeId.Value, Optional.ToNullable(term), Optional.ToNullable(billingPlan), Optional.ToNullable(appliedScopeType), appliedScopeProperties.Value, commitment.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SavingsPlanPurchase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanPurchase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SavingsPlanPurchase)} does not support '{options.Format}' format.");
            }
        }

        SavingsPlanPurchase IPersistableModel<SavingsPlanPurchase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanPurchase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSavingsPlanPurchase(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SavingsPlanPurchase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SavingsPlanPurchase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
