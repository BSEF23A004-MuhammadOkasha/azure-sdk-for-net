// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class AfdCustomDomainUpdatePropertiesParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TlsSettings))
            {
                writer.WritePropertyName("tlsSettings");
                writer.WriteObjectValue(TlsSettings);
            }
            if (Optional.IsDefined(AzureDnsZone))
            {
                writer.WritePropertyName("azureDnsZone");
                JsonSerializer.Serialize(writer, AzureDnsZone);
            }
            writer.WriteEndObject();
        }
    }
}
