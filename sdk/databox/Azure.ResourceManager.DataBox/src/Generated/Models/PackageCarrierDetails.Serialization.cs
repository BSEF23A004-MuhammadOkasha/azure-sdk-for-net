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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class PackageCarrierDetails : IUtf8JsonSerializable, IJsonModel<PackageCarrierDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PackageCarrierDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PackageCarrierDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageCarrierDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PackageCarrierDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CarrierAccountNumber))
            {
                writer.WritePropertyName("carrierAccountNumber"u8);
                writer.WriteStringValue(CarrierAccountNumber);
            }
            if (Optional.IsDefined(CarrierName))
            {
                writer.WritePropertyName("carrierName"u8);
                writer.WriteStringValue(CarrierName);
            }
            if (Optional.IsDefined(TrackingId))
            {
                writer.WritePropertyName("trackingId"u8);
                writer.WriteStringValue(TrackingId);
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

        PackageCarrierDetails IJsonModel<PackageCarrierDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageCarrierDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PackageCarrierDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePackageCarrierDetails(document.RootElement, options);
        }

        internal static PackageCarrierDetails DeserializePackageCarrierDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> carrierAccountNumber = default;
            Optional<string> carrierName = default;
            Optional<string> trackingId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("carrierAccountNumber"u8))
                {
                    carrierAccountNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("carrierName"u8))
                {
                    carrierName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingId"u8))
                {
                    trackingId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PackageCarrierDetails(carrierAccountNumber.Value, carrierName.Value, trackingId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PackageCarrierDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageCarrierDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PackageCarrierDetails)} does not support '{options.Format}' format.");
            }
        }

        PackageCarrierDetails IPersistableModel<PackageCarrierDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PackageCarrierDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePackageCarrierDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PackageCarrierDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PackageCarrierDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
