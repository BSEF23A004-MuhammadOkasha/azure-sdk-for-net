// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class LookingGlassOutput
    {
        internal static LookingGlassOutput DeserializeLookingGlassOutput(JsonElement element)
        {
            Optional<LookingGlassCommand> command = default;
            Optional<string> output = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("command"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    command = new LookingGlassCommand(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("output"))
                {
                    output = property.Value.GetString();
                    continue;
                }
            }
            return new LookingGlassOutput(Optional.ToNullable(command), output.Value);
        }
    }
}
