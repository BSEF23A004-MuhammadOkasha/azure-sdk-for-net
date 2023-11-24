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

namespace Azure.ResourceManager.Network.Models
{
    public partial class AzureReachabilityReportLocation : IUtf8JsonSerializable, IJsonModel<AzureReachabilityReportLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureReachabilityReportLocation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureReachabilityReportLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AzureReachabilityReportLocation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
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

        AzureReachabilityReportLocation IJsonModel<AzureReachabilityReportLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AzureReachabilityReportLocation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureReachabilityReportLocation(document.RootElement, options);
        }

        internal static AzureReachabilityReportLocation DeserializeAzureReachabilityReportLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string country = default;
            Optional<string> state = default;
            Optional<string> city = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureReachabilityReportLocation(country, state.Value, city.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureReachabilityReportLocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AzureReachabilityReportLocation)} does not support '{options.Format}' format.");
            }
        }

        AzureReachabilityReportLocation IPersistableModel<AzureReachabilityReportLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureReachabilityReportLocation(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AzureReachabilityReportLocation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureReachabilityReportLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
