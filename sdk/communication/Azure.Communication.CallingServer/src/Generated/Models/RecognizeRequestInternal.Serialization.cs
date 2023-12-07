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

namespace Azure.Communication.CallingServer
{
    internal partial class RecognizeRequestInternal : IUtf8JsonSerializable, IJsonModel<RecognizeRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecognizeRequestInternal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecognizeRequestInternal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecognizeRequestInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RecognizeRequestInternal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("recognizeInputType"u8);
            writer.WriteStringValue(RecognizeInputType.ToString());
            if (Optional.IsDefined(PlayPrompt))
            {
                writer.WritePropertyName("playPrompt"u8);
                writer.WriteObjectValue(PlayPrompt);
            }
            if (Optional.IsDefined(InterruptCallMediaOperation))
            {
                writer.WritePropertyName("interruptCallMediaOperation"u8);
                writer.WriteBooleanValue(InterruptCallMediaOperation.Value);
            }
            writer.WritePropertyName("recognizeOptions"u8);
            writer.WriteObjectValue(RecognizeOptions);
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
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

        RecognizeRequestInternal IJsonModel<RecognizeRequestInternal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecognizeRequestInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RecognizeRequestInternal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecognizeRequestInternal(document.RootElement, options);
        }

        internal static RecognizeRequestInternal DeserializeRecognizeRequestInternal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecognizeInputType recognizeInputType = default;
            Optional<PlaySourceInternal> playPrompt = default;
            Optional<bool> interruptCallMediaOperation = default;
            RecognizeOptionsInternal recognizeOptions = default;
            Optional<string> operationContext = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recognizeInputType"u8))
                {
                    recognizeInputType = new RecognizeInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("playPrompt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    playPrompt = PlaySourceInternal.DeserializePlaySourceInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("interruptCallMediaOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interruptCallMediaOperation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("recognizeOptions"u8))
                {
                    recognizeOptions = RecognizeOptionsInternal.DeserializeRecognizeOptionsInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecognizeRequestInternal(recognizeInputType, playPrompt.Value, Optional.ToNullable(interruptCallMediaOperation), recognizeOptions, operationContext.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecognizeRequestInternal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecognizeRequestInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RecognizeRequestInternal)} does not support '{options.Format}' format.");
            }
        }

        RecognizeRequestInternal IPersistableModel<RecognizeRequestInternal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecognizeRequestInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecognizeRequestInternal(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RecognizeRequestInternal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecognizeRequestInternal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
