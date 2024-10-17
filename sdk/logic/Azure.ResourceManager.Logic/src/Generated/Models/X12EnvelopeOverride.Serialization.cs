// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12EnvelopeOverride : IUtf8JsonSerializable, IJsonModel<X12EnvelopeOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<X12EnvelopeOverride>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<X12EnvelopeOverride>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12EnvelopeOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12EnvelopeOverride)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("targetNamespace"u8);
            writer.WriteStringValue(TargetNamespace);
            writer.WritePropertyName("protocolVersion"u8);
            writer.WriteStringValue(ProtocolVersion);
            writer.WritePropertyName("messageId"u8);
            writer.WriteStringValue(MessageId);
            writer.WritePropertyName("responsibleAgencyCode"u8);
            writer.WriteStringValue(ResponsibleAgencyCode);
            writer.WritePropertyName("headerVersion"u8);
            writer.WriteStringValue(HeaderVersion);
            writer.WritePropertyName("senderApplicationId"u8);
            writer.WriteStringValue(SenderApplicationId);
            writer.WritePropertyName("receiverApplicationId"u8);
            writer.WriteStringValue(ReceiverApplicationId);
            if (Optional.IsDefined(FunctionalIdentifierCode))
            {
                writer.WritePropertyName("functionalIdentifierCode"u8);
                writer.WriteStringValue(FunctionalIdentifierCode);
            }
            writer.WritePropertyName("dateFormat"u8);
            writer.WriteStringValue(DateFormat.ToString());
            writer.WritePropertyName("timeFormat"u8);
            writer.WriteStringValue(TimeFormat.ToString());
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

        X12EnvelopeOverride IJsonModel<X12EnvelopeOverride>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12EnvelopeOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12EnvelopeOverride)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeX12EnvelopeOverride(document.RootElement, options);
        }

        internal static X12EnvelopeOverride DeserializeX12EnvelopeOverride(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetNamespace = default;
            string protocolVersion = default;
            string messageId = default;
            string responsibleAgencyCode = default;
            string headerVersion = default;
            string senderApplicationId = default;
            string receiverApplicationId = default;
            string functionalIdentifierCode = default;
            X12DateFormat dateFormat = default;
            X12TimeFormat timeFormat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetNamespace"u8))
                {
                    targetNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocolVersion"u8))
                {
                    protocolVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("responsibleAgencyCode"u8))
                {
                    responsibleAgencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("headerVersion"u8))
                {
                    headerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderApplicationId"u8))
                {
                    senderApplicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receiverApplicationId"u8))
                {
                    receiverApplicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("functionalIdentifierCode"u8))
                {
                    functionalIdentifierCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dateFormat"u8))
                {
                    dateFormat = new X12DateFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeFormat"u8))
                {
                    timeFormat = new X12TimeFormat(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new X12EnvelopeOverride(
                targetNamespace,
                protocolVersion,
                messageId,
                responsibleAgencyCode,
                headerVersion,
                senderApplicationId,
                receiverApplicationId,
                functionalIdentifierCode,
                dateFormat,
                timeFormat,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<X12EnvelopeOverride>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12EnvelopeOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(X12EnvelopeOverride)} does not support writing '{options.Format}' format.");
            }
        }

        X12EnvelopeOverride IPersistableModel<X12EnvelopeOverride>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12EnvelopeOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeX12EnvelopeOverride(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(X12EnvelopeOverride)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<X12EnvelopeOverride>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
