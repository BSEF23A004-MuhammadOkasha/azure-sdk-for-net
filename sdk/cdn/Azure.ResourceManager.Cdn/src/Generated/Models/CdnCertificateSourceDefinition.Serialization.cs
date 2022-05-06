// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnCertificateSourceDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName");
            writer.WriteStringValue(TypeDefinition.ToString());
            writer.WritePropertyName("certificateType");
            writer.WriteStringValue(CertificateType.ToString());
            writer.WriteEndObject();
        }

        internal static CdnCertificateSourceDefinition DeserializeCdnCertificateSourceDefinition(JsonElement element)
        {
            CdnCertificateSourceType typeName = default;
            CdnManagedCertificateType certificateType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"))
                {
                    typeName = new CdnCertificateSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certificateType"))
                {
                    certificateType = new CdnManagedCertificateType(property.Value.GetString());
                    continue;
                }
            }
            return new CdnCertificateSourceDefinition(typeName, certificateType);
        }
    }
}
