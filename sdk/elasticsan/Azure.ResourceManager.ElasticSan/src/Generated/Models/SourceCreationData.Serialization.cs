// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class SourceCreationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("createSource");
            writer.WriteStringValue(CreateSource.ToSerialString());
            if (Optional.IsDefined(SourceUri))
            {
                writer.WritePropertyName("sourceUri");
                writer.WriteStringValue(SourceUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static SourceCreationData DeserializeSourceCreationData(JsonElement element)
        {
            VolumeCreateOption createSource = default;
            Optional<Uri> sourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createSource"))
                {
                    createSource = property.Value.GetString().ToVolumeCreateOption();
                    continue;
                }
                if (property.NameEquals("sourceUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sourceUri = null;
                        continue;
                    }
                    sourceUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new SourceCreationData(createSource, sourceUri.Value);
        }
    }
}
