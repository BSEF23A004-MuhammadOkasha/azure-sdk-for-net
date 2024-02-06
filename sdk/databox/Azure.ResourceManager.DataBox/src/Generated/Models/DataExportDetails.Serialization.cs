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
    public partial class DataExportDetails : IUtf8JsonSerializable, IJsonModel<DataExportDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataExportDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataExportDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataExportDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataExportDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("transferConfiguration"u8);
            BinaryData data = ModelReaderWriter.Write(TransferConfiguration, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
            using (JsonDocument document = JsonDocument.Parse(data))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            if (Optional.IsDefined(LogCollectionLevel))
            {
                writer.WritePropertyName("logCollectionLevel"u8);
                writer.WriteStringValue(LogCollectionLevel.Value.ToSerialString());
            }
            writer.WritePropertyName("accountDetails"u8);
            BinaryData data0 = ModelReaderWriter.Write(AccountDetails, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data0);
#else
            using (JsonDocument document = JsonDocument.Parse(data0))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
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

        DataExportDetails IJsonModel<DataExportDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataExportDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataExportDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataExportDetails(document.RootElement, options);
        }

        internal static DataExportDetails DeserializeDataExportDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TransferConfiguration transferConfiguration = default;
            Optional<LogCollectionLevel> logCollectionLevel = default;
            DataAccountDetails accountDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transferConfiguration"u8))
                {
                    transferConfiguration = TransferConfiguration.DeserializeTransferConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("logCollectionLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logCollectionLevel = property.Value.GetString().ToLogCollectionLevel();
                    continue;
                }
                if (property.NameEquals("accountDetails"u8))
                {
                    accountDetails = DataAccountDetails.DeserializeDataAccountDetails(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataExportDetails(transferConfiguration, Optional.ToNullable(logCollectionLevel), accountDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataExportDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataExportDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataExportDetails)} does not support '{options.Format}' format.");
            }
        }

        DataExportDetails IPersistableModel<DataExportDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataExportDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataExportDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataExportDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataExportDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
