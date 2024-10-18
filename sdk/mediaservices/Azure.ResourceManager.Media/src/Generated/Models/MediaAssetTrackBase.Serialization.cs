// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    [PersistableModelProxy(typeof(UnknownTrackBase))]
    public partial class MediaAssetTrackBase : IUtf8JsonSerializable, IJsonModel<MediaAssetTrackBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaAssetTrackBase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MediaAssetTrackBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetTrackBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaAssetTrackBase)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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
        }

        MediaAssetTrackBase IJsonModel<MediaAssetTrackBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetTrackBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaAssetTrackBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaAssetTrackBase(document.RootElement, options);
        }

        internal static MediaAssetTrackBase DeserializeMediaAssetTrackBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AudioTrack": return AudioTrack.DeserializeAudioTrack(element, options);
                    case "#Microsoft.Media.TextTrack": return TextTrack.DeserializeTextTrack(element, options);
                    case "#Microsoft.Media.VideoTrack": return VideoTrack.DeserializeVideoTrack(element, options);
                }
            }
            return UnknownTrackBase.DeserializeUnknownTrackBase(element, options);
        }

        BinaryData IPersistableModel<MediaAssetTrackBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetTrackBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaAssetTrackBase)} does not support writing '{options.Format}' format.");
            }
        }

        MediaAssetTrackBase IPersistableModel<MediaAssetTrackBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaAssetTrackBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaAssetTrackBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaAssetTrackBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaAssetTrackBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
