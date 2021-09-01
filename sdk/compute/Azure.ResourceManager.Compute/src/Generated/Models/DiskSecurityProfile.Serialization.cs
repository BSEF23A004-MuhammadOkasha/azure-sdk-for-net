// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DiskSecurityProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SecurityType))
            {
                writer.WritePropertyName("securityType");
                writer.WriteStringValue(SecurityType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DiskSecurityProfile DeserializeDiskSecurityProfile(JsonElement element)
        {
            Optional<DiskSecurityTypes> securityType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("securityType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    securityType = new DiskSecurityTypes(property.Value.GetString());
                    continue;
                }
            }
            return new DiskSecurityProfile(Optional.ToNullable(securityType));
        }
    }
}
