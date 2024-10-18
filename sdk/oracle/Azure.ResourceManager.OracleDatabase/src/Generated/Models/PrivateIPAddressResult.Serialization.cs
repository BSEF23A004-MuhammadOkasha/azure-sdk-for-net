// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class PrivateIPAddressResult : IUtf8JsonSerializable, IJsonModel<PrivateIPAddressResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateIPAddressResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateIPAddressResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateIPAddressResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateIPAddressResult)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("displayName"u8);
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("hostnameLabel"u8);
            writer.WriteStringValue(HostnameLabel);
            writer.WritePropertyName("ocid"u8);
            writer.WriteStringValue(Ocid);
            writer.WritePropertyName("ipAddress"u8);
            writer.WriteStringValue(IPAddress);
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
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

        PrivateIPAddressResult IJsonModel<PrivateIPAddressResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateIPAddressResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateIPAddressResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateIPAddressResult(document.RootElement, options);
        }

        internal static PrivateIPAddressResult DeserializePrivateIPAddressResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            string hostnameLabel = default;
            ResourceIdentifier ocid = default;
            string ipAddress = default;
            ResourceIdentifier subnetId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostnameLabel"u8))
                {
                    hostnameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ocid"u8))
                {
                    ocid = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PrivateIPAddressResult(
                displayName,
                hostnameLabel,
                ocid,
                ipAddress,
                subnetId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateIPAddressResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateIPAddressResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateIPAddressResult)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateIPAddressResult IPersistableModel<PrivateIPAddressResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateIPAddressResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateIPAddressResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateIPAddressResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateIPAddressResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
