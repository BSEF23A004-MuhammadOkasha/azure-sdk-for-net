// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class BackupPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(BackupPolicyType.ToString());
            if (Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState");
                writer.WriteObjectValue(MigrationState);
            }
            writer.WriteEndObject();
        }

        internal static BackupPolicy DeserializeBackupPolicy(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Continuous": return ContinuousModeBackupPolicy.DeserializeContinuousModeBackupPolicy(element);
                    case "Periodic": return PeriodicModeBackupPolicy.DeserializePeriodicModeBackupPolicy(element);
                }
            }
            BackupPolicyType type = default;
            Optional<BackupPolicyMigrationState> migrationState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new BackupPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationState = BackupPolicyMigrationState.DeserializeBackupPolicyMigrationState(property.Value);
                    continue;
                }
            }
            return new BackupPolicy(type, migrationState.Value);
        }
    }
}
