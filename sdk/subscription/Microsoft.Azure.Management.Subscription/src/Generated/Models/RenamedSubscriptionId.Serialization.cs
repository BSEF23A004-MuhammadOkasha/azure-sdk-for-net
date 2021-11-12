// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace SubscriptionClient.Models
{
    public partial class RenamedSubscriptionId
    {
        internal static RenamedSubscriptionId DeserializeRenamedSubscriptionId(JsonElement element)
        {
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new RenamedSubscriptionId(value.Value);
        }
    }
}
