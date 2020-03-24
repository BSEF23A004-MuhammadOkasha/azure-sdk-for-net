// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class PrivateLinkResourceListResult
    {
        internal static PrivateLinkResourceListResult DeserializePrivateLinkResourceListResult(JsonElement element)
        {
            IReadOnlyList<PrivateLinkResource> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateLinkResource> array = new List<PrivateLinkResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateLinkResource.DeserializePrivateLinkResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PrivateLinkResourceListResult(value);
        }
    }
}
