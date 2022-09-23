// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisEnterpriseDatabaseGeoReplication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GroupNickname))
            {
                writer.WritePropertyName("groupNickname");
                writer.WriteStringValue(GroupNickname);
            }
            if (Optional.IsCollectionDefined(LinkedDatabases))
            {
                writer.WritePropertyName("linkedDatabases");
                writer.WriteStartArray();
                foreach (var item in LinkedDatabases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RedisEnterpriseDatabaseGeoReplication DeserializeRedisEnterpriseDatabaseGeoReplication(JsonElement element)
        {
            Optional<string> groupNickname = default;
            Optional<IList<RedisEnterpriseLinkedDatabase>> linkedDatabases = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupNickname"))
                {
                    groupNickname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedDatabases"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RedisEnterpriseLinkedDatabase> array = new List<RedisEnterpriseLinkedDatabase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RedisEnterpriseLinkedDatabase.DeserializeRedisEnterpriseLinkedDatabase(item));
                    }
                    linkedDatabases = array;
                    continue;
                }
            }
            return new RedisEnterpriseDatabaseGeoReplication(groupNickname.Value, Optional.ToList(linkedDatabases));
        }
    }
}
