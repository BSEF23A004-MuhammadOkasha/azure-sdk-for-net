// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class RestoredLogs : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StartRestoreOn))
            {
                writer.WritePropertyName("startRestoreTime");
                writer.WriteStringValue(StartRestoreOn.Value, "O");
            }
            if (Optional.IsDefined(EndRestoreOn))
            {
                writer.WritePropertyName("endRestoreTime");
                writer.WriteStringValue(EndRestoreOn.Value, "O");
            }
            if (Optional.IsDefined(SourceTable))
            {
                writer.WritePropertyName("sourceTable");
                writer.WriteStringValue(SourceTable);
            }
            writer.WriteEndObject();
        }

        internal static RestoredLogs DeserializeRestoredLogs(JsonElement element)
        {
            Optional<DateTimeOffset> startRestoreTime = default;
            Optional<DateTimeOffset> endRestoreTime = default;
            Optional<string> sourceTable = default;
            Optional<string> azureAsyncOperationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startRestoreTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startRestoreTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endRestoreTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endRestoreTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceTable"))
                {
                    sourceTable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureAsyncOperationId"))
                {
                    azureAsyncOperationId = property.Value.GetString();
                    continue;
                }
            }
            return new RestoredLogs(Optional.ToNullable(startRestoreTime), Optional.ToNullable(endRestoreTime), sourceTable.Value, azureAsyncOperationId.Value);
        }
    }
}
