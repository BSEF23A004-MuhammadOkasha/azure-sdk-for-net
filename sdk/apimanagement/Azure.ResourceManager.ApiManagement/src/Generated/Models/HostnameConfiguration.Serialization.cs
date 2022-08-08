// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class HostnameConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(HostnameType.ToString());
            writer.WritePropertyName("hostName");
            writer.WriteStringValue(HostName);
            if (Optional.IsDefined(KeyVaultSecretUri))
            {
                writer.WritePropertyName("keyVaultId");
                writer.WriteStringValue(KeyVaultSecretUri.AbsoluteUri);
            }
            if (Optional.IsDefined(IdentityClientId))
            {
                writer.WritePropertyName("identityClientId");
                writer.WriteStringValue(IdentityClientId);
            }
            if (Optional.IsDefined(EncodedCertificate))
            {
                writer.WritePropertyName("encodedCertificate");
                writer.WriteStringValue(EncodedCertificate);
            }
            if (Optional.IsDefined(CertificatePassword))
            {
                writer.WritePropertyName("certificatePassword");
                writer.WriteStringValue(CertificatePassword);
            }
            if (Optional.IsDefined(EnableDefaultSslBinding))
            {
                writer.WritePropertyName("defaultSslBinding");
                writer.WriteBooleanValue(EnableDefaultSslBinding.Value);
            }
            if (Optional.IsDefined(EnableClientCertificateNegotiation))
            {
                writer.WritePropertyName("negotiateClientCertificate");
                writer.WriteBooleanValue(EnableClientCertificateNegotiation.Value);
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate");
                writer.WriteObjectValue(Certificate);
            }
            if (Optional.IsDefined(CertificateSource))
            {
                writer.WritePropertyName("certificateSource");
                writer.WriteStringValue(CertificateSource.Value.ToString());
            }
            if (Optional.IsDefined(CertificateStatus))
            {
                writer.WritePropertyName("certificateStatus");
                writer.WriteStringValue(CertificateStatus.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static HostnameConfiguration DeserializeHostnameConfiguration(JsonElement element)
        {
            HostnameType type = default;
            string hostName = default;
            Optional<Uri> keyVaultId = default;
            Optional<string> identityClientId = default;
            Optional<string> encodedCertificate = default;
            Optional<string> certificatePassword = default;
            Optional<bool> defaultSslBinding = default;
            Optional<bool> negotiateClientCertificate = default;
            Optional<CertificateInformation> certificate = default;
            Optional<CertificateSource> certificateSource = default;
            Optional<CertificateStatus> certificateStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new HostnameType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostName"))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyVaultId = null;
                        continue;
                    }
                    keyVaultId = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityClientId"))
                {
                    identityClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encodedCertificate"))
                {
                    encodedCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificatePassword"))
                {
                    certificatePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultSslBinding"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultSslBinding = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("negotiateClientCertificate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    negotiateClientCertificate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    certificate = CertificateInformation.DeserializeCertificateInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("certificateSource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    certificateSource = new CertificateSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certificateStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    certificateStatus = new CertificateStatus(property.Value.GetString());
                    continue;
                }
            }
            return new HostnameConfiguration(type, hostName, keyVaultId.Value, identityClientId.Value, encodedCertificate.Value, certificatePassword.Value, Optional.ToNullable(defaultSslBinding), Optional.ToNullable(negotiateClientCertificate), certificate.Value, Optional.ToNullable(certificateSource), Optional.ToNullable(certificateStatus));
        }
    }
}
