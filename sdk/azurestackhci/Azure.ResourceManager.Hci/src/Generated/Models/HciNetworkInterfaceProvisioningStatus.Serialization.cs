// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciNetworkInterfaceProvisioningStatus
    {
        internal static HciNetworkInterfaceProvisioningStatus DeserializeHciNetworkInterfaceProvisioningStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> operationId = default;
            Optional<HciClusterStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new HciClusterStatus(property.Value.GetString());
                    continue;
                }
            }
            return new HciNetworkInterfaceProvisioningStatus(operationId.Value, Optional.ToNullable(status));
        }
    }
}
