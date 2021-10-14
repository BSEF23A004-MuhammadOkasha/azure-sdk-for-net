// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RestorePointProvisioningDetails
    {
        internal static RestorePointProvisioningDetails DeserializeRestorePointProvisioningDetails(JsonElement element)
        {
            Optional<DateTimeOffset> creationTime = default;
            Optional<long> totalUsedSizeInBytes = default;
            Optional<int> statusCode = default;
            Optional<string> statusMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("creationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("totalUsedSizeInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalUsedSizeInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("statusCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("statusMessage"))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
            }
            return new RestorePointProvisioningDetails(Optional.ToNullable(creationTime), Optional.ToNullable(totalUsedSizeInBytes), Optional.ToNullable(statusCode), statusMessage.Value);
        }
    }
}
