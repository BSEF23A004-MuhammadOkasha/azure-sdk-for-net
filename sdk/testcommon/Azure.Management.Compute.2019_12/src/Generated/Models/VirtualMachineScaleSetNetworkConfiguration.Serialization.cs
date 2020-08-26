// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineScaleSetNetworkConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Primary))
            {
                writer.WritePropertyName("primary");
                writer.WriteBooleanValue(Primary.Value);
            }
            if (Optional.IsDefined(EnableAcceleratedNetworking))
            {
                writer.WritePropertyName("enableAcceleratedNetworking");
                writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
            }
            if (Optional.IsDefined(NetworkSecurityGroup))
            {
                writer.WritePropertyName("networkSecurityGroup");
                writer.WriteObjectValue(NetworkSecurityGroup);
            }
            if (Optional.IsDefined(DnsSettings))
            {
                writer.WritePropertyName("dnsSettings");
                writer.WriteObjectValue(DnsSettings);
            }
            if (Optional.IsCollectionDefined(IpConfigurations))
            {
                writer.WritePropertyName("ipConfigurations");
                writer.WriteStartArray();
                foreach (var item in IpConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableIPForwarding))
            {
                writer.WritePropertyName("enableIPForwarding");
                writer.WriteBooleanValue(EnableIPForwarding.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetNetworkConfiguration DeserializeVirtualMachineScaleSetNetworkConfiguration(JsonElement element)
        {
            string name = default;
            Optional<string> id = default;
            Optional<bool> primary = default;
            Optional<bool> enableAcceleratedNetworking = default;
            Optional<SubResource> networkSecurityGroup = default;
            Optional<VirtualMachineScaleSetNetworkConfigurationDnsSettings> dnsSettings = default;
            Optional<IList<VirtualMachineScaleSetIPConfiguration>> ipConfigurations = default;
            Optional<bool> enableIPForwarding = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("primary"))
                        {
                            primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAcceleratedNetworking"))
                        {
                            enableAcceleratedNetworking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityGroup"))
                        {
                            networkSecurityGroup = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"))
                        {
                            dnsSettings = VirtualMachineScaleSetNetworkConfigurationDnsSettings.DeserializeVirtualMachineScaleSetNetworkConfigurationDnsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            List<VirtualMachineScaleSetIPConfiguration> array = new List<VirtualMachineScaleSetIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualMachineScaleSetIPConfiguration.DeserializeVirtualMachineScaleSetIPConfiguration(item));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("enableIPForwarding"))
                        {
                            enableIPForwarding = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineScaleSetNetworkConfiguration(id.Value, name, Optional.ToNullable(primary), Optional.ToNullable(enableAcceleratedNetworking), networkSecurityGroup.Value, dnsSettings.Value, Optional.ToList(ipConfigurations), Optional.ToNullable(enableIPForwarding));
        }
    }
}
