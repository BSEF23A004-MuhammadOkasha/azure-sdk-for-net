// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryWebhookEventRequestMessage : IUtf8JsonSerializable, IJsonModel<ContainerRegistryWebhookEventRequestMessage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryWebhookEventRequestMessage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryWebhookEventRequestMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventRequestMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventRequestMessage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                BinaryData data = ModelReaderWriter.Write(Content, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartObject();
                foreach (var item in Headers)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method);
            }
            if (Optional.IsDefined(RequestUri))
            {
                writer.WritePropertyName("requestUri"u8);
                writer.WriteStringValue(RequestUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
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

        ContainerRegistryWebhookEventRequestMessage IJsonModel<ContainerRegistryWebhookEventRequestMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventRequestMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventRequestMessage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryWebhookEventRequestMessage(document.RootElement, options);
        }

        internal static ContainerRegistryWebhookEventRequestMessage DeserializeContainerRegistryWebhookEventRequestMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerRegistryWebhookEventContent> content = default;
            Optional<IReadOnlyDictionary<string, string>> headers = default;
            Optional<string> method = default;
            Optional<Uri> requestUri = default;
            Optional<string> version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = ContainerRegistryWebhookEventContent.DeserializeContainerRegistryWebhookEventContent(property.Value);
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    headers = dictionary;
                    continue;
                }
                if (property.NameEquals("method"u8))
                {
                    method = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryWebhookEventRequestMessage(content.Value, Optional.ToDictionary(headers), method.Value, requestUri.Value, version.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryWebhookEventRequestMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventRequestMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventRequestMessage)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryWebhookEventRequestMessage IPersistableModel<ContainerRegistryWebhookEventRequestMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventRequestMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryWebhookEventRequestMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventRequestMessage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryWebhookEventRequestMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
