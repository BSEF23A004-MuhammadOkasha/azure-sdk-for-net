// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Maintenance.Models;
using Azure.ResourceManager.Models;

// Custom code to support custom datetime format for the 2 properties startDateTime and expirationDateTime
// Here is an issue https://github.com/Azure/autorest.csharp/issues/3184 to track if codegen can support custom datetime format in the furture.

namespace Azure.ResourceManager.Maintenance
{
    [CodeGenSuppress("global::Azure.Core.IUtf8JsonSerializable.Write", typeof(Utf8JsonWriter))]
    public partial class MaintenanceConfigurationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsCollectionDefined(ExtensionProperties))
            {
                writer.WritePropertyName("extensionProperties"u8);
                writer.WriteStartObject();
                foreach (var item in ExtensionProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(MaintenanceScope))
            {
                writer.WritePropertyName("maintenanceScope"u8);
                writer.WriteStringValue(MaintenanceScope.Value.ToString());
            }
            if (Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility"u8);
                writer.WriteStringValue(Visibility.Value.ToString());
            }
            if (Optional.IsDefined(InstallPatches))
            {
                Console.WriteLine("InstallPatches is defined");
                writer.WritePropertyName("installPathes"u8);
                writer.WriteStartObject();

                if (Optional.IsDefined(InstallPatches.RebootSetting))
                {
                    Console.WriteLine("RebootSetting is defined");
                    writer.WritePropertyName("rebootSetting"u8);
                    writer.WriteStringValue(InstallPatches.RebootSetting.Value.ToString());
                }

                if (Optional.IsDefined(InstallPatches.LinuxParameters))
                {
                    Console.WriteLine("LinuxParameters is defined");
                    writer.WritePropertyName("linuxParameters"u8);
                    writer.WriteStartObject();

                    if (Optional.IsDefined(InstallPatches.LinuxParameters.ClassificationsToInclude))
                    {
                        writer.WritePropertyName("classificationsToInclude"u8);
                        writer.WriteStartArray();
                        foreach (var item in InstallPatches.LinuxParameters.ClassificationsToInclude)
                        {
                            writer.WriteStringValue(item.ToString());
                        }
                        writer.WriteEndArray();
                    }

                    if (Optional.IsDefined(InstallPatches.LinuxParameters.PackageNameMasksToInclude))
                    {
                        writer.WritePropertyName("packageNameMasksToInclude"u8);
                        writer.WriteStartArray();
                        foreach (var item in InstallPatches.LinuxParameters.PackageNameMasksToInclude)
                        {
                            writer.WriteStringValue(item.ToString());
                        }
                        writer.WriteEndArray();
                    }

                    if (Optional.IsDefined(InstallPatches.LinuxParameters.PackageNameMasksToExclude))
                    {
                        writer.WritePropertyName("packageNameMasksToExclude"u8);
                        writer.WriteStartArray();
                        foreach (var item in InstallPatches.LinuxParameters.PackageNameMasksToExclude)
                        {
                            writer.WriteStringValue(item.ToString());
                        }
                        writer.WriteEndArray();
                    }

                    writer.WriteEndObject();
                }

                if (Optional.IsDefined(InstallPatches.WindowsParameters))
                {
                    writer.WritePropertyName("windowsParameters"u8);
                    writer.WriteStartObject();

                    if (Optional.IsDefined(InstallPatches.WindowsParameters.ClassificationsToInclude))
                    {
                        writer.WritePropertyName("classificationsToInclude"u8);
                        writer.WriteStartArray();
                        foreach (var item in InstallPatches.WindowsParameters.ClassificationsToInclude)
                        {
                            writer.WriteStringValue(item.ToString());
                        }
                        writer.WriteEndArray();
                    }

                    if (Optional.IsDefined(InstallPatches.WindowsParameters.KbNumbersToInclude))
                    {
                        writer.WritePropertyName("kbNumbersToInclude"u8);
                        writer.WriteStartArray();
                        foreach (var item in InstallPatches.WindowsParameters.KbNumbersToInclude)
                        {
                            writer.WriteStringValue(item.ToString());
                        }
                        writer.WriteEndArray();
                    }

                    if (Optional.IsDefined(InstallPatches.WindowsParameters.KbNumbersToExclude))
                    {
                        writer.WritePropertyName("kbNumbersToExclude"u8);
                        writer.WriteStartArray();
                        foreach (var item in InstallPatches.WindowsParameters.KbNumbersToExclude)
                        {
                            writer.WriteStringValue(item.ToString());
                        }
                        writer.WriteEndArray();
                    }

                    writer.WriteEndObject();
                }

                writer.WriteEndObject();
            }
            writer.WritePropertyName("maintenanceWindow"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "yyyy-MM-dd hh:mm");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDateTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "yyyy-MM-dd hh:mm");
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "c");
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(RecurEvery))
            {
                writer.WritePropertyName("recurEvery"u8);
                writer.WriteStringValue(RecurEvery);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
