// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Models
{
    public partial class CertificateAttributes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (RecoverableDays != null)
            {
                writer.WritePropertyName("recoverableDays");
                writer.WriteNumberValue(RecoverableDays.Value);
            }
            if (RecoveryLevel != null)
            {
                writer.WritePropertyName("recoveryLevel");
                writer.WriteStringValue(RecoveryLevel.Value.ToString());
            }
            if (Enabled != null)
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (NotBefore != null)
            {
                writer.WritePropertyName("nbf");
                writer.WriteNumberValue(NotBefore.Value, "U");
            }
            if (Expires != null)
            {
                writer.WritePropertyName("exp");
                writer.WriteNumberValue(Expires.Value, "U");
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
            writer.WriteEndObject();
        }

        internal static CertificateAttributes DeserializeCertificateAttributes(JsonElement element)
        {
            int? recoverableDays = default;
            DeletionRecoveryLevel? recoveryLevel = default;
            bool? enabled = default;
            DateTimeOffset? nbf = default;
            DateTimeOffset? exp = default;
            DateTimeOffset? created = default;
            DateTimeOffset? updated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoverableDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoverableDays = property.Value.GetInt32();
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
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nbf"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nbf = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("exp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exp = property.Value.GetDateTimeOffset("U");
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
            }
            return new CertificateAttributes(enabled, nbf, exp, created, updated, recoverableDays, recoveryLevel);
        }
    }
}
