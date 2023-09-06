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
    public partial class MigrateSqlServerSqlDBSyncDatabaseInput : IUtf8JsonSerializable, IModelJsonSerializable<MigrateSqlServerSqlDBSyncDatabaseInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateSqlServerSqlDBSyncDatabaseInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateSqlServerSqlDBSyncDatabaseInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBSyncDatabaseInput>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(TargetDatabaseName))
            {
                writer.WritePropertyName("targetDatabaseName"u8);
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName"u8);
                writer.WriteStringValue(SchemaName);
            }
            if (Optional.IsCollectionDefined(TableMap))
            {
                writer.WritePropertyName("tableMap"u8);
                writer.WriteStartObject();
                foreach (var item in TableMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(MigrationSetting))
            {
                writer.WritePropertyName("migrationSetting"u8);
                writer.WriteStartObject();
                foreach (var item in MigrationSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SourceSetting))
            {
                writer.WritePropertyName("sourceSetting"u8);
                writer.WriteStartObject();
                foreach (var item in SourceSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetSetting))
            {
                writer.WritePropertyName("targetSetting"u8);
                writer.WriteStartObject();
                foreach (var item in TargetSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static MigrateSqlServerSqlDBSyncDatabaseInput DeserializeMigrateSqlServerSqlDBSyncDatabaseInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> targetDatabaseName = default;
            Optional<string> schemaName = default;
            Optional<IDictionary<string, string>> tableMap = default;
            Optional<IDictionary<string, string>> migrationSetting = default;
            Optional<IDictionary<string, string>> sourceSetting = default;
            Optional<IDictionary<string, string>> targetSetting = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"u8))
                {
                    targetDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"u8))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tableMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tableMap = dictionary;
                    continue;
                }
                if (property.NameEquals("migrationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    migrationSetting = dictionary;
                    continue;
                }
                if (property.NameEquals("sourceSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    sourceSetting = dictionary;
                    continue;
                }
                if (property.NameEquals("targetSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetSetting = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MigrateSqlServerSqlDBSyncDatabaseInput(id.Value, name.Value, targetDatabaseName.Value, schemaName.Value, Optional.ToDictionary(tableMap), Optional.ToDictionary(migrationSetting), Optional.ToDictionary(sourceSetting), Optional.ToDictionary(targetSetting), rawData);
        }

        MigrateSqlServerSqlDBSyncDatabaseInput IModelJsonSerializable<MigrateSqlServerSqlDBSyncDatabaseInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBSyncDatabaseInput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBSyncDatabaseInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateSqlServerSqlDBSyncDatabaseInput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBSyncDatabaseInput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateSqlServerSqlDBSyncDatabaseInput IModelSerializable<MigrateSqlServerSqlDBSyncDatabaseInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBSyncDatabaseInput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateSqlServerSqlDBSyncDatabaseInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigrateSqlServerSqlDBSyncDatabaseInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigrateSqlServerSqlDBSyncDatabaseInput"/> to convert. </param>
        public static implicit operator RequestContent(MigrateSqlServerSqlDBSyncDatabaseInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigrateSqlServerSqlDBSyncDatabaseInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigrateSqlServerSqlDBSyncDatabaseInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateSqlServerSqlDBSyncDatabaseInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
