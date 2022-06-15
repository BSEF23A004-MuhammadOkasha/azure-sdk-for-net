// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class LinuxVmGuestPatchAutomaticByPlatformSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RebootSetting))
            {
                writer.WritePropertyName("rebootSetting");
                writer.WriteStringValue(RebootSetting.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static LinuxVmGuestPatchAutomaticByPlatformSettings DeserializeLinuxVmGuestPatchAutomaticByPlatformSettings(JsonElement element)
        {
            Optional<LinuxVmGuestPatchAutomaticByPlatformRebootSetting> rebootSetting = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rebootSetting"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rebootSetting = new LinuxVmGuestPatchAutomaticByPlatformRebootSetting(property.Value.GetString());
                    continue;
                }
            }
            return new LinuxVmGuestPatchAutomaticByPlatformSettings(Optional.ToNullable(rebootSetting));
        }
    }
}
