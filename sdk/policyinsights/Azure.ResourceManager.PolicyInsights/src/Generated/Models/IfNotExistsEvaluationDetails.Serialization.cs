// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class IfNotExistsEvaluationDetails
    {
        internal static IfNotExistsEvaluationDetails DeserializeIfNotExistsEvaluationDetails(JsonElement element)
        {
            Optional<string> resourceId = default;
            Optional<int> totalResources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalResources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalResources = property.Value.GetInt32();
                    continue;
                }
            }
            return new IfNotExistsEvaluationDetails(resourceId.Value, Optional.ToNullable(totalResources));
        }
    }
}
