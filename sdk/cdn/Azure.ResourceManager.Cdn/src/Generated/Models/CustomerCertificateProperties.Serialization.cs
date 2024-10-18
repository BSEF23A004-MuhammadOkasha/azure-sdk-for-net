// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CustomerCertificateProperties : IUtf8JsonSerializable, IJsonModel<CustomerCertificateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomerCertificateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomerCertificateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomerCertificateProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("secretSource"u8);
            JsonSerializer.Serialize(writer, SecretSource);
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion"u8);
                writer.WriteStringValue(SecretVersion);
            }
            if (Optional.IsDefined(UseLatestVersion))
            {
                writer.WritePropertyName("useLatestVersion"u8);
                writer.WriteBooleanValue(UseLatestVersion.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpiresOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpiresOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CertificateAuthority))
            {
                writer.WritePropertyName("certificateAuthority"u8);
                writer.WriteStringValue(CertificateAuthority);
            }
            if (Optional.IsCollectionDefined(SubjectAlternativeNames))
            {
                writer.WritePropertyName("subjectAlternativeNames"u8);
                writer.WriteStartArray();
                foreach (var item in SubjectAlternativeNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
            }
        }

        CustomerCertificateProperties IJsonModel<CustomerCertificateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomerCertificateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomerCertificateProperties(document.RootElement, options);
        }

        internal static CustomerCertificateProperties DeserializeCustomerCertificateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource secretSource = default;
            string secretVersion = default;
            bool? useLatestVersion = default;
            string subject = default;
            DateTimeOffset? expirationDate = default;
            string certificateAuthority = default;
            IList<string> subjectAlternativeNames = default;
            string thumbprint = default;
            SecretType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretSource"u8))
                {
                    secretSource = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("secretVersion"u8))
                {
                    secretVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useLatestVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useLatestVersion = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("certificateAuthority"u8))
                {
                    certificateAuthority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subjectAlternativeNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    subjectAlternativeNames = array;
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SecretType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CustomerCertificateProperties(
                type,
                serializedAdditionalRawData,
                secretSource,
                secretVersion,
                useLatestVersion,
                subject,
                expirationDate,
                certificateAuthority,
                subjectAlternativeNames ?? new ChangeTrackingList<string>(),
                thumbprint);
        }

        BinaryData IPersistableModel<CustomerCertificateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomerCertificateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CustomerCertificateProperties IPersistableModel<CustomerCertificateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomerCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomerCertificateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomerCertificateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomerCertificateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
