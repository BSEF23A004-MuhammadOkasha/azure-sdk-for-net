// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineAgentInstanceView : IUtf8JsonSerializable, IJsonModel<VirtualMachineAgentInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineAgentInstanceView>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineAgentInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineAgentInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineAgentInstanceView)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VmAgentVersion))
            {
                writer.WritePropertyName("vmAgentVersion"u8);
                writer.WriteStringValue(VmAgentVersion);
            }
            if (Optional.IsCollectionDefined(ExtensionHandlers))
            {
                writer.WritePropertyName("extensionHandlers"u8);
                writer.WriteStartArray();
                foreach (var item in ExtensionHandlers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        VirtualMachineAgentInstanceView IJsonModel<VirtualMachineAgentInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineAgentInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineAgentInstanceView)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineAgentInstanceView(document.RootElement, options);
        }

        internal static VirtualMachineAgentInstanceView DeserializeVirtualMachineAgentInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vmAgentVersion = default;
            Optional<IReadOnlyList<VirtualMachineExtensionHandlerInstanceView>> extensionHandlers = default;
            Optional<IReadOnlyList<InstanceViewStatus>> statuses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmAgentVersion"u8))
                {
                    vmAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extensionHandlers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineExtensionHandlerInstanceView> array = new List<VirtualMachineExtensionHandlerInstanceView>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineExtensionHandlerInstanceView.DeserializeVirtualMachineExtensionHandlerInstanceView(item));
                    }
                    extensionHandlers = array;
                    continue;
                }
                if (property.NameEquals("statuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item));
                    }
                    statuses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineAgentInstanceView(vmAgentVersion.Value, Optional.ToList(extensionHandlers), Optional.ToList(statuses), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineAgentInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineAgentInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineAgentInstanceView)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineAgentInstanceView IPersistableModel<VirtualMachineAgentInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineAgentInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineAgentInstanceView(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineAgentInstanceView)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineAgentInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
