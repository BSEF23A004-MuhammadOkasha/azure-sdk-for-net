// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class DatabasePrincipalListResult
    {
        internal static DatabasePrincipalListResult DeserializeDatabasePrincipalListResult(JsonElement element)
        {
            Optional<IReadOnlyList<KustoDatabasePrincipal>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KustoDatabasePrincipal> array = new List<KustoDatabasePrincipal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoDatabasePrincipal.DeserializeKustoDatabasePrincipal(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DatabasePrincipalListResult(Optional.ToList(value));
        }
    }
}
