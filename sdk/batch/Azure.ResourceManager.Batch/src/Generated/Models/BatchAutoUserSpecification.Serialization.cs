// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAutoUserSpecification : IUtf8JsonSerializable, IJsonModel<BatchAutoUserSpecification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAutoUserSpecification>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchAutoUserSpecification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAutoUserSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAutoUserSpecification)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope.Value.ToSerialString());
            }
            if (Optional.IsDefined(ElevationLevel))
            {
                writer.WritePropertyName("elevationLevel"u8);
                writer.WriteStringValue(ElevationLevel.Value.ToSerialString());
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
        }

        BatchAutoUserSpecification IJsonModel<BatchAutoUserSpecification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAutoUserSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAutoUserSpecification)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAutoUserSpecification(document.RootElement, options);
        }

        internal static BatchAutoUserSpecification DeserializeBatchAutoUserSpecification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchAutoUserScope? scope = default;
            BatchUserAccountElevationLevel? elevationLevel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = property.Value.GetString().ToBatchAutoUserScope();
                    continue;
                }
                if (property.NameEquals("elevationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elevationLevel = property.Value.GetString().ToBatchUserAccountElevationLevel();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchAutoUserSpecification(scope, elevationLevel, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAutoUserSpecification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAutoUserSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchAutoUserSpecification)} does not support writing '{options.Format}' format.");
            }
        }

        BatchAutoUserSpecification IPersistableModel<BatchAutoUserSpecification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAutoUserSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAutoUserSpecification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchAutoUserSpecification)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAutoUserSpecification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
