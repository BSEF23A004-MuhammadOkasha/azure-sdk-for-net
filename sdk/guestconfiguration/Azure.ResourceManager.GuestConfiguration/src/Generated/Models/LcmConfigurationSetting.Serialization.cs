// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class LcmConfigurationSetting
    {
        internal static LcmConfigurationSetting DeserializeLcmConfigurationSetting(JsonElement element)
        {
            Optional<LcmConfigurationMode> configurationMode = default;
            Optional<bool> allowModuleOverwrite = default;
            Optional<ActionAfterReboot> actionAfterReboot = default;
            Optional<float> refreshFrequencyMins = default;
            Optional<bool> rebootIfNeeded = default;
            Optional<float> configurationModeFrequencyMins = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    configurationMode = new LcmConfigurationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowModuleOverwrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowModuleOverwrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("actionAfterReboot"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    actionAfterReboot = new ActionAfterReboot(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("refreshFrequencyMins"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    refreshFrequencyMins = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("rebootIfNeeded"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rebootIfNeeded = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationModeFrequencyMins"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    configurationModeFrequencyMins = property.Value.GetSingle();
                    continue;
                }
            }
            return new LcmConfigurationSetting(Optional.ToNullable(configurationMode), Optional.ToNullable(allowModuleOverwrite), Optional.ToNullable(actionAfterReboot), Optional.ToNullable(refreshFrequencyMins), Optional.ToNullable(rebootIfNeeded), Optional.ToNullable(configurationModeFrequencyMins));
        }
    }
}
