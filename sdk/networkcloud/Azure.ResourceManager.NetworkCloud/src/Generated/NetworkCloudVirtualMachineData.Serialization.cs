// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudVirtualMachineData : IUtf8JsonSerializable, IJsonModel<NetworkCloudVirtualMachineData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudVirtualMachineData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkCloudVirtualMachineData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudVirtualMachineData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudVirtualMachineData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("extendedLocation"u8);
            writer.WriteObjectValue(ExtendedLocation, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("adminUsername"u8);
            writer.WriteStringValue(AdminUsername);
            if (options.Format != "W" && Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone);
            }
            if (options.Format != "W" && Optional.IsDefined(BareMetalMachineId))
            {
                writer.WritePropertyName("bareMetalMachineId"u8);
                writer.WriteStringValue(BareMetalMachineId);
            }
            if (Optional.IsDefined(BootMethod))
            {
                writer.WritePropertyName("bootMethod"u8);
                writer.WriteStringValue(BootMethod.Value.ToString());
            }
            writer.WritePropertyName("cloudServicesNetworkAttachment"u8);
            writer.WriteObjectValue(CloudServicesNetworkAttachment, options);
            if (options.Format != "W" && Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId"u8);
                writer.WriteStringValue(ClusterId);
            }
            writer.WritePropertyName("cpuCores"u8);
            writer.WriteNumberValue(CpuCores);
            if (options.Format != "W" && Optional.IsDefined(DetailedStatus))
            {
                writer.WritePropertyName("detailedStatus"u8);
                writer.WriteStringValue(DetailedStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatusMessage))
            {
                writer.WritePropertyName("detailedStatusMessage"u8);
                writer.WriteStringValue(DetailedStatusMessage);
            }
            if (Optional.IsDefined(IsolateEmulatorThread))
            {
                writer.WritePropertyName("isolateEmulatorThread"u8);
                writer.WriteStringValue(IsolateEmulatorThread.Value.ToString());
            }
            writer.WritePropertyName("memorySizeGB"u8);
            writer.WriteNumberValue(MemorySizeInGB);
            if (Optional.IsCollectionDefined(NetworkAttachments))
            {
                writer.WritePropertyName("networkAttachments"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkAttachments)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkData))
            {
                writer.WritePropertyName("networkData"u8);
                writer.WriteStringValue(NetworkData);
            }
            if (Optional.IsCollectionDefined(PlacementHints))
            {
                writer.WritePropertyName("placementHints"u8);
                writer.WriteStartArray();
                foreach (var item in PlacementHints)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(PowerState))
            {
                writer.WritePropertyName("powerState"u8);
                writer.WriteStringValue(PowerState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SshPublicKeys))
            {
                writer.WritePropertyName("sshPublicKeys"u8);
                writer.WriteStartArray();
                foreach (var item in SshPublicKeys)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("storageProfile"u8);
            writer.WriteObjectValue(StorageProfile, options);
            if (Optional.IsDefined(UserData))
            {
                writer.WritePropertyName("userData"u8);
                writer.WriteStringValue(UserData);
            }
            if (Optional.IsDefined(VirtioInterface))
            {
                writer.WritePropertyName("virtioInterface"u8);
                writer.WriteStringValue(VirtioInterface.Value.ToString());
            }
            if (Optional.IsDefined(VmDeviceModel))
            {
                writer.WritePropertyName("vmDeviceModel"u8);
                writer.WriteStringValue(VmDeviceModel.Value.ToString());
            }
            writer.WritePropertyName("vmImage"u8);
            writer.WriteStringValue(VmImage);
            if (Optional.IsDefined(VmImageRepositoryCredentials))
            {
                writer.WritePropertyName("vmImageRepositoryCredentials"u8);
                writer.WriteObjectValue(VmImageRepositoryCredentials, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Volumes))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        NetworkCloudVirtualMachineData IJsonModel<NetworkCloudVirtualMachineData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudVirtualMachineData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudVirtualMachineData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudVirtualMachineData(document.RootElement, options);
        }

        internal static NetworkCloudVirtualMachineData DeserializeNetworkCloudVirtualMachineData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string adminUsername = default;
            string availabilityZone = default;
            ResourceIdentifier bareMetalMachineId = default;
            VirtualMachineBootMethod? bootMethod = default;
            NetworkAttachment cloudServicesNetworkAttachment = default;
            ResourceIdentifier clusterId = default;
            long cpuCores = default;
            VirtualMachineDetailedStatus? detailedStatus = default;
            string detailedStatusMessage = default;
            VirtualMachineIsolateEmulatorThread? isolateEmulatorThread = default;
            long memorySizeGB = default;
            IList<NetworkAttachment> networkAttachments = default;
            string networkData = default;
            IList<VirtualMachinePlacementHint> placementHints = default;
            VirtualMachinePowerState? powerState = default;
            VirtualMachineProvisioningState? provisioningState = default;
            IList<NetworkCloudSshPublicKey> sshPublicKeys = default;
            NetworkCloudStorageProfile storageProfile = default;
            string userData = default;
            VirtualMachineVirtioInterfaceType? virtioInterface = default;
            VirtualMachineDeviceModelType? vmDeviceModel = default;
            string vmImage = default;
            ImageRepositoryCredentials vmImageRepositoryCredentials = default;
            IReadOnlyList<ResourceIdentifier> volumes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value, options);
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
                        if (property0.NameEquals("adminUsername"u8))
                        {
                            adminUsername = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"u8))
                        {
                            availabilityZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bareMetalMachineId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bareMetalMachineId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("bootMethod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bootMethod = new VirtualMachineBootMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cloudServicesNetworkAttachment"u8))
                        {
                            cloudServicesNetworkAttachment = NetworkAttachment.DeserializeNetworkAttachment(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cpuCores"u8))
                        {
                            cpuCores = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new VirtualMachineDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isolateEmulatorThread"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isolateEmulatorThread = new VirtualMachineIsolateEmulatorThread(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("memorySizeGB"u8))
                        {
                            memorySizeGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("networkAttachments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkAttachment> array = new List<NetworkAttachment>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkAttachment.DeserializeNetworkAttachment(item, options));
                            }
                            networkAttachments = array;
                            continue;
                        }
                        if (property0.NameEquals("networkData"u8))
                        {
                            networkData = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("placementHints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualMachinePlacementHint> array = new List<VirtualMachinePlacementHint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualMachinePlacementHint.DeserializeVirtualMachinePlacementHint(item, options));
                            }
                            placementHints = array;
                            continue;
                        }
                        if (property0.NameEquals("powerState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            powerState = new VirtualMachinePowerState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VirtualMachineProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sshPublicKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkCloudSshPublicKey> array = new List<NetworkCloudSshPublicKey>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkCloudSshPublicKey.DeserializeNetworkCloudSshPublicKey(item, options));
                            }
                            sshPublicKeys = array;
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"u8))
                        {
                            storageProfile = NetworkCloudStorageProfile.DeserializeNetworkCloudStorageProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("userData"u8))
                        {
                            userData = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtioInterface"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtioInterface = new VirtualMachineVirtioInterfaceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vmDeviceModel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmDeviceModel = new VirtualMachineDeviceModelType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vmImage"u8))
                        {
                            vmImage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmImageRepositoryCredentials"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmImageRepositoryCredentials = ImageRepositoryCredentials.DeserializeImageRepositoryCredentials(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("volumes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            volumes = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkCloudVirtualMachineData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                extendedLocation,
                adminUsername,
                availabilityZone,
                bareMetalMachineId,
                bootMethod,
                cloudServicesNetworkAttachment,
                clusterId,
                cpuCores,
                detailedStatus,
                detailedStatusMessage,
                isolateEmulatorThread,
                memorySizeGB,
                networkAttachments ?? new ChangeTrackingList<NetworkAttachment>(),
                networkData,
                placementHints ?? new ChangeTrackingList<VirtualMachinePlacementHint>(),
                powerState,
                provisioningState,
                sshPublicKeys ?? new ChangeTrackingList<NetworkCloudSshPublicKey>(),
                storageProfile,
                userData,
                virtioInterface,
                vmDeviceModel,
                vmImage,
                vmImageRepositoryCredentials,
                volumes ?? new ChangeTrackingList<ResourceIdentifier>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudVirtualMachineData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudVirtualMachineData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudVirtualMachineData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkCloudVirtualMachineData IPersistableModel<NetworkCloudVirtualMachineData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudVirtualMachineData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkCloudVirtualMachineData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudVirtualMachineData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudVirtualMachineData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
