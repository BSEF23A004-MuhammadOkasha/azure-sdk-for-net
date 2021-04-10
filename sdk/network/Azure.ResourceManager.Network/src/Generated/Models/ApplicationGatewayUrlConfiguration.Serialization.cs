// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayUrlConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ModifiedPath))
            {
                writer.WritePropertyName("modifiedPath");
                writer.WriteStringValue(ModifiedPath);
            }
            if (Optional.IsDefined(ModifiedQueryString))
            {
                writer.WritePropertyName("modifiedQueryString");
                writer.WriteStringValue(ModifiedQueryString);
            }
            if (Optional.IsDefined(Reroute))
            {
                writer.WritePropertyName("reroute");
                writer.WriteBooleanValue(Reroute.Value);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayUrlConfiguration DeserializeApplicationGatewayUrlConfiguration(JsonElement element)
        {
            Optional<string> modifiedPath = default;
            Optional<string> modifiedQueryString = default;
            Optional<bool> reroute = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modifiedPath"))
                {
                    modifiedPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedQueryString"))
                {
                    modifiedQueryString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reroute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reroute = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ApplicationGatewayUrlConfiguration(modifiedPath.Value, modifiedQueryString.Value, Optional.ToNullable(reroute));
        }
    }
}
