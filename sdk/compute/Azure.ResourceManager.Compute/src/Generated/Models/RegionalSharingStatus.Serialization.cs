// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RegionalSharingStatus
    {
        internal static RegionalSharingStatus DeserializeRegionalSharingStatus(JsonElement element)
        {
            Optional<string> region = default;
            Optional<SharingState> state = default;
            Optional<string> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("region"))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new SharingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    details = property.Value.GetString();
                    continue;
                }
            }
            return new RegionalSharingStatus(region.Value, Optional.ToNullable(state), details.Value);
        }
    }
}
