// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class DB2ProviderInstanceProperties : IUtf8JsonSerializable, IJsonModel<DB2ProviderInstanceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DB2ProviderInstanceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DB2ProviderInstanceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DB2ProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DB2ProviderInstanceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (Optional.IsDefined(DBName))
            {
                writer.WritePropertyName("dbName"u8);
                writer.WriteStringValue(DBName);
            }
            if (Optional.IsDefined(DBPort))
            {
                writer.WritePropertyName("dbPort"u8);
                writer.WriteStringValue(DBPort);
            }
            if (Optional.IsDefined(DBUsername))
            {
                writer.WritePropertyName("dbUsername"u8);
                writer.WriteStringValue(DBUsername);
            }
            if (Optional.IsDefined(DBPassword))
            {
                writer.WritePropertyName("dbPassword"u8);
                writer.WriteStringValue(DBPassword);
            }
            if (Optional.IsDefined(DBPasswordUri))
            {
                writer.WritePropertyName("dbPasswordUri"u8);
                writer.WriteStringValue(DBPasswordUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SapSid))
            {
                writer.WritePropertyName("sapSid"u8);
                writer.WriteStringValue(SapSid);
            }
            if (Optional.IsDefined(SslPreference))
            {
                writer.WritePropertyName("sslPreference"u8);
                writer.WriteStringValue(SslPreference.Value.ToString());
            }
            if (Optional.IsDefined(SslCertificateUri))
            {
                writer.WritePropertyName("sslCertificateUri"u8);
                writer.WriteStringValue(SslCertificateUri.AbsoluteUri);
            }
            writer.WritePropertyName("providerType"u8);
            writer.WriteStringValue(ProviderType);
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

        DB2ProviderInstanceProperties IJsonModel<DB2ProviderInstanceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DB2ProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DB2ProviderInstanceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDB2ProviderInstanceProperties(document.RootElement, options);
        }

        internal static DB2ProviderInstanceProperties DeserializeDB2ProviderInstanceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string hostname = default;
            string dbName = default;
            string dbPort = default;
            string dbUsername = default;
            string dbPassword = default;
            Uri dbPasswordUri = default;
            string sapSid = default;
            SapSslPreference? sslPreference = default;
            Uri sslCertificateUri = default;
            string providerType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbName"u8))
                {
                    dbName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPort"u8))
                {
                    dbPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbUsername"u8))
                {
                    dbUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPassword"u8))
                {
                    dbPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPasswordUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbPasswordUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sapSid"u8))
                {
                    sapSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslPreference = new SapSslPreference(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslCertificateUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertificateUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DB2ProviderInstanceProperties(
                providerType,
                serializedAdditionalRawData,
                hostname,
                dbName,
                dbPort,
                dbUsername,
                dbPassword,
                dbPasswordUri,
                sapSid,
                sslPreference,
                sslCertificateUri);
        }

        BinaryData IPersistableModel<DB2ProviderInstanceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DB2ProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DB2ProviderInstanceProperties)} does not support '{options.Format}' format.");
            }
        }

        DB2ProviderInstanceProperties IPersistableModel<DB2ProviderInstanceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DB2ProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDB2ProviderInstanceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DB2ProviderInstanceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DB2ProviderInstanceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
