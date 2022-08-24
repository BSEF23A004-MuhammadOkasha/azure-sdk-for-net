// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class Endpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(EndpointValue))
            {
                writer.WritePropertyName("endpoint");
                writer.WriteStringValue(EndpointValue);
            }
            writer.WriteEndObject();
        }

        internal static Endpoint DeserializeEndpoint(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> endpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
            }
            return new Endpoint(name.Value, endpoint.Value);
        }
    }
}
