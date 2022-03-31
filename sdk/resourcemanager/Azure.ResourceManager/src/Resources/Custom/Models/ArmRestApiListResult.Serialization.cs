// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ArmRestApiListResult
    {
        internal static ArmRestApiListResult DeserializeComputeOperationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ArmRestApi>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ArmRestApi> array = new List<ArmRestApi>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArmRestApi.DeserializeRestApi(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ArmRestApiListResult(Optional.ToList(value));
        }
    }
}
