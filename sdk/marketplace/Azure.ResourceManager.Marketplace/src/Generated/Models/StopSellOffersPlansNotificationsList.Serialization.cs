// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class StopSellOffersPlansNotificationsList
    {
        internal static StopSellOffersPlansNotificationsList DeserializeStopSellOffersPlansNotificationsList(JsonElement element)
        {
            Optional<IReadOnlyList<StopSellOffersPlansNotificationsListProperties>> stopSellNotifications = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stopSellNotifications"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StopSellOffersPlansNotificationsListProperties> array = new List<StopSellOffersPlansNotificationsListProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StopSellOffersPlansNotificationsListProperties.DeserializeStopSellOffersPlansNotificationsListProperties(item));
                    }
                    stopSellNotifications = array;
                    continue;
                }
            }
            return new StopSellOffersPlansNotificationsList(Optional.ToList(stopSellNotifications));
        }
    }
}
