// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    public partial class GeoJsonFeatureCollectionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("features");
            writer.WriteStartArray();
            foreach (var item in Features)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static GeoJsonFeatureCollectionData DeserializeGeoJsonFeatureCollectionData(JsonElement element)
        {
            IList<GeoJsonFeature> features = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("features"))
                {
                    List<GeoJsonFeature> array = new List<GeoJsonFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeoJsonFeature.DeserializeGeoJsonFeature(item));
                    }
                    features = array;
                    continue;
                }
            }
            return new GeoJsonFeatureCollectionData(features);
        }
    }
}
