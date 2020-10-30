// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class DdosProtectionPlanListResult
    {
        internal static DdosProtectionPlanListResult DeserializeDdosProtectionPlanListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DdosProtectionPlan>> value = default;
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
                    List<DdosProtectionPlan> array = new List<DdosProtectionPlan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DdosProtectionPlan.DeserializeDdosProtectionPlan(item));
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
            return new DdosProtectionPlanListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
