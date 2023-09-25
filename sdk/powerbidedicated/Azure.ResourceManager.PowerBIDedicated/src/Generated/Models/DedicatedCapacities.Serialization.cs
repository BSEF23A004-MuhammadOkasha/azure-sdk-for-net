// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.ResourceManager.PowerBIDedicated;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    internal partial class DedicatedCapacities
    {
        internal static DedicatedCapacities DeserializeDedicatedCapacities(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DedicatedCapacityData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DedicatedCapacityData> array = new List<DedicatedCapacityData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DedicatedCapacityData.DeserializeDedicatedCapacityData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DedicatedCapacities(value);
        }
    }
}
