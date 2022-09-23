// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverVirtualNetworkResourceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
            }
            if (Optional.IsDefined(EnableDdosProtection))
            {
                if (EnableDdosProtection != null)
                {
                    writer.WritePropertyName("enableDdosProtection");
                    writer.WriteBooleanValue(EnableDdosProtection.Value);
                }
                else
                {
                    writer.WriteNull("enableDdosProtection");
                }
            }
            if (Optional.IsCollectionDefined(AddressSpace))
            {
                if (AddressSpace != null)
                {
                    writer.WritePropertyName("addressSpace");
                    writer.WriteStartArray();
                    foreach (var item in AddressSpace)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("addressSpace");
                }
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                if (DnsServers != null)
                {
                    writer.WritePropertyName("dnsServers");
                    writer.WriteStartArray();
                    foreach (var item in DnsServers)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("dnsServers");
                }
            }
            if (Optional.IsCollectionDefined(Subnets))
            {
                if (Subnets != null)
                {
                    writer.WritePropertyName("subnets");
                    writer.WriteStartArray();
                    foreach (var item in Subnets)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("subnets");
                }
            }
            writer.WritePropertyName("resourceType");
            writer.WriteStringValue(ResourceType);
            writer.WritePropertyName("targetResourceName");
            writer.WriteStringValue(TargetResourceName);
            writer.WriteEndObject();
        }

        internal static MoverVirtualNetworkResourceSettings DeserializeMoverVirtualNetworkResourceSettings(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            Optional<bool?> enableDdosProtection = default;
            Optional<IList<string>> addressSpace = default;
            Optional<IList<string>> dnsServers = default;
            Optional<IList<SubnetResourceSettings>> subnets = default;
            string resourceType = default;
            string targetResourceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (property.NameEquals("enableDdosProtection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableDdosProtection = null;
                        continue;
                    }
                    enableDdosProtection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("addressSpace"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        addressSpace = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressSpace = array;
                    continue;
                }
                if (property.NameEquals("dnsServers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dnsServers = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("subnets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subnets = null;
                        continue;
                    }
                    List<SubnetResourceSettings> array = new List<SubnetResourceSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubnetResourceSettings.DeserializeSubnetResourceSettings(item));
                    }
                    subnets = array;
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
            }
            return new MoverVirtualNetworkResourceSettings(resourceType, targetResourceName, Optional.ToDictionary(tags), Optional.ToNullable(enableDdosProtection), Optional.ToList(addressSpace), Optional.ToList(dnsServers), Optional.ToList(subnets));
        }
    }
}
