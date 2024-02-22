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
    public partial class CbcsDrmConfiguration : IUtf8JsonSerializable, IJsonModel<CbcsDrmConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CbcsDrmConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CbcsDrmConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CbcsDrmConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CbcsDrmConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FairPlay))
            {
                writer.WritePropertyName("fairPlay"u8);
                writer.WriteObjectValue(FairPlay);
            }
            if (Optional.IsDefined(PlayReady))
            {
                writer.WritePropertyName("playReady"u8);
                writer.WriteObjectValue(PlayReady);
            }
            if (Optional.IsDefined(Widevine))
            {
                writer.WritePropertyName("widevine"u8);
                writer.WriteObjectValue(Widevine);
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

        CbcsDrmConfiguration IJsonModel<CbcsDrmConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CbcsDrmConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CbcsDrmConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCbcsDrmConfiguration(document.RootElement, options);
        }

        internal static CbcsDrmConfiguration DeserializeCbcsDrmConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StreamingPolicyFairPlayConfiguration> fairPlay = default;
            Optional<StreamingPolicyPlayReadyConfiguration> playReady = default;
            Optional<StreamingPolicyWidevineConfiguration> widevine = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fairPlay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fairPlay = StreamingPolicyFairPlayConfiguration.DeserializeStreamingPolicyFairPlayConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("playReady"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    playReady = StreamingPolicyPlayReadyConfiguration.DeserializeStreamingPolicyPlayReadyConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("widevine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    widevine = StreamingPolicyWidevineConfiguration.DeserializeStreamingPolicyWidevineConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CbcsDrmConfiguration(fairPlay.Value, playReady.Value, widevine.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CbcsDrmConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CbcsDrmConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CbcsDrmConfiguration)} does not support '{options.Format}' format.");
            }
        }

        CbcsDrmConfiguration IPersistableModel<CbcsDrmConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CbcsDrmConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCbcsDrmConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CbcsDrmConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CbcsDrmConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
