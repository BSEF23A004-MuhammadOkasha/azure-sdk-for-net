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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RecommendedMachineConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<RecommendedMachineConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecommendedMachineConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecommendedMachineConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecommendedMachineConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VCpus))
            {
                writer.WritePropertyName("vCPUs"u8);
                if (VCpus is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ResourceRange>)VCpus).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Memory))
            {
                writer.WritePropertyName("memory"u8);
                if (Memory is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ResourceRange>)Memory).Serialize(writer, options);
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

        internal static RecommendedMachineConfiguration DeserializeRecommendedMachineConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceRange> vCpus = default;
            Optional<ResourceRange> memory = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCPUs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCpus = ResourceRange.DeserializeResourceRange(property.Value);
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memory = ResourceRange.DeserializeResourceRange(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RecommendedMachineConfiguration(vCpus.Value, memory.Value, rawData);
        }

        RecommendedMachineConfiguration IModelJsonSerializable<RecommendedMachineConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecommendedMachineConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecommendedMachineConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecommendedMachineConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecommendedMachineConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecommendedMachineConfiguration IModelSerializable<RecommendedMachineConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecommendedMachineConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecommendedMachineConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RecommendedMachineConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RecommendedMachineConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(RecommendedMachineConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RecommendedMachineConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RecommendedMachineConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecommendedMachineConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
