// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class UpgradeOperationHistoricalStatusInfo : IUtf8JsonSerializable, IJsonModel<UpgradeOperationHistoricalStatusInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpgradeOperationHistoricalStatusInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpgradeOperationHistoricalStatusInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradeOperationHistoricalStatusInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpgradeOperationHistoricalStatusInfo)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties, options);
            }
            if (options.Format != "W" && Optional.IsDefined(UpgradeOperationHistoricalStatusInfoType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(UpgradeOperationHistoricalStatusInfoType);
            }
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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

        UpgradeOperationHistoricalStatusInfo IJsonModel<UpgradeOperationHistoricalStatusInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradeOperationHistoricalStatusInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpgradeOperationHistoricalStatusInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpgradeOperationHistoricalStatusInfo(document.RootElement, options);
        }

        internal static UpgradeOperationHistoricalStatusInfo DeserializeUpgradeOperationHistoricalStatusInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UpgradeOperationHistoricalStatusInfoProperties properties = default;
            string type = default;
            AzureLocation? location = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = UpgradeOperationHistoricalStatusInfoProperties.DeserializeUpgradeOperationHistoricalStatusInfoProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpgradeOperationHistoricalStatusInfo(properties, type, location, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpgradeOperationHistoricalStatusInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradeOperationHistoricalStatusInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpgradeOperationHistoricalStatusInfo)} does not support writing '{options.Format}' format.");
            }
        }

        UpgradeOperationHistoricalStatusInfo IPersistableModel<UpgradeOperationHistoricalStatusInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpgradeOperationHistoricalStatusInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpgradeOperationHistoricalStatusInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpgradeOperationHistoricalStatusInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpgradeOperationHistoricalStatusInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
