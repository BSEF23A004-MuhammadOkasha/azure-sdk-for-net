// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VirtualMachineTaskDetails
    {
        internal static VirtualMachineTaskDetails DeserializeVirtualMachineTaskDetails(JsonElement element)
        {
            Optional<string> skippedReason = default;
            Optional<string> skippedReasonString = default;
            Optional<JobEntity> jobTask = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skippedReason"))
                {
                    skippedReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skippedReasonString"))
                {
                    skippedReasonString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobTask"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobTask = JobEntity.DeserializeJobEntity(property.Value);
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualMachineTaskDetails(instanceType, jobTask.Value, skippedReason.Value, skippedReasonString.Value);
        }
    }
}
