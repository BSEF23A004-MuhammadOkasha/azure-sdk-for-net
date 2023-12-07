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
    public partial class VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig : IUtf8JsonSerializable, IJsonModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaximumMemoryMB))
            {
                writer.WritePropertyName("maximumMemoryMB"u8);
                writer.WriteNumberValue(MaximumMemoryMB.Value);
            }
            if (Optional.IsDefined(MinimumMemoryMB))
            {
                writer.WritePropertyName("minimumMemoryMB"u8);
                writer.WriteNumberValue(MinimumMemoryMB.Value);
            }
            if (Optional.IsDefined(TargetMemoryBuffer))
            {
                writer.WritePropertyName("targetMemoryBuffer"u8);
                writer.WriteNumberValue(TargetMemoryBuffer.Value);
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

        VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig IJsonModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig(document.RootElement, options);
        }

        internal static VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig DeserializeVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> maximumMemoryMB = default;
            Optional<long> minimumMemoryMB = default;
            Optional<int> targetMemoryBuffer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maximumMemoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumMemoryMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minimumMemoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumMemoryMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("targetMemoryBuffer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetMemoryBuffer = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig(Optional.ToNullable(maximumMemoryMB), Optional.ToNullable(minimumMemoryMB), Optional.ToNullable(targetMemoryBuffer), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig IPersistableModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
