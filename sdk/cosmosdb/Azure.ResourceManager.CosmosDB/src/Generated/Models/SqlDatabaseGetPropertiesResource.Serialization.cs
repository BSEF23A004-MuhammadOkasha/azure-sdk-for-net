// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class SqlDatabaseGetPropertiesResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Colls))
            {
                writer.WritePropertyName("_colls");
                writer.WriteStringValue(Colls);
            }
            if (Optional.IsDefined(Users))
            {
                writer.WritePropertyName("_users");
                writer.WriteStringValue(Users);
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WriteEndObject();
        }

        internal static SqlDatabaseGetPropertiesResource DeserializeSqlDatabaseGetPropertiesResource(JsonElement element)
        {
            Optional<string> Colls = default;
            Optional<string> Users = default;
            Optional<string> Rid = default;
            Optional<object> Ts = default;
            Optional<string> Etag = default;
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_colls"))
                {
                    Colls = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_users"))
                {
                    Users = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_rid"))
                {
                    Rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Ts = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("_etag"))
                {
                    Etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new SqlDatabaseGetPropertiesResource(id, Colls.Value, Users.Value, Rid.Value, Ts.Value, Etag.Value);
        }
    }
}
