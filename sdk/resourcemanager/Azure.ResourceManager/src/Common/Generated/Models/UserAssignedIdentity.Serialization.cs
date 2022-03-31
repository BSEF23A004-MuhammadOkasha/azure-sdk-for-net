// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(UserAssignedIdentityConverter))]
    public partial class UserAssignedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static UserAssignedIdentity DeserializeUserAssignedIdentity(JsonElement element)
        {
            Optional<Guid> principalId = default;
            Optional<Guid> clientId = default;
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
                if (property.NameEquals("clientId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clientId = property.Value.GetGuid();
                    continue;
                }
            }
            return new UserAssignedIdentity(Optional.ToNullable(principalId), Optional.ToNullable(clientId));
        }

        internal partial class UserAssignedIdentityConverter : JsonConverter<UserAssignedIdentity>
        {
            public override void Write(Utf8JsonWriter writer, UserAssignedIdentity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override UserAssignedIdentity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeUserAssignedIdentity(document.RootElement);
            }
        }
    }
}
