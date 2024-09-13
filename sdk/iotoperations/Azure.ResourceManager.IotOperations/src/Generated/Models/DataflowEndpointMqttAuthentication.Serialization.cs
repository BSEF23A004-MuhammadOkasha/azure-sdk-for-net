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
    public partial class DataflowEndpointMqttAuthentication : IUtf8JsonSerializable, IJsonModel<DataflowEndpointMqttAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataflowEndpointMqttAuthentication>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataflowEndpointMqttAuthentication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointMqttAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointMqttAuthentication)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("method"u8);
            writer.WriteStringValue(Method.ToString());
            if (Optional.IsDefined(SystemAssignedManagedIdentitySettings))
            {
                writer.WritePropertyName("systemAssignedManagedIdentitySettings"u8);
                writer.WriteObjectValue(SystemAssignedManagedIdentitySettings, options);
            }
            if (Optional.IsDefined(UserAssignedManagedIdentitySettings))
            {
                writer.WritePropertyName("userAssignedManagedIdentitySettings"u8);
                writer.WriteObjectValue(UserAssignedManagedIdentitySettings, options);
            }
            if (Optional.IsDefined(ServiceAccountTokenSettings))
            {
                writer.WritePropertyName("serviceAccountTokenSettings"u8);
                writer.WriteObjectValue(ServiceAccountTokenSettings, options);
            }
            if (Optional.IsDefined(X509CertificateSettings))
            {
                writer.WritePropertyName("x509CertificateSettings"u8);
                writer.WriteObjectValue(X509CertificateSettings, options);
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

        DataflowEndpointMqttAuthentication IJsonModel<DataflowEndpointMqttAuthentication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointMqttAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataflowEndpointMqttAuthentication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataflowEndpointMqttAuthentication(document.RootElement, options);
        }

        internal static DataflowEndpointMqttAuthentication DeserializeDataflowEndpointMqttAuthentication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MqttAuthMethod method = default;
            DataflowEndpointAuthenticationSystemAssignedManagedIdentity systemAssignedManagedIdentitySettings = default;
            DataflowEndpointAuthenticationUserAssignedManagedIdentity userAssignedManagedIdentitySettings = default;
            DataflowEndpointAuthenticationServiceAccountToken serviceAccountTokenSettings = default;
            DataflowEndpointAuthenticationX509 x509CertificateSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("method"u8))
                {
                    method = new MqttAuthMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemAssignedManagedIdentitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemAssignedManagedIdentitySettings = DataflowEndpointAuthenticationSystemAssignedManagedIdentity.DeserializeDataflowEndpointAuthenticationSystemAssignedManagedIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userAssignedManagedIdentitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedManagedIdentitySettings = DataflowEndpointAuthenticationUserAssignedManagedIdentity.DeserializeDataflowEndpointAuthenticationUserAssignedManagedIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serviceAccountTokenSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceAccountTokenSettings = DataflowEndpointAuthenticationServiceAccountToken.DeserializeDataflowEndpointAuthenticationServiceAccountToken(property.Value, options);
                    continue;
                }
                if (property.NameEquals("x509CertificateSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509CertificateSettings = DataflowEndpointAuthenticationX509.DeserializeDataflowEndpointAuthenticationX509(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataflowEndpointMqttAuthentication(
                method,
                systemAssignedManagedIdentitySettings,
                userAssignedManagedIdentitySettings,
                serviceAccountTokenSettings,
                x509CertificateSettings,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataflowEndpointMqttAuthentication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointMqttAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointMqttAuthentication)} does not support writing '{options.Format}' format.");
            }
        }

        DataflowEndpointMqttAuthentication IPersistableModel<DataflowEndpointMqttAuthentication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataflowEndpointMqttAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataflowEndpointMqttAuthentication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataflowEndpointMqttAuthentication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataflowEndpointMqttAuthentication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
