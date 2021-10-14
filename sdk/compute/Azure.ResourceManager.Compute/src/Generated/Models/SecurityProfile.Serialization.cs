// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SecurityProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UefiSettings))
            {
                writer.WritePropertyName("uefiSettings");
                writer.WriteObjectValue(UefiSettings);
            }
            if (Optional.IsDefined(EncryptionAtHost))
            {
                writer.WritePropertyName("encryptionAtHost");
                writer.WriteBooleanValue(EncryptionAtHost.Value);
            }
            if (Optional.IsDefined(SecurityType))
            {
                writer.WritePropertyName("securityType");
                writer.WriteStringValue(SecurityType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SecurityProfile DeserializeSecurityProfile(JsonElement element)
        {
            Optional<UefiSettings> uefiSettings = default;
            Optional<bool> encryptionAtHost = default;
            Optional<SecurityTypes> securityType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uefiSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    uefiSettings = UefiSettings.DeserializeUefiSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("encryptionAtHost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encryptionAtHost = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("securityType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    securityType = new SecurityTypes(property.Value.GetString());
                    continue;
                }
            }
            return new SecurityProfile(uefiSettings.Value, Optional.ToNullable(encryptionAtHost), Optional.ToNullable(securityType));
        }
    }
}
