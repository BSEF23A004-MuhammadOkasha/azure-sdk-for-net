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
    public partial class ConnectToSourceSqlServerTaskInput : IUtf8JsonSerializable, IModelJsonSerializable<ConnectToSourceSqlServerTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectToSourceSqlServerTaskInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectToSourceSqlServerTaskInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceSqlServerTaskInput>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo"u8);
            if (SourceConnectionInfo is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SqlConnectionInfo>)SourceConnectionInfo).Serialize(writer, options);
            }
            if (Optional.IsDefined(CheckPermissionsGroup))
            {
                writer.WritePropertyName("checkPermissionsGroup"u8);
                writer.WriteStringValue(CheckPermissionsGroup.Value.ToSerialString());
            }
            if (Optional.IsDefined(CollectDatabases))
            {
                writer.WritePropertyName("collectDatabases"u8);
                writer.WriteBooleanValue(CollectDatabases.Value);
            }
            if (Optional.IsDefined(CollectLogins))
            {
                writer.WritePropertyName("collectLogins"u8);
                writer.WriteBooleanValue(CollectLogins.Value);
            }
            if (Optional.IsDefined(CollectAgentJobs))
            {
                writer.WritePropertyName("collectAgentJobs"u8);
                writer.WriteBooleanValue(CollectAgentJobs.Value);
            }
            if (Optional.IsDefined(CollectTdeCertificateInfo))
            {
                writer.WritePropertyName("collectTdeCertificateInfo"u8);
                writer.WriteBooleanValue(CollectTdeCertificateInfo.Value);
            }
            if (Optional.IsDefined(ValidateSsisCatalogOnly))
            {
                writer.WritePropertyName("validateSsisCatalogOnly"u8);
                writer.WriteBooleanValue(ValidateSsisCatalogOnly.Value);
            }
            if (Optional.IsDefined(EncryptedKeyForSecureFields))
            {
                writer.WritePropertyName("encryptedKeyForSecureFields"u8);
                writer.WriteStringValue(EncryptedKeyForSecureFields);
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

        internal static ConnectToSourceSqlServerTaskInput DeserializeConnectToSourceSqlServerTaskInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlConnectionInfo sourceConnectionInfo = default;
            Optional<ServerLevelPermissionsGroup> checkPermissionsGroup = default;
            Optional<bool> collectDatabases = default;
            Optional<bool> collectLogins = default;
            Optional<bool> collectAgentJobs = default;
            Optional<bool> collectTdeCertificateInfo = default;
            Optional<bool> validateSsisCatalogOnly = default;
            Optional<string> encryptedKeyForSecureFields = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("checkPermissionsGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    checkPermissionsGroup = property.Value.GetString().ToServerLevelPermissionsGroup();
                    continue;
                }
                if (property.NameEquals("collectDatabases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectDatabases = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("collectLogins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectLogins = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("collectAgentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectAgentJobs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("collectTdeCertificateInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectTdeCertificateInfo = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateSsisCatalogOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateSsisCatalogOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptedKeyForSecureFields"u8))
                {
                    encryptedKeyForSecureFields = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectToSourceSqlServerTaskInput(sourceConnectionInfo, Optional.ToNullable(checkPermissionsGroup), Optional.ToNullable(collectDatabases), Optional.ToNullable(collectLogins), Optional.ToNullable(collectAgentJobs), Optional.ToNullable(collectTdeCertificateInfo), Optional.ToNullable(validateSsisCatalogOnly), encryptedKeyForSecureFields.Value, rawData);
        }

        ConnectToSourceSqlServerTaskInput IModelJsonSerializable<ConnectToSourceSqlServerTaskInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceSqlServerTaskInput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourceSqlServerTaskInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectToSourceSqlServerTaskInput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceSqlServerTaskInput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectToSourceSqlServerTaskInput IModelSerializable<ConnectToSourceSqlServerTaskInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectToSourceSqlServerTaskInput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectToSourceSqlServerTaskInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectToSourceSqlServerTaskInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectToSourceSqlServerTaskInput"/> to convert. </param>
        public static implicit operator RequestContent(ConnectToSourceSqlServerTaskInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectToSourceSqlServerTaskInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectToSourceSqlServerTaskInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectToSourceSqlServerTaskInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
