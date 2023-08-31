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

namespace Azure.ResourceManager.FluidRelay.Models
{
    public partial class CmkEncryptionProperties : IUtf8JsonSerializable, IModelJsonSerializable<CmkEncryptionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CmkEncryptionProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CmkEncryptionProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyEncryptionKeyIdentity))
            {
                writer.WritePropertyName("keyEncryptionKeyIdentity"u8);
                if (KeyEncryptionKeyIdentity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CmkIdentity>)KeyEncryptionKeyIdentity).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(KeyEncryptionKeyUri))
            {
                writer.WritePropertyName("keyEncryptionKeyUrl"u8);
                writer.WriteStringValue(KeyEncryptionKeyUri.AbsoluteUri);
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

        internal static CmkEncryptionProperties DeserializeCmkEncryptionProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CmkIdentity> keyEncryptionKeyIdentity = default;
            Optional<Uri> keyEncryptionKeyUrl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyEncryptionKeyIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKeyIdentity = CmkIdentity.DeserializeCmkIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKeyUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKeyUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CmkEncryptionProperties(keyEncryptionKeyIdentity.Value, keyEncryptionKeyUrl.Value, rawData);
        }

        CmkEncryptionProperties IModelJsonSerializable<CmkEncryptionProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCmkEncryptionProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CmkEncryptionProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CmkEncryptionProperties IModelSerializable<CmkEncryptionProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCmkEncryptionProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CmkEncryptionProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CmkEncryptionProperties"/> to convert. </param>
        public static implicit operator RequestContent(CmkEncryptionProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CmkEncryptionProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CmkEncryptionProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCmkEncryptionProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
