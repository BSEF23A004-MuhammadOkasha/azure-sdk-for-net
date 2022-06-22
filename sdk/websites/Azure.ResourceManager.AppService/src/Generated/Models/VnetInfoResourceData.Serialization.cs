// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class VnetInfoResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VnetResourceId))
            {
                writer.WritePropertyName("vnetResourceId");
                writer.WriteStringValue(VnetResourceId);
            }
            if (Optional.IsDefined(CertBlob))
            {
                writer.WritePropertyName("certBlob");
                writer.WriteStringValue(CertBlob);
            }
            if (Optional.IsDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers");
                writer.WriteStringValue(DnsServers);
            }
            if (Optional.IsDefined(IsSwift))
            {
                writer.WritePropertyName("isSwift");
                writer.WriteBooleanValue(IsSwift.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VnetInfoResourceData DeserializeVnetInfoResourceData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> vnetResourceId = default;
            Optional<string> certThumbprint = default;
            Optional<string> certBlob = default;
            Optional<IReadOnlyList<VnetRoute>> routes = default;
            Optional<bool> resyncRequired = default;
            Optional<string> dnsServers = default;
            Optional<bool> isSwift = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("vnetResourceId"))
                        {
                            vnetResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("certThumbprint"))
                        {
                            certThumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("certBlob"))
                        {
                            certBlob = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VnetRoute> array = new List<VnetRoute>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VnetRoute.DeserializeVnetRoute(item));
                            }
                            routes = array;
                            continue;
                        }
                        if (property0.NameEquals("resyncRequired"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resyncRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dnsServers"))
                        {
                            dnsServers = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isSwift"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isSwift = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VnetInfoResourceData(id, name, type, systemData.Value, kind.Value, vnetResourceId.Value, certThumbprint.Value, certBlob.Value, Optional.ToList(routes), Optional.ToNullable(resyncRequired), dnsServers.Value, Optional.ToNullable(isSwift));
        }
    }
}
