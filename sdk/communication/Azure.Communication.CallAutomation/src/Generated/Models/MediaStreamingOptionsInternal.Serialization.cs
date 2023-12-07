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

namespace Azure.Communication.CallAutomation
{
    internal partial class MediaStreamingOptionsInternal : IUtf8JsonSerializable, IJsonModel<MediaStreamingOptionsInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaStreamingOptionsInternal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaStreamingOptionsInternal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaStreamingOptionsInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MediaStreamingOptionsInternal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("transportUrl"u8);
            writer.WriteStringValue(TransportUrl);
            writer.WritePropertyName("transportType"u8);
            writer.WriteStringValue(TransportType.ToString());
            writer.WritePropertyName("contentType"u8);
            writer.WriteStringValue(ContentType.ToString());
            writer.WritePropertyName("audioChannelType"u8);
            writer.WriteStringValue(AudioChannelType.ToString());
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

        MediaStreamingOptionsInternal IJsonModel<MediaStreamingOptionsInternal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaStreamingOptionsInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MediaStreamingOptionsInternal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaStreamingOptionsInternal(document.RootElement, options);
        }

        internal static MediaStreamingOptionsInternal DeserializeMediaStreamingOptionsInternal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string transportUrl = default;
            MediaStreamingTransport transportType = default;
            MediaStreamingContent contentType = default;
            MediaStreamingAudioChannel audioChannelType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transportUrl"u8))
                {
                    transportUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transportType"u8))
                {
                    transportType = new MediaStreamingTransport(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    contentType = new MediaStreamingContent(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("audioChannelType"u8))
                {
                    audioChannelType = new MediaStreamingAudioChannel(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaStreamingOptionsInternal(transportUrl, transportType, contentType, audioChannelType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaStreamingOptionsInternal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaStreamingOptionsInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MediaStreamingOptionsInternal)} does not support '{options.Format}' format.");
            }
        }

        MediaStreamingOptionsInternal IPersistableModel<MediaStreamingOptionsInternal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaStreamingOptionsInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaStreamingOptionsInternal(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MediaStreamingOptionsInternal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaStreamingOptionsInternal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
