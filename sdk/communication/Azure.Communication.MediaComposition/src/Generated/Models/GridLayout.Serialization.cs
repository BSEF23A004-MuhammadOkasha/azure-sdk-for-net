// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class GridLayout : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rows");
            writer.WriteNumberValue(Rows);
            writer.WritePropertyName("columns");
            writer.WriteNumberValue(Columns);
            writer.WritePropertyName("inputIds");
            writer.WriteStartArray();
            foreach (var item in InputIds)
            {
                writer.WriteStartArray();
                foreach (var item0 in item)
                {
                    writer.WriteStringValue(item0);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Resolution))
            {
                writer.WritePropertyName("resolution");
                writer.WriteObjectValue(Resolution);
            }
            if (Optional.IsDefined(PlaceholderImageUri))
            {
                writer.WritePropertyName("placeholderImageUri");
                writer.WriteStringValue(PlaceholderImageUri);
            }
            writer.WriteEndObject();
        }

        internal static GridLayout DeserializeGridLayout(JsonElement element)
        {
            int rows = default;
            int columns = default;
            IList<IList<string>> inputIds = default;
            LayoutType kind = default;
            Optional<LayoutResolution> resolution = default;
            Optional<string> placeholderImageUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rows"))
                {
                    rows = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columns"))
                {
                    columns = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inputIds"))
                {
                    List<IList<string>> array = new List<IList<string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<string> array0 = new List<string>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(item0.GetString());
                        }
                        array.Add(array0);
                    }
                    inputIds = array;
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new LayoutType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resolution = LayoutResolution.DeserializeLayoutResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
            }
            return new GridLayout(kind, resolution.Value, placeholderImageUri.Value, rows, columns, inputIds);
        }
    }
}
