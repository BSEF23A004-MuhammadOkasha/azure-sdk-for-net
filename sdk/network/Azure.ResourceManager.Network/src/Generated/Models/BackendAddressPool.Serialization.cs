// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BackendAddressPool : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LoadBalancerBackendAddresses))
            {
                writer.WritePropertyName("loadBalancerBackendAddresses");
                writer.WriteStartArray();
                foreach (var item in LoadBalancerBackendAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BackendAddressPool DeserializeBackendAddressPool(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<IReadOnlyList<NetworkInterfaceIPConfiguration>> backendIPConfigurations = default;
            Optional<IList<LoadBalancerBackendAddress>> loadBalancerBackendAddresses = default;
            Optional<IReadOnlyList<SubResource>> loadBalancingRules = default;
            Optional<SubResource> outboundRule = default;
            Optional<IReadOnlyList<SubResource>> outboundRules = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("backendIPConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<NetworkInterfaceIPConfiguration> array = new List<NetworkInterfaceIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceIPConfiguration.DeserializeNetworkInterfaceIPConfiguration(item));
                            }
                            backendIPConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerBackendAddresses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<LoadBalancerBackendAddress> array = new List<LoadBalancerBackendAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LoadBalancerBackendAddress.DeserializeLoadBalancerBackendAddress(item));
                            }
                            loadBalancerBackendAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            loadBalancingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("outboundRule"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            outboundRule = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outboundRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            outboundRules = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BackendAddressPool(id.Value, name.Value, etag.Value, type.Value, Optional.ToList(backendIPConfigurations), Optional.ToList(loadBalancerBackendAddresses), Optional.ToList(loadBalancingRules), outboundRule.Value, Optional.ToList(outboundRules), Optional.ToNullable(provisioningState));
        }
    }
}
