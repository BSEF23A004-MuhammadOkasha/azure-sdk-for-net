// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class DataSourceCredentialList
    {
        internal static DataSourceCredentialList DeserializeDataSourceCredentialList(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<DataSourceCredentialEntity>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataSourceCredentialEntity> array = new List<DataSourceCredentialEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataSourceCredentialEntity.DeserializeDataSourceCredentialEntity(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DataSourceCredentialList(nextLink.Value, Optional.ToList(value));
        }
    }
}
