// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDbSyncDatabaseInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(TargetDatabaseName))
            {
                writer.WritePropertyName("targetDatabaseName");
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName");
                writer.WriteStringValue(SchemaName);
            }
            if (Optional.IsCollectionDefined(TableMap))
            {
                writer.WritePropertyName("tableMap");
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
                writer.WritePropertyName("migrationSetting");
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
                writer.WritePropertyName("sourceSetting");
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
                writer.WritePropertyName("targetSetting");
                writer.WriteStartObject();
                foreach (var item in TargetSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static MigrateSqlServerSqlDbSyncDatabaseInput DeserializeMigrateSqlServerSqlDbSyncDatabaseInput(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> targetDatabaseName = default;
            Optional<string> schemaName = default;
            Optional<IDictionary<string, string>> tableMap = default;
            Optional<IDictionary<string, string>> migrationSetting = default;
            Optional<IDictionary<string, string>> sourceSetting = default;
            Optional<IDictionary<string, string>> targetSetting = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"))
                {
                    targetDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tableMap"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("migrationSetting"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("sourceSetting"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("targetSetting"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
            }
            return new MigrateSqlServerSqlDbSyncDatabaseInput(id.Value, name.Value, targetDatabaseName.Value, schemaName.Value, Optional.ToDictionary(tableMap), Optional.ToDictionary(migrationSetting), Optional.ToDictionary(sourceSetting), Optional.ToDictionary(targetSetting));
        }
    }
}
