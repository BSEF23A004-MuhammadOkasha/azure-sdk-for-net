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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryRunContent : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistryRunContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistryRunContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistryRunContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryRunContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RunRequestType);
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (Optional.IsDefined(AgentPoolName))
            {
                writer.WritePropertyName("agentPoolName"u8);
                writer.WriteStringValue(AgentPoolName);
            }
            if (Optional.IsDefined(LogTemplate))
            {
                writer.WritePropertyName("logTemplate"u8);
                writer.WriteStringValue(LogTemplate);
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

        internal static ContainerRegistryRunContent DeserializeContainerRegistryRunContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DockerBuildRequest": return ContainerRegistryDockerBuildContent.DeserializeContainerRegistryDockerBuildContent(element);
                    case "EncodedTaskRunRequest": return ContainerRegistryEncodedTaskRunContent.DeserializeContainerRegistryEncodedTaskRunContent(element);
                    case "FileTaskRunRequest": return ContainerRegistryFileTaskRunContent.DeserializeContainerRegistryFileTaskRunContent(element);
                    case "TaskRunRequest": return ContainerRegistryTaskRunContent.DeserializeContainerRegistryTaskRunContent(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string type = default;
            Optional<bool> isArchiveEnabled = default;
            Optional<string> agentPoolName = default;
            Optional<string> logTemplate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("agentPoolName"u8))
                {
                    agentPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logTemplate"u8))
                {
                    logTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownRunRequest(type, Optional.ToNullable(isArchiveEnabled), agentPoolName.Value, logTemplate.Value, rawData);
        }

        ContainerRegistryRunContent IModelJsonSerializable<ContainerRegistryRunContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryRunContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryRunContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistryRunContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryRunContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistryRunContent IModelSerializable<ContainerRegistryRunContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryRunContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistryRunContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerRegistryRunContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerRegistryRunContent"/> to convert. </param>
        public static implicit operator RequestContent(ContainerRegistryRunContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerRegistryRunContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerRegistryRunContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerRegistryRunContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
