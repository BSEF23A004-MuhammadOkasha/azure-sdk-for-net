// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkFunction.Models
{
    public partial class EmissionPolicyDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DestinationType))
            {
                writer.WritePropertyName("destinationType");
                writer.WriteStringValue(DestinationType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static EmissionPolicyDestination DeserializeEmissionPolicyDestination(JsonElement element)
        {
            Optional<DestinationType> destinationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destinationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    destinationType = new DestinationType(property.Value.GetString());
                    continue;
                }
            }
            return new EmissionPolicyDestination(Optional.ToNullable(destinationType));
        }
    }
}
