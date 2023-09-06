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

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerGroupEncryptionProperties : IUtf8JsonSerializable, IModelJsonSerializable<ContainerGroupEncryptionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerGroupEncryptionProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerGroupEncryptionProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerGroupEncryptionProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("vaultBaseUrl"u8);
            writer.WriteStringValue(VaultBaseUri.AbsoluteUri);
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
            writer.WritePropertyName("keyVersion"u8);
            writer.WriteStringValue(KeyVersion);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteStringValue(Identity);
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

        internal static ContainerGroupEncryptionProperties DeserializeContainerGroupEncryptionProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri vaultBaseUrl = default;
            string keyName = default;
            string keyVersion = default;
            Optional<string> identity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultBaseUrl"u8))
                {
                    vaultBaseUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"u8))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerGroupEncryptionProperties(vaultBaseUrl, keyName, keyVersion, identity.Value, rawData);
        }

        ContainerGroupEncryptionProperties IModelJsonSerializable<ContainerGroupEncryptionProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerGroupEncryptionProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerGroupEncryptionProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerGroupEncryptionProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerGroupEncryptionProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerGroupEncryptionProperties IModelSerializable<ContainerGroupEncryptionProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerGroupEncryptionProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerGroupEncryptionProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerGroupEncryptionProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerGroupEncryptionProperties"/> to convert. </param>
        public static implicit operator RequestContent(ContainerGroupEncryptionProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerGroupEncryptionProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerGroupEncryptionProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerGroupEncryptionProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
