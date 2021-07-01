// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    public partial class GeoJsonLineStringData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("coordinates");
            writer.WriteStartArray();
            foreach (var item in Coordinates)
            {
                writer.WriteStartArray();
                foreach (var item0 in item)
                {
                    writer.WriteNumberValue(item0);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static GeoJsonLineStringData DeserializeGeoJsonLineStringData(JsonElement element)
        {
            IList<IList<double>> coordinates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"))
                {
                    List<IList<double>> array = new List<IList<double>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<double> array0 = new List<double>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(item0.GetDouble());
                        }
                        array.Add(array0);
                    }
                    coordinates = array;
                    continue;
                }
            }
            return new GeoJsonLineStringData(coordinates);
        }
    }
}
