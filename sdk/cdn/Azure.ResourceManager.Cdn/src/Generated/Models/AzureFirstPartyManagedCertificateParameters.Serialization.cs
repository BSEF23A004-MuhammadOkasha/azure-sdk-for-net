// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class AzureFirstPartyManagedCertificateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(SecretType.ToString());
            writer.WriteEndObject();
        }

        internal static AzureFirstPartyManagedCertificateParameters DeserializeAzureFirstPartyManagedCertificateParameters(JsonElement element)
        {
            SecretType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new SecretType(property.Value.GetString());
                    continue;
                }
            }
            return new AzureFirstPartyManagedCertificateParameters(type);
        }
    }
}
