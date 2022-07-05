// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class AssetFilterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PresentationTimeRange))
            {
                writer.WritePropertyName("presentationTimeRange");
                writer.WriteObjectValue(PresentationTimeRange);
            }
            if (Optional.IsDefined(FirstQuality))
            {
                writer.WritePropertyName("firstQuality");
                writer.WriteObjectValue(FirstQuality);
            }
            if (Optional.IsCollectionDefined(Tracks))
            {
                writer.WritePropertyName("tracks");
                writer.WriteStartArray();
                foreach (var item in Tracks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AssetFilterData DeserializeAssetFilterData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<PresentationTimeRange> presentationTimeRange = default;
            Optional<FirstQuality> firstQuality = default;
            Optional<IList<FilterTrackSelection>> tracks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("presentationTimeRange"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            presentationTimeRange = PresentationTimeRange.DeserializePresentationTimeRange(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("firstQuality"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            firstQuality = FirstQuality.DeserializeFirstQuality(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tracks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FilterTrackSelection> array = new List<FilterTrackSelection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FilterTrackSelection.DeserializeFilterTrackSelection(item));
                            }
                            tracks = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AssetFilterData(id, name, type, systemData.Value, presentationTimeRange.Value, firstQuality.Value, Optional.ToList(tracks));
        }
    }
}
