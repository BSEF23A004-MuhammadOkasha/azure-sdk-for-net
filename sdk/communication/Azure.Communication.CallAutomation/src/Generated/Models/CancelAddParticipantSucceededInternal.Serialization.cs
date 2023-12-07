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
    internal partial class CancelAddParticipantSucceededInternal : IUtf8JsonSerializable, IJsonModel<CancelAddParticipantSucceededInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CancelAddParticipantSucceededInternal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CancelAddParticipantSucceededInternal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelAddParticipantSucceededInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CancelAddParticipantSucceededInternal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(InvitationId))
            {
                writer.WritePropertyName("invitationId"u8);
                writer.WriteStringValue(InvitationId);
            }
            if (options.Format != "W" && Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (options.Format != "W" && Optional.IsDefined(ResultInformation))
            {
                writer.WritePropertyName("resultInformation"u8);
                writer.WriteObjectValue(ResultInformation);
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

        CancelAddParticipantSucceededInternal IJsonModel<CancelAddParticipantSucceededInternal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelAddParticipantSucceededInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CancelAddParticipantSucceededInternal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCancelAddParticipantSucceededInternal(document.RootElement, options);
        }

        internal static CancelAddParticipantSucceededInternal DeserializeCancelAddParticipantSucceededInternal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> invitationId = default;
            Optional<string> operationContext = default;
            Optional<ResultInformation> resultInformation = default;
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            Optional<string> correlationId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("invitationId"u8))
                {
                    invitationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
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
            return new CancelAddParticipantSucceededInternal(invitationId.Value, operationContext.Value, resultInformation.Value, callConnectionId.Value, serverCallId.Value, correlationId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CancelAddParticipantSucceededInternal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelAddParticipantSucceededInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CancelAddParticipantSucceededInternal)} does not support '{options.Format}' format.");
            }
        }

        CancelAddParticipantSucceededInternal IPersistableModel<CancelAddParticipantSucceededInternal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelAddParticipantSucceededInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCancelAddParticipantSucceededInternal(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CancelAddParticipantSucceededInternal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CancelAddParticipantSucceededInternal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
