// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class Role : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Db))
            {
                writer.WritePropertyName("db");
                writer.WriteStringValue(Db);
            }
            if (Optional.IsDefined(RoleValue))
            {
                writer.WritePropertyName("role");
                writer.WriteStringValue(RoleValue);
            }
            writer.WriteEndObject();
        }

        internal static Role DeserializeRole(JsonElement element)
        {
            Optional<string> db = default;
            Optional<string> role = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("db"))
                {
                    db = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"))
                {
                    role = property.Value.GetString();
                    continue;
                }
            }
            return new Role(db.Value, role.Value);
        }
    }
}
