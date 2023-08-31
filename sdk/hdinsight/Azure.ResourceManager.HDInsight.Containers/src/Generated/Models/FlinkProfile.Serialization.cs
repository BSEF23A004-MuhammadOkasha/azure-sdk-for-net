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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class FlinkProfile : IUtf8JsonSerializable, IModelJsonSerializable<FlinkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FlinkProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FlinkProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("storage"u8);
            if (Storage is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<FlinkStorageProfile>)Storage).Serialize(writer, options);
            }
            if (Optional.IsDefined(NumReplicas))
            {
                writer.WritePropertyName("numReplicas"u8);
                writer.WriteNumberValue(NumReplicas.Value);
            }
            writer.WritePropertyName("jobManager"u8);
            if (JobManager is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ComputeResourceRequirement>)JobManager).Serialize(writer, options);
            }
            if (Optional.IsDefined(HistoryServer))
            {
                writer.WritePropertyName("historyServer"u8);
                if (HistoryServer is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ComputeResourceRequirement>)HistoryServer).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("taskManager"u8);
            if (TaskManager is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ComputeResourceRequirement>)TaskManager).Serialize(writer, options);
            }
            if (Optional.IsDefined(CatalogOptions))
            {
                writer.WritePropertyName("catalogOptions"u8);
                if (CatalogOptions is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<FlinkCatalogOptions>)CatalogOptions).Serialize(writer, options);
                }
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

        internal static FlinkProfile DeserializeFlinkProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FlinkStorageProfile storage = default;
            Optional<int> numReplicas = default;
            ComputeResourceRequirement jobManager = default;
            Optional<ComputeResourceRequirement> historyServer = default;
            ComputeResourceRequirement taskManager = default;
            Optional<FlinkCatalogOptions> catalogOptions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storage"u8))
                {
                    storage = FlinkStorageProfile.DeserializeFlinkStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("numReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("jobManager"u8))
                {
                    jobManager = ComputeResourceRequirement.DeserializeComputeResourceRequirement(property.Value);
                    continue;
                }
                if (property.NameEquals("historyServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    historyServer = ComputeResourceRequirement.DeserializeComputeResourceRequirement(property.Value);
                    continue;
                }
                if (property.NameEquals("taskManager"u8))
                {
                    taskManager = ComputeResourceRequirement.DeserializeComputeResourceRequirement(property.Value);
                    continue;
                }
                if (property.NameEquals("catalogOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogOptions = FlinkCatalogOptions.DeserializeFlinkCatalogOptions(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FlinkProfile(storage, Optional.ToNullable(numReplicas), jobManager, historyServer.Value, taskManager, catalogOptions.Value, rawData);
        }

        FlinkProfile IModelJsonSerializable<FlinkProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFlinkProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FlinkProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FlinkProfile IModelSerializable<FlinkProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFlinkProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FlinkProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FlinkProfile"/> to convert. </param>
        public static implicit operator RequestContent(FlinkProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FlinkProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FlinkProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFlinkProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
