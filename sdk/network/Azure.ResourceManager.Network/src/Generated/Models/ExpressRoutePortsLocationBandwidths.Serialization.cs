// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRoutePortsLocationBandwidths : IUtf8JsonSerializable, IJsonModel<ExpressRoutePortsLocationBandwidths>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRoutePortsLocationBandwidths>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExpressRoutePortsLocationBandwidths>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRoutePortsLocationBandwidths>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRoutePortsLocationBandwidths)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(OfferName))
            {
                writer.WritePropertyName("offerName"u8);
                writer.WriteStringValue(OfferName);
            }
            if (options.Format != "W" && Optional.IsDefined(ValueInGbps))
            {
                writer.WritePropertyName("valueInGbps"u8);
                writer.WriteNumberValue(ValueInGbps.Value);
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

        ExpressRoutePortsLocationBandwidths IJsonModel<ExpressRoutePortsLocationBandwidths>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRoutePortsLocationBandwidths>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRoutePortsLocationBandwidths)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRoutePortsLocationBandwidths(document.RootElement, options);
        }

        internal static ExpressRoutePortsLocationBandwidths DeserializeExpressRoutePortsLocationBandwidths(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string offerName = default;
            int? valueInGbps = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerName"u8))
                {
                    offerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueInGbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueInGbps = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExpressRoutePortsLocationBandwidths(offerName, valueInGbps, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRoutePortsLocationBandwidths>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRoutePortsLocationBandwidths>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRoutePortsLocationBandwidths)} does not support writing '{options.Format}' format.");
            }
        }

        ExpressRoutePortsLocationBandwidths IPersistableModel<ExpressRoutePortsLocationBandwidths>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRoutePortsLocationBandwidths>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRoutePortsLocationBandwidths(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRoutePortsLocationBandwidths)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRoutePortsLocationBandwidths>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
