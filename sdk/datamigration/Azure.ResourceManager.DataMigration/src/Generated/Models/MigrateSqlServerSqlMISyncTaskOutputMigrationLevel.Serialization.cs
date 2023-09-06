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
    public partial class MigrateSqlServerSqlMISyncTaskOutputMigrationLevel : IUtf8JsonSerializable, IModelJsonSerializable<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>(this, options.Format);

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

        internal static MigrateSqlServerSqlMISyncTaskOutputMigrationLevel DeserializeMigrateSqlServerSqlMISyncTaskOutputMigrationLevel(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> databaseCount = default;
            Optional<MigrationState> state = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<string> sourceServerName = default;
            Optional<string> sourceServerVersion = default;
            Optional<string> sourceServerBrandVersion = default;
            Optional<string> targetServerName = default;
            Optional<string> targetServerVersion = default;
            Optional<string> targetServerBrandVersion = default;
            Optional<int> databaseErrorCount = default;
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new MigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceServerName"u8))
                {
                    sourceServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerVersion"u8))
                {
                    sourceServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerBrandVersion"u8))
                {
                    sourceServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerName"u8))
                {
                    targetServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerVersion"u8))
                {
                    targetServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerBrandVersion"u8))
                {
                    targetServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseErrorCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseErrorCount = property.Value.GetInt32();
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
            return new MigrateSqlServerSqlMISyncTaskOutputMigrationLevel(id.Value, resultType, Optional.ToNullable(databaseCount), Optional.ToNullable(state), Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), sourceServerName.Value, sourceServerVersion.Value, sourceServerBrandVersion.Value, targetServerName.Value, targetServerVersion.Value, targetServerBrandVersion.Value, Optional.ToNullable(databaseErrorCount), rawData);
        }

        MigrateSqlServerSqlMISyncTaskOutputMigrationLevel IModelJsonSerializable<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlMISyncTaskOutputMigrationLevel(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateSqlServerSqlMISyncTaskOutputMigrationLevel IModelSerializable<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateSqlServerSqlMISyncTaskOutputMigrationLevel(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigrateSqlServerSqlMISyncTaskOutputMigrationLevel"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigrateSqlServerSqlMISyncTaskOutputMigrationLevel"/> to convert. </param>
        public static implicit operator RequestContent(MigrateSqlServerSqlMISyncTaskOutputMigrationLevel model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigrateSqlServerSqlMISyncTaskOutputMigrationLevel"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigrateSqlServerSqlMISyncTaskOutputMigrationLevel(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateSqlServerSqlMISyncTaskOutputMigrationLevel(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
