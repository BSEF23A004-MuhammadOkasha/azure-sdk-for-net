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
    internal partial class TransferConfigurationTransferAllDetails : IUtf8JsonSerializable, IJsonModel<TransferConfigurationTransferAllDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransferConfigurationTransferAllDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TransferConfigurationTransferAllDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfigurationTransferAllDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferConfigurationTransferAllDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Include != null)
            {
                writer.WritePropertyName("include"u8);
                writer.WriteObjectValue(Include);
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

        TransferConfigurationTransferAllDetails IJsonModel<TransferConfigurationTransferAllDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfigurationTransferAllDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferConfigurationTransferAllDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferConfigurationTransferAllDetails(document.RootElement, options);
        }

        internal static TransferConfigurationTransferAllDetails DeserializeTransferConfigurationTransferAllDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TransferAllDetails include = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("include"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    include = TransferAllDetails.DeserializeTransferAllDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TransferConfigurationTransferAllDetails(include, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TransferConfigurationTransferAllDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfigurationTransferAllDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TransferConfigurationTransferAllDetails)} does not support '{options.Format}' format.");
            }
        }

        TransferConfigurationTransferAllDetails IPersistableModel<TransferConfigurationTransferAllDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfigurationTransferAllDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTransferConfigurationTransferAllDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TransferConfigurationTransferAllDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TransferConfigurationTransferAllDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
