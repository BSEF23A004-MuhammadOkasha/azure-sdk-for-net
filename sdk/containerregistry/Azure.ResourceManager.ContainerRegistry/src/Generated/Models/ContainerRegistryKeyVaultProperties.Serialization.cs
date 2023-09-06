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
    public partial class ContainerRegistryKeyVaultProperties : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistryKeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistryKeyVaultProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistryKeyVaultProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryKeyVaultProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyIdentifier))
            {
                writer.WritePropertyName("keyIdentifier"u8);
                writer.WriteStringValue(KeyIdentifier);
            }
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

        internal static ContainerRegistryKeyVaultProperties DeserializeContainerRegistryKeyVaultProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> keyIdentifier = default;
            Optional<string> versionedKeyIdentifier = default;
            Optional<string> identity = default;
            Optional<bool> keyRotationEnabled = default;
            Optional<DateTimeOffset> lastKeyRotationTimestamp = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyIdentifier"u8))
                {
                    keyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("versionedKeyIdentifier"u8))
                {
                    versionedKeyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyRotationEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyRotationEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastKeyRotationTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastKeyRotationTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerRegistryKeyVaultProperties(keyIdentifier.Value, versionedKeyIdentifier.Value, identity.Value, Optional.ToNullable(keyRotationEnabled), Optional.ToNullable(lastKeyRotationTimestamp), rawData);
        }

        ContainerRegistryKeyVaultProperties IModelJsonSerializable<ContainerRegistryKeyVaultProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryKeyVaultProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryKeyVaultProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistryKeyVaultProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryKeyVaultProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistryKeyVaultProperties IModelSerializable<ContainerRegistryKeyVaultProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryKeyVaultProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistryKeyVaultProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerRegistryKeyVaultProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerRegistryKeyVaultProperties"/> to convert. </param>
        public static implicit operator RequestContent(ContainerRegistryKeyVaultProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerRegistryKeyVaultProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerRegistryKeyVaultProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerRegistryKeyVaultProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
