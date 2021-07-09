// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault
{
    public partial class DimensionProperties
    {
        internal static DimensionProperties DeserializeDimensionProperties(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<bool> toBeExportedForShoebox = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("toBeExportedForShoebox"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    toBeExportedForShoebox = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DimensionProperties(name.Value, displayName.Value, Optional.ToNullable(toBeExportedForShoebox));
        }
    }
}
