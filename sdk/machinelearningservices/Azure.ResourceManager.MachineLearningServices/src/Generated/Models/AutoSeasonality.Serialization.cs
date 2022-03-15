// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal partial class AutoSeasonality : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("mode");
            writer.WriteStringValue(Mode.ToString());
            writer.WriteEndObject();
        }

        internal static AutoSeasonality DeserializeAutoSeasonality(JsonElement element)
        {
            SeasonalityMode mode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"))
                {
                    mode = new SeasonalityMode(property.Value.GetString());
                    continue;
                }
            }
            return new AutoSeasonality(mode);
        }
    }
}
