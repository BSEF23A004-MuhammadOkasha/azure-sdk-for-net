// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRoutePortData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location.Value);
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
            if (Optional.IsDefined(PeeringLocation))
            {
                writer.WritePropertyName("peeringLocation");
                writer.WriteStringValue(PeeringLocation);
            }
            if (Optional.IsDefined(BandwidthInGbps))
            {
                writer.WritePropertyName("bandwidthInGbps");
                writer.WriteNumberValue(BandwidthInGbps.Value);
            }
            if (Optional.IsDefined(Encapsulation))
            {
                writer.WritePropertyName("encapsulation");
                writer.WriteStringValue(Encapsulation.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Links))
            {
                writer.WritePropertyName("links");
                writer.WriteStartArray();
                foreach (var item in Links)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRoutePortData DeserializeExpressRoutePortData(JsonElement element)
        {
            Optional<ETag> etag = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> peeringLocation = default;
            Optional<int> bandwidthInGbps = default;
            Optional<float> provisionedBandwidthInGbps = default;
            Optional<string> mtu = default;
            Optional<ExpressRoutePortsEncapsulation> encapsulation = default;
            Optional<string> etherType = default;
            Optional<string> allocationDate = default;
            Optional<IList<ExpressRouteLinkData>> links = default;
            Optional<IReadOnlyList<WritableSubResource>> circuits = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<Guid> resourceGuid = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("peeringLocation"))
                        {
                            peeringLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bandwidthInGbps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bandwidthInGbps = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisionedBandwidthInGbps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisionedBandwidthInGbps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("mtu"))
                        {
                            mtu = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encapsulation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encapsulation = new ExpressRoutePortsEncapsulation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("etherType"))
                        {
                            etherType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allocationDate"))
                        {
                            allocationDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("links"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ExpressRouteLinkData> array = new List<ExpressRouteLinkData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteLinkData.DeserializeExpressRouteLinkData(item));
                            }
                            links = array;
                            continue;
                        }
                        if (property0.NameEquals("circuits"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            circuits = array;
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
                    }
                    continue;
                }
            }
            return new ExpressRoutePortData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), Optional.ToNullable(etag), identity, peeringLocation.Value, Optional.ToNullable(bandwidthInGbps), Optional.ToNullable(provisionedBandwidthInGbps), mtu.Value, Optional.ToNullable(encapsulation), etherType.Value, allocationDate.Value, Optional.ToList(links), Optional.ToList(circuits), Optional.ToNullable(provisioningState), Optional.ToNullable(resourceGuid));
        }
    }
}
