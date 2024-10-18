// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionMeterDetailsInfo : IUtf8JsonSerializable, IJsonModel<ConsumptionMeterDetailsInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionMeterDetailsInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConsumptionMeterDetailsInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionMeterDetailsInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionMeterDetailsInfo)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(MeterName))
            {
                writer.WritePropertyName("meterName"u8);
                writer.WriteStringValue(MeterName);
            }
            if (options.Format != "W" && Optional.IsDefined(MeterCategory))
            {
                writer.WritePropertyName("meterCategory"u8);
                writer.WriteStringValue(MeterCategory);
            }
            if (options.Format != "W" && Optional.IsDefined(MeterSubCategory))
            {
                writer.WritePropertyName("meterSubCategory"u8);
                writer.WriteStringValue(MeterSubCategory);
            }
            if (options.Format != "W" && Optional.IsDefined(UnitOfMeasure))
            {
                writer.WritePropertyName("unitOfMeasure"u8);
                writer.WriteStringValue(UnitOfMeasure);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceFamily))
            {
                writer.WritePropertyName("serviceFamily"u8);
                writer.WriteStringValue(ServiceFamily);
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
        }

        ConsumptionMeterDetailsInfo IJsonModel<ConsumptionMeterDetailsInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionMeterDetailsInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionMeterDetailsInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionMeterDetailsInfo(document.RootElement, options);
        }

        internal static ConsumptionMeterDetailsInfo DeserializeConsumptionMeterDetailsInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string meterName = default;
            string meterCategory = default;
            string meterSubCategory = default;
            string unitOfMeasure = default;
            string serviceFamily = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meterName"u8))
                {
                    meterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterCategory"u8))
                {
                    meterCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterSubCategory"u8))
                {
                    meterSubCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unitOfMeasure"u8))
                {
                    unitOfMeasure = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceFamily"u8))
                {
                    serviceFamily = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConsumptionMeterDetailsInfo(
                meterName,
                meterCategory,
                meterSubCategory,
                unitOfMeasure,
                serviceFamily,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionMeterDetailsInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionMeterDetailsInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionMeterDetailsInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ConsumptionMeterDetailsInfo IPersistableModel<ConsumptionMeterDetailsInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionMeterDetailsInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionMeterDetailsInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionMeterDetailsInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionMeterDetailsInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
