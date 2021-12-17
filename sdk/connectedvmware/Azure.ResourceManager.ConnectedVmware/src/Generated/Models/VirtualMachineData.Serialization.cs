// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVmware.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVmware
{
    public partial class VirtualMachineData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourcePoolId))
            {
                writer.WritePropertyName("resourcePoolId");
                writer.WriteStringValue(ResourcePoolId);
            }
            if (Optional.IsDefined(TemplateId))
            {
                writer.WritePropertyName("templateId");
                writer.WriteStringValue(TemplateId);
            }
            if (Optional.IsDefined(VCenterId))
            {
                writer.WritePropertyName("vCenterId");
                writer.WriteStringValue(VCenterId);
            }
            if (Optional.IsDefined(PlacementProfile))
            {
                writer.WritePropertyName("placementProfile");
                writer.WriteObjectValue(PlacementProfile);
            }
            if (Optional.IsDefined(OsProfile))
            {
                writer.WritePropertyName("osProfile");
                writer.WriteObjectValue(OsProfile);
            }
            if (Optional.IsDefined(HardwareProfile))
            {
                writer.WritePropertyName("hardwareProfile");
                writer.WriteObjectValue(HardwareProfile);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile");
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile");
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(GuestAgentProfile))
            {
                writer.WritePropertyName("guestAgentProfile");
                writer.WriteObjectValue(GuestAgentProfile);
            }
            if (Optional.IsDefined(MoRefId))
            {
                writer.WritePropertyName("moRefId");
                writer.WriteStringValue(MoRefId);
            }
            if (Optional.IsDefined(InventoryItemId))
            {
                writer.WritePropertyName("inventoryItemId");
                writer.WriteStringValue(InventoryItemId);
            }
            if (Optional.IsDefined(SmbiosUuid))
            {
                writer.WritePropertyName("smbiosUuid");
                writer.WriteStringValue(SmbiosUuid);
            }
            if (Optional.IsDefined(FirmwareType))
            {
                writer.WritePropertyName("firmwareType");
                writer.WriteStringValue(FirmwareType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineData DeserializeVirtualMachineData(JsonElement element)
        {
            Optional<CheckNameAvailabilityRequest> extendedLocation = default;
            Optional<SystemData> systemData = default;
            Optional<string> kind = default;
            Optional<VmwareIdentity> identity = default;
            IDictionary<string, string> tags = default;
            Location location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> resourcePoolId = default;
            Optional<string> templateId = default;
            Optional<string> vCenterId = default;
            Optional<PlacementProfile> placementProfile = default;
            Optional<OsProfile> osProfile = default;
            Optional<HardwareProfile> hardwareProfile = default;
            Optional<NetworkProfile> networkProfile = default;
            Optional<StorageProfile> storageProfile = default;
            Optional<GuestAgentProfile> guestAgentProfile = default;
            Optional<string> moRefId = default;
            Optional<string> inventoryItemId = default;
            Optional<string> moName = default;
            Optional<string> folderPath = default;
            Optional<string> instanceUuid = default;
            Optional<string> smbiosUuid = default;
            Optional<FirmwareType> firmwareType = default;
            Optional<string> powerState = default;
            Optional<string> customResourceName = default;
            Optional<string> uuid = default;
            Optional<IReadOnlyList<ResourceStatus>> statuses = default;
            Optional<string> provisioningState = default;
            Optional<string> vmId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<CheckNameAvailabilityRequest>(property.Value.ToString());
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
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = VmwareIdentity.DeserializeVmwareIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("resourcePoolId"))
                        {
                            resourcePoolId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("templateId"))
                        {
                            templateId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vCenterId"))
                        {
                            vCenterId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("placementProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            placementProfile = PlacementProfile.DeserializePlacementProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("osProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            osProfile = OsProfile.DeserializeOsProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hardwareProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hardwareProfile = HardwareProfile.DeserializeHardwareProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkProfile = NetworkProfile.DeserializeNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageProfile = StorageProfile.DeserializeStorageProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("guestAgentProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            guestAgentProfile = GuestAgentProfile.DeserializeGuestAgentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("moRefId"))
                        {
                            moRefId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inventoryItemId"))
                        {
                            inventoryItemId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moName"))
                        {
                            moName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("folderPath"))
                        {
                            folderPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceUuid"))
                        {
                            instanceUuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("smbiosUuid"))
                        {
                            smbiosUuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("firmwareType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            firmwareType = new FirmwareType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("powerState"))
                        {
                            powerState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customResourceName"))
                        {
                            customResourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uuid"))
                        {
                            uuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statuses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ResourceStatus> array = new List<ResourceStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResourceStatus.DeserializeResourceStatus(item));
                            }
                            statuses = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmId"))
                        {
                            vmId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineData(id, name, type, tags, location, extendedLocation, systemData, kind.Value, identity.Value, resourcePoolId.Value, templateId.Value, vCenterId.Value, placementProfile.Value, osProfile.Value, hardwareProfile.Value, networkProfile.Value, storageProfile.Value, guestAgentProfile.Value, moRefId.Value, inventoryItemId.Value, moName.Value, folderPath.Value, instanceUuid.Value, smbiosUuid.Value, Optional.ToNullable(firmwareType), powerState.Value, customResourceName.Value, uuid.Value, Optional.ToList(statuses), provisioningState.Value, vmId.Value);
        }
    }
}
