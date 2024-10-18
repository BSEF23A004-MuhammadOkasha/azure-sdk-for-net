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

namespace Azure.ResourceManager.Compute
{
    public partial class VirtualMachineExtensionImageData : IUtf8JsonSerializable, IJsonModel<VirtualMachineExtensionImageData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineExtensionImageData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineExtensionImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineExtensionImageData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OperatingSystem))
            {
                writer.WritePropertyName("operatingSystem"u8);
                writer.WriteStringValue(OperatingSystem);
            }
            if (Optional.IsDefined(ComputeRole))
            {
                writer.WritePropertyName("computeRole"u8);
                writer.WriteStringValue(ComputeRole);
            }
            if (Optional.IsDefined(HandlerSchema))
            {
                writer.WritePropertyName("handlerSchema"u8);
                writer.WriteStringValue(HandlerSchema);
            }
            if (Optional.IsDefined(VirtualMachineScaleSetEnabled))
            {
                writer.WritePropertyName("vmScaleSetEnabled"u8);
                writer.WriteBooleanValue(VirtualMachineScaleSetEnabled.Value);
            }
            if (Optional.IsDefined(SupportsMultipleExtensions))
            {
                writer.WritePropertyName("supportsMultipleExtensions"u8);
                writer.WriteBooleanValue(SupportsMultipleExtensions.Value);
            }
            writer.WriteEndObject();
        }

        VirtualMachineExtensionImageData IJsonModel<VirtualMachineExtensionImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineExtensionImageData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineExtensionImageData(document.RootElement, options);
        }

        internal static VirtualMachineExtensionImageData DeserializeVirtualMachineExtensionImageData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string operatingSystem = default;
            string computeRole = default;
            string handlerSchema = default;
            bool? virtualMachineScaleSetEnabled = default;
            bool? supportsMultipleExtensions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("operatingSystem"u8))
                        {
                            operatingSystem = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("computeRole"u8))
                        {
                            computeRole = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("handlerSchema"u8))
                        {
                            handlerSchema = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmScaleSetEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMachineScaleSetEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("supportsMultipleExtensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportsMultipleExtensions = property0.Value.GetBoolean();
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
            return new VirtualMachineExtensionImageData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                operatingSystem,
                computeRole,
                handlerSchema,
                virtualMachineScaleSetEnabled,
                supportsMultipleExtensions,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineExtensionImageData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineExtensionImageData)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineExtensionImageData IPersistableModel<VirtualMachineExtensionImageData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineExtensionImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineExtensionImageData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineExtensionImageData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineExtensionImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
