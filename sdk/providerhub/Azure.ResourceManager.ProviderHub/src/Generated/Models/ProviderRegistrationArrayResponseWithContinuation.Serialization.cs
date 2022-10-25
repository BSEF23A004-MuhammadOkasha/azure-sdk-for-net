// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    internal partial class ProviderRegistrationArrayResponseWithContinuation
    {
        internal static ProviderRegistrationArrayResponseWithContinuation DeserializeProviderRegistrationArrayResponseWithContinuation(JsonElement element)
        {
            Optional<IReadOnlyList<ProviderRegistrationData>> value = default;
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
                    List<ProviderRegistrationData> array = new List<ProviderRegistrationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderRegistrationData.DeserializeProviderRegistrationData(item));
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
            return new ProviderRegistrationArrayResponseWithContinuation(Optional.ToList(value), nextLink.Value);
        }
    }
}
