// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Applications.Containers;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    internal partial class ContainerAppCollection
    {
        internal static ContainerAppCollection DeserializeContainerAppCollection(JsonElement element)
        {
            IReadOnlyList<ContainerAppData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ContainerAppData> array = new List<ContainerAppData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppData.DeserializeContainerAppData(item));
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
            return new ContainerAppCollection(value, nextLink.Value);
        }
    }
}
