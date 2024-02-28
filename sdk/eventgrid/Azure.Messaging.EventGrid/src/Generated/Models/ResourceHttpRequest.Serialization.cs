// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ResourceHttpRequest
    {
        internal static ResourceHttpRequest DeserializeResourceHttpRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientRequestId = default;
            string clientIpAddress = default;
            string method = default;
            string url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientIpAddress"u8))
                {
                    clientIpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("method"u8))
                {
                    method = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceHttpRequest(clientRequestId, clientIpAddress, method, url);
        }
    }
}
