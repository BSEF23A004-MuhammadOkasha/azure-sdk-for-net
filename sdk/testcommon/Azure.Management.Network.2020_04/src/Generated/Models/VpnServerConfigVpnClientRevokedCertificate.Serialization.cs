// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VpnServerConfigVpnClientRevokedCertificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint");
                writer.WriteStringValue(Thumbprint);
            }
            writer.WriteEndObject();
        }

        internal static VpnServerConfigVpnClientRevokedCertificate DeserializeVpnServerConfigVpnClientRevokedCertificate(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> thumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
            }
            return new VpnServerConfigVpnClientRevokedCertificate(name.Value, thumbprint.Value);
        }
    }
}
