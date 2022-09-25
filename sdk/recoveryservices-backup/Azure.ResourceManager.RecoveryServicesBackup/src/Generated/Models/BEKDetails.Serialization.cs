// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BEKDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SecretUri))
            {
                writer.WritePropertyName("secretUrl");
                writer.WriteStringValue(SecretUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SecretVaultId))
            {
                writer.WritePropertyName("secretVaultId");
                writer.WriteStringValue(SecretVaultId);
            }
            if (Optional.IsDefined(SecretData))
            {
                writer.WritePropertyName("secretData");
                writer.WriteStringValue(SecretData);
            }
            writer.WriteEndObject();
        }

        internal static BEKDetails DeserializeBEKDetails(JsonElement element)
        {
            Optional<Uri> secretUrl = default;
            Optional<string> secretVaultId = default;
            Optional<string> secretData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secretUrl = null;
                        continue;
                    }
                    secretUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secretVaultId"))
                {
                    secretVaultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretData"))
                {
                    secretData = property.Value.GetString();
                    continue;
                }
            }
            return new BEKDetails(secretUrl.Value, secretVaultId.Value, secretData.Value);
        }
    }
}
