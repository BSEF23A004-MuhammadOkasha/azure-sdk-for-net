// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseMigrationPropertiesSqlMi : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BackupConfiguration))
            {
                writer.WritePropertyName("backupConfiguration");
                writer.WriteObjectValue(BackupConfiguration);
            }
            if (Optional.IsDefined(OfflineConfiguration))
            {
                writer.WritePropertyName("offlineConfiguration");
                writer.WriteObjectValue(OfflineConfiguration);
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(SourceSqlConnection))
            {
                writer.WritePropertyName("sourceSqlConnection");
                writer.WriteObjectValue(SourceSqlConnection);
            }
            if (Optional.IsDefined(SourceDatabaseName))
            {
                writer.WritePropertyName("sourceDatabaseName");
                writer.WriteStringValue(SourceDatabaseName);
            }
            if (Optional.IsDefined(MigrationService))
            {
                writer.WritePropertyName("migrationService");
                writer.WriteStringValue(MigrationService);
            }
            if (Optional.IsDefined(MigrationOperationId))
            {
                writer.WritePropertyName("migrationOperationId");
                writer.WriteStringValue(MigrationOperationId);
            }
            if (Optional.IsDefined(TargetDatabaseCollation))
            {
                writer.WritePropertyName("targetDatabaseCollation");
                writer.WriteStringValue(TargetDatabaseCollation);
            }
            if (Optional.IsDefined(ProvisioningError))
            {
                writer.WritePropertyName("provisioningError");
                writer.WriteStringValue(ProvisioningError);
            }
            writer.WriteEndObject();
        }

        internal static DatabaseMigrationPropertiesSqlMi DeserializeDatabaseMigrationPropertiesSqlMi(JsonElement element)
        {
            Optional<MigrationStatusDetails> migrationStatusDetails = default;
            Optional<BackupConfiguration> backupConfiguration = default;
            Optional<OfflineConfiguration> offlineConfiguration = default;
            ResourceType kind = default;
            Optional<string> scope = default;
            Optional<string> provisioningState = default;
            Optional<string> migrationStatus = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<SqlConnectionInformation> sourceSqlConnection = default;
            Optional<string> sourceDatabaseName = default;
            Optional<string> sourceServerName = default;
            Optional<string> migrationService = default;
            Optional<string> migrationOperationId = default;
            Optional<ErrorInfo> migrationFailureError = default;
            Optional<string> targetDatabaseCollation = default;
            Optional<string> provisioningError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationStatusDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationStatusDetails = MigrationStatusDetails.DeserializeMigrationStatusDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("backupConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupConfiguration = BackupConfiguration.DeserializeBackupConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("offlineConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    offlineConfiguration = OfflineConfiguration.DeserializeOfflineConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scope"))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationStatus"))
                {
                    migrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceSqlConnection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceSqlConnection = SqlConnectionInformation.DeserializeSqlConnectionInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDatabaseName"))
                {
                    sourceDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerName"))
                {
                    sourceServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationService"))
                {
                    migrationService = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationOperationId"))
                {
                    migrationOperationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationFailureError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationFailureError = ErrorInfo.DeserializeErrorInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetDatabaseCollation"))
                {
                    targetDatabaseCollation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningError"))
                {
                    provisioningError = property.Value.GetString();
                    continue;
                }
            }
            return new DatabaseMigrationPropertiesSqlMi(kind, scope.Value, provisioningState.Value, migrationStatus.Value, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), sourceSqlConnection.Value, sourceDatabaseName.Value, sourceServerName.Value, migrationService.Value, migrationOperationId.Value, migrationFailureError.Value, targetDatabaseCollation.Value, provisioningError.Value, migrationStatusDetails.Value, backupConfiguration.Value, offlineConfiguration.Value);
        }
    }
}
