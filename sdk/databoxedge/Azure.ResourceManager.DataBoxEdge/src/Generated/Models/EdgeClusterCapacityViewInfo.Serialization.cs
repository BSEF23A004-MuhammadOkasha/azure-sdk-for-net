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
    public partial class EdgeClusterCapacityViewInfo : IUtf8JsonSerializable, IModelJsonSerializable<EdgeClusterCapacityViewInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdgeClusterCapacityViewInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdgeClusterCapacityViewInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeClusterCapacityViewInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (Optional.IsDefined(GpuCapacity))
            {
                writer.WritePropertyName("gpuCapacity"u8);
                if (GpuCapacity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<EdgeClusterGpuCapacity>)GpuCapacity).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MemoryCapacity))
            {
                writer.WritePropertyName("memoryCapacity"u8);
                if (MemoryCapacity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<EdgeClusterMemoryCapacity>)MemoryCapacity).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(LastRefreshedOn))
            {
                writer.WritePropertyName("lastRefreshedTime"u8);
                writer.WriteStringValue(LastRefreshedOn.Value, "O");
            }
            if (Optional.IsDefined(TotalProvisionedNonHpnCores))
            {
                writer.WritePropertyName("totalProvisionedNonHpnCores"u8);
                writer.WriteNumberValue(TotalProvisionedNonHpnCores.Value);
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

        internal static EdgeClusterCapacityViewInfo DeserializeEdgeClusterCapacityViewInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fqdn = default;
            Optional<EdgeClusterGpuCapacity> gpuCapacity = default;
            Optional<EdgeClusterMemoryCapacity> memoryCapacity = default;
            Optional<DateTimeOffset> lastRefreshedTime = default;
            Optional<long> totalProvisionedNonHpnCores = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gpuCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gpuCapacity = EdgeClusterGpuCapacity.DeserializeEdgeClusterGpuCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("memoryCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryCapacity = EdgeClusterMemoryCapacity.DeserializeEdgeClusterMemoryCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("lastRefreshedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRefreshedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("totalProvisionedNonHpnCores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalProvisionedNonHpnCores = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdgeClusterCapacityViewInfo(fqdn.Value, gpuCapacity.Value, memoryCapacity.Value, Optional.ToNullable(lastRefreshedTime), Optional.ToNullable(totalProvisionedNonHpnCores), rawData);
        }

        EdgeClusterCapacityViewInfo IModelJsonSerializable<EdgeClusterCapacityViewInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeClusterCapacityViewInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeClusterCapacityViewInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdgeClusterCapacityViewInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeClusterCapacityViewInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdgeClusterCapacityViewInfo IModelSerializable<EdgeClusterCapacityViewInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EdgeClusterCapacityViewInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdgeClusterCapacityViewInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EdgeClusterCapacityViewInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EdgeClusterCapacityViewInfo"/> to convert. </param>
        public static implicit operator RequestContent(EdgeClusterCapacityViewInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EdgeClusterCapacityViewInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EdgeClusterCapacityViewInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdgeClusterCapacityViewInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
