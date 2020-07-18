// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class PurgeMessageQueueResult
    {
        internal static PurgeMessageQueueResult DeserializePurgeMessageQueueResult(JsonElement element)
        {
            int? totalMessagesPurged = default;
            string deviceId = default;
            string moduleId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalMessagesPurged"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMessagesPurged = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deviceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moduleId = property.Value.GetString();
                    continue;
                }
            }
            return new PurgeMessageQueueResult(totalMessagesPurged, deviceId, moduleId);
        }
    }
}
