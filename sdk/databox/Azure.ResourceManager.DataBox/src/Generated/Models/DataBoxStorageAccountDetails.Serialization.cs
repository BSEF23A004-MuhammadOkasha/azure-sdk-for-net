// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxStorageAccountDetails : IUtf8JsonSerializable, IJsonModel<DataBoxStorageAccountDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxStorageAccountDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxStorageAccountDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxStorageAccountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataBoxStorageAccountDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storageAccountId"u8);
            writer.WriteStringValue(StorageAccountId);
            writer.WritePropertyName("dataAccountType"u8);
            writer.WriteStringValue(DataAccountType.ToSerialString());
            if (Optional.IsDefined(SharePassword))
            {
                writer.WritePropertyName("sharePassword"u8);
                writer.WriteStringValue(SharePassword);
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

        DataBoxStorageAccountDetails IJsonModel<DataBoxStorageAccountDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxStorageAccountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataBoxStorageAccountDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxStorageAccountDetails(document.RootElement, options);
        }

        internal static DataBoxStorageAccountDetails DeserializeDataBoxStorageAccountDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier storageAccountId = default;
            DataAccountType dataAccountType = default;
            Optional<string> sharePassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountId"u8))
                {
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataAccountType"u8))
                {
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("sharePassword"u8))
                {
                    sharePassword = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxStorageAccountDetails(dataAccountType, sharePassword.Value, serializedAdditionalRawData, storageAccountId);
        }

        BinaryData IPersistableModel<DataBoxStorageAccountDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxStorageAccountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DataBoxStorageAccountDetails)} does not support '{options.Format}' format.");
            }
        }

        DataBoxStorageAccountDetails IPersistableModel<DataBoxStorageAccountDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxStorageAccountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxStorageAccountDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DataBoxStorageAccountDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxStorageAccountDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
