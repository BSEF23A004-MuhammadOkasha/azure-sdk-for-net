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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeKubernetesRoleStorage : IUtf8JsonSerializable, IModelJsonSerializable<EdgeKubernetesRoleStorage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdgeKubernetesRoleStorage>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdgeKubernetesRoleStorage>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeKubernetesRoleStorage>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataBoxEdgeMountPointMap>)item).Serialize(writer, options);
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

        internal static EdgeKubernetesRoleStorage DeserializeEdgeKubernetesRoleStorage(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<EdgeKubernetesRoleStorageClassInfo>> storageClasses = default;
            Optional<IList<DataBoxEdgeMountPointMap>> endpoints = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageClasses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EdgeKubernetesRoleStorageClassInfo> array = new List<EdgeKubernetesRoleStorageClassInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdgeKubernetesRoleStorageClassInfo.DeserializeEdgeKubernetesRoleStorageClassInfo(item));
                    }
                    storageClasses = array;
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxEdgeMountPointMap> array = new List<DataBoxEdgeMountPointMap>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeMountPointMap.DeserializeDataBoxEdgeMountPointMap(item));
                    }
                    endpoints = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdgeKubernetesRoleStorage(Optional.ToList(storageClasses), Optional.ToList(endpoints), rawData);
        }

        EdgeKubernetesRoleStorage IModelJsonSerializable<EdgeKubernetesRoleStorage>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeKubernetesRoleStorage>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeKubernetesRoleStorage(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdgeKubernetesRoleStorage>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeKubernetesRoleStorage>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdgeKubernetesRoleStorage IModelSerializable<EdgeKubernetesRoleStorage>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeKubernetesRoleStorage>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdgeKubernetesRoleStorage(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EdgeKubernetesRoleStorage"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EdgeKubernetesRoleStorage"/> to convert. </param>
        public static implicit operator RequestContent(EdgeKubernetesRoleStorage model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EdgeKubernetesRoleStorage"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EdgeKubernetesRoleStorage(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdgeKubernetesRoleStorage(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
