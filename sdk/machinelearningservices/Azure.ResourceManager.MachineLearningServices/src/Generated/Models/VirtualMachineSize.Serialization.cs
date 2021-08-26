// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class VirtualMachineSize
    {
        internal static VirtualMachineSize DeserializeVirtualMachineSize(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> family = default;
            Optional<int> vCPUs = default;
            Optional<int> gpus = default;
            Optional<int> osVhdSizeMB = default;
            Optional<int> maxResourceVolumeMB = default;
            Optional<double> memoryGB = default;
            Optional<bool> lowPriorityCapable = default;
            Optional<bool> premiumIO = default;
            Optional<EstimatedVMPrices> estimatedVMPrices = default;
            Optional<IReadOnlyList<string>> supportedComputeTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("family"))
                {
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCPUs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vCPUs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("gpus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    gpus = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osVhdSizeMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osVhdSizeMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxResourceVolumeMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxResourceVolumeMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("memoryGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    memoryGB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("lowPriorityCapable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lowPriorityCapable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("premiumIO"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    premiumIO = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("estimatedVMPrices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    estimatedVMPrices = EstimatedVMPrices.DeserializeEstimatedVMPrices(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedComputeTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedComputeTypes = array;
                    continue;
                }
            }
            return new VirtualMachineSize(name.Value, family.Value, Optional.ToNullable(vCPUs), Optional.ToNullable(gpus), Optional.ToNullable(osVhdSizeMB), Optional.ToNullable(maxResourceVolumeMB), Optional.ToNullable(memoryGB), Optional.ToNullable(lowPriorityCapable), Optional.ToNullable(premiumIO), estimatedVMPrices.Value, Optional.ToList(supportedComputeTypes));
        }
    }
}
