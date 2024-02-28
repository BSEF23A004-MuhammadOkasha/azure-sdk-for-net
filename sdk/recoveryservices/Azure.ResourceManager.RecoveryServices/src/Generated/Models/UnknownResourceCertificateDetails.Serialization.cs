// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    internal partial class UnknownResourceCertificateDetails : IUtf8JsonSerializable, IJsonModel<ResourceCertificateDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceCertificateDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceCertificateDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceCertificateDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceCertificateDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType);
            if (Certificate != null)
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteBase64StringValue(Certificate, "D");
            }
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Issuer != null)
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (ResourceId.HasValue)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteNumberValue(ResourceId.Value);
            }
            if (Subject != null)
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (Thumbprint != null)
            {
                writer.WritePropertyName("thumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Thumbprint);
#else
                using (JsonDocument document = JsonDocument.Parse(Thumbprint))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (ValidStartOn.HasValue)
            {
                writer.WritePropertyName("validFrom"u8);
                writer.WriteStringValue(ValidStartOn.Value, "O");
            }
            if (ValidEndOn.HasValue)
            {
                writer.WritePropertyName("validTo"u8);
                writer.WriteStringValue(ValidEndOn.Value, "O");
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

        ResourceCertificateDetails IJsonModel<ResourceCertificateDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceCertificateDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceCertificateDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceCertificateDetails(document.RootElement, options);
        }

        internal static UnknownResourceCertificateDetails DeserializeUnknownResourceCertificateDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string authType = "Unknown";
            byte[] certificate = default;
            string friendlyName = default;
            string issuer = default;
            long? resourceId = default;
            string subject = default;
            BinaryData thumbprint = default;
            DateTimeOffset? validFrom = default;
            DateTimeOffset? validTo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authType"u8))
                {
                    authType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificate = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("validFrom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("validTo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validTo = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownResourceCertificateDetails(
                authType,
                certificate,
                friendlyName,
                issuer,
                resourceId,
                subject,
                thumbprint,
                validFrom,
                validTo,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceCertificateDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceCertificateDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceCertificateDetails)} does not support '{options.Format}' format.");
            }
        }

        ResourceCertificateDetails IPersistableModel<ResourceCertificateDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceCertificateDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceCertificateDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceCertificateDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceCertificateDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
