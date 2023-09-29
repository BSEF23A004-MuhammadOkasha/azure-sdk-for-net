// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DatabaseFleetManager
{
    internal class DatabaseFleetOperationSource : IOperationSource<DatabaseFleetResource>
    {
        private readonly ArmClient _client;

        internal DatabaseFleetOperationSource(ArmClient client)
        {
            _client = client;
        }

        DatabaseFleetResource IOperationSource<DatabaseFleetResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DatabaseFleetData.DeserializeDatabaseFleetData(document.RootElement);
            return new DatabaseFleetResource(_client, data);
        }

        async ValueTask<DatabaseFleetResource> IOperationSource<DatabaseFleetResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DatabaseFleetData.DeserializeDatabaseFleetData(document.RootElement);
            return new DatabaseFleetResource(_client, data);
        }
    }
}
