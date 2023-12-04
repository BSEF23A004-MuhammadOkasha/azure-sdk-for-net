// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class HyperVToAzStackHciProtectedItemModelCustomProperties : IUtf8JsonSerializable, IJsonModel<HyperVToAzStackHciProtectedItemModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVToAzStackHciProtectedItemModelCustomProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HyperVToAzStackHciProtectedItemModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciProtectedItemModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(HyperVToAzStackHciProtectedItemModelCustomProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ActiveLocation))
            {
                writer.WritePropertyName("activeLocation"u8);
                writer.WriteStringValue(ActiveLocation.Value.ToString());
            }
            writer.WritePropertyName("targetHciClusterId"u8);
            writer.WriteStringValue(TargetHciClusterId);
            writer.WritePropertyName("targetArcClusterCustomLocationId"u8);
            writer.WriteStringValue(TargetArcClusterCustomLocationId);
            if (options.Format != "W" && Optional.IsDefined(TargetAzStackHciClusterName))
            {
                writer.WritePropertyName("targetAzStackHciClusterName"u8);
                writer.WriteStringValue(TargetAzStackHciClusterName);
            }
            writer.WritePropertyName("fabricDiscoveryMachineId"u8);
            writer.WriteStringValue(FabricDiscoveryMachineId);
            writer.WritePropertyName("disksToInclude"u8);
            writer.WriteStartArray();
            foreach (var item in DisksToInclude)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("nicsToInclude"u8);
            writer.WriteStartArray();
            foreach (var item in NicsToInclude)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsDefined(SourceVmName))
            {
                writer.WritePropertyName("sourceVmName"u8);
                writer.WriteStringValue(SourceVmName);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceCpuCores))
            {
                writer.WritePropertyName("sourceCpuCores"u8);
                writer.WriteNumberValue(SourceCpuCores.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceMemoryInMegaBytes))
            {
                writer.WritePropertyName("sourceMemoryInMegaBytes"u8);
                writer.WriteNumberValue(SourceMemoryInMegaBytes.Value);
            }
            if (Optional.IsDefined(TargetVmName))
            {
                writer.WritePropertyName("targetVmName"u8);
                writer.WriteStringValue(TargetVmName);
            }
            writer.WritePropertyName("targetResourceGroupId"u8);
            writer.WriteStringValue(TargetResourceGroupId);
            writer.WritePropertyName("storageContainerId"u8);
            writer.WriteStringValue(StorageContainerId);
            writer.WritePropertyName("hyperVGeneration"u8);
            writer.WriteStringValue(HyperVGeneration);
            if (Optional.IsDefined(TargetNetworkId))
            {
                writer.WritePropertyName("targetNetworkId"u8);
                writer.WriteStringValue(TargetNetworkId);
            }
            if (Optional.IsDefined(TestNetworkId))
            {
                writer.WritePropertyName("testNetworkId"u8);
                writer.WriteStringValue(TestNetworkId);
            }
            if (Optional.IsDefined(TargetCpuCores))
            {
                writer.WritePropertyName("targetCpuCores"u8);
                writer.WriteNumberValue(TargetCpuCores.Value);
            }
            if (Optional.IsDefined(IsDynamicRam))
            {
                writer.WritePropertyName("isDynamicRam"u8);
                writer.WriteBooleanValue(IsDynamicRam.Value);
            }
            if (Optional.IsDefined(DynamicMemoryConfig))
            {
                writer.WritePropertyName("dynamicMemoryConfig"u8);
                writer.WriteObjectValue(DynamicMemoryConfig);
            }
            if (Optional.IsDefined(TargetMemoryInMegaBytes))
            {
                writer.WritePropertyName("targetMemoryInMegaBytes"u8);
                writer.WriteNumberValue(TargetMemoryInMegaBytes.Value);
            }
            writer.WritePropertyName("runAsAccountId"u8);
            writer.WriteStringValue(RunAsAccountId);
            writer.WritePropertyName("sourceDraName"u8);
            writer.WriteStringValue(SourceDraName);
            writer.WritePropertyName("targetDraName"u8);
            writer.WriteStringValue(TargetDraName);
            if (options.Format != "W" && Optional.IsDefined(SourceApplianceName))
            {
                writer.WritePropertyName("sourceApplianceName"u8);
                writer.WriteStringValue(SourceApplianceName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetApplianceName))
            {
                writer.WritePropertyName("targetApplianceName"u8);
                writer.WriteStringValue(TargetApplianceName);
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (options.Format != "W" && Optional.IsDefined(OSName))
            {
                writer.WritePropertyName("osName"u8);
                writer.WriteStringValue(OSName);
            }
            if (options.Format != "W" && Optional.IsDefined(FirmwareType))
            {
                writer.WritePropertyName("firmwareType"u8);
                writer.WriteStringValue(FirmwareType);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetLocation))
            {
                writer.WritePropertyName("targetLocation"u8);
                writer.WriteStringValue(TargetLocation);
            }
            writer.WritePropertyName("customLocationRegion"u8);
            writer.WriteStringValue(CustomLocationRegion);
            if (options.Format != "W" && Optional.IsDefined(FailoverRecoveryPointId))
            {
                writer.WritePropertyName("failoverRecoveryPointId"u8);
                writer.WriteStringValue(FailoverRecoveryPointId);
            }
            if (options.Format != "W" && Optional.IsDefined(LastRecoveryPointReceived))
            {
                writer.WritePropertyName("lastRecoveryPointReceived"u8);
                writer.WriteStringValue(LastRecoveryPointReceived.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastRecoveryPointId))
            {
                writer.WritePropertyName("lastRecoveryPointId"u8);
                writer.WriteStringValue(LastRecoveryPointId);
            }
            if (options.Format != "W" && Optional.IsDefined(InitialReplicationProgressPercentage))
            {
                writer.WritePropertyName("initialReplicationProgressPercentage"u8);
                writer.WriteNumberValue(InitialReplicationProgressPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncProgressPercentage))
            {
                writer.WritePropertyName("resyncProgressPercentage"u8);
                writer.WriteNumberValue(ResyncProgressPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ProtectedDisks))
            {
                writer.WritePropertyName("protectedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ProtectedNics))
            {
                writer.WritePropertyName("protectedNics"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TargetVmBiosId))
            {
                writer.WritePropertyName("targetVmBiosId"u8);
                writer.WriteStringValue(TargetVmBiosId);
            }
            if (options.Format != "W" && Optional.IsDefined(LastReplicationUpdateOn))
            {
                writer.WritePropertyName("lastReplicationUpdateTime"u8);
                writer.WriteStringValue(LastReplicationUpdateOn.Value, "O");
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        HyperVToAzStackHciProtectedItemModelCustomProperties IJsonModel<HyperVToAzStackHciProtectedItemModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciProtectedItemModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(HyperVToAzStackHciProtectedItemModelCustomProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVToAzStackHciProtectedItemModelCustomProperties(document.RootElement, options);
        }

        internal static HyperVToAzStackHciProtectedItemModelCustomProperties DeserializeHyperVToAzStackHciProtectedItemModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProtectedItemActiveLocation> activeLocation = default;
            ResourceIdentifier targetHciClusterId = default;
            ResourceIdentifier targetArcClusterCustomLocationId = default;
            Optional<string> targetAzStackHciClusterName = default;
            ResourceIdentifier fabricDiscoveryMachineId = default;
            IList<HyperVToAzStackHciDiskInput> disksToInclude = default;
            IList<HyperVToAzStackHciNicInput> nicsToInclude = default;
            Optional<string> sourceVmName = default;
            Optional<int> sourceCpuCores = default;
            Optional<double> sourceMemoryInMegaBytes = default;
            Optional<string> targetVmName = default;
            ResourceIdentifier targetResourceGroupId = default;
            ResourceIdentifier storageContainerId = default;
            string hyperVGeneration = default;
            Optional<string> targetNetworkId = default;
            Optional<string> testNetworkId = default;
            Optional<int> targetCpuCores = default;
            Optional<bool> isDynamicRam = default;
            Optional<ProtectedItemDynamicMemoryConfig> dynamicMemoryConfig = default;
            Optional<int> targetMemoryInMegaBytes = default;
            string runAsAccountId = default;
            string sourceDraName = default;
            string targetDraName = default;
            Optional<string> sourceApplianceName = default;
            Optional<string> targetApplianceName = default;
            Optional<string> osType = default;
            Optional<string> osName = default;
            Optional<string> firmwareType = default;
            Optional<string> targetLocation = default;
            string customLocationRegion = default;
            Optional<string> failoverRecoveryPointId = default;
            Optional<DateTimeOffset> lastRecoveryPointReceived = default;
            Optional<string> lastRecoveryPointId = default;
            Optional<int> initialReplicationProgressPercentage = default;
            Optional<int> resyncProgressPercentage = default;
            Optional<IReadOnlyList<HyperVToAzStackHciProtectedDiskProperties>> protectedDisks = default;
            Optional<IReadOnlyList<HyperVToAzStackHciProtectedNicProperties>> protectedNics = default;
            Optional<string> targetVmBiosId = default;
            Optional<DateTimeOffset> lastReplicationUpdateTime = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activeLocation = new ProtectedItemActiveLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetHciClusterId"u8))
                {
                    targetHciClusterId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetArcClusterCustomLocationId"u8))
                {
                    targetArcClusterCustomLocationId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzStackHciClusterName"u8))
                {
                    targetAzStackHciClusterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricDiscoveryMachineId"u8))
                {
                    fabricDiscoveryMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disksToInclude"u8))
                {
                    List<HyperVToAzStackHciDiskInput> array = new List<HyperVToAzStackHciDiskInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HyperVToAzStackHciDiskInput.DeserializeHyperVToAzStackHciDiskInput(item));
                    }
                    disksToInclude = array;
                    continue;
                }
                if (property.NameEquals("nicsToInclude"u8))
                {
                    List<HyperVToAzStackHciNicInput> array = new List<HyperVToAzStackHciNicInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HyperVToAzStackHciNicInput.DeserializeHyperVToAzStackHciNicInput(item));
                    }
                    nicsToInclude = array;
                    continue;
                }
                if (property.NameEquals("sourceVmName"u8))
                {
                    sourceVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCpuCores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceCpuCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sourceMemoryInMegaBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceMemoryInMegaBytes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("targetVmName"u8))
                {
                    targetVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupId"u8))
                {
                    targetResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageContainerId"u8))
                {
                    storageContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hyperVGeneration"u8))
                {
                    hyperVGeneration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    targetNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    testNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetCpuCores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetCpuCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isDynamicRam"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDynamicRam = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dynamicMemoryConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicMemoryConfig = ProtectedItemDynamicMemoryConfig.DeserializeProtectedItemDynamicMemoryConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("targetMemoryInMegaBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetMemoryInMegaBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("runAsAccountId"u8))
                {
                    runAsAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceDraName"u8))
                {
                    sourceDraName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDraName"u8))
                {
                    targetDraName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceApplianceName"u8))
                {
                    sourceApplianceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetApplianceName"u8))
                {
                    targetApplianceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"u8))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firmwareType"u8))
                {
                    firmwareType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customLocationRegion"u8))
                {
                    customLocationRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failoverRecoveryPointId"u8))
                {
                    failoverRecoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPointReceived = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointId"u8))
                {
                    lastRecoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resyncProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("protectedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HyperVToAzStackHciProtectedDiskProperties> array = new List<HyperVToAzStackHciProtectedDiskProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HyperVToAzStackHciProtectedDiskProperties.DeserializeHyperVToAzStackHciProtectedDiskProperties(item));
                    }
                    protectedDisks = array;
                    continue;
                }
                if (property.NameEquals("protectedNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HyperVToAzStackHciProtectedNicProperties> array = new List<HyperVToAzStackHciProtectedNicProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HyperVToAzStackHciProtectedNicProperties.DeserializeHyperVToAzStackHciProtectedNicProperties(item));
                    }
                    protectedNics = array;
                    continue;
                }
                if (property.NameEquals("targetVmBiosId"u8))
                {
                    targetVmBiosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastReplicationUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReplicationUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HyperVToAzStackHciProtectedItemModelCustomProperties(instanceType, serializedAdditionalRawData, Optional.ToNullable(activeLocation), targetHciClusterId, targetArcClusterCustomLocationId, targetAzStackHciClusterName.Value, fabricDiscoveryMachineId, disksToInclude, nicsToInclude, sourceVmName.Value, Optional.ToNullable(sourceCpuCores), Optional.ToNullable(sourceMemoryInMegaBytes), targetVmName.Value, targetResourceGroupId, storageContainerId, hyperVGeneration, targetNetworkId.Value, testNetworkId.Value, Optional.ToNullable(targetCpuCores), Optional.ToNullable(isDynamicRam), dynamicMemoryConfig.Value, Optional.ToNullable(targetMemoryInMegaBytes), runAsAccountId, sourceDraName, targetDraName, sourceApplianceName.Value, targetApplianceName.Value, osType.Value, osName.Value, firmwareType.Value, targetLocation.Value, customLocationRegion, failoverRecoveryPointId.Value, Optional.ToNullable(lastRecoveryPointReceived), lastRecoveryPointId.Value, Optional.ToNullable(initialReplicationProgressPercentage), Optional.ToNullable(resyncProgressPercentage), Optional.ToList(protectedDisks), Optional.ToList(protectedNics), targetVmBiosId.Value, Optional.ToNullable(lastReplicationUpdateTime));
        }

        BinaryData IPersistableModel<HyperVToAzStackHciProtectedItemModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciProtectedItemModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(HyperVToAzStackHciProtectedItemModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        HyperVToAzStackHciProtectedItemModelCustomProperties IPersistableModel<HyperVToAzStackHciProtectedItemModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciProtectedItemModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVToAzStackHciProtectedItemModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(HyperVToAzStackHciProtectedItemModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVToAzStackHciProtectedItemModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
