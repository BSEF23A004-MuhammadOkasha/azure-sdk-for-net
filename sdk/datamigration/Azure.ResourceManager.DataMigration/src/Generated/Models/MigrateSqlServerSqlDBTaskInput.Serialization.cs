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
    public partial class MigrateSqlServerSqlDBTaskInput : IUtf8JsonSerializable, IModelJsonSerializable<MigrateSqlServerSqlDBTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateSqlServerSqlDBTaskInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateSqlServerSqlDBTaskInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskInput>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("selectedDatabases"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MigrateSqlServerSqlDBDatabaseInput>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ValidationOptions))
            {
                writer.WritePropertyName("validationOptions"u8);
                if (ValidationOptions is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MigrationValidationOptions>)ValidationOptions).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn);
            }
            if (Optional.IsDefined(EncryptedKeyForSecureFields))
            {
                writer.WritePropertyName("encryptedKeyForSecureFields"u8);
                writer.WriteStringValue(EncryptedKeyForSecureFields);
            }
            writer.WritePropertyName("sourceConnectionInfo"u8);
            if (SourceConnectionInfo is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SqlConnectionInfo>)SourceConnectionInfo).Serialize(writer, options);
            }
            writer.WritePropertyName("targetConnectionInfo"u8);
            if (TargetConnectionInfo is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SqlConnectionInfo>)TargetConnectionInfo).Serialize(writer, options);
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

        internal static MigrateSqlServerSqlDBTaskInput DeserializeMigrateSqlServerSqlDBTaskInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MigrateSqlServerSqlDBDatabaseInput> selectedDatabases = default;
            Optional<MigrationValidationOptions> validationOptions = default;
            Optional<string> startedOn = default;
            Optional<string> encryptedKeyForSecureFields = default;
            SqlConnectionInfo sourceConnectionInfo = default;
            SqlConnectionInfo targetConnectionInfo = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSqlServerSqlDBDatabaseInput> array = new List<MigrateSqlServerSqlDBDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSqlServerSqlDBDatabaseInput.DeserializeMigrateSqlServerSqlDBDatabaseInput(item));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("validationOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationOptions = MigrationValidationOptions.DeserializeMigrationValidationOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    startedOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptedKeyForSecureFields"u8))
                {
                    encryptedKeyForSecureFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MigrateSqlServerSqlDBTaskInput(sourceConnectionInfo, targetConnectionInfo, selectedDatabases, validationOptions.Value, startedOn.Value, encryptedKeyForSecureFields.Value, rawData);
        }

        MigrateSqlServerSqlDBTaskInput IModelJsonSerializable<MigrateSqlServerSqlDBTaskInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskInput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBTaskInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateSqlServerSqlDBTaskInput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskInput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateSqlServerSqlDBTaskInput IModelSerializable<MigrateSqlServerSqlDBTaskInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskInput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateSqlServerSqlDBTaskInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigrateSqlServerSqlDBTaskInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigrateSqlServerSqlDBTaskInput"/> to convert. </param>
        public static implicit operator RequestContent(MigrateSqlServerSqlDBTaskInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigrateSqlServerSqlDBTaskInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigrateSqlServerSqlDBTaskInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateSqlServerSqlDBTaskInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
