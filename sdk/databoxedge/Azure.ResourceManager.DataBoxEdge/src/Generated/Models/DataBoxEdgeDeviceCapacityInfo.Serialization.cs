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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDeviceCapacityInfo : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxEdgeDeviceCapacityInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxEdgeDeviceCapacityInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxEdgeDeviceCapacityInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceCapacityInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(TimeStamp))
            {
                writer.WritePropertyName("timeStamp"u8);
                writer.WriteStringValue(TimeStamp.Value, "O");
            }
            if (Optional.IsDefined(ClusterStorageCapacityInfo))
            {
                writer.WritePropertyName("clusterStorageCapacityInfo"u8);
                if (ClusterStorageCapacityInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<EdgeClusterStorageViewInfo>)ClusterStorageCapacityInfo).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ClusterComputeCapacityInfo))
            {
                writer.WritePropertyName("clusterComputeCapacityInfo"u8);
                if (ClusterComputeCapacityInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<EdgeClusterCapacityViewInfo>)ClusterComputeCapacityInfo).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(NodeCapacityInfos))
            {
                writer.WritePropertyName("nodeCapacityInfos"u8);
                writer.WriteStartObject();
                foreach (var item in NodeCapacityInfos)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HostCapacity>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
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

        internal static DataBoxEdgeDeviceCapacityInfo DeserializeDataBoxEdgeDeviceCapacityInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> timeStamp = default;
            Optional<EdgeClusterStorageViewInfo> clusterStorageCapacityInfo = default;
            Optional<EdgeClusterCapacityViewInfo> clusterComputeCapacityInfo = default;
            Optional<IDictionary<string, HostCapacity>> nodeCapacityInfos = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("timeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("clusterStorageCapacityInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterStorageCapacityInfo = EdgeClusterStorageViewInfo.DeserializeEdgeClusterStorageViewInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterComputeCapacityInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterComputeCapacityInfo = EdgeClusterCapacityViewInfo.DeserializeEdgeClusterCapacityViewInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("nodeCapacityInfos"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, HostCapacity> dictionary = new Dictionary<string, HostCapacity>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, HostCapacity.DeserializeHostCapacity(property1.Value));
                            }
                            nodeCapacityInfos = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxEdgeDeviceCapacityInfo(id, name, type, systemData.Value, Optional.ToNullable(timeStamp), clusterStorageCapacityInfo.Value, clusterComputeCapacityInfo.Value, Optional.ToDictionary(nodeCapacityInfos), rawData);
        }

        DataBoxEdgeDeviceCapacityInfo IModelJsonSerializable<DataBoxEdgeDeviceCapacityInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceCapacityInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeDeviceCapacityInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxEdgeDeviceCapacityInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceCapacityInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxEdgeDeviceCapacityInfo IModelSerializable<DataBoxEdgeDeviceCapacityInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceCapacityInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxEdgeDeviceCapacityInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataBoxEdgeDeviceCapacityInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataBoxEdgeDeviceCapacityInfo"/> to convert. </param>
        public static implicit operator RequestContent(DataBoxEdgeDeviceCapacityInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataBoxEdgeDeviceCapacityInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataBoxEdgeDeviceCapacityInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxEdgeDeviceCapacityInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
