// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ArmApplicationManagementPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ArmApplicationManagementPolicy DeserializeArmApplicationManagementPolicy(JsonElement element)
        {
            Optional<ArmApplicationManagementMode> mode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = new ArmApplicationManagementMode(property.Value.GetString());
                    continue;
                }
            }
            return new ArmApplicationManagementPolicy(Optional.ToNullable(mode));
        }
    }
}
