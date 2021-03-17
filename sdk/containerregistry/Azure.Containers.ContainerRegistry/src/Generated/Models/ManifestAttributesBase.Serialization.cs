// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class ManifestAttributesBase
    {
        internal static ManifestAttributesBase DeserializeManifestAttributesBase(JsonElement element)
        {
            Optional<string> digest = default;
            Optional<long> imageSize = default;
            Optional<string> createdTime = default;
            Optional<string> lastUpdateTime = default;
            Optional<string> architecture = default;
            Optional<string> os = default;
            Optional<string> mediaType = default;
            Optional<string> configMediaType = default;
            Optional<IReadOnlyList<string>> tags = default;
            Optional<ChangeableAttributes> changeableAttributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("digest"))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    imageSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    createdTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"))
                {
                    lastUpdateTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("architecture"))
                {
                    architecture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("os"))
                {
                    os = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mediaType"))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configMediaType"))
                {
                    configMediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
                    continue;
                }
                if (property.NameEquals("changeableAttributes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    changeableAttributes = ChangeableAttributes.DeserializeChangeableAttributes(property.Value);
                    continue;
                }
            }
            return new ManifestAttributesBase(digest.Value, Optional.ToNullable(imageSize), createdTime.Value, lastUpdateTime.Value, architecture.Value, os.Value, mediaType.Value, configMediaType.Value, Optional.ToList(tags), changeableAttributes.Value);
        }
    }
}
