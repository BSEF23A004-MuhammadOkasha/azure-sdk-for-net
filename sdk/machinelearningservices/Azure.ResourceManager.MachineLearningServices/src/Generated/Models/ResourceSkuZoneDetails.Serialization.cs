// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ResourceSkuZoneDetails
    {
        internal static ResourceSkuZoneDetails DeserializeResourceSkuZoneDetails(JsonElement element)
        {
            Optional<IReadOnlyList<string>> name = default;
            Optional<IReadOnlyList<SKUCapability>> capabilities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
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
                    name = array;
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SKUCapability> array = new List<SKUCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SKUCapability.DeserializeSKUCapability(item));
                    }
                    capabilities = array;
                    continue;
                }
            }
            return new ResourceSkuZoneDetails(Optional.ToList(name), Optional.ToList(capabilities));
        }
    }
}
