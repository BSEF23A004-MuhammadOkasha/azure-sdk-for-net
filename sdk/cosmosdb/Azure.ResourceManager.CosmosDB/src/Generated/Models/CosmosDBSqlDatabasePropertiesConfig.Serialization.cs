// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBSqlDatabasePropertiesConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Throughput))
            {
                writer.WritePropertyName("throughput");
                writer.WriteNumberValue(Throughput.Value);
            }
            if (Optional.IsDefined(AutoscaleSettings))
            {
                writer.WritePropertyName("autoscaleSettings");
                writer.WriteObjectValue(AutoscaleSettings);
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBSqlDatabasePropertiesConfig DeserializeCosmosDBSqlDatabasePropertiesConfig(JsonElement element)
        {
            Optional<int> throughput = default;
            Optional<AutoscaleSettings> autoscaleSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("throughput"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    throughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoscaleSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoscaleSettings = AutoscaleSettings.DeserializeAutoscaleSettings(property.Value);
                    continue;
                }
            }
            return new CosmosDBSqlDatabasePropertiesConfig(Optional.ToNullable(throughput), autoscaleSettings.Value);
        }
    }
}
