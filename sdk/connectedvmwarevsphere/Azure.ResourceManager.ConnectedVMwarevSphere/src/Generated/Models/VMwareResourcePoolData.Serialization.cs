// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class VMwareResourcePoolData : IUtf8JsonSerializable, IJsonModel<VMwareResourcePoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareResourcePoolData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareResourcePoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareResourcePoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareResourcePoolData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
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
            if (options.Format != "W" && Optional.IsDefined(CpuSharesLevel))
            {
                writer.WritePropertyName("cpuSharesLevel"u8);
                writer.WriteStringValue(CpuSharesLevel);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuReservationMHz))
            {
                writer.WritePropertyName("cpuReservationMHz"u8);
                writer.WriteNumberValue(CpuReservationMHz.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuLimitMHz))
            {
                writer.WritePropertyName("cpuLimitMHz"u8);
                writer.WriteNumberValue(CpuLimitMHz.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemSharesLevel))
            {
                writer.WritePropertyName("memSharesLevel"u8);
                writer.WriteStringValue(MemSharesLevel);
            }
            if (options.Format != "W" && Optional.IsDefined(MemReservationMB))
            {
                writer.WritePropertyName("memReservationMB"u8);
                writer.WriteNumberValue(MemReservationMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemLimitMB))
            {
                writer.WritePropertyName("memLimitMB"u8);
                writer.WriteNumberValue(MemLimitMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemOverallUsageGB))
            {
                writer.WritePropertyName("memOverallUsageGB"u8);
                writer.WriteNumberValue(MemOverallUsageGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemCapacityGB))
            {
                writer.WritePropertyName("memCapacityGB"u8);
                writer.WriteNumberValue(MemCapacityGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuOverallUsageMHz))
            {
                writer.WritePropertyName("cpuOverallUsageMHz"u8);
                writer.WriteNumberValue(CpuOverallUsageMHz.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuCapacityMHz))
            {
                writer.WritePropertyName("cpuCapacityMHz"u8);
                writer.WriteNumberValue(CpuCapacityMHz.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomResourceName))
            {
                writer.WritePropertyName("customResourceName"u8);
                writer.WriteStringValue(CustomResourceName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DatastoreIds))
            {
                writer.WritePropertyName("datastoreIds"u8);
                writer.WriteStartArray();
                foreach (var item in DatastoreIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(NetworkIds))
            {
                writer.WritePropertyName("networkIds"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
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

        VMwareResourcePoolData IJsonModel<VMwareResourcePoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareResourcePoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareResourcePoolData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareResourcePoolData(document.RootElement, options);
        }

        internal static VMwareResourcePoolData DeserializeVMwareResourcePoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> uuid = default;
            Optional<string> vCenterId = default;
            Optional<string> moRefId = default;
            Optional<string> inventoryItemId = default;
            Optional<string> moName = default;
            Optional<string> cpuSharesLevel = default;
            Optional<long> cpuReservationMHz = default;
            Optional<long> cpuLimitMHz = default;
            Optional<string> memSharesLevel = default;
            Optional<long> memReservationMB = default;
            Optional<long> memLimitMB = default;
            Optional<long> memOverallUsageGB = default;
            Optional<long> memCapacityGB = default;
            Optional<long> cpuOverallUsageMHz = default;
            Optional<long> cpuCapacityMHz = default;
            Optional<string> customResourceName = default;
            Optional<IReadOnlyList<string>> datastoreIds = default;
            Optional<IReadOnlyList<string>> networkIds = default;
            Optional<IReadOnlyList<VMwareResourceStatus>> statuses = default;
            Optional<VMwareResourceProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("cpuSharesLevel"u8))
                        {
                            cpuSharesLevel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cpuReservationMHz"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuReservationMHz = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("cpuLimitMHz"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuLimitMHz = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("memSharesLevel"u8))
                        {
                            memSharesLevel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("memReservationMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memReservationMB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("memLimitMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memLimitMB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("memOverallUsageGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memOverallUsageGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("memCapacityGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memCapacityGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("cpuOverallUsageMHz"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuOverallUsageMHz = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("cpuCapacityMHz"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuCapacityMHz = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("customResourceName"u8))
                        {
                            customResourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("datastoreIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            datastoreIds = array;
                            continue;
                        }
                        if (property0.NameEquals("networkIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            networkIds = array;
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
                                array.Add(VMwareResourceStatus.DeserializeVMwareResourceStatus(item));
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
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareResourcePoolData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, kind.Value, uuid.Value, vCenterId.Value, moRefId.Value, inventoryItemId.Value, moName.Value, cpuSharesLevel.Value, Optional.ToNullable(cpuReservationMHz), Optional.ToNullable(cpuLimitMHz), memSharesLevel.Value, Optional.ToNullable(memReservationMB), Optional.ToNullable(memLimitMB), Optional.ToNullable(memOverallUsageGB), Optional.ToNullable(memCapacityGB), Optional.ToNullable(cpuOverallUsageMHz), Optional.ToNullable(cpuCapacityMHz), customResourceName.Value, Optional.ToList(datastoreIds), Optional.ToList(networkIds), Optional.ToList(statuses), Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ExtendedLocation))
            {
                builder.Append("  extendedLocation:");
                AppendChildObject(builder, ExtendedLocation, options, 2, false);
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind}'");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value}'");
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(Uuid))
            {
                builder.Append("    uuid:");
                builder.AppendLine($" '{Uuid}'");
            }

            if (Optional.IsDefined(VCenterId))
            {
                builder.Append("    vCenterId:");
                builder.AppendLine($" '{VCenterId}'");
            }

            if (Optional.IsDefined(MoRefId))
            {
                builder.Append("    moRefId:");
                builder.AppendLine($" '{MoRefId}'");
            }

            if (Optional.IsDefined(InventoryItemId))
            {
                builder.Append("    inventoryItemId:");
                builder.AppendLine($" '{InventoryItemId}'");
            }

            if (Optional.IsDefined(MoName))
            {
                builder.Append("    moName:");
                builder.AppendLine($" '{MoName}'");
            }

            if (Optional.IsDefined(CpuSharesLevel))
            {
                builder.Append("    cpuSharesLevel:");
                builder.AppendLine($" '{CpuSharesLevel}'");
            }

            if (Optional.IsDefined(CpuReservationMHz))
            {
                builder.Append("    cpuReservationMHz:");
                builder.AppendLine($" '{CpuReservationMHz.Value.ToString()}'");
            }

            if (Optional.IsDefined(CpuLimitMHz))
            {
                builder.Append("    cpuLimitMHz:");
                builder.AppendLine($" '{CpuLimitMHz.Value.ToString()}'");
            }

            if (Optional.IsDefined(MemSharesLevel))
            {
                builder.Append("    memSharesLevel:");
                builder.AppendLine($" '{MemSharesLevel}'");
            }

            if (Optional.IsDefined(MemReservationMB))
            {
                builder.Append("    memReservationMB:");
                builder.AppendLine($" '{MemReservationMB.Value.ToString()}'");
            }

            if (Optional.IsDefined(MemLimitMB))
            {
                builder.Append("    memLimitMB:");
                builder.AppendLine($" '{MemLimitMB.Value.ToString()}'");
            }

            if (Optional.IsDefined(MemOverallUsageGB))
            {
                builder.Append("    memOverallUsageGB:");
                builder.AppendLine($" '{MemOverallUsageGB.Value.ToString()}'");
            }

            if (Optional.IsDefined(MemCapacityGB))
            {
                builder.Append("    memCapacityGB:");
                builder.AppendLine($" '{MemCapacityGB.Value.ToString()}'");
            }

            if (Optional.IsDefined(CpuOverallUsageMHz))
            {
                builder.Append("    cpuOverallUsageMHz:");
                builder.AppendLine($" '{CpuOverallUsageMHz.Value.ToString()}'");
            }

            if (Optional.IsDefined(CpuCapacityMHz))
            {
                builder.Append("    cpuCapacityMHz:");
                builder.AppendLine($" '{CpuCapacityMHz.Value.ToString()}'");
            }

            if (Optional.IsDefined(CustomResourceName))
            {
                builder.Append("    customResourceName:");
                builder.AppendLine($" '{CustomResourceName}'");
            }

            if (Optional.IsCollectionDefined(DatastoreIds))
            {
                if (DatastoreIds.Any())
                {
                    builder.Append("    datastoreIds:");
                    builder.AppendLine(" [");
                    foreach (var item in DatastoreIds)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"      '{item}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(NetworkIds))
            {
                if (NetworkIds.Any())
                {
                    builder.Append("    networkIds:");
                    builder.AppendLine(" [");
                    foreach (var item in NetworkIds)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"      '{item}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(Statuses))
            {
                if (Statuses.Any())
                {
                    builder.Append("    statuses:");
                    builder.AppendLine(" [");
                    foreach (var item in Statuses)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("    provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<VMwareResourcePoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareResourcePoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VMwareResourcePoolData)} does not support '{options.Format}' format.");
            }
        }

        VMwareResourcePoolData IPersistableModel<VMwareResourcePoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareResourcePoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareResourcePoolData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VMwareResourcePoolData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareResourcePoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
