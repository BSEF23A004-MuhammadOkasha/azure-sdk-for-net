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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ServiceCorrelationDescription : IUtf8JsonSerializable, IJsonModel<ServiceCorrelationDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceCorrelationDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceCorrelationDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceCorrelationDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ServiceCorrelationDescription)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("scheme"u8);
            writer.WriteStringValue(Scheme.ToString());
            writer.WritePropertyName("serviceName"u8);
            writer.WriteStringValue(ServiceName);
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

        ServiceCorrelationDescription IJsonModel<ServiceCorrelationDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceCorrelationDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ServiceCorrelationDescription)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceCorrelationDescription(document.RootElement, options);
        }

        internal static ServiceCorrelationDescription DeserializeServiceCorrelationDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ServiceCorrelationScheme scheme = default;
            string serviceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheme"u8))
                {
                    scheme = new ServiceCorrelationScheme(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceName"u8))
                {
                    serviceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceCorrelationDescription(scheme, serviceName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceCorrelationDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceCorrelationDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ServiceCorrelationDescription)} does not support '{options.Format}' format.");
            }
        }

        ServiceCorrelationDescription IPersistableModel<ServiceCorrelationDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceCorrelationDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceCorrelationDescription(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ServiceCorrelationDescription)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceCorrelationDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
