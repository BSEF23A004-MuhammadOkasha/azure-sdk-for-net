// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    internal partial class PostgreSqlServerKeyListResult
    {
        internal static PostgreSqlServerKeyListResult DeserializePostgreSqlServerKeyListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PostgreSqlServerKeyData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PostgreSqlServerKeyData> array = new List<PostgreSqlServerKeyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlServerKeyData.DeserializePostgreSqlServerKeyData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PostgreSqlServerKeyListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
