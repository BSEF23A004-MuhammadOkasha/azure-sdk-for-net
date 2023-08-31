// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class ComputeVmProperties : IUtf8JsonSerializable, IModelJsonSerializable<ComputeVmProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ComputeVmProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ComputeVmProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ComputeVmInstanceViewStatus>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(NetworkInterfaceId))
            {
                writer.WritePropertyName("networkInterfaceId"u8);
                writer.WriteStringValue(NetworkInterfaceId);
            }
            if (Optional.IsDefined(OSDiskId))
            {
                writer.WritePropertyName("osDiskId"u8);
                writer.WriteStringValue(OSDiskId);
            }
            if (Optional.IsCollectionDefined(DataDiskIds))
            {
                writer.WritePropertyName("dataDiskIds"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataDisks))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ComputeDataDisk>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ComputeVmProperties DeserializeComputeVmProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ComputeVmInstanceViewStatus>> statuses = default;
            Optional<string> osType = default;
            Optional<string> vmSize = default;
            Optional<string> networkInterfaceId = default;
            Optional<string> osDiskId = default;
            Optional<IReadOnlyList<string>> dataDiskIds = default;
            Optional<IReadOnlyList<ComputeDataDisk>> dataDisks = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeVmInstanceViewStatus> array = new List<ComputeVmInstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeVmInstanceViewStatus.DeserializeComputeVmInstanceViewStatus(item));
                    }
                    statuses = array;
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkInterfaceId"u8))
                {
                    networkInterfaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osDiskId"u8))
                {
                    osDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataDiskIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dataDiskIds = array;
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeDataDisk> array = new List<ComputeDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeDataDisk.DeserializeComputeDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ComputeVmProperties(Optional.ToList(statuses), osType.Value, vmSize.Value, networkInterfaceId.Value, osDiskId.Value, Optional.ToList(dataDiskIds), Optional.ToList(dataDisks), rawData);
        }

        ComputeVmProperties IModelJsonSerializable<ComputeVmProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeVmProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ComputeVmProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ComputeVmProperties IModelSerializable<ComputeVmProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeComputeVmProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ComputeVmProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ComputeVmProperties"/> to convert. </param>
        public static implicit operator RequestContent(ComputeVmProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ComputeVmProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ComputeVmProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeComputeVmProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
