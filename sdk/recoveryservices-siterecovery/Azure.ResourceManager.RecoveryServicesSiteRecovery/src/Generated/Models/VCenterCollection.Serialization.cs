// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class VCenterCollection
    {
        internal static VCenterCollection DeserializeVCenterCollection(JsonElement element)
        {
            Optional<IReadOnlyList<VCenterData>> value = default;
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
                    List<VCenterData> array = new List<VCenterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VCenterData.DeserializeVCenterData(item));
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
            return new VCenterCollection(Optional.ToList(value), nextLink.Value);
        }
    }
}
