// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkSecurityGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Optional.IsCollectionDefined(SecurityRules))
            {
                writer.WritePropertyName("securityRules");
                writer.WriteStartArray();
                foreach (var item in SecurityRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkSecurityGroupData DeserializeNetworkSecurityGroupData(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<SecurityRuleData>> securityRules = default;
            Optional<IReadOnlyList<SecurityRuleData>> defaultSecurityRules = default;
            Optional<IReadOnlyList<NetworkInterfaceData>> networkInterfaces = default;
            Optional<IReadOnlyList<SubnetData>> subnets = default;
            Optional<IReadOnlyList<FlowLogData>> flowLogs = default;
            Optional<Guid> resourceGuid = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("securityRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SecurityRuleData> array = new List<SecurityRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityRuleData.DeserializeSecurityRuleData(item));
                            }
                            securityRules = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultSecurityRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SecurityRuleData> array = new List<SecurityRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityRuleData.DeserializeSecurityRuleData(item));
                            }
                            defaultSecurityRules = array;
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
                        if (property0.NameEquals("subnets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubnetData> array = new List<SubnetData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubnetData.DeserializeSubnetData(item));
                            }
                            subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("flowLogs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FlowLogData> array = new List<FlowLogData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FlowLogData.DeserializeFlowLogData(item));
                            }
                            flowLogs = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
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
                    }
                    continue;
                }
            }
            return new NetworkSecurityGroupData(id.Value, name.Value, Optional.ToNullable(type), location.Value, Optional.ToDictionary(tags), etag.Value, Optional.ToList(securityRules), Optional.ToList(defaultSecurityRules), Optional.ToList(networkInterfaces), Optional.ToList(subnets), Optional.ToList(flowLogs), Optional.ToNullable(resourceGuid), Optional.ToNullable(provisioningState));
        }
    }
}
