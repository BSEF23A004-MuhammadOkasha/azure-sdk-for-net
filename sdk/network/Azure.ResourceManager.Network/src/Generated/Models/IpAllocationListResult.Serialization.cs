// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class IpAllocationListResult
    {
        internal static IpAllocationListResult DeserializeIpAllocationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<IpAllocation>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IpAllocation> array = new List<IpAllocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IpAllocation.DeserializeIpAllocation(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new IpAllocationListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
