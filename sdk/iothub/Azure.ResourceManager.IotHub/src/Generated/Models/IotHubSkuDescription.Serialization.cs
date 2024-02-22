// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubSkuDescription : IUtf8JsonSerializable, IJsonModel<IotHubSkuDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubSkuDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotHubSkuDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubSkuDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubSkuDescription)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            writer.WritePropertyName("capacity"u8);
            writer.WriteObjectValue(Capacity);
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

        IotHubSkuDescription IJsonModel<IotHubSkuDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubSkuDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubSkuDescription)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubSkuDescription(document.RootElement, options);
        }

        internal static IotHubSkuDescription DeserializeIotHubSkuDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceType> resourceType = default;
            IotHubSkuInfo sku = default;
            IotHubCapacity capacity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = IotHubSkuInfo.DeserializeIotHubSkuInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    capacity = IotHubCapacity.DeserializeIotHubCapacity(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubSkuDescription(Optional.ToNullable(resourceType), sku, capacity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubSkuDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubSkuDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubSkuDescription)} does not support '{options.Format}' format.");
            }
        }

        IotHubSkuDescription IPersistableModel<IotHubSkuDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubSkuDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubSkuDescription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubSkuDescription)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubSkuDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
