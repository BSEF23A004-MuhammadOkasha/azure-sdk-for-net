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
    public partial class ContainerAppRegistration : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppRegistration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppRegistration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppRegistration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppRegistration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(AppSecretSettingName))
            {
                writer.WritePropertyName("appSecretSettingName"u8);
                writer.WriteStringValue(AppSecretSettingName);
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

        internal static ContainerAppRegistration DeserializeContainerAppRegistration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> appId = default;
            Optional<string> appSecretSettingName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appSecretSettingName"u8))
                {
                    appSecretSettingName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppRegistration(appId.Value, appSecretSettingName.Value, rawData);
        }

        ContainerAppRegistration IModelJsonSerializable<ContainerAppRegistration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppRegistration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppRegistration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppRegistration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppRegistration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppRegistration IModelSerializable<ContainerAppRegistration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppRegistration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppRegistration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppRegistration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppRegistration"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppRegistration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppRegistration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppRegistration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppRegistration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
