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
    internal partial class CreateCallRequestInternal : IUtf8JsonSerializable, IJsonModel<CreateCallRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreateCallRequestInternal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreateCallRequestInternal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CreateCallRequestInternal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("targets"u8);
            writer.WriteStartArray();
            foreach (var item in Targets)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(SourceCallerIdNumber))
            {
                writer.WritePropertyName("sourceCallerIdNumber"u8);
                writer.WriteObjectValue(SourceCallerIdNumber);
            }
            if (Optional.IsDefined(SourceDisplayName))
            {
                writer.WritePropertyName("sourceDisplayName"u8);
                writer.WriteStringValue(SourceDisplayName);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(Source);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            writer.WritePropertyName("callbackUri"u8);
            writer.WriteStringValue(CallbackUri);
            if (Optional.IsDefined(MediaStreamingConfiguration))
            {
                writer.WritePropertyName("mediaStreamingConfiguration"u8);
                writer.WriteObjectValue(MediaStreamingConfiguration);
            }
            if (Optional.IsDefined(TranscriptionConfiguration))
            {
                writer.WritePropertyName("transcriptionConfiguration"u8);
                writer.WriteObjectValue(TranscriptionConfiguration);
            }
            if (Optional.IsDefined(CallIntelligenceOptions))
            {
                writer.WritePropertyName("callIntelligenceOptions"u8);
                writer.WriteObjectValue(CallIntelligenceOptions);
            }
            if (Optional.IsDefined(CustomCallingContext))
            {
                writer.WritePropertyName("customCallingContext"u8);
                writer.WriteObjectValue(CustomCallingContext);
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

        CreateCallRequestInternal IJsonModel<CreateCallRequestInternal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CreateCallRequestInternal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateCallRequestInternal(document.RootElement, options);
        }

        internal static CreateCallRequestInternal DeserializeCreateCallRequestInternal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<CommunicationIdentifierModel> targets = default;
            Optional<PhoneNumberIdentifierModel> sourceCallerIdNumber = default;
            Optional<string> sourceDisplayName = default;
            Optional<CommunicationUserIdentifierModel> source = default;
            Optional<string> operationContext = default;
            string callbackUri = default;
            Optional<MediaStreamingOptionsInternal> mediaStreamingConfiguration = default;
            Optional<TranscriptionOptionsInternal> transcriptionConfiguration = default;
            Optional<CallIntelligenceOptionsInternal> callIntelligenceOptions = default;
            Optional<CustomCallingContextInternal> customCallingContext = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targets"u8))
                {
                    List<CommunicationIdentifierModel> array = new List<CommunicationIdentifierModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("sourceCallerIdNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceCallerIdNumber = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDisplayName"u8))
                {
                    sourceDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callbackUri"u8))
                {
                    callbackUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mediaStreamingConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mediaStreamingConfiguration = MediaStreamingOptionsInternal.DeserializeMediaStreamingOptionsInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("transcriptionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transcriptionConfiguration = TranscriptionOptionsInternal.DeserializeTranscriptionOptionsInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("callIntelligenceOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callIntelligenceOptions = CallIntelligenceOptionsInternal.DeserializeCallIntelligenceOptionsInternal(property.Value);
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateCallRequestInternal(targets, sourceCallerIdNumber.Value, sourceDisplayName.Value, source.Value, operationContext.Value, callbackUri, mediaStreamingConfiguration.Value, transcriptionConfiguration.Value, callIntelligenceOptions.Value, customCallingContext.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateCallRequestInternal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CreateCallRequestInternal)} does not support '{options.Format}' format.");
            }
        }

        CreateCallRequestInternal IPersistableModel<CreateCallRequestInternal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateCallRequestInternal(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CreateCallRequestInternal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateCallRequestInternal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
