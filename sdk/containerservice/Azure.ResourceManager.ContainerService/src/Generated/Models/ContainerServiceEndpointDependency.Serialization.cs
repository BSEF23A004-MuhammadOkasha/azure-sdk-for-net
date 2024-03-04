// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceEndpointDependency : IUtf8JsonSerializable, IJsonModel<ContainerServiceEndpointDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceEndpointDependency>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceEndpointDependency>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceEndpointDependency)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Optional.IsCollectionDefined(EndpointDetails))
            {
                writer.WritePropertyName("endpointDetails"u8);
                writer.WriteStartArray();
                foreach (var item in EndpointDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ContainerServiceEndpointDependency IJsonModel<ContainerServiceEndpointDependency>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceEndpointDependency)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceEndpointDependency(document.RootElement, options);
        }

        internal static ContainerServiceEndpointDependency DeserializeContainerServiceEndpointDependency(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            IReadOnlyList<ContainerServiceEndpointDetail> endpointDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceEndpointDetail> array = new List<ContainerServiceEndpointDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceEndpointDetail.DeserializeContainerServiceEndpointDetail(item, options));
                    }
                    endpointDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceEndpointDependency(domainName, endpointDetails ?? new ChangeTrackingList<ContainerServiceEndpointDetail>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceEndpointDependency>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceEndpointDependency)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceEndpointDependency IPersistableModel<ContainerServiceEndpointDependency>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceEndpointDependency(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceEndpointDependency)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceEndpointDependency>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
