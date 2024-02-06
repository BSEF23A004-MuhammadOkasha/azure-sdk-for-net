// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class UnknownValidationRequest : IUtf8JsonSerializable, IJsonModel<DataBoxValidationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxValidationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxValidationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxValidationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("validationCategory"u8);
            writer.WriteStringValue(ValidationCategory.ToString());
            writer.WritePropertyName("individualRequestDetails"u8);
            writer.WriteStartArray();
            foreach (var item in IndividualRequestDetails)
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

        DataBoxValidationContent IJsonModel<DataBoxValidationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxValidationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownValidationRequest(document.RootElement, options);
        }

        internal static UnknownValidationRequest DeserializeUnknownValidationRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxValidationCategory validationCategory = "Unknown";
            IList<DataBoxValidationInputContent> individualRequestDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationCategory"u8))
                {
                    validationCategory = new DataBoxValidationCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("individualRequestDetails"u8))
                {
                    List<DataBoxValidationInputContent> array = new List<DataBoxValidationInputContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxValidationInputContent.DeserializeDataBoxValidationInputContent(item));
                    }
                    individualRequestDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownValidationRequest(validationCategory, individualRequestDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxValidationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxValidationContent)} does not support '{options.Format}' format.");
            }
        }

        DataBoxValidationContent IPersistableModel<DataBoxValidationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownValidationRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxValidationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxValidationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
