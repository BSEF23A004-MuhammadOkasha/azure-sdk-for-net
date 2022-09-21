// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDbSyncTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("selectedDatabases");
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ValidationOptions))
            {
                writer.WritePropertyName("validationOptions");
                writer.WriteObjectValue(ValidationOptions);
            }
            writer.WritePropertyName("sourceConnectionInfo");
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WritePropertyName("targetConnectionInfo");
            writer.WriteObjectValue(TargetConnectionInfo);
            writer.WriteEndObject();
        }

        internal static MigrateSqlServerSqlDbSyncTaskInput DeserializeMigrateSqlServerSqlDbSyncTaskInput(JsonElement element)
        {
            IList<MigrateSqlServerSqlDbSyncDatabaseInput> selectedDatabases = default;
            Optional<MigrationValidationOptions> validationOptions = default;
            SqlConnectionInfo sourceConnectionInfo = default;
            SqlConnectionInfo targetConnectionInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"))
                {
                    List<MigrateSqlServerSqlDbSyncDatabaseInput> array = new List<MigrateSqlServerSqlDbSyncDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSqlServerSqlDbSyncDatabaseInput.DeserializeMigrateSqlServerSqlDbSyncDatabaseInput(item));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("validationOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validationOptions = MigrationValidationOptions.DeserializeMigrationValidationOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"))
                {
                    targetConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
            }
            return new MigrateSqlServerSqlDbSyncTaskInput(sourceConnectionInfo, targetConnectionInfo, selectedDatabases, validationOptions.Value);
        }
    }
}
