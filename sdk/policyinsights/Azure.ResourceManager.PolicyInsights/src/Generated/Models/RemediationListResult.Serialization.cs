// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PolicyInsights;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    internal partial class RemediationListResult
    {
        internal static RemediationListResult DeserializeRemediationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RemediationData>> value = default;
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
                    List<RemediationData> array = new List<RemediationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RemediationData.DeserializeRemediationData(item));
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
            return new RemediationListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
