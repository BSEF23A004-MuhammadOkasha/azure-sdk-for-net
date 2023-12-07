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
    public partial class ContinuousDtmfRecognitionToneReceived : IUtf8JsonSerializable, IJsonModel<ContinuousDtmfRecognitionToneReceived>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContinuousDtmfRecognitionToneReceived>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContinuousDtmfRecognitionToneReceived>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuousDtmfRecognitionToneReceived>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContinuousDtmfRecognitionToneReceived)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ResultInformation))
            {
                writer.WritePropertyName("resultInformation"u8);
                writer.WriteObjectValue(ResultInformation);
            }
            if (options.Format != "W" && Optional.IsDefined(SequenceId))
            {
                writer.WritePropertyName("sequenceId"u8);
                writer.WriteNumberValue(SequenceId.Value);
            }
            if (Optional.IsDefined(Tone))
            {
                writer.WritePropertyName("tone"u8);
                writer.WriteStringValue(Tone.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (options.Format != "W" && Optional.IsDefined(CallConnectionId))
            {
                writer.WritePropertyName("callConnectionId"u8);
                writer.WriteStringValue(CallConnectionId);
            }
            if (options.Format != "W" && Optional.IsDefined(ServerCallId))
            {
                writer.WritePropertyName("serverCallId"u8);
                writer.WriteStringValue(ServerCallId);
            }
            if (options.Format != "W" && Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
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

        ContinuousDtmfRecognitionToneReceived IJsonModel<ContinuousDtmfRecognitionToneReceived>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuousDtmfRecognitionToneReceived>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContinuousDtmfRecognitionToneReceived)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContinuousDtmfRecognitionToneReceived(document.RootElement, options);
        }

        internal static ContinuousDtmfRecognitionToneReceived DeserializeContinuousDtmfRecognitionToneReceived(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResultInformation> resultInformation = default;
            Optional<int> sequenceId = default;
            Optional<DtmfTone> tone = default;
            Optional<string> operationContext = default;
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            Optional<string> correlationId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("sequenceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tone"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tone = new DtmfTone(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContinuousDtmfRecognitionToneReceived(resultInformation.Value, Optional.ToNullable(sequenceId), Optional.ToNullable(tone), operationContext.Value, callConnectionId.Value, serverCallId.Value, correlationId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContinuousDtmfRecognitionToneReceived>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuousDtmfRecognitionToneReceived>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ContinuousDtmfRecognitionToneReceived)} does not support '{options.Format}' format.");
            }
        }

        ContinuousDtmfRecognitionToneReceived IPersistableModel<ContinuousDtmfRecognitionToneReceived>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinuousDtmfRecognitionToneReceived>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContinuousDtmfRecognitionToneReceived(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ContinuousDtmfRecognitionToneReceived)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContinuousDtmfRecognitionToneReceived>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
