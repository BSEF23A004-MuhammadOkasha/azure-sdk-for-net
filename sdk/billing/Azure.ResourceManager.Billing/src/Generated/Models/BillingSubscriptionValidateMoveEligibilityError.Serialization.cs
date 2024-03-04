// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Billing;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingSubscriptionValidateMoveEligibilityError : IUtf8JsonSerializable, IJsonModel<BillingSubscriptionValidateMoveEligibilityError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingSubscriptionValidateMoveEligibilityError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BillingSubscriptionValidateMoveEligibilityError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionValidateMoveEligibilityError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingSubscriptionValidateMoveEligibilityError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code.Value.ToString());
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStringValue(Details);
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

        BillingSubscriptionValidateMoveEligibilityError IJsonModel<BillingSubscriptionValidateMoveEligibilityError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionValidateMoveEligibilityError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingSubscriptionValidateMoveEligibilityError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingSubscriptionValidateMoveEligibilityError(document.RootElement, options);
        }

        internal static BillingSubscriptionValidateMoveEligibilityError DeserializeBillingSubscriptionValidateMoveEligibilityError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SubscriptionTransferValidationErrorCode? code = default;
            string message = default;
            string details = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    code = new SubscriptionTransferValidationErrorCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    details = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BillingSubscriptionValidateMoveEligibilityError(code, message, details, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingSubscriptionValidateMoveEligibilityError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionValidateMoveEligibilityError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingSubscriptionValidateMoveEligibilityError)} does not support '{options.Format}' format.");
            }
        }

        BillingSubscriptionValidateMoveEligibilityError IPersistableModel<BillingSubscriptionValidateMoveEligibilityError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionValidateMoveEligibilityError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingSubscriptionValidateMoveEligibilityError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingSubscriptionValidateMoveEligibilityError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingSubscriptionValidateMoveEligibilityError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
