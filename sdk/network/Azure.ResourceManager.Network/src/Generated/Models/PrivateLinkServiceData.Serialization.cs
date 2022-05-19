// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class PrivateLinkServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                writer.WriteObjectValue(ExtendedLocation);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LoadBalancerFrontendIPConfigurations))
            {
                writer.WritePropertyName("loadBalancerFrontendIpConfigurations");
                writer.WriteStartArray();
                foreach (var item in LoadBalancerFrontendIPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations");
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility");
                writer.WriteObjectValue(Visibility);
            }
            if (Optional.IsDefined(AutoApproval))
            {
                writer.WritePropertyName("autoApproval");
                writer.WriteObjectValue(AutoApproval);
            }
            if (Optional.IsCollectionDefined(Fqdns))
            {
                writer.WritePropertyName("fqdns");
                writer.WriteStartArray();
                foreach (var item in Fqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableProxyProtocol))
            {
                writer.WritePropertyName("enableProxyProtocol");
                writer.WriteBooleanValue(EnableProxyProtocol.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PrivateLinkServiceData DeserializePrivateLinkServiceData(JsonElement element)
        {
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<string> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<FrontendIPConfigurationData>> loadBalancerFrontendIpConfigurations = default;
            Optional<IList<PrivateLinkServiceIPConfiguration>> ipConfigurations = default;
            Optional<IReadOnlyList<NetworkInterfaceData>> networkInterfaces = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<NetworkPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<PrivateLinkServicePropertiesVisibility> visibility = default;
            Optional<PrivateLinkServicePropertiesAutoApproval> autoApproval = default;
            Optional<IList<string>> fqdns = default;
            Optional<string> @alias = default;
            Optional<bool> enableProxyProtocol = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("loadBalancerFrontendIpConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FrontendIPConfigurationData> array = new List<FrontendIPConfigurationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontendIPConfigurationData.DeserializeFrontendIPConfigurationData(item));
                            }
                            loadBalancerFrontendIpConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PrivateLinkServiceIPConfiguration> array = new List<PrivateLinkServiceIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateLinkServiceIPConfiguration.DeserializePrivateLinkServiceIPConfiguration(item));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NetworkInterfaceData> array = new List<NetworkInterfaceData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceData.DeserializeNetworkInterfaceData(item));
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NetworkPrivateEndpointConnectionData> array = new List<NetworkPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkPrivateEndpointConnectionData.DeserializeNetworkPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("visibility"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            visibility = PrivateLinkServicePropertiesVisibility.DeserializePrivateLinkServicePropertiesVisibility(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("autoApproval"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoApproval = PrivateLinkServicePropertiesAutoApproval.DeserializePrivateLinkServicePropertiesAutoApproval(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("fqdns"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            fqdns = array;
                            continue;
                        }
                        if (property0.NameEquals("alias"))
                        {
                            @alias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableProxyProtocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableProxyProtocol = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PrivateLinkServiceData(id.Value, name.Value, Optional.ToNullable(type), location.Value, Optional.ToDictionary(tags), extendedLocation.Value, etag.Value, Optional.ToList(loadBalancerFrontendIpConfigurations), Optional.ToList(ipConfigurations), Optional.ToList(networkInterfaces), Optional.ToNullable(provisioningState), Optional.ToList(privateEndpointConnections), visibility.Value, autoApproval.Value, Optional.ToList(fqdns), @alias.Value, Optional.ToNullable(enableProxyProtocol));
        }
    }
}
