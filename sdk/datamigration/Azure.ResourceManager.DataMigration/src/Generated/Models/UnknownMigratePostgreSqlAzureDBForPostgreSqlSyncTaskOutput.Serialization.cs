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
    internal partial class UnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput : IUtf8JsonSerializable, IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>(this, options.Format);

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

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput DeserializeUnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(JsonElement element, ModelSerializerOptions options = default) => DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(element, options);

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput IModelSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(doc.RootElement, options);
        }
    }
}
