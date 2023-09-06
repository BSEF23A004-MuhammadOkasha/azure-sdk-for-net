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
    public partial class ContainerAppAppleRegistrationConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppAppleRegistrationConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppAppleRegistrationConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppAppleRegistrationConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppAppleRegistrationConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecretSettingName))
            {
                writer.WritePropertyName("clientSecretSettingName"u8);
                writer.WriteStringValue(ClientSecretSettingName);
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

        internal static ContainerAppAppleRegistrationConfiguration DeserializeContainerAppAppleRegistrationConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientId = default;
            Optional<string> clientSecretSettingName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretSettingName"u8))
                {
                    clientSecretSettingName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppAppleRegistrationConfiguration(clientId.Value, clientSecretSettingName.Value, rawData);
        }

        ContainerAppAppleRegistrationConfiguration IModelJsonSerializable<ContainerAppAppleRegistrationConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppAppleRegistrationConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppAppleRegistrationConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppAppleRegistrationConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppAppleRegistrationConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppAppleRegistrationConfiguration IModelSerializable<ContainerAppAppleRegistrationConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerAppAppleRegistrationConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppAppleRegistrationConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppAppleRegistrationConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppAppleRegistrationConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppAppleRegistrationConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppAppleRegistrationConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppAppleRegistrationConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppAppleRegistrationConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
