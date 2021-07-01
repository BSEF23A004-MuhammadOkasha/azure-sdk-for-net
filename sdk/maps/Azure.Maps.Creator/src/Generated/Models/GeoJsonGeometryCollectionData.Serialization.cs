// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    public partial class GeoJsonGeometryCollectionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("geometries");
            writer.WriteStartArray();
            foreach (var item in Geometries)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static GeoJsonGeometryCollectionData DeserializeGeoJsonGeometryCollectionData(JsonElement element)
        {
            IList<GeoJsonGeometry> geometries = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("geometries"))
                {
                    List<GeoJsonGeometry> array = new List<GeoJsonGeometry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeoJsonGeometry.DeserializeGeoJsonGeometry(item));
                    }
                    geometries = array;
                    continue;
                }
            }
            return new GeoJsonGeometryCollectionData(geometries);
        }
    }
}
