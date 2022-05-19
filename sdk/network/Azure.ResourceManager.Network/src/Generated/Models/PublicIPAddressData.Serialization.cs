// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class PublicIPAddressData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                writer.WriteObjectValue(ExtendedLocation);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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
            if (Optional.IsDefined(PublicIPAllocationMethod))
            {
                writer.WritePropertyName("publicIPAllocationMethod");
                writer.WriteStringValue(PublicIPAllocationMethod.Value.ToString());
            }
            if (Optional.IsDefined(PublicIPAddressVersion))
            {
                writer.WritePropertyName("publicIPAddressVersion");
                writer.WriteStringValue(PublicIPAddressVersion.Value.ToString());
            }
            if (Optional.IsDefined(DnsSettings))
            {
                writer.WritePropertyName("dnsSettings");
                writer.WriteObjectValue(DnsSettings);
            }
            if (Optional.IsDefined(DdosSettings))
            {
                writer.WritePropertyName("ddosSettings");
                writer.WriteObjectValue(DdosSettings);
            }
            if (Optional.IsCollectionDefined(IPTags))
            {
                writer.WritePropertyName("ipTags");
                writer.WriteStartArray();
                foreach (var item in IPTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress");
                writer.WriteStringValue(IPAddress);
            }
            if (Optional.IsDefined(PublicIPPrefix))
            {
                writer.WritePropertyName("publicIPPrefix");
                JsonSerializer.Serialize(writer, PublicIPPrefix);
            }
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes");
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(ServicePublicIPAddress))
            {
                writer.WritePropertyName("servicePublicIPAddress");
                writer.WriteObjectValue(ServicePublicIPAddress);
            }
            if (Optional.IsDefined(NatGateway))
            {
                writer.WritePropertyName("natGateway");
                writer.WriteObjectValue(NatGateway);
            }
            if (Optional.IsDefined(MigrationPhase))
            {
                writer.WritePropertyName("migrationPhase");
                writer.WriteStringValue(MigrationPhase.Value.ToString());
            }
            if (Optional.IsDefined(LinkedPublicIPAddress))
            {
                writer.WritePropertyName("linkedPublicIPAddress");
                writer.WriteObjectValue(LinkedPublicIPAddress);
            }
            if (Optional.IsDefined(DeleteOption))
            {
                writer.WritePropertyName("deleteOption");
                writer.WriteStringValue(DeleteOption.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PublicIPAddressData DeserializePublicIPAddressData(JsonElement element)
        {
            Optional<Models.ExtendedLocation> extendedLocation = default;
            Optional<PublicIPAddressSku> sku = default;
            Optional<string> etag = default;
            Optional<IList<string>> zones = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IPAllocationMethod> publicIPAllocationMethod = default;
            Optional<IPVersion> publicIPAddressVersion = default;
            Optional<IPConfiguration> ipConfiguration = default;
            Optional<PublicIPAddressDnsSettings> dnsSettings = default;
            Optional<DdosSettings> ddosSettings = default;
            Optional<IList<IPTag>> ipTags = default;
            Optional<string> ipAddress = default;
            Optional<WritableSubResource> publicIPPrefix = default;
            Optional<int> idleTimeoutInMinutes = default;
            Optional<Guid> resourceGuid = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<PublicIPAddressData> servicePublicIPAddress = default;
            Optional<NatGatewayData> natGateway = default;
            Optional<PublicIPAddressMigrationPhase> migrationPhase = default;
            Optional<PublicIPAddressData> linkedPublicIPAddress = default;
            Optional<DeleteOptions> deleteOption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocation = Models.ExtendedLocation.DeserializeExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = PublicIPAddressSku.DeserializePublicIPAddressSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
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
                        if (property0.NameEquals("publicIPAllocationMethod"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicIPAllocationMethod = new IPAllocationMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddressVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ipConfiguration = IPConfiguration.DeserializeIPConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dnsSettings = PublicIPAddressDnsSettings.DeserializePublicIPAddressDnsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ddosSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ddosSettings = DdosSettings.DeserializeDdosSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipTags"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<IPTag> array = new List<IPTag>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IPTag.DeserializeIPTag(item));
                            }
                            ipTags = array;
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicIPPrefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicIPPrefix = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("idleTimeoutInMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            idleTimeoutInMinutes = property0.Value.GetInt32();
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
                        if (property0.NameEquals("servicePublicIPAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            servicePublicIPAddress = DeserializePublicIPAddressData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("natGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            natGateway = NatGatewayData.DeserializeNatGatewayData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("migrationPhase"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            migrationPhase = new PublicIPAddressMigrationPhase(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("linkedPublicIPAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            linkedPublicIPAddress = DeserializePublicIPAddressData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("deleteOption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deleteOption = new DeleteOptions(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PublicIPAddressData(id.Value, name.Value, Optional.ToNullable(type), location.Value, Optional.ToDictionary(tags), extendedLocation.Value, sku.Value, etag.Value, Optional.ToList(zones), Optional.ToNullable(publicIPAllocationMethod), Optional.ToNullable(publicIPAddressVersion), ipConfiguration.Value, dnsSettings.Value, ddosSettings.Value, Optional.ToList(ipTags), ipAddress.Value, publicIPPrefix, Optional.ToNullable(idleTimeoutInMinutes), Optional.ToNullable(resourceGuid), Optional.ToNullable(provisioningState), servicePublicIPAddress.Value, natGateway.Value, Optional.ToNullable(migrationPhase), linkedPublicIPAddress.Value, Optional.ToNullable(deleteOption));
        }
    }
}
