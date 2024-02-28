// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration
{
    public partial class KeyVaultRoleDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (RoleName != null)
            {
                writer.WritePropertyName("roleName"u8);
                writer.WriteStringValue(RoleName);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (RoleType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RoleType.Value.ToString());
            }
            if (!(Permissions is ChangeTrackingList<KeyVaultPermission> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStartArray();
                foreach (var item in Permissions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AssignableScopes is ChangeTrackingList<KeyVaultRoleScope> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("assignableScopes"u8);
                writer.WriteStartArray();
                foreach (var item in AssignableScopes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static KeyVaultRoleDefinition DeserializeKeyVaultRoleDefinition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            KeyVaultRoleDefinitionType? type = default;
            string roleName = default;
            string description = default;
            KeyVaultRoleType? type0 = default;
            IList<KeyVaultPermission> permissions = default;
            IList<KeyVaultRoleScope> assignableScopes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new KeyVaultRoleDefinitionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("roleName"u8))
                        {
                            roleName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new KeyVaultRoleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("permissions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KeyVaultPermission> array = new List<KeyVaultPermission>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KeyVaultPermission.DeserializeKeyVaultPermission(item));
                            }
                            permissions = array;
                            continue;
                        }
                        if (property0.NameEquals("assignableScopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KeyVaultRoleScope> array = new List<KeyVaultRoleScope>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new KeyVaultRoleScope(item.GetString()));
                            }
                            assignableScopes = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new KeyVaultRoleDefinition(
                id,
                name,
                type,
                roleName,
                description,
                type0,
                permissions ?? new ChangeTrackingList<KeyVaultPermission>(),
                assignableScopes ?? new ChangeTrackingList<KeyVaultRoleScope>());
        }
    }
}
