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
    internal partial class RedirectCallRequestInternal : IUtf8JsonSerializable, IJsonModel<RedirectCallRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedirectCallRequestInternal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedirectCallRequestInternal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedirectCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RedirectCallRequestInternal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("incomingCallContext"u8);
            writer.WriteStringValue(IncomingCallContext);
            writer.WritePropertyName("target"u8);
            writer.WriteObjectValue(Target);
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

        RedirectCallRequestInternal IJsonModel<RedirectCallRequestInternal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedirectCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RedirectCallRequestInternal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedirectCallRequestInternal(document.RootElement, options);
        }

        internal static RedirectCallRequestInternal DeserializeRedirectCallRequestInternal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string incomingCallContext = default;
            CommunicationIdentifierModel target = default;
            Optional<CustomCallingContextInternal> customCallingContext = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("incomingCallContext"u8))
                {
                    incomingCallContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
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
            return new RedirectCallRequestInternal(incomingCallContext, target, customCallingContext.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedirectCallRequestInternal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedirectCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RedirectCallRequestInternal)} does not support '{options.Format}' format.");
            }
        }

        RedirectCallRequestInternal IPersistableModel<RedirectCallRequestInternal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedirectCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedirectCallRequestInternal(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RedirectCallRequestInternal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedirectCallRequestInternal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
