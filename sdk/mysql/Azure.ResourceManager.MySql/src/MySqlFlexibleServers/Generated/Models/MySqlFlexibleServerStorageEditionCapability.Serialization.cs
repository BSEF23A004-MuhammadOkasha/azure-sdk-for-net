// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerStorageEditionCapability
    {
        internal static MySqlFlexibleServerStorageEditionCapability DeserializeMySqlFlexibleServerStorageEditionCapability(JsonElement element)
        {
            Optional<string> name = default;
            Optional<long> minStorageSize = default;
            Optional<long> maxStorageSize = default;
            Optional<long> minBackupRetentionDays = default;
            Optional<long> maxBackupRetentionDays = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minStorageSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minStorageSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxStorageSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxStorageSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minBackupRetentionDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minBackupRetentionDays = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxBackupRetentionDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxBackupRetentionDays = property.Value.GetInt64();
                    continue;
                }
            }
            return new MySqlFlexibleServerStorageEditionCapability(name.Value, Optional.ToNullable(minStorageSize), Optional.ToNullable(maxStorageSize), Optional.ToNullable(minBackupRetentionDays), Optional.ToNullable(maxBackupRetentionDays));
        }
    }
}
