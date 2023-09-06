// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    internal partial class UnknownTaskStepProperties : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistryTaskStepProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistryTaskStepProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistryTaskStepProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTaskStepProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ContainerRegistryTaskStepType.ToString());
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(ContextAccessToken))
            {
                writer.WritePropertyName("contextAccessToken"u8);
                writer.WriteStringValue(ContextAccessToken);
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

        internal static ContainerRegistryTaskStepProperties DeserializeUnknownTaskStepProperties(JsonElement element, ModelSerializerOptions options = default) => DeserializeContainerRegistryTaskStepProperties(element, options);

        ContainerRegistryTaskStepProperties IModelJsonSerializable<ContainerRegistryTaskStepProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTaskStepProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownTaskStepProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistryTaskStepProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTaskStepProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistryTaskStepProperties IModelSerializable<ContainerRegistryTaskStepProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTaskStepProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistryTaskStepProperties(doc.RootElement, options);
        }
    }
}
