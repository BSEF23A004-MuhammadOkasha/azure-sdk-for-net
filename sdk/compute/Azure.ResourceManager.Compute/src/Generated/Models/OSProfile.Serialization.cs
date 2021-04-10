// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class OSProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ComputerName))
            {
                writer.WritePropertyName("computerName");
                writer.WriteStringValue(ComputerName);
            }
            if (Optional.IsDefined(AdminUsername))
            {
                writer.WritePropertyName("adminUsername");
                writer.WriteStringValue(AdminUsername);
            }
            if (Optional.IsDefined(AdminPassword))
            {
                writer.WritePropertyName("adminPassword");
                writer.WriteStringValue(AdminPassword);
            }
            if (Optional.IsDefined(CustomData))
            {
                writer.WritePropertyName("customData");
                writer.WriteStringValue(CustomData);
            }
            if (Optional.IsDefined(WindowsConfiguration))
            {
                writer.WritePropertyName("windowsConfiguration");
                writer.WriteObjectValue(WindowsConfiguration);
            }
            if (Optional.IsDefined(LinuxConfiguration))
            {
                writer.WritePropertyName("linuxConfiguration");
                writer.WriteObjectValue(LinuxConfiguration);
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets");
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowExtensionOperations))
            {
                writer.WritePropertyName("allowExtensionOperations");
                writer.WriteBooleanValue(AllowExtensionOperations.Value);
            }
            if (Optional.IsDefined(RequireGuestProvisionSignal))
            {
                writer.WritePropertyName("requireGuestProvisionSignal");
                writer.WriteBooleanValue(RequireGuestProvisionSignal.Value);
            }
            writer.WriteEndObject();
        }

        internal static OSProfile DeserializeOSProfile(JsonElement element)
        {
            Optional<string> computerName = default;
            Optional<string> adminUsername = default;
            Optional<string> adminPassword = default;
            Optional<string> customData = default;
            Optional<WindowsConfiguration> windowsConfiguration = default;
            Optional<LinuxConfiguration> linuxConfiguration = default;
            Optional<IList<VaultSecretGroup>> secrets = default;
            Optional<bool> allowExtensionOperations = default;
            Optional<bool> requireGuestProvisionSignal = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computerName"))
                {
                    computerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminUsername"))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminPassword"))
                {
                    adminPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customData"))
                {
                    customData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowsConfiguration = WindowsConfiguration.DeserializeWindowsConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("linuxConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linuxConfiguration = LinuxConfiguration.DeserializeLinuxConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("secrets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VaultSecretGroup> array = new List<VaultSecretGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VaultSecretGroup.DeserializeVaultSecretGroup(item));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("allowExtensionOperations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowExtensionOperations = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("requireGuestProvisionSignal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requireGuestProvisionSignal = property.Value.GetBoolean();
                    continue;
                }
            }
            return new OSProfile(computerName.Value, adminUsername.Value, adminPassword.Value, customData.Value, windowsConfiguration.Value, linuxConfiguration.Value, Optional.ToList(secrets), Optional.ToNullable(allowExtensionOperations), Optional.ToNullable(requireGuestProvisionSignal));
        }
    }
}
