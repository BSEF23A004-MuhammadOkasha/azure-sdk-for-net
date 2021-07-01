// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Creator.Models
{
    public partial class ConformanceResponse
    {
        internal static ConformanceResponse DeserializeConformanceResponse(JsonElement element)
        {
            IReadOnlyList<string> conformsTo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conformsTo"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    conformsTo = array;
                    continue;
                }
            }
            return new ConformanceResponse(conformsTo);
        }
    }
}
