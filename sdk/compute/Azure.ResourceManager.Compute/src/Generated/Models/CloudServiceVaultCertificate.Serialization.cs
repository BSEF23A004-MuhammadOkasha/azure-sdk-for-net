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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CloudServiceVaultCertificate : IUtf8JsonSerializable, IJsonModel<CloudServiceVaultCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudServiceVaultCertificate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudServiceVaultCertificate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceVaultCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CloudServiceVaultCertificate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateUri))
            {
                writer.WritePropertyName("certificateUrl"u8);
                writer.WriteStringValue(CertificateUri.AbsoluteUri);
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

        CloudServiceVaultCertificate IJsonModel<CloudServiceVaultCertificate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceVaultCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CloudServiceVaultCertificate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudServiceVaultCertificate(document.RootElement, options);
        }

        internal static CloudServiceVaultCertificate DeserializeCloudServiceVaultCertificate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> certificateUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudServiceVaultCertificate(certificateUrl.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudServiceVaultCertificate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceVaultCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CloudServiceVaultCertificate)} does not support '{options.Format}' format.");
            }
        }

        CloudServiceVaultCertificate IPersistableModel<CloudServiceVaultCertificate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceVaultCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudServiceVaultCertificate(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CloudServiceVaultCertificate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudServiceVaultCertificate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
