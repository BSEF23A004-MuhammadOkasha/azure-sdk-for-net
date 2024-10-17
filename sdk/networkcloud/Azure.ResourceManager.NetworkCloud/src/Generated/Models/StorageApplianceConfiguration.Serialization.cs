// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class StorageApplianceConfiguration : IUtf8JsonSerializable, IJsonModel<StorageApplianceConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageApplianceConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageApplianceConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageApplianceConfiguration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("adminCredentials"u8);
            writer.WriteObjectValue(AdminCredentials, options);
            writer.WritePropertyName("rackSlot"u8);
            writer.WriteNumberValue(RackSlot);
            writer.WritePropertyName("serialNumber"u8);
            writer.WriteStringValue(SerialNumber);
            if (Optional.IsDefined(StorageApplianceName))
            {
                writer.WritePropertyName("storageApplianceName"u8);
                writer.WriteStringValue(StorageApplianceName);
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

        StorageApplianceConfiguration IJsonModel<StorageApplianceConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageApplianceConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageApplianceConfiguration(document.RootElement, options);
        }

        internal static StorageApplianceConfiguration DeserializeStorageApplianceConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AdministrativeCredentials adminCredentials = default;
            long rackSlot = default;
            string serialNumber = default;
            string storageApplianceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminCredentials"u8))
                {
                    adminCredentials = AdministrativeCredentials.DeserializeAdministrativeCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rackSlot"u8))
                {
                    rackSlot = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageApplianceName"u8))
                {
                    storageApplianceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageApplianceConfiguration(adminCredentials, rackSlot, serialNumber, storageApplianceName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageApplianceConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageApplianceConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        StorageApplianceConfiguration IPersistableModel<StorageApplianceConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageApplianceConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageApplianceConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageApplianceConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
