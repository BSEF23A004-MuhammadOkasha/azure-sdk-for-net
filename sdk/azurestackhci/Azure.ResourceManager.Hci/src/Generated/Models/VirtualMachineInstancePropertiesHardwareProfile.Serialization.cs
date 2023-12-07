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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class VirtualMachineInstancePropertiesHardwareProfile : IUtf8JsonSerializable, IJsonModel<VirtualMachineInstancePropertiesHardwareProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineInstancePropertiesHardwareProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineInstancePropertiesHardwareProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualMachineInstancePropertiesHardwareProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize.Value.ToString());
            }
            if (Optional.IsDefined(Processors))
            {
                writer.WritePropertyName("processors"u8);
                writer.WriteNumberValue(Processors.Value);
            }
            if (Optional.IsDefined(MemoryMB))
            {
                writer.WritePropertyName("memoryMB"u8);
                writer.WriteNumberValue(MemoryMB.Value);
            }
            if (Optional.IsDefined(DynamicMemoryConfig))
            {
                writer.WritePropertyName("dynamicMemoryConfig"u8);
                writer.WriteObjectValue(DynamicMemoryConfig);
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

        VirtualMachineInstancePropertiesHardwareProfile IJsonModel<VirtualMachineInstancePropertiesHardwareProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualMachineInstancePropertiesHardwareProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineInstancePropertiesHardwareProfile(document.RootElement, options);
        }

        internal static VirtualMachineInstancePropertiesHardwareProfile DeserializeVirtualMachineInstancePropertiesHardwareProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VmSizeEnum> vmSize = default;
            Optional<int> processors = default;
            Optional<long> memoryMB = default;
            Optional<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig> dynamicMemoryConfig = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmSize = new VmSizeEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("processors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processors = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("memoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dynamicMemoryConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicMemoryConfig = VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig.DeserializeVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineInstancePropertiesHardwareProfile(Optional.ToNullable(vmSize), Optional.ToNullable(processors), Optional.ToNullable(memoryMB), dynamicMemoryConfig.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineInstancePropertiesHardwareProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualMachineInstancePropertiesHardwareProfile)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineInstancePropertiesHardwareProfile IPersistableModel<VirtualMachineInstancePropertiesHardwareProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineInstancePropertiesHardwareProfile(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualMachineInstancePropertiesHardwareProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineInstancePropertiesHardwareProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
