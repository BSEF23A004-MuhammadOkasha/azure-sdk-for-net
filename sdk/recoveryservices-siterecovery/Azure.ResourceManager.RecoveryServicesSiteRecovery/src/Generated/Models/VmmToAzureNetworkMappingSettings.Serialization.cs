// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VmmToAzureNetworkMappingSettings : IUtf8JsonSerializable, IJsonModel<VmmToAzureNetworkMappingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmmToAzureNetworkMappingSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VmmToAzureNetworkMappingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmToAzureNetworkMappingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmmToAzureNetworkMappingSettings)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        VmmToAzureNetworkMappingSettings IJsonModel<VmmToAzureNetworkMappingSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmToAzureNetworkMappingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmmToAzureNetworkMappingSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmmToAzureNetworkMappingSettings(document.RootElement, options);
        }

        internal static VmmToAzureNetworkMappingSettings DeserializeVmmToAzureNetworkMappingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VmmToAzureNetworkMappingSettings(instanceType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VmmToAzureNetworkMappingSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmToAzureNetworkMappingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmmToAzureNetworkMappingSettings)} does not support writing '{options.Format}' format.");
            }
        }

        VmmToAzureNetworkMappingSettings IPersistableModel<VmmToAzureNetworkMappingSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmToAzureNetworkMappingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmmToAzureNetworkMappingSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmmToAzureNetworkMappingSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmmToAzureNetworkMappingSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
