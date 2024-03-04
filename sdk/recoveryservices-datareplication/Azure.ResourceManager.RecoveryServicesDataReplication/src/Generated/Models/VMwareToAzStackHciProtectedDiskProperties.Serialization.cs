// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class VMwareToAzStackHciProtectedDiskProperties : IUtf8JsonSerializable, IJsonModel<VMwareToAzStackHciProtectedDiskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareToAzStackHciProtectedDiskProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareToAzStackHciProtectedDiskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciProtectedDiskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciProtectedDiskProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(StorageContainerId))
            {
                writer.WritePropertyName("storageContainerId"u8);
                writer.WriteStringValue(StorageContainerId);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageContainerLocalPath))
            {
                writer.WritePropertyName("storageContainerLocalPath"u8);
                writer.WriteStringValue(StorageContainerLocalPath);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceDiskId))
            {
                writer.WritePropertyName("sourceDiskId"u8);
                writer.WriteStringValue(SourceDiskId);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceDiskName))
            {
                writer.WritePropertyName("sourceDiskName"u8);
                writer.WriteStringValue(SourceDiskName);
            }
            if (options.Format != "W" && Optional.IsDefined(SeedDiskName))
            {
                writer.WritePropertyName("seedDiskName"u8);
                writer.WriteStringValue(SeedDiskName);
            }
            if (options.Format != "W" && Optional.IsDefined(TestMigrateDiskName))
            {
                writer.WritePropertyName("testMigrateDiskName"u8);
                writer.WriteStringValue(TestMigrateDiskName);
            }
            if (options.Format != "W" && Optional.IsDefined(MigrateDiskName))
            {
                writer.WritePropertyName("migrateDiskName"u8);
                writer.WriteStringValue(MigrateDiskName);
            }
            if (options.Format != "W" && Optional.IsDefined(IsOSDisk))
            {
                writer.WritePropertyName("isOsDisk"u8);
                writer.WriteBooleanValue(IsOSDisk.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CapacityInBytes))
            {
                writer.WritePropertyName("capacityInBytes"u8);
                writer.WriteNumberValue(CapacityInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsDynamic))
            {
                writer.WritePropertyName("isDynamic"u8);
                writer.WriteBooleanValue(IsDynamic.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType);
            }
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

        VMwareToAzStackHciProtectedDiskProperties IJsonModel<VMwareToAzStackHciProtectedDiskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciProtectedDiskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciProtectedDiskProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareToAzStackHciProtectedDiskProperties(document.RootElement, options);
        }

        internal static VMwareToAzStackHciProtectedDiskProperties DeserializeVMwareToAzStackHciProtectedDiskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier storageContainerId = default;
            string storageContainerLocalPath = default;
            string sourceDiskId = default;
            string sourceDiskName = default;
            string seedDiskName = default;
            string testMigrateDiskName = default;
            string migrateDiskName = default;
            bool? isOSDisk = default;
            long? capacityInBytes = default;
            bool? isDynamic = default;
            string diskType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageContainerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageContainerLocalPath"u8))
                {
                    storageContainerLocalPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceDiskId"u8))
                {
                    sourceDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceDiskName"u8))
                {
                    sourceDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedDiskName"u8))
                {
                    seedDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testMigrateDiskName"u8))
                {
                    testMigrateDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrateDiskName"u8))
                {
                    migrateDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOsDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOSDisk = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("capacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("isDynamic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDynamic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    diskType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareToAzStackHciProtectedDiskProperties(
                storageContainerId,
                storageContainerLocalPath,
                sourceDiskId,
                sourceDiskName,
                seedDiskName,
                testMigrateDiskName,
                migrateDiskName,
                isOSDisk,
                capacityInBytes,
                isDynamic,
                diskType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareToAzStackHciProtectedDiskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciProtectedDiskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciProtectedDiskProperties)} does not support '{options.Format}' format.");
            }
        }

        VMwareToAzStackHciProtectedDiskProperties IPersistableModel<VMwareToAzStackHciProtectedDiskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciProtectedDiskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareToAzStackHciProtectedDiskProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciProtectedDiskProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareToAzStackHciProtectedDiskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
