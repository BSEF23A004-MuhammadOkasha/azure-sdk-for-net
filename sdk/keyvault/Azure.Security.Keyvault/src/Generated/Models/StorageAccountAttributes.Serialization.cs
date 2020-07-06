// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Models
{
    public partial class StorageAccountAttributes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Enabled != null)
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Created != null)
            {
                writer.WritePropertyName("created");
                writer.WriteNumberValue(Created.Value, "U");
            }
            if (Updated != null)
            {
                writer.WritePropertyName("updated");
                writer.WriteNumberValue(Updated.Value, "U");
            }
            if (RecoveryLevel != null)
            {
                writer.WritePropertyName("recoveryLevel");
                writer.WriteStringValue(RecoveryLevel.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static StorageAccountAttributes DeserializeStorageAccountAttributes(JsonElement element)
        {
            bool? enabled = default;
            DateTimeOffset? created = default;
            DateTimeOffset? updated = default;
            DeletionRecoveryLevel? recoveryLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("created"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("updated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updated = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("recoveryLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryLevel = new DeletionRecoveryLevel(property.Value.GetString());
                    continue;
                }
            }
            return new StorageAccountAttributes(enabled, created, updated, recoveryLevel);
        }
    }
}
