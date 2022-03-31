// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    internal partial class WorkspaceList
    {
        internal static WorkspaceList DeserializeWorkspaceList(JsonElement element)
        {
            Optional<IReadOnlyList<VirtualWorkspaceData>> value = default;
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
                    List<VirtualWorkspaceData> array = new List<VirtualWorkspaceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualWorkspaceData.DeserializeVirtualWorkspaceData(item));
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
            return new WorkspaceList(Optional.ToList(value), nextLink.Value);
        }
    }
}
