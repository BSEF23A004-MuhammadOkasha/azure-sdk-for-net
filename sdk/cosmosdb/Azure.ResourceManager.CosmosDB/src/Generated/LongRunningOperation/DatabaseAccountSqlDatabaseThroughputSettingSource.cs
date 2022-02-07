// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDB
{
    internal class DatabaseAccountSqlDatabaseThroughputSettingSource : IOperationSource<DatabaseAccountSqlDatabaseThroughputSetting>
    {
        private readonly ArmClient _client;
        private readonly Dictionary<string, string> _idMappings = new Dictionary<string, string>()
        {
            { "subscriptionId", "Microsoft.Resources/subscriptions" },
            { "resourceGroupName", "Microsoft.Resources/resourceGroups" },
            { "accountName", "Microsoft.DocumentDB/databaseAccounts" },
            { "databaseName", "Microsoft.DocumentDB/databaseAccounts/sqlDatabases" },
        };

        internal DatabaseAccountSqlDatabaseThroughputSettingSource(ArmClient client)
        {
            _client = client;
        }

        DatabaseAccountSqlDatabaseThroughputSetting IOperationSource<DatabaseAccountSqlDatabaseThroughputSetting>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ScrubId(ThroughputSettingsData.DeserializeThroughputSettingsData(document.RootElement));
            return new DatabaseAccountSqlDatabaseThroughputSetting(_client, data);
        }

        async ValueTask<DatabaseAccountSqlDatabaseThroughputSetting> IOperationSource<DatabaseAccountSqlDatabaseThroughputSetting>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ScrubId(ThroughputSettingsData.DeserializeThroughputSettingsData(document.RootElement));
            return new DatabaseAccountSqlDatabaseThroughputSetting(_client, data);
        }

        private ThroughputSettingsData ScrubId(ThroughputSettingsData data)
        {
            if (data.Id.ResourceType == DatabaseAccountSqlDatabaseThroughputSetting.ResourceType)
                return data;

            var newId = DatabaseAccountSqlDatabaseThroughputSetting.CreateResourceIdentifier(
                GetName("subscriptionId", data.Id),
                GetName("resourceGroupName", data.Id),
                GetName("accountName", data.Id),
                GetName("databaseName", data.Id));

            return new ThroughputSettingsData(
                newId,
                newId.Name,
                newId.ResourceType,
                data.SystemData,
                data.Tags,
                data.Location,
                data.Resource);
        }

        private string GetName(string param, ResourceIdentifier id)
        {
            while (id.ResourceType != _idMappings[param])
                id = id.Parent;
            return id.Name;
        }
    }
}
