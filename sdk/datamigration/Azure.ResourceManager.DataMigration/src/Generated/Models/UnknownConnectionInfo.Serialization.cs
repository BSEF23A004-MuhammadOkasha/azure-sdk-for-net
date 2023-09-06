// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataMigration.Models
{
    internal partial class UnknownConnectionInfo : IUtf8JsonSerializable, IModelJsonSerializable<ConnectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectionInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectionInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ConnectionInfoType);
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
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

        internal static ConnectionInfo DeserializeUnknownConnectionInfo(JsonElement element, ModelSerializerOptions options = default) => DeserializeConnectionInfo(element, options);

        ConnectionInfo IModelJsonSerializable<ConnectionInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownConnectionInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectionInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectionInfo IModelSerializable<ConnectionInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectionInfo(doc.RootElement, options);
        }
    }
}
