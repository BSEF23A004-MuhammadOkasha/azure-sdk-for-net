// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ConfigServerSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GitProperty))
            {
                writer.WritePropertyName("gitProperty");
                writer.WriteObjectValue(GitProperty);
            }
            writer.WriteEndObject();
        }

        internal static ConfigServerSettings DeserializeConfigServerSettings(JsonElement element)
        {
            Optional<ConfigServerGitProperty> gitProperty = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gitProperty"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    gitProperty = ConfigServerGitProperty.DeserializeConfigServerGitProperty(property.Value);
                    continue;
                }
            }
            return new ConfigServerSettings(gitProperty.Value);
        }
    }
}
