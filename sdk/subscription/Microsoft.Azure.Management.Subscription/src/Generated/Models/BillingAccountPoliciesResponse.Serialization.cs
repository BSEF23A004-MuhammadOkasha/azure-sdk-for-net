// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace SubscriptionClient.Models
{
    public partial class BillingAccountPoliciesResponse
    {
        internal static BillingAccountPoliciesResponse DeserializeBillingAccountPoliciesResponse(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<BillingAccountPoliciesResponseProperties> properties = default;
            Optional<SystemData> systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = BillingAccountPoliciesResponseProperties.DeserializeBillingAccountPoliciesResponseProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
                    continue;
                }
            }
            return new BillingAccountPoliciesResponse(id.Value, name.Value, type.Value, properties.Value, systemData.Value);
        }
    }
}
