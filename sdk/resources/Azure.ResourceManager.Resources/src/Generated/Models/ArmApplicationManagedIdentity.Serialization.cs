// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmApplicationManagedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ArmApplicationManagedIdentityType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ArmApplicationManagedIdentityType.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities");
                writer.WriteStartObject();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ArmApplicationManagedIdentity DeserializeArmApplicationManagedIdentity(JsonElement element)
        {
            Optional<Guid> principalId = default;
            Optional<Guid> tenantId = default;
            Optional<ArmApplicationManagedIdentityType> type = default;
            Optional<IDictionary<string, ArmApplicationUserAssignedIdentity>> userAssignedIdentities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.GetString().ToArmApplicationManagedIdentityType();
                    continue;
                }
                if (property.NameEquals("userAssignedIdentities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ArmApplicationUserAssignedIdentity> dictionary = new Dictionary<string, ArmApplicationUserAssignedIdentity>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ArmApplicationUserAssignedIdentity.DeserializeArmApplicationUserAssignedIdentity(property0.Value));
                    }
                    userAssignedIdentities = dictionary;
                    continue;
                }
            }
            return new ArmApplicationManagedIdentity(Optional.ToNullable(principalId), Optional.ToNullable(tenantId), Optional.ToNullable(type), Optional.ToDictionary(userAssignedIdentities));
        }
    }
}
