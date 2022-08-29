// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    internal partial class DenyAssignmentListResult
    {
        internal static DenyAssignmentListResult DeserializeDenyAssignmentListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DenyAssignmentData>> value = default;
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
                    List<DenyAssignmentData> array = new List<DenyAssignmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DenyAssignmentData.DeserializeDenyAssignmentData(item));
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
            return new DenyAssignmentListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
