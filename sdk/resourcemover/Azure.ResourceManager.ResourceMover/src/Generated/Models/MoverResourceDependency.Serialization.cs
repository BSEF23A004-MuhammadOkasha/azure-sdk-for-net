// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceDependency
    {
        internal static MoverResourceDependency DeserializeMoverResourceDependency(JsonElement element)
        {
            Optional<ResourceIdentifier> id = default;
            Optional<string> resolutionStatus = default;
            Optional<MoverResourceResolutionType> resolutionType = default;
            Optional<MoverDependencyType> dependencyType = default;
            Optional<ManualResolutionProperties> manualResolution = default;
            Optional<AutomaticResolutionProperties> automaticResolution = default;
            Optional<bool> isOptional = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolutionStatus"))
                {
                    resolutionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resolutionType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resolutionType = new MoverResourceResolutionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependencyType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dependencyType = new MoverDependencyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("manualResolution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    manualResolution = ManualResolutionProperties.DeserializeManualResolutionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("automaticResolution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    automaticResolution = AutomaticResolutionProperties.DeserializeAutomaticResolutionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("isOptional"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isOptional = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MoverResourceDependency(id.Value, resolutionStatus.Value, Optional.ToNullable(resolutionType), Optional.ToNullable(dependencyType), manualResolution.Value, automaticResolution.Value, Optional.ToNullable(isOptional));
        }
    }
}
