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

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class Pav2MeterDetails : IUtf8JsonSerializable, IJsonModel<Pav2MeterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Pav2MeterDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Pav2MeterDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Pav2MeterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(Pav2MeterDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MeterGuid))
            {
                writer.WritePropertyName("meterGuid"u8);
                writer.WriteStringValue(MeterGuid.Value);
            }
            writer.WritePropertyName("billingType"u8);
            writer.WriteStringValue(BillingType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Multiplier))
            {
                writer.WritePropertyName("multiplier"u8);
                writer.WriteNumberValue(Multiplier.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ChargingType))
            {
                writer.WritePropertyName("chargingType"u8);
                writer.WriteStringValue(ChargingType.Value.ToString());
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

        Pav2MeterDetails IJsonModel<Pav2MeterDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Pav2MeterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(Pav2MeterDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePav2MeterDetails(document.RootElement, options);
        }

        internal static Pav2MeterDetails DeserializePav2MeterDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> meterGuid = default;
            BillingType billingType = default;
            Optional<double> multiplier = default;
            Optional<EdgeOrderProductChargingType> chargingType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meterGuid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    meterGuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("billingType"u8))
                {
                    billingType = new BillingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiplier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multiplier = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("chargingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    chargingType = new EdgeOrderProductChargingType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Pav2MeterDetails(billingType, Optional.ToNullable(multiplier), Optional.ToNullable(chargingType), serializedAdditionalRawData, Optional.ToNullable(meterGuid));
        }

        BinaryData IPersistableModel<Pav2MeterDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Pav2MeterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(Pav2MeterDetails)} does not support '{options.Format}' format.");
            }
        }

        Pav2MeterDetails IPersistableModel<Pav2MeterDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Pav2MeterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePav2MeterDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(Pav2MeterDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Pav2MeterDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
