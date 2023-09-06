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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppScaleRuleAuth : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppScaleRuleAuth>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppScaleRuleAuth>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppScaleRuleAuth>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppScaleRuleAuth>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SecretRef))
            {
                writer.WritePropertyName("secretRef"u8);
                writer.WriteStringValue(SecretRef);
            }
            if (Optional.IsDefined(TriggerParameter))
            {
                writer.WritePropertyName("triggerParameter"u8);
                writer.WriteStringValue(TriggerParameter);
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

        internal static ContainerAppScaleRuleAuth DeserializeContainerAppScaleRuleAuth(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> secretRef = default;
            Optional<string> triggerParameter = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretRef"u8))
                {
                    secretRef = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerParameter"u8))
                {
                    triggerParameter = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppScaleRuleAuth(secretRef.Value, triggerParameter.Value, rawData);
        }

        ContainerAppScaleRuleAuth IModelJsonSerializable<ContainerAppScaleRuleAuth>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppScaleRuleAuth>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppScaleRuleAuth(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppScaleRuleAuth>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppScaleRuleAuth>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppScaleRuleAuth IModelSerializable<ContainerAppScaleRuleAuth>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppScaleRuleAuth>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppScaleRuleAuth(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppScaleRuleAuth"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppScaleRuleAuth"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppScaleRuleAuth model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppScaleRuleAuth"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppScaleRuleAuth(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppScaleRuleAuth(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
