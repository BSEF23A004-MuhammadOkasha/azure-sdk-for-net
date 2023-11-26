// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaJobOutputScheduledEventDataConverter))]
    public partial class MediaJobOutputScheduledEventData : IUtf8JsonSerializable, IJsonModel<MediaJobOutputScheduledEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaJobOutputScheduledEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaJobOutputScheduledEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobOutputScheduledEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MediaJobOutputScheduledEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PreviousState))
            {
                writer.WritePropertyName("previousState"u8);
                writer.WriteStringValue(PreviousState.Value.ToSerialString());
            }
            if (Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteObjectValue(Output);
            }
            if (Optional.IsCollectionDefined(JobCorrelationData))
            {
                writer.WritePropertyName("jobCorrelationData"u8);
                writer.WriteStartObject();
                foreach (var item in JobCorrelationData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
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

        MediaJobOutputScheduledEventData IJsonModel<MediaJobOutputScheduledEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobOutputScheduledEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MediaJobOutputScheduledEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobOutputScheduledEventData(document.RootElement, options);
        }

        internal static MediaJobOutputScheduledEventData DeserializeMediaJobOutputScheduledEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MediaJobState> previousState = default;
            Optional<MediaJobOutput> output = default;
            Optional<IReadOnlyDictionary<string, string>> jobCorrelationData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("previousState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previousState = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = MediaJobOutput.DeserializeMediaJobOutput(property.Value);
                    continue;
                }
                if (property.NameEquals("jobCorrelationData"u8))
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
                    jobCorrelationData = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaJobOutputScheduledEventData(Optional.ToNullable(previousState), output.Value, Optional.ToDictionary(jobCorrelationData), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaJobOutputScheduledEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobOutputScheduledEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MediaJobOutputScheduledEventData)} does not support '{options.Format}' format.");
            }
        }

        MediaJobOutputScheduledEventData IPersistableModel<MediaJobOutputScheduledEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobOutputScheduledEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaJobOutputScheduledEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MediaJobOutputScheduledEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaJobOutputScheduledEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class MediaJobOutputScheduledEventDataConverter : JsonConverter<MediaJobOutputScheduledEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaJobOutputScheduledEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaJobOutputScheduledEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaJobOutputScheduledEventData(document.RootElement);
            }
        }
    }
}
