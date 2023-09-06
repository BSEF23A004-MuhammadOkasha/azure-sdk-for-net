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
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError : IUtf8JsonSerializable, IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SyncMigrationDatabaseErrorEvent>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
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

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReportableException> error = default;
            Optional<IReadOnlyList<SyncMigrationDatabaseErrorEvent>> events = default;
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ReportableException.DeserializeReportableException(property.Value);
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyncMigrationDatabaseErrorEvent> array = new List<SyncMigrationDatabaseErrorEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncMigrationDatabaseErrorEvent.DeserializeSyncMigrationDatabaseErrorEvent(item));
                    }
                    events = array;
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
            return new MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError(id.Value, resultType, error.Value, Optional.ToList(events), rawData);
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError IModelSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError"/> to convert. </param>
        public static implicit operator RequestContent(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
