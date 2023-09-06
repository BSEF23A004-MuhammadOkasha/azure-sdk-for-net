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
    internal partial class ConnectToSourceOracleSyncTaskInput : IUtf8JsonSerializable, IModelJsonSerializable<ConnectToSourceOracleSyncTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectToSourceOracleSyncTaskInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectToSourceOracleSyncTaskInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceOracleSyncTaskInput>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo"u8);
            if (SourceConnectionInfo is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<OracleConnectionInfo>)SourceConnectionInfo).Serialize(writer, options);
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

        internal static ConnectToSourceOracleSyncTaskInput DeserializeConnectToSourceOracleSyncTaskInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OracleConnectionInfo sourceConnectionInfo = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = OracleConnectionInfo.DeserializeOracleConnectionInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectToSourceOracleSyncTaskInput(sourceConnectionInfo, rawData);
        }

        ConnectToSourceOracleSyncTaskInput IModelJsonSerializable<ConnectToSourceOracleSyncTaskInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceOracleSyncTaskInput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourceOracleSyncTaskInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectToSourceOracleSyncTaskInput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceOracleSyncTaskInput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectToSourceOracleSyncTaskInput IModelSerializable<ConnectToSourceOracleSyncTaskInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceOracleSyncTaskInput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectToSourceOracleSyncTaskInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectToSourceOracleSyncTaskInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectToSourceOracleSyncTaskInput"/> to convert. </param>
        public static implicit operator RequestContent(ConnectToSourceOracleSyncTaskInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectToSourceOracleSyncTaskInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectToSourceOracleSyncTaskInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectToSourceOracleSyncTaskInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
