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
    internal partial class CancelAddParticipantResponseInternal : IUtf8JsonSerializable, IJsonModel<CancelAddParticipantResponseInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CancelAddParticipantResponseInternal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CancelAddParticipantResponseInternal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelAddParticipantResponseInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CancelAddParticipantResponseInternal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InvitationId))
            {
                writer.WritePropertyName("invitationId"u8);
                writer.WriteStringValue(InvitationId);
            }
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

        CancelAddParticipantResponseInternal IJsonModel<CancelAddParticipantResponseInternal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelAddParticipantResponseInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CancelAddParticipantResponseInternal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCancelAddParticipantResponseInternal(document.RootElement, options);
        }

        internal static CancelAddParticipantResponseInternal DeserializeCancelAddParticipantResponseInternal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> invitationId = default;
            Optional<string> operationContext = default;
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CancelAddParticipantResponseInternal(invitationId.Value, operationContext.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CancelAddParticipantResponseInternal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelAddParticipantResponseInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CancelAddParticipantResponseInternal)} does not support '{options.Format}' format.");
            }
        }

        CancelAddParticipantResponseInternal IPersistableModel<CancelAddParticipantResponseInternal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CancelAddParticipantResponseInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCancelAddParticipantResponseInternal(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CancelAddParticipantResponseInternal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CancelAddParticipantResponseInternal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
