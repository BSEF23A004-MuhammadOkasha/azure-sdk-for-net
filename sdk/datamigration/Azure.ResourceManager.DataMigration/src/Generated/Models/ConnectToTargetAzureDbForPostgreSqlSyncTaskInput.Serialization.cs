// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToTargetAzureDbForPostgreSqlSyncTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo");
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WritePropertyName("targetConnectionInfo");
            writer.WriteObjectValue(TargetConnectionInfo);
            writer.WriteEndObject();
        }

        internal static ConnectToTargetAzureDbForPostgreSqlSyncTaskInput DeserializeConnectToTargetAzureDbForPostgreSqlSyncTaskInput(JsonElement element)
        {
            PostgreSqlConnectionInfo sourceConnectionInfo = default;
            PostgreSqlConnectionInfo targetConnectionInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"))
                {
                    sourceConnectionInfo = PostgreSqlConnectionInfo.DeserializePostgreSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"))
                {
                    targetConnectionInfo = PostgreSqlConnectionInfo.DeserializePostgreSqlConnectionInfo(property.Value);
                    continue;
                }
            }
            return new ConnectToTargetAzureDbForPostgreSqlSyncTaskInput(sourceConnectionInfo, targetConnectionInfo);
        }
    }
}
