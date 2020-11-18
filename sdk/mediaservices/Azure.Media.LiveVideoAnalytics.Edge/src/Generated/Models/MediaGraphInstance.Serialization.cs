// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    public partial class MediaGraphInstance : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData");
                writer.WriteObjectValue(SystemData);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            writer.WriteEndObject();
        }

        internal static MediaGraphInstance DeserializeMediaGraphInstance(JsonElement element)
        {
            string name = default;
            Optional<MediaGraphSystemData> systemData = default;
            Optional<MediaGraphInstanceProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = MediaGraphSystemData.DeserializeMediaGraphSystemData(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    properties = MediaGraphInstanceProperties.DeserializeMediaGraphInstanceProperties(property.Value);
                    continue;
                }
            }
            return new MediaGraphInstance(name, systemData.Value, properties.Value);
        }
    }
}
