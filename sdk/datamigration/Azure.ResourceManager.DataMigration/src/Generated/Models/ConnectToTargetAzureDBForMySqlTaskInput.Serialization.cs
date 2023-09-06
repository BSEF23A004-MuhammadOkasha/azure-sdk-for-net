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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToTargetAzureDBForMySqlTaskInput : IUtf8JsonSerializable, IModelJsonSerializable<ConnectToTargetAzureDBForMySqlTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectToTargetAzureDBForMySqlTaskInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectToTargetAzureDBForMySqlTaskInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToTargetAzureDBForMySqlTaskInput>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo"u8);
            if (SourceConnectionInfo is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<MySqlConnectionInfo>)SourceConnectionInfo).Serialize(writer, options);
            }
            writer.WritePropertyName("targetConnectionInfo"u8);
            if (TargetConnectionInfo is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<MySqlConnectionInfo>)TargetConnectionInfo).Serialize(writer, options);
            }
            if (Optional.IsDefined(IsOfflineMigration))
            {
                writer.WritePropertyName("isOfflineMigration"u8);
                writer.WriteBooleanValue(IsOfflineMigration.Value);
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

        internal static ConnectToTargetAzureDBForMySqlTaskInput DeserializeConnectToTargetAzureDBForMySqlTaskInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MySqlConnectionInfo sourceConnectionInfo = default;
            MySqlConnectionInfo targetConnectionInfo = default;
            Optional<bool> isOfflineMigration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("isOfflineMigration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOfflineMigration = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectToTargetAzureDBForMySqlTaskInput(sourceConnectionInfo, targetConnectionInfo, Optional.ToNullable(isOfflineMigration), rawData);
        }

        ConnectToTargetAzureDBForMySqlTaskInput IModelJsonSerializable<ConnectToTargetAzureDBForMySqlTaskInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToTargetAzureDBForMySqlTaskInput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToTargetAzureDBForMySqlTaskInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectToTargetAzureDBForMySqlTaskInput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToTargetAzureDBForMySqlTaskInput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectToTargetAzureDBForMySqlTaskInput IModelSerializable<ConnectToTargetAzureDBForMySqlTaskInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToTargetAzureDBForMySqlTaskInput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectToTargetAzureDBForMySqlTaskInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectToTargetAzureDBForMySqlTaskInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectToTargetAzureDBForMySqlTaskInput"/> to convert. </param>
        public static implicit operator RequestContent(ConnectToTargetAzureDBForMySqlTaskInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectToTargetAzureDBForMySqlTaskInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectToTargetAzureDBForMySqlTaskInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectToTargetAzureDBForMySqlTaskInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
