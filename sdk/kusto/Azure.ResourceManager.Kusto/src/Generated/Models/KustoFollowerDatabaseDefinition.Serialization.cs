// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoFollowerDatabaseDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("clusterResourceId");
            writer.WriteStringValue(ClusterResourceId);
            writer.WritePropertyName("attachedDatabaseConfigurationName");
            writer.WriteStringValue(AttachedDatabaseConfigurationName);
            writer.WriteEndObject();
        }

        internal static KustoFollowerDatabaseDefinition DeserializeKustoFollowerDatabaseDefinition(JsonElement element)
        {
            ResourceIdentifier clusterResourceId = default;
            string attachedDatabaseConfigurationName = default;
            Optional<string> databaseName = default;
            Optional<KustoDatabaseTableLevelSharingProperties> tableLevelSharingProperties = default;
            Optional<KustoDatabaseShareOrigin> databaseShareOrigin = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterResourceId"))
                {
                    clusterResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("attachedDatabaseConfigurationName"))
                {
                    attachedDatabaseConfigurationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tableLevelSharingProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tableLevelSharingProperties = KustoDatabaseTableLevelSharingProperties.DeserializeKustoDatabaseTableLevelSharingProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("databaseShareOrigin"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    databaseShareOrigin = new KustoDatabaseShareOrigin(property.Value.GetString());
                    continue;
                }
            }
            return new KustoFollowerDatabaseDefinition(clusterResourceId, attachedDatabaseConfigurationName, databaseName.Value, tableLevelSharingProperties.Value, Optional.ToNullable(databaseShareOrigin));
        }
    }
}
