// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    internal partial class OperationListResult
    {
        internal static OperationListResult DeserializeOperationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<EdgeOrderOperation>> value = default;
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
                    List<EdgeOrderOperation> array = new List<EdgeOrderOperation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdgeOrderOperation.DeserializeEdgeOrderOperation(item));
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
            return new OperationListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
