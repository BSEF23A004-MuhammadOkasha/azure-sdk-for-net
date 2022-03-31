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

namespace Azure.ResourceManager.Sql
{
    internal class ManagedDatabaseOperationSource : IOperationSource<ManagedDatabaseResource>
    {
        private readonly ArmClient _client;

        internal ManagedDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedDatabaseResource IOperationSource<ManagedDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedDatabaseData.DeserializeManagedDatabaseData(document.RootElement);
            return new ManagedDatabaseResource(_client, data);
        }

        async ValueTask<ManagedDatabaseResource> IOperationSource<ManagedDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedDatabaseData.DeserializeManagedDatabaseData(document.RootElement);
            return new ManagedDatabaseResource(_client, data);
        }
    }
}
