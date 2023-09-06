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
    public partial class MigrateSqlServerSqlDBSyncTaskOutputTableLevel : IUtf8JsonSerializable, IModelJsonSerializable<MigrateSqlServerSqlDBSyncTaskOutputTableLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateSqlServerSqlDBSyncTaskOutputTableLevel>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateSqlServerSqlDBSyncTaskOutputTableLevel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBSyncTaskOutputTableLevel>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        internal static MigrateSqlServerSqlDBSyncTaskOutputTableLevel DeserializeMigrateSqlServerSqlDBSyncTaskOutputTableLevel(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> tableName = default;
            Optional<string> databaseName = default;
            Optional<long> cdcInsertCounter = default;
            Optional<long> cdcUpdateCounter = default;
            Optional<long> cdcDeleteCounter = default;
            Optional<DateTimeOffset> fullLoadEstFinishTime = default;
            Optional<DateTimeOffset> fullLoadStartedOn = default;
            Optional<DateTimeOffset> fullLoadEndedOn = default;
            Optional<long> fullLoadTotalRows = default;
            Optional<SyncTableMigrationState> state = default;
            Optional<long> totalChangesApplied = default;
            Optional<long> dataErrorsCounter = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tableName"u8))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cdcInsertCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcInsertCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcUpdateCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcUpdateCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcDeleteCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcDeleteCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadEstFinishTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadEstFinishTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fullLoadStartedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadStartedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fullLoadEndedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadEndedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fullLoadTotalRows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadTotalRows = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SyncTableMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalChangesApplied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalChangesApplied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataErrorsCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataErrorsCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MigrateSqlServerSqlDBSyncTaskOutputTableLevel(id.Value, resultType, tableName.Value, databaseName.Value, Optional.ToNullable(cdcInsertCounter), Optional.ToNullable(cdcUpdateCounter), Optional.ToNullable(cdcDeleteCounter), Optional.ToNullable(fullLoadEstFinishTime), Optional.ToNullable(fullLoadStartedOn), Optional.ToNullable(fullLoadEndedOn), Optional.ToNullable(fullLoadTotalRows), Optional.ToNullable(state), Optional.ToNullable(totalChangesApplied), Optional.ToNullable(dataErrorsCounter), Optional.ToNullable(lastModifiedTime), rawData);
        }

        MigrateSqlServerSqlDBSyncTaskOutputTableLevel IModelJsonSerializable<MigrateSqlServerSqlDBSyncTaskOutputTableLevel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBSyncTaskOutputTableLevel>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBSyncTaskOutputTableLevel(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateSqlServerSqlDBSyncTaskOutputTableLevel>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBSyncTaskOutputTableLevel>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateSqlServerSqlDBSyncTaskOutputTableLevel IModelSerializable<MigrateSqlServerSqlDBSyncTaskOutputTableLevel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBSyncTaskOutputTableLevel>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateSqlServerSqlDBSyncTaskOutputTableLevel(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigrateSqlServerSqlDBSyncTaskOutputTableLevel"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigrateSqlServerSqlDBSyncTaskOutputTableLevel"/> to convert. </param>
        public static implicit operator RequestContent(MigrateSqlServerSqlDBSyncTaskOutputTableLevel model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigrateSqlServerSqlDBSyncTaskOutputTableLevel"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigrateSqlServerSqlDBSyncTaskOutputTableLevel(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateSqlServerSqlDBSyncTaskOutputTableLevel(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
