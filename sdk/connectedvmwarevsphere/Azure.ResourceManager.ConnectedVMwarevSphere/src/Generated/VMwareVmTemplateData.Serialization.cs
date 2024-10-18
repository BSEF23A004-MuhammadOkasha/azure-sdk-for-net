// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class VMwareVmTemplateData : IUtf8JsonSerializable, IJsonModel<VMwareVmTemplateData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareVmTemplateData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VMwareVmTemplateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmTemplateData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVmTemplateData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Uuid))
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid);
            }
            if (Optional.IsDefined(VCenterId))
            {
                writer.WritePropertyName("vCenterId"u8);
                writer.WriteStringValue(VCenterId);
            }
            if (Optional.IsDefined(MoRefId))
            {
                writer.WritePropertyName("moRefId"u8);
                writer.WriteStringValue(MoRefId);
            }
            if (Optional.IsDefined(InventoryItemId))
            {
                writer.WritePropertyName("inventoryItemId"u8);
                writer.WriteStringValue(InventoryItemId);
            }
            if (options.Format != "W" && Optional.IsDefined(MoName))
            {
                writer.WritePropertyName("moName"u8);
                writer.WriteStringValue(MoName);
            }
            if (options.Format != "W" && Optional.IsDefined(MemorySizeMB))
            {
                writer.WritePropertyName("memorySizeMB"u8);
                writer.WriteNumberValue(MemorySizeMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumCpus))
            {
                writer.WritePropertyName("numCPUs"u8);
                writer.WriteNumberValue(NumCpus.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumCoresPerSocket))
            {
                writer.WritePropertyName("numCoresPerSocket"u8);
                writer.WriteNumberValue(NumCoresPerSocket.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OSName))
            {
                writer.WritePropertyName("osName"u8);
                writer.WriteStringValue(OSName);
            }
            if (options.Format != "W" && Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath"u8);
                writer.WriteStringValue(FolderPath);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(NetworkInterfaces))
            {
                writer.WritePropertyName("networkInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Disks))
            {
                writer.WritePropertyName("disks"u8);
                writer.WriteStartArray();
                foreach (var item in Disks)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CustomResourceName))
            {
                writer.WritePropertyName("customResourceName"u8);
                writer.WriteStringValue(CustomResourceName);
            }
            if (options.Format != "W" && Optional.IsDefined(ToolsVersionStatus))
            {
                writer.WritePropertyName("toolsVersionStatus"u8);
                writer.WriteStringValue(ToolsVersionStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(ToolsVersion))
            {
                writer.WritePropertyName("toolsVersion"u8);
                writer.WriteStringValue(ToolsVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(FirmwareType))
            {
                writer.WritePropertyName("firmwareType"u8);
                writer.WriteStringValue(FirmwareType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        VMwareVmTemplateData IJsonModel<VMwareVmTemplateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmTemplateData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVmTemplateData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareVmTemplateData(document.RootElement, options);
        }

        internal static VMwareVmTemplateData DeserializeVMwareVmTemplateData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            string kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string uuid = default;
            string vCenterId = default;
            string moRefId = default;
            string inventoryItemId = default;
            string moName = default;
            int? memorySizeMB = default;
            int? numCpus = default;
            int? numCoresPerSocket = default;
            VMwareOSType? osType = default;
            string osName = default;
            string folderPath = default;
            IReadOnlyList<VMwareNetworkInterface> networkInterfaces = default;
            IReadOnlyList<VMwareVirtualDisk> disks = default;
            string customResourceName = default;
            string toolsVersionStatus = default;
            string toolsVersion = default;
            VMwareFirmwareType? firmwareType = default;
            IReadOnlyList<VMwareResourceStatus> statuses = default;
            VMwareResourceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("uuid"u8))
                        {
                            uuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vCenterId"u8))
                        {
                            vCenterId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moRefId"u8))
                        {
                            moRefId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inventoryItemId"u8))
                        {
                            inventoryItemId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moName"u8))
                        {
                            moName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("memorySizeMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memorySizeMB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numCPUs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numCpus = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numCoresPerSocket"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numCoresPerSocket = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osType = new VMwareOSType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("osName"u8))
                        {
                            osName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("folderPath"u8))
                        {
                            folderPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VMwareNetworkInterface> array = new List<VMwareNetworkInterface>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VMwareNetworkInterface.DeserializeVMwareNetworkInterface(item, options));
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("disks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VMwareVirtualDisk> array = new List<VMwareVirtualDisk>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VMwareVirtualDisk.DeserializeVMwareVirtualDisk(item, options));
                            }
                            disks = array;
                            continue;
                        }
                        if (property0.NameEquals("customResourceName"u8))
                        {
                            customResourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("toolsVersionStatus"u8))
                        {
                            toolsVersionStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("toolsVersion"u8))
                        {
                            toolsVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("firmwareType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firmwareType = new VMwareFirmwareType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statuses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VMwareResourceStatus> array = new List<VMwareResourceStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VMwareResourceStatus.DeserializeVMwareResourceStatus(item, options));
                            }
                            statuses = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VMwareResourceProvisioningState(property0.Value.GetString());
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
            return new VMwareVmTemplateData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                extendedLocation,
                kind,
                uuid,
                vCenterId,
                moRefId,
                inventoryItemId,
                moName,
                memorySizeMB,
                numCpus,
                numCoresPerSocket,
                osType,
                osName,
                folderPath,
                networkInterfaces ?? new ChangeTrackingList<VMwareNetworkInterface>(),
                disks ?? new ChangeTrackingList<VMwareVirtualDisk>(),
                customResourceName,
                toolsVersionStatus,
                toolsVersion,
                firmwareType,
                statuses ?? new ChangeTrackingList<VMwareResourceStatus>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareVmTemplateData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmTemplateData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareVmTemplateData)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareVmTemplateData IPersistableModel<VMwareVmTemplateData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmTemplateData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareVmTemplateData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareVmTemplateData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareVmTemplateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
