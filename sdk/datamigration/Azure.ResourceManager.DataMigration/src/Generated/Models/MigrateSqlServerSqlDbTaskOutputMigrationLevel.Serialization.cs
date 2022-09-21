// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDbTaskOutputMigrationLevel
    {
        internal static MigrateSqlServerSqlDbTaskOutputMigrationLevel DeserializeMigrateSqlServerSqlDbTaskOutputMigrationLevel(JsonElement element)
        {
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<long> durationInSeconds = default;
            Optional<MigrationStatus> status = default;
            Optional<string> statusMessage = default;
            Optional<string> message = default;
            Optional<string> databases = default;
            Optional<string> databaseSummary = default;
            Optional<MigrationValidationResult> migrationValidationResult = default;
            Optional<MigrationReportResult> migrationReportResult = default;
            Optional<string> sourceServerVersion = default;
            Optional<string> sourceServerBrandVersion = default;
            Optional<string> targetServerVersion = default;
            Optional<string> targetServerBrandVersion = default;
            Optional<IReadOnlyList<ReportableException>> exceptionsAndWarnings = default;
            Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("durationInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    durationInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new MigrationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusMessage"))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databases"))
                {
                    databases = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseSummary"))
                {
                    databaseSummary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationValidationResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationValidationResult = MigrationValidationResult.DeserializeMigrationValidationResult(property.Value);
                    continue;
                }
                if (property.NameEquals("migrationReportResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationReportResult = MigrationReportResult.DeserializeMigrationReportResult(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceServerVersion"))
                {
                    sourceServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerBrandVersion"))
                {
                    sourceServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerVersion"))
                {
                    targetServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerBrandVersion"))
                {
                    targetServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exceptionsAndWarnings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    exceptionsAndWarnings = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateSqlServerSqlDbTaskOutputMigrationLevel(id.Value, resultType, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), Optional.ToNullable(durationInSeconds), Optional.ToNullable(status), statusMessage.Value, message.Value, databases.Value, databaseSummary.Value, migrationValidationResult.Value, migrationReportResult.Value, sourceServerVersion.Value, sourceServerBrandVersion.Value, targetServerVersion.Value, targetServerBrandVersion.Value, Optional.ToList(exceptionsAndWarnings));
        }
    }
}
