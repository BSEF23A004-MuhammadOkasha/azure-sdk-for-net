// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    internal partial class GuestAgentList
    {
        internal static GuestAgentList DeserializeGuestAgentList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            IReadOnlyList<HciGuestAgentData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<HciGuestAgentData> array = new List<HciGuestAgentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HciGuestAgentData.DeserializeHciGuestAgentData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new GuestAgentList(nextLink.Value, value);
        }
    }
}
