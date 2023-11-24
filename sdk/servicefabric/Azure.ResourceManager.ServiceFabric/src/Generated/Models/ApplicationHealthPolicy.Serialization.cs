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
    public partial class ApplicationHealthPolicy : IUtf8JsonSerializable, IJsonModel<ApplicationHealthPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationHealthPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationHealthPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApplicationHealthPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultServiceTypeHealthPolicy))
            {
                writer.WritePropertyName("defaultServiceTypeHealthPolicy"u8);
                writer.WriteObjectValue(DefaultServiceTypeHealthPolicy);
            }
            if (Optional.IsCollectionDefined(ServiceTypeHealthPolicies))
            {
                writer.WritePropertyName("serviceTypeHealthPolicies"u8);
                writer.WriteStartObject();
                foreach (var item in ServiceTypeHealthPolicies)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        ApplicationHealthPolicy IJsonModel<ApplicationHealthPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApplicationHealthPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationHealthPolicy(document.RootElement, options);
        }

        internal static ApplicationHealthPolicy DeserializeApplicationHealthPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ServiceTypeHealthPolicy> defaultServiceTypeHealthPolicy = default;
            Optional<IDictionary<string, ServiceTypeHealthPolicy>> serviceTypeHealthPolicies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultServiceTypeHealthPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultServiceTypeHealthPolicy = ServiceTypeHealthPolicy.DeserializeServiceTypeHealthPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("serviceTypeHealthPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ServiceTypeHealthPolicy> dictionary = new Dictionary<string, ServiceTypeHealthPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ServiceTypeHealthPolicy.DeserializeServiceTypeHealthPolicy(property0.Value));
                    }
                    serviceTypeHealthPolicies = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationHealthPolicy(defaultServiceTypeHealthPolicy.Value, Optional.ToDictionary(serviceTypeHealthPolicies), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationHealthPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ApplicationHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        ApplicationHealthPolicy IPersistableModel<ApplicationHealthPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationHealthPolicy(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ApplicationHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationHealthPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
