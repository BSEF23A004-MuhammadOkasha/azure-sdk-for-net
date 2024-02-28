// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class AudioOverlay : IUtf8JsonSerializable, IJsonModel<AudioOverlay>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AudioOverlay>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AudioOverlay>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioOverlay>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioOverlay)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("inputLabel"u8);
            writer.WriteStringValue(InputLabel);
            if (Start.HasValue)
            {
                writer.WritePropertyName("start"u8);
                writer.WriteStringValue(Start.Value, "P");
            }
            if (End.HasValue)
            {
                writer.WritePropertyName("end"u8);
                writer.WriteStringValue(End.Value, "P");
            }
            if (FadeInDuration.HasValue)
            {
                writer.WritePropertyName("fadeInDuration"u8);
                writer.WriteStringValue(FadeInDuration.Value, "P");
            }
            if (FadeOutDuration.HasValue)
            {
                writer.WritePropertyName("fadeOutDuration"u8);
                writer.WriteStringValue(FadeOutDuration.Value, "P");
            }
            if (AudioGainLevel.HasValue)
            {
                writer.WritePropertyName("audioGainLevel"u8);
                writer.WriteNumberValue(AudioGainLevel.Value);
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

        AudioOverlay IJsonModel<AudioOverlay>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioOverlay>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioOverlay)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAudioOverlay(document.RootElement, options);
        }

        internal static AudioOverlay DeserializeAudioOverlay(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataType = default;
            string inputLabel = default;
            TimeSpan? start = default;
            TimeSpan? end = default;
            TimeSpan? fadeInDuration = default;
            TimeSpan? fadeOutDuration = default;
            double? audioGainLevel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputLabel"u8))
                {
                    inputLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    start = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    end = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeInDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fadeInDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeOutDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fadeOutDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("audioGainLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    audioGainLevel = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AudioOverlay(
                odataType,
                inputLabel,
                start,
                end,
                fadeInDuration,
                fadeOutDuration,
                audioGainLevel,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AudioOverlay>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioOverlay>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AudioOverlay)} does not support '{options.Format}' format.");
            }
        }

        AudioOverlay IPersistableModel<AudioOverlay>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioOverlay>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAudioOverlay(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AudioOverlay)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AudioOverlay>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
