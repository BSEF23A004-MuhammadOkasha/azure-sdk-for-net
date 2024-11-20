// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    public partial class UtteranceIntentsEvaluationResult : IUtf8JsonSerializable, IJsonModel<UtteranceIntentsEvaluationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UtteranceIntentsEvaluationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UtteranceIntentsEvaluationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UtteranceIntentsEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UtteranceIntentsEvaluationResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("expectedIntent"u8);
            writer.WriteStringValue(ExpectedIntent);
            writer.WritePropertyName("predictedIntent"u8);
            writer.WriteStringValue(PredictedIntent);
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

        UtteranceIntentsEvaluationResult IJsonModel<UtteranceIntentsEvaluationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UtteranceIntentsEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UtteranceIntentsEvaluationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUtteranceIntentsEvaluationResult(document.RootElement, options);
        }

        internal static UtteranceIntentsEvaluationResult DeserializeUtteranceIntentsEvaluationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string expectedIntent = default;
            string predictedIntent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expectedIntent"u8))
                {
                    expectedIntent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("predictedIntent"u8))
                {
                    predictedIntent = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UtteranceIntentsEvaluationResult(expectedIntent, predictedIntent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UtteranceIntentsEvaluationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UtteranceIntentsEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UtteranceIntentsEvaluationResult)} does not support writing '{options.Format}' format.");
            }
        }

        UtteranceIntentsEvaluationResult IPersistableModel<UtteranceIntentsEvaluationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UtteranceIntentsEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUtteranceIntentsEvaluationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UtteranceIntentsEvaluationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UtteranceIntentsEvaluationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UtteranceIntentsEvaluationResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUtteranceIntentsEvaluationResult(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
