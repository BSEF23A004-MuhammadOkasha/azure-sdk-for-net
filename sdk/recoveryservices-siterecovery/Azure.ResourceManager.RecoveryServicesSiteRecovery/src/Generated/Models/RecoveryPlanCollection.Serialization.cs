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
    internal partial class RecoveryPlanCollection
    {
        internal static RecoveryPlanCollection DeserializeRecoveryPlanCollection(JsonElement element)
        {
            Optional<IReadOnlyList<RecoveryPlanData>> value = default;
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
                    List<RecoveryPlanData> array = new List<RecoveryPlanData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanData.DeserializeRecoveryPlanData(item));
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
            return new RecoveryPlanCollection(Optional.ToList(value), nextLink.Value);
        }
    }
}
