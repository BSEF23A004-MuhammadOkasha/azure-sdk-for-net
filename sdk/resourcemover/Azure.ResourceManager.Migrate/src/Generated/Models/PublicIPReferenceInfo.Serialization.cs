// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    internal partial class PublicIPReferenceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceArmResourceId");
            writer.WriteStringValue(SourceArmResourceId);
            writer.WriteEndObject();
        }

        internal static PublicIPReferenceInfo DeserializePublicIPReferenceInfo(JsonElement element)
        {
            ResourceIdentifier sourceArmResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceArmResourceId"))
                {
                    sourceArmResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new PublicIPReferenceInfo(sourceArmResourceId);
        }
    }
}
