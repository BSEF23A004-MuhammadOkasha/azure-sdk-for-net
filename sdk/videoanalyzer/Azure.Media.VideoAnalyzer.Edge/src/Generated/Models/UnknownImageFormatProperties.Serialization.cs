// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    internal partial class UnknownImageFormatProperties
    {
        internal static UnknownImageFormatProperties DeserializeUnknownImageFormatProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownImageFormatProperties(type);
        }
    }
}
