// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class WaitTimeExceptionTrigger : IUtf8JsonSerializable, IJsonModel<WaitTimeExceptionTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WaitTimeExceptionTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WaitTimeExceptionTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WaitTimeExceptionTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(WaitTimeExceptionTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("thresholdSeconds"u8);
            writer.WriteNumberValue(_thresholdSeconds);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        WaitTimeExceptionTrigger IJsonModel<WaitTimeExceptionTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WaitTimeExceptionTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(WaitTimeExceptionTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWaitTimeExceptionTrigger(document.RootElement, options);
        }

        internal static WaitTimeExceptionTrigger DeserializeWaitTimeExceptionTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double thresholdSeconds = default;
            ExceptionTriggerKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("thresholdSeconds"u8))
                {
                    thresholdSeconds = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ExceptionTriggerKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WaitTimeExceptionTrigger(kind, serializedAdditionalRawData, thresholdSeconds);
        }

        BinaryData IPersistableModel<WaitTimeExceptionTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WaitTimeExceptionTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(WaitTimeExceptionTrigger)} does not support '{options.Format}' format.");
            }
        }

        WaitTimeExceptionTrigger IPersistableModel<WaitTimeExceptionTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WaitTimeExceptionTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWaitTimeExceptionTrigger(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(WaitTimeExceptionTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WaitTimeExceptionTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WaitTimeExceptionTrigger FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWaitTimeExceptionTrigger(document.RootElement, new ModelReaderWriterOptions("W"));
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
