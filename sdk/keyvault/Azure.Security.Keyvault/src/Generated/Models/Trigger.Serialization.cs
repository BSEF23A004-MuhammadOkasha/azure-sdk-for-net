// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Models
{
    public partial class Trigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (LifetimePercentage != null)
            {
                writer.WritePropertyName("lifetime_percentage");
                writer.WriteNumberValue(LifetimePercentage.Value);
            }
            if (DaysBeforeExpiry != null)
            {
                writer.WritePropertyName("days_before_expiry");
                writer.WriteNumberValue(DaysBeforeExpiry.Value);
            }
            writer.WriteEndObject();
        }

        internal static Trigger DeserializeTrigger(JsonElement element)
        {
            int? lifetimePercentage = default;
            int? daysBeforeExpiry = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lifetime_percentage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lifetimePercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("days_before_expiry"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    daysBeforeExpiry = property.Value.GetInt32();
                    continue;
                }
            }
            return new Trigger(lifetimePercentage, daysBeforeExpiry);
        }
    }
}
