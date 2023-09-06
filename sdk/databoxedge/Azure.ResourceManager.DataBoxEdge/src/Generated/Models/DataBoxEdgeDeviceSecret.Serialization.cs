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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDeviceSecret : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxEdgeDeviceSecret>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxEdgeDeviceSecret>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxEdgeDeviceSecret>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceSecret>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EncryptedSecret))
            {
                writer.WritePropertyName("encryptedSecret"u8);
                if (EncryptedSecret is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AsymmetricEncryptedSecret>)EncryptedSecret).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
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

        internal static DataBoxEdgeDeviceSecret DeserializeDataBoxEdgeDeviceSecret(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AsymmetricEncryptedSecret> encryptedSecret = default;
            Optional<string> keyVaultId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encryptedSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptedSecret = AsymmetricEncryptedSecret.DeserializeAsymmetricEncryptedSecret(property.Value);
                    continue;
                }
                if (property.NameEquals("keyVaultId"u8))
                {
                    keyVaultId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxEdgeDeviceSecret(encryptedSecret.Value, keyVaultId.Value, rawData);
        }

        DataBoxEdgeDeviceSecret IModelJsonSerializable<DataBoxEdgeDeviceSecret>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceSecret>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeDeviceSecret(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxEdgeDeviceSecret>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceSecret>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxEdgeDeviceSecret IModelSerializable<DataBoxEdgeDeviceSecret>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceSecret>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxEdgeDeviceSecret(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataBoxEdgeDeviceSecret"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataBoxEdgeDeviceSecret"/> to convert. </param>
        public static implicit operator RequestContent(DataBoxEdgeDeviceSecret model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataBoxEdgeDeviceSecret"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataBoxEdgeDeviceSecret(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxEdgeDeviceSecret(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
