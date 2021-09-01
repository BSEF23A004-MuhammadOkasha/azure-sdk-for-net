// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network.Models
{
    public partial class Topology
    {
        internal static Topology DeserializeTopology(JsonElement element)
        {
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<IReadOnlyList<TopologyResource>> resources = default;
            ResourceIdentifier id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TopologyResource> array = new List<TopologyResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopologyResource.DeserializeTopologyResource(item));
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new Topology(id, Optional.ToNullable(createdDateTime), Optional.ToNullable(lastModified), Optional.ToList(resources));
        }
    }
}
