// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    [PersistableModelProxy(typeof(UnknownValidationInputResponse))]
    public partial class DataBoxValidationInputResult : IUtf8JsonSerializable, IJsonModel<DataBoxValidationInputResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxValidationInputResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxValidationInputResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationInputResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataBoxValidationInputResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("validationType"u8);
            writer.WriteStringValue(ValidationType.ToSerialString());
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        DataBoxValidationInputResult IJsonModel<DataBoxValidationInputResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationInputResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataBoxValidationInputResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxValidationInputResult(document.RootElement, options);
        }

        internal static DataBoxValidationInputResult DeserializeDataBoxValidationInputResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("validationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ValidateCreateOrderLimit": return CreateOrderLimitForSubscriptionValidationResult.DeserializeCreateOrderLimitForSubscriptionValidationResult(element);
                    case "ValidateDataTransferDetails": return DataTransferDetailsValidationResult.DeserializeDataTransferDetailsValidationResult(element);
                    case "ValidatePreferences": return PreferencesValidationResult.DeserializePreferencesValidationResult(element);
                    case "ValidateSkuAvailability": return SkuAvailabilityValidationResult.DeserializeSkuAvailabilityValidationResult(element);
                    case "ValidateSubscriptionIsAllowedToCreateJob": return SubscriptionIsAllowedToCreateJobValidationResult.DeserializeSubscriptionIsAllowedToCreateJobValidationResult(element);
                    case "ValidateAddress": return AddressValidationResult.DeserializeAddressValidationResult(element);
                }
            }
            return UnknownValidationInputResponse.DeserializeUnknownValidationInputResponse(element);
        }

        BinaryData IPersistableModel<DataBoxValidationInputResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationInputResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DataBoxValidationInputResult)} does not support '{options.Format}' format.");
            }
        }

        DataBoxValidationInputResult IPersistableModel<DataBoxValidationInputResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationInputResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxValidationInputResult(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DataBoxValidationInputResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxValidationInputResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
