// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BillingBenefits
{
    public partial class BillingBenefitsReservationOrderAliasData : IUtf8JsonSerializable, IJsonModel<BillingBenefitsReservationOrderAliasData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingBenefitsReservationOrderAliasData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BillingBenefitsReservationOrderAliasData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsReservationOrderAliasData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsReservationOrderAliasData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && ReservationOrderId != null)
            {
                writer.WritePropertyName("reservationOrderId"u8);
                writer.WriteStringValue(ReservationOrderId);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (BillingScopeId != null)
            {
                writer.WritePropertyName("billingScopeId"u8);
                writer.WriteStringValue(BillingScopeId);
            }
            if (Term.HasValue)
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (BillingPlan.HasValue)
            {
                writer.WritePropertyName("billingPlan"u8);
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (AppliedScopeType.HasValue)
            {
                writer.WritePropertyName("appliedScopeType"u8);
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (AppliedScopeProperties != null)
            {
                writer.WritePropertyName("appliedScopeProperties"u8);
                writer.WriteObjectValue(AppliedScopeProperties);
            }
            if (Quantity.HasValue)
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (IsRenewed.HasValue)
            {
                writer.WritePropertyName("renew"u8);
                writer.WriteBooleanValue(IsRenewed.Value);
            }
            if (ReservedResourceType.HasValue)
            {
                writer.WritePropertyName("reservedResourceType"u8);
                writer.WriteStringValue(ReservedResourceType.Value.ToString());
            }
            if (ReviewOn.HasValue)
            {
                writer.WritePropertyName("reviewDateTime"u8);
                writer.WriteStringValue(ReviewOn.Value, "O");
            }
            if (ReservedResourceProperties != null)
            {
                writer.WritePropertyName("reservedResourceProperties"u8);
                writer.WriteObjectValue(ReservedResourceProperties);
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

        BillingBenefitsReservationOrderAliasData IJsonModel<BillingBenefitsReservationOrderAliasData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsReservationOrderAliasData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsReservationOrderAliasData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsReservationOrderAliasData(document.RootElement, options);
        }

        internal static BillingBenefitsReservationOrderAliasData DeserializeBillingBenefitsReservationOrderAliasData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingBenefitsSku sku = default;
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string displayName = default;
            ResourceIdentifier reservationOrderId = default;
            BillingBenefitsProvisioningState? provisioningState = default;
            ResourceIdentifier billingScopeId = default;
            BillingBenefitsTerm? term = default;
            BillingBenefitsBillingPlan? billingPlan = default;
            BillingBenefitsAppliedScopeType? appliedScopeType = default;
            BillingBenefitsAppliedScopeProperties appliedScopeProperties = default;
            int? quantity = default;
            bool? renew = default;
            BillingBenefitsReservedResourceType? reservedResourceType = default;
            DateTimeOffset? reviewDateTime = default;
            ReservationOrderAliasResponsePropertiesReservedResourceProperties reservedResourceProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = BillingBenefitsSku.DeserializeBillingBenefitsSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationOrderId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reservationOrderId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new BillingBenefitsProvisioningState(property0.Value.GetString());
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
                            term = new BillingBenefitsTerm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingPlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingPlan = new BillingBenefitsBillingPlan(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeType = new BillingBenefitsAppliedScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeProperties = BillingBenefitsAppliedScopeProperties.DeserializeBillingBenefitsAppliedScopeProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quantity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("renew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            renew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("reservedResourceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reservedResourceType = new BillingBenefitsReservedResourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reviewDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reviewDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("reservedResourceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reservedResourceProperties = ReservationOrderAliasResponsePropertiesReservedResourceProperties.DeserializeReservationOrderAliasResponsePropertiesReservedResourceProperties(property0.Value, options);
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
            return new BillingBenefitsReservationOrderAliasData(
                id,
                name,
                type,
                systemData,
                sku,
                location,
                displayName,
                reservationOrderId,
                provisioningState,
                billingScopeId,
                term,
                billingPlan,
                appliedScopeType,
                appliedScopeProperties,
                quantity,
                renew,
                reservedResourceType,
                reviewDateTime,
                reservedResourceProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingBenefitsReservationOrderAliasData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsReservationOrderAliasData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsReservationOrderAliasData)} does not support '{options.Format}' format.");
            }
        }

        BillingBenefitsReservationOrderAliasData IPersistableModel<BillingBenefitsReservationOrderAliasData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsReservationOrderAliasData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingBenefitsReservationOrderAliasData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsReservationOrderAliasData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingBenefitsReservationOrderAliasData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
