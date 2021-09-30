// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class ArtifactManifestProperties
    {
        internal static ArtifactManifestProperties DeserializeArtifactManifestProperties(JsonElement element)
        {
            Optional<string> registry = default;
            Optional<string> imageName = default;
            string digest = default;
            Optional<long> imageSize = default;
            DateTimeOffset createdTime = default;
            DateTimeOffset lastUpdateTime = default;
            Optional<ArtifactArchitecture?> architecture = default;
            Optional<ArtifactOperatingSystem?> os = default;
            Optional<IReadOnlyList<ArtifactManifestPlatform>> references = default;
            Optional<string> configMediaType = default;
            Optional<IReadOnlyList<string>> tags = default;
            Optional<bool> deleteEnabled = default;
            Optional<bool> writeEnabled = default;
            Optional<bool> listEnabled = default;
            Optional<bool> readEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registry"))
                {
                    registry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageName"))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("digest"))
                        {
                            digest = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            imageSize = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("createdTime"))
                        {
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdateTime"))
                        {
                            lastUpdateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("architecture"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                architecture = null;
                                continue;
                            }
                            architecture = new ArtifactArchitecture(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("os"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                os = null;
                                continue;
                            }
                            os = new ArtifactOperatingSystem(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("references"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ArtifactManifestPlatform> array = new List<ArtifactManifestPlatform>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArtifactManifestPlatform.DeserializeArtifactManifestPlatform(item));
                            }
                            references = array;
                            continue;
                        }
                        if (property0.NameEquals("configMediaType"))
                        {
                            configMediaType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tags"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            tags = array;
                            continue;
                        }
                        if (property0.NameEquals("changeableAttributes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("deleteEnabled"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    deleteEnabled = property1.Value.GetBoolean();
                                    continue;
                                }
                                if (property1.NameEquals("writeEnabled"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    writeEnabled = property1.Value.GetBoolean();
                                    continue;
                                }
                                if (property1.NameEquals("listEnabled"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    listEnabled = property1.Value.GetBoolean();
                                    continue;
                                }
                                if (property1.NameEquals("readEnabled"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    readEnabled = property1.Value.GetBoolean();
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ArtifactManifestProperties(registry.Value, imageName.Value, digest, Optional.ToNullable(imageSize), createdTime, lastUpdateTime, Optional.ToNullable(architecture), Optional.ToNullable(os), Optional.ToList(references), configMediaType.Value, Optional.ToList(tags), Optional.ToNullable(deleteEnabled), Optional.ToNullable(writeEnabled), Optional.ToNullable(listEnabled), Optional.ToNullable(readEnabled));
        }
    }
}
