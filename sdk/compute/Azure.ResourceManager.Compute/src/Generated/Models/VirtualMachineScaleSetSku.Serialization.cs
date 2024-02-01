// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetSku : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetSku>, IPersistableModel<VirtualMachineScaleSetSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetSku>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetSku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetSku)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (options.Format != "W" && Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity);
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

        VirtualMachineScaleSetSku IJsonModel<VirtualMachineScaleSetSku>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetSku)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetSku(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetSku DeserializeVirtualMachineScaleSetSku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceType> resourceType = default;
            Optional<ComputeSku> sku = default;
            Optional<VirtualMachineScaleSetSkuCapacity> capacity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ComputeSku.DeserializeComputeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = VirtualMachineScaleSetSkuCapacity.DeserializeVirtualMachineScaleSetSkuCapacity(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetSku(Optional.ToNullable(resourceType), sku.Value, capacity.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  resourceType:");
                builder.AppendLine($" '{ResourceType.Value.ToString()}'");
            }

            if (Optional.IsDefined(Sku))
            {
                builder.Append("  sku:");
                AppendChildObject(builder, Sku, options, 2);
            }

            if (Optional.IsDefined(Capacity))
            {
                builder.Append("  capacity:");
                AppendChildObject(builder, Capacity, options, 2);
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetSku>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetSku)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetSku IPersistableModel<VirtualMachineScaleSetSku>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetSku(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetSku)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetSku>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
