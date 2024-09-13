// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IoTOperations.Models
{
    public partial class CertManagerCertificateSpec : IUtf8JsonSerializable, IJsonModel<CertManagerCertificateSpec>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CertManagerCertificateSpec>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CertManagerCertificateSpec>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertManagerCertificateSpec>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CertManagerCertificateSpec)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration);
            }
            if (Optional.IsDefined(SecretName))
            {
                writer.WritePropertyName("secretName"u8);
                writer.WriteStringValue(SecretName);
            }
            if (Optional.IsDefined(RenewBefore))
            {
                writer.WritePropertyName("renewBefore"u8);
                writer.WriteStringValue(RenewBefore);
            }
            writer.WritePropertyName("issuerRef"u8);
            writer.WriteObjectValue(IssuerRef, options);
            if (Optional.IsDefined(PrivateKey))
            {
                writer.WritePropertyName("privateKey"u8);
                writer.WriteObjectValue(PrivateKey, options);
            }
            if (Optional.IsDefined(San))
            {
                writer.WritePropertyName("san"u8);
                writer.WriteObjectValue(San, options);
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

        CertManagerCertificateSpec IJsonModel<CertManagerCertificateSpec>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertManagerCertificateSpec>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CertManagerCertificateSpec)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCertManagerCertificateSpec(document.RootElement, options);
        }

        internal static CertManagerCertificateSpec DeserializeCertManagerCertificateSpec(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string duration = default;
            string secretName = default;
            string renewBefore = default;
            CertManagerIssuerRef issuerRef = default;
            CertManagerPrivateKey privateKey = default;
            SanForCert san = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("duration"u8))
                {
                    duration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretName"u8))
                {
                    secretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("renewBefore"u8))
                {
                    renewBefore = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuerRef"u8))
                {
                    issuerRef = CertManagerIssuerRef.DeserializeCertManagerIssuerRef(property.Value, options);
                    continue;
                }
                if (property.NameEquals("privateKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateKey = CertManagerPrivateKey.DeserializeCertManagerPrivateKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("san"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    san = SanForCert.DeserializeSanForCert(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CertManagerCertificateSpec(
                duration,
                secretName,
                renewBefore,
                issuerRef,
                privateKey,
                san,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CertManagerCertificateSpec>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertManagerCertificateSpec>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CertManagerCertificateSpec)} does not support writing '{options.Format}' format.");
            }
        }

        CertManagerCertificateSpec IPersistableModel<CertManagerCertificateSpec>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertManagerCertificateSpec>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCertManagerCertificateSpec(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CertManagerCertificateSpec)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CertManagerCertificateSpec>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
