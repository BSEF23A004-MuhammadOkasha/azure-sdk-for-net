// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class DatabaseVmDetails
    {
        internal static DatabaseVmDetails DeserializeDatabaseVmDetails(JsonElement element)
        {
            Optional<ResourceIdentifier> virtualMachineId = default;
            Optional<SapVirtualInstanceStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachineId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new SapVirtualInstanceStatus(property.Value.GetString());
                    continue;
                }
            }
            return new DatabaseVmDetails(virtualMachineId.Value, Optional.ToNullable(status));
        }
    }
}
