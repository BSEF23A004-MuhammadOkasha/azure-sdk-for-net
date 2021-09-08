// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ConnectionMonitorListResult
    {
        internal static ConnectionMonitorListResult DeserializeConnectionMonitorListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ConnectionMonitorData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConnectionMonitorData> array = new List<ConnectionMonitorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionMonitorData.DeserializeConnectionMonitorData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ConnectionMonitorListResult(Optional.ToList(value));
        }
    }
}
