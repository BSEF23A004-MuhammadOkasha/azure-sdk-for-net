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
    public partial class ContainerRegistryTokenCertificate : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistryTokenCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistryTokenCertificate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistryTokenCertificate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTokenCertificate>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name.Value.ToString());
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiry"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
            }
            if (Optional.IsDefined(EncodedPemCertificate))
            {
                writer.WritePropertyName("encodedPemCertificate"u8);
                writer.WriteStringValue(EncodedPemCertificate);
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

        internal static ContainerRegistryTokenCertificate DeserializeContainerRegistryTokenCertificate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerRegistryTokenCertificateName> name = default;
            Optional<DateTimeOffset> expiry = default;
            Optional<string> thumbprint = default;
            Optional<string> encodedPemCertificate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = new ContainerRegistryTokenCertificateName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encodedPemCertificate"u8))
                {
                    encodedPemCertificate = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerRegistryTokenCertificate(Optional.ToNullable(name), Optional.ToNullable(expiry), thumbprint.Value, encodedPemCertificate.Value, rawData);
        }

        ContainerRegistryTokenCertificate IModelJsonSerializable<ContainerRegistryTokenCertificate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTokenCertificate>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryTokenCertificate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistryTokenCertificate>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTokenCertificate>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistryTokenCertificate IModelSerializable<ContainerRegistryTokenCertificate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryTokenCertificate>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistryTokenCertificate(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerRegistryTokenCertificate"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerRegistryTokenCertificate"/> to convert. </param>
        public static implicit operator RequestContent(ContainerRegistryTokenCertificate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerRegistryTokenCertificate"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerRegistryTokenCertificate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerRegistryTokenCertificate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
