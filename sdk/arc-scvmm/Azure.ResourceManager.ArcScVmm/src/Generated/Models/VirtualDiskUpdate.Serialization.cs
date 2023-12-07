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

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class VirtualDiskUpdate : IUtf8JsonSerializable, IJsonModel<VirtualDiskUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualDiskUpdate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualDiskUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualDiskUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualDiskUpdate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(Bus))
            {
                writer.WritePropertyName("bus"u8);
                writer.WriteNumberValue(Bus.Value);
            }
            if (Optional.IsDefined(Lun))
            {
                writer.WritePropertyName("lun"u8);
                writer.WriteNumberValue(Lun.Value);
            }
            if (Optional.IsDefined(BusType))
            {
                writer.WritePropertyName("busType"u8);
                writer.WriteStringValue(BusType);
            }
            if (Optional.IsDefined(VhdType))
            {
                writer.WritePropertyName("vhdType"u8);
                writer.WriteStringValue(VhdType);
            }
            if (Optional.IsDefined(StorageQoSPolicy))
            {
                writer.WritePropertyName("storageQoSPolicy"u8);
                writer.WriteObjectValue(StorageQoSPolicy);
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

        VirtualDiskUpdate IJsonModel<VirtualDiskUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualDiskUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualDiskUpdate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualDiskUpdate(document.RootElement, options);
        }

        internal static VirtualDiskUpdate DeserializeVirtualDiskUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> diskId = default;
            Optional<int> diskSizeGB = default;
            Optional<int> bus = default;
            Optional<int> lun = default;
            Optional<string> busType = default;
            Optional<string> vhdType = default;
            Optional<StorageQoSPolicyDetails> storageQoSPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bus = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lun"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("busType"u8))
                {
                    busType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdType"u8))
                {
                    vhdType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageQoSPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageQoSPolicy = StorageQoSPolicyDetails.DeserializeStorageQoSPolicyDetails(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualDiskUpdate(name.Value, diskId.Value, Optional.ToNullable(diskSizeGB), Optional.ToNullable(bus), Optional.ToNullable(lun), busType.Value, vhdType.Value, storageQoSPolicy.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualDiskUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualDiskUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualDiskUpdate)} does not support '{options.Format}' format.");
            }
        }

        VirtualDiskUpdate IPersistableModel<VirtualDiskUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualDiskUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualDiskUpdate(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualDiskUpdate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualDiskUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
