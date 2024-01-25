// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ResourcesResponseEndpointsItem : IUtf8JsonSerializable, IJsonModel<ResourcesResponseEndpointsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourcesResponseEndpointsItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourcesResponseEndpointsItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesResponseEndpointsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourcesResponseEndpointsItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(History))
            {
                writer.WritePropertyName("history"u8);
                writer.WriteBooleanValue(History.Value);
            }
            if (Optional.IsCollectionDefined(CustomDomains))
            {
                writer.WritePropertyName("customDomains"u8);
                writer.WriteStartArray();
                foreach (var item in CustomDomains)
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

        ResourcesResponseEndpointsItem IJsonModel<ResourcesResponseEndpointsItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesResponseEndpointsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourcesResponseEndpointsItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourcesResponseEndpointsItem(document.RootElement, options);
        }

        internal static ResourcesResponseEndpointsItem DeserializeResourcesResponseEndpointsItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<bool> history = default;
            Optional<IReadOnlyList<ResourcesResponseEndpointsPropertiesItemsItem>> customDomains = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("history"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    history = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customDomains"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourcesResponseEndpointsPropertiesItemsItem> array = new List<ResourcesResponseEndpointsPropertiesItemsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourcesResponseEndpointsPropertiesItemsItem.DeserializeResourcesResponseEndpointsPropertiesItemsItem(item));
                    }
                    customDomains = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourcesResponseEndpointsItem(id.Value, name.Value, Optional.ToNullable(history), Optional.ToList(customDomains), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourcesResponseEndpointsItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesResponseEndpointsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourcesResponseEndpointsItem)} does not support '{options.Format}' format.");
            }
        }

        ResourcesResponseEndpointsItem IPersistableModel<ResourcesResponseEndpointsItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcesResponseEndpointsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourcesResponseEndpointsItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourcesResponseEndpointsItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourcesResponseEndpointsItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
