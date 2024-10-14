// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    public partial class InformaticaNetworkInterfaceConfigurationUpdate : IUtf8JsonSerializable, IJsonModel<InformaticaNetworkInterfaceConfigurationUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InformaticaNetworkInterfaceConfigurationUpdate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InformaticaNetworkInterfaceConfigurationUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaNetworkInterfaceConfigurationUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformaticaNetworkInterfaceConfigurationUpdate)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(VnetId))
            {
                writer.WritePropertyName("vnetId"u8);
                writer.WriteStringValue(VnetId);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(VnetResourceGuid))
            {
                writer.WritePropertyName("vnetResourceGuid"u8);
                writer.WriteStringValue(VnetResourceGuid);
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

        InformaticaNetworkInterfaceConfigurationUpdate IJsonModel<InformaticaNetworkInterfaceConfigurationUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaNetworkInterfaceConfigurationUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformaticaNetworkInterfaceConfigurationUpdate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInformaticaNetworkInterfaceConfigurationUpdate(document.RootElement, options);
        }

        internal static InformaticaNetworkInterfaceConfigurationUpdate DeserializeInformaticaNetworkInterfaceConfigurationUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vnetId = default;
            ResourceIdentifier subnetId = default;
            string vnetResourceGuid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vnetResourceGuid"u8))
                {
                    vnetResourceGuid = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InformaticaNetworkInterfaceConfigurationUpdate(vnetId, subnetId, vnetResourceGuid, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InformaticaNetworkInterfaceConfigurationUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaNetworkInterfaceConfigurationUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InformaticaNetworkInterfaceConfigurationUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        InformaticaNetworkInterfaceConfigurationUpdate IPersistableModel<InformaticaNetworkInterfaceConfigurationUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaNetworkInterfaceConfigurationUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInformaticaNetworkInterfaceConfigurationUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InformaticaNetworkInterfaceConfigurationUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InformaticaNetworkInterfaceConfigurationUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
