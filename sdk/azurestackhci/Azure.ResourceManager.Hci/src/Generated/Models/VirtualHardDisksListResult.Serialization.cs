// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    internal partial class VirtualHardDisksListResult
    {
        internal static VirtualHardDisksListResult DeserializeVirtualHardDisksListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<HciVirtualHardDiskData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HciVirtualHardDiskData> array = new List<HciVirtualHardDiskData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HciVirtualHardDiskData.DeserializeHciVirtualHardDiskData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualHardDisksListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
