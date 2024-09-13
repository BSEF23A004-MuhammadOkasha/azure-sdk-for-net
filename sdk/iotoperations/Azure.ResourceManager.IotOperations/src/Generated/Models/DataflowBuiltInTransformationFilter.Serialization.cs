// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IoTOperations.Models
{
    public partial class DataflowBuiltInTransformationFilter : IUtf8JsonSerializable, IJsonModel<DataflowBuiltInTransformationFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataflowBuiltInTransformationFilter>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataflowBuiltInTransformationFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowBuiltInTransformationFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowBuiltInTransformationFilter)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("expression"u8);
            writer.WriteStringValue(Expression);
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

        DataflowBuiltInTransformationFilter IJsonModel<DataflowBuiltInTransformationFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowBuiltInTransformationFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowBuiltInTransformationFilter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataflowBuiltInTransformationFilter(document.RootElement, options);
        }

        internal static DataflowBuiltInTransformationFilter DeserializeDataflowBuiltInTransformationFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FilterType? type = default;
            string description = default;
            IList<string> inputs = default;
            string expression = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new FilterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataflowBuiltInTransformationFilter(type, description, inputs, expression, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataflowBuiltInTransformationFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowBuiltInTransformationFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataflowBuiltInTransformationFilter)} does not support writing '{options.Format}' format.");
            }
        }

        DataflowBuiltInTransformationFilter IPersistableModel<DataflowBuiltInTransformationFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowBuiltInTransformationFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataflowBuiltInTransformationFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataflowBuiltInTransformationFilter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataflowBuiltInTransformationFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
