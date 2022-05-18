// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class OriginGroupOverrideActionDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName");
            writer.WriteStringValue(TypeDefinition.ToString());
            writer.WritePropertyName("originGroup");
            JsonSerializer.Serialize(writer, OriginGroup); writer.WriteEndObject();
        }

        internal static OriginGroupOverrideActionDefinition DeserializeOriginGroupOverrideActionDefinition(JsonElement element)
        {
            OriginGroupOverrideActionType typeName = default;
            WritableSubResource originGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"))
                {
                    typeName = new OriginGroupOverrideActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("originGroup"))
                {
                    originGroup = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
            }
            return new OriginGroupOverrideActionDefinition(typeName, originGroup);
        }
    }
}
