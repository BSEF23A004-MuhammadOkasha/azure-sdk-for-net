// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class KeyVaultAndKeyReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceVault");
            writer.WriteObjectValue(SourceVault);
            writer.WritePropertyName("keyUrl");
            writer.WriteStringValue(KeyUrl);
            writer.WriteEndObject();
        }

        internal static KeyVaultAndKeyReference DeserializeKeyVaultAndKeyReference(JsonElement element)
        {
            SourceVault sourceVault = default;
            string keyUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVault"))
                {
                    sourceVault = SourceVault.DeserializeSourceVault(property.Value);
                    continue;
                }
                if (property.NameEquals("keyUrl"))
                {
                    keyUrl = property.Value.GetString();
                    continue;
                }
            }
            return new KeyVaultAndKeyReference(sourceVault, keyUrl);
        }
    }
}
