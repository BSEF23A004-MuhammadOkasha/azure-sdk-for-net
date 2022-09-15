// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLake.Store.Models
{
    public partial class CapabilityInformation
    {
        internal static CapabilityInformation DeserializeCapabilityInformation(JsonElement element)
        {
            Optional<Guid> subscriptionId = default;
            Optional<SubscriptionState> state = default;
            Optional<int> maxAccountCount = default;
            Optional<int> accountCount = default;
            Optional<bool> migrationState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new SubscriptionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxAccountCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxAccountCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("accountCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accountCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("migrationState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationState = property.Value.GetBoolean();
                    continue;
                }
            }
            return new CapabilityInformation(Optional.ToNullable(subscriptionId), Optional.ToNullable(state), Optional.ToNullable(maxAccountCount), Optional.ToNullable(accountCount), Optional.ToNullable(migrationState));
        }
    }
}
