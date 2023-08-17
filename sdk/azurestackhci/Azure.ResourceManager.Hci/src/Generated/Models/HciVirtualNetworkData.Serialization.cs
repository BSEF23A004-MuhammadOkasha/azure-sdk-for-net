// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class HciVirtualNetworkData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                writer.WriteObjectValue(ExtendedLocation);
            }
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
            if (Optional.IsDefined(DhcpOptions))
            {
                writer.WritePropertyName("dhcpOptions"u8);
                writer.WriteObjectValue(DhcpOptions);
            }
            if (Optional.IsDefined(NetworkType))
            {
                writer.WritePropertyName("networkType"u8);
                writer.WriteStringValue(NetworkType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Subnets))
            {
                writer.WritePropertyName("subnets"u8);
                writer.WriteStartArray();
                foreach (var item in Subnets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VmSwitchName))
            {
                writer.WritePropertyName("vmSwitchName"u8);
                writer.WriteStringValue(VmSwitchName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HciVirtualNetworkData DeserializeHciVirtualNetworkData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HciExtendedLocation> extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<VirtualNetworkPropertiesDhcpOptions> dhcpOptions = default;
            Optional<HciNetworkType> networkType = default;
            Optional<IList<HciSubnet>> subnets = default;
            Optional<HciGenericProvisioningState> provisioningState = default;
            Optional<string> vmSwitchName = default;
            Optional<HciVirtualNetworkStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = HciExtendedLocation.DeserializeHciExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dhcpOptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dhcpOptions = VirtualNetworkPropertiesDhcpOptions.DeserializeVirtualNetworkPropertiesDhcpOptions(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkType = new HciNetworkType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HciSubnet> array = new List<HciSubnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HciSubnet.DeserializeHciSubnet(item));
                            }
                            subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HciGenericProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vmSwitchName"u8))
                        {
                            vmSwitchName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = HciVirtualNetworkStatus.DeserializeHciVirtualNetworkStatus(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HciVirtualNetworkData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation.Value, dhcpOptions.Value, Optional.ToNullable(networkType), Optional.ToList(subnets), Optional.ToNullable(provisioningState), vmSwitchName.Value, status.Value);
        }
    }
}
