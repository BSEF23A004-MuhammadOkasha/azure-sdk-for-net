// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    internal partial class HttpProxyConfiguration : IUtf8JsonSerializable, IJsonModel<HttpProxyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HttpProxyConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HttpProxyConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpProxyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HttpProxyConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (HttpsProxy != null)
            {
                writer.WritePropertyName("httpsProxy"u8);
                writer.WriteStringValue(HttpsProxy);
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

        HttpProxyConfiguration IJsonModel<HttpProxyConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpProxyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HttpProxyConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHttpProxyConfiguration(document.RootElement, options);
        }

        internal static HttpProxyConfiguration DeserializeHttpProxyConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string httpsProxy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("httpsProxy"u8))
                {
                    httpsProxy = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HttpProxyConfiguration(httpsProxy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HttpProxyConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpProxyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HttpProxyConfiguration)} does not support '{options.Format}' format.");
            }
        }

        HttpProxyConfiguration IPersistableModel<HttpProxyConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpProxyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHttpProxyConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HttpProxyConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HttpProxyConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
