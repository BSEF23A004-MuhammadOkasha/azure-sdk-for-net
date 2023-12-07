// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class TransferToParticipantRequestInternal : IUtf8JsonSerializable, IJsonModel<TransferToParticipantRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransferToParticipantRequestInternal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TransferToParticipantRequestInternal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferToParticipantRequestInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(TransferToParticipantRequestInternal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("targetParticipant"u8);
            writer.WriteObjectValue(TargetParticipant);
            if (Optional.IsDefined(CustomCallingContext))
            {
                writer.WritePropertyName("customCallingContext"u8);
                writer.WriteObjectValue(CustomCallingContext);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (Optional.IsDefined(Transferee))
            {
                writer.WritePropertyName("transferee"u8);
                writer.WriteObjectValue(Transferee);
            }
            if (Optional.IsDefined(OperationCallbackUri))
            {
                writer.WritePropertyName("operationCallbackUri"u8);
                writer.WriteStringValue(OperationCallbackUri);
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

        TransferToParticipantRequestInternal IJsonModel<TransferToParticipantRequestInternal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferToParticipantRequestInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(TransferToParticipantRequestInternal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferToParticipantRequestInternal(document.RootElement, options);
        }

        internal static TransferToParticipantRequestInternal DeserializeTransferToParticipantRequestInternal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationIdentifierModel targetParticipant = default;
            Optional<CustomCallingContextInternal> customCallingContext = default;
            Optional<string> operationContext = default;
            Optional<CommunicationIdentifierModel> transferee = default;
            Optional<string> operationCallbackUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetParticipant"u8))
                {
                    targetParticipant = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("customCallingContext"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customCallingContext = CustomCallingContextInternal.DeserializeCustomCallingContextInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transferee"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferee = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("operationCallbackUri"u8))
                {
                    operationCallbackUri = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TransferToParticipantRequestInternal(targetParticipant, customCallingContext.Value, operationContext.Value, transferee.Value, operationCallbackUri.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TransferToParticipantRequestInternal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferToParticipantRequestInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(TransferToParticipantRequestInternal)} does not support '{options.Format}' format.");
            }
        }

        TransferToParticipantRequestInternal IPersistableModel<TransferToParticipantRequestInternal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferToParticipantRequestInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTransferToParticipantRequestInternal(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(TransferToParticipantRequestInternal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TransferToParticipantRequestInternal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
