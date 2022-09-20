// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class DeviceProvisioningServicesSharedAccessKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyName");
            writer.WriteStringValue(KeyName);
            if (Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey");
                writer.WriteStringValue(PrimaryKey);
            }
            if (Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey");
                writer.WriteStringValue(SecondaryKey);
            }
            writer.WritePropertyName("rights");
            writer.WriteStringValue(Rights.ToString());
            writer.WriteEndObject();
        }

        internal static DeviceProvisioningServicesSharedAccessKey DeserializeDeviceProvisioningServicesSharedAccessKey(JsonElement element)
        {
            string keyName = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            DeviceProvisioningServicesAccessKeyRight rights = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rights"))
                {
                    rights = new DeviceProvisioningServicesAccessKeyRight(property.Value.GetString());
                    continue;
                }
            }
            return new DeviceProvisioningServicesSharedAccessKey(keyName, primaryKey.Value, secondaryKey.Value, rights);
        }
    }
}
