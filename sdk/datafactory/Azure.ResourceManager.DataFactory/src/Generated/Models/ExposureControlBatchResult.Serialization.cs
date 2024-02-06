// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ExposureControlBatchResult : IUtf8JsonSerializable, IJsonModel<ExposureControlBatchResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExposureControlBatchResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExposureControlBatchResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExposureControlBatchResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExposureControlBatchResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("exposureControlResponses"u8);
            writer.WriteStartArray();
            foreach (var item in ExposureControlResults)
            {
                BinaryData data = ModelReaderWriter.Write(item, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndArray();
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

        ExposureControlBatchResult IJsonModel<ExposureControlBatchResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExposureControlBatchResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExposureControlBatchResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExposureControlBatchResult(document.RootElement, options);
        }

        internal static ExposureControlBatchResult DeserializeExposureControlBatchResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ExposureControlResult> exposureControlResponses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exposureControlResponses"u8))
                {
                    List<ExposureControlResult> array = new List<ExposureControlResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExposureControlResult.DeserializeExposureControlResult(item));
                    }
                    exposureControlResponses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExposureControlBatchResult(exposureControlResponses, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExposureControlBatchResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExposureControlBatchResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExposureControlBatchResult)} does not support '{options.Format}' format.");
            }
        }

        ExposureControlBatchResult IPersistableModel<ExposureControlBatchResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExposureControlBatchResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExposureControlBatchResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExposureControlBatchResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExposureControlBatchResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
