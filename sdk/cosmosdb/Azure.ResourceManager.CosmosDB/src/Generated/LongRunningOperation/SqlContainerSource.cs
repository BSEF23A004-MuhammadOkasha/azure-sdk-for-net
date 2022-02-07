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

namespace Azure.ResourceManager.CosmosDB
{
    internal class SqlContainerSource : IOperationSource<SqlContainer>
    {
        private readonly ArmClient _client;

        internal SqlContainerSource(ArmClient client)
        {
            _client = client;
        }

        SqlContainer IOperationSource<SqlContainer>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlContainerData.DeserializeSqlContainerData(document.RootElement);
            return new SqlContainer(_client, data);
        }

        async ValueTask<SqlContainer> IOperationSource<SqlContainer>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlContainerData.DeserializeSqlContainerData(document.RootElement);
            return new SqlContainer(_client, data);
        }
    }
}
