// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class Dependency
    {
        internal static Dependency DeserializeDependency(JsonElement element)
        {
            Optional<IReadOnlyList<BasicDependency>> dependsOn = default;
            Optional<string> resourceType = default;
            Optional<string> resourceName = default;
            ResourceIdentifier id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dependsOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BasicDependency> array = new List<BasicDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BasicDependency.DeserializeBasicDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new Dependency(id, Optional.ToList(dependsOn), resourceType.Value, resourceName.Value);
        }
    }
}
