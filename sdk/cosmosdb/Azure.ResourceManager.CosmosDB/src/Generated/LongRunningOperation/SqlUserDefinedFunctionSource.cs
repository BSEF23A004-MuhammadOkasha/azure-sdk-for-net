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
    internal class SqlUserDefinedFunctionSource : IOperationSource<SqlUserDefinedFunction>
    {
        private readonly ArmClient _client;

        internal SqlUserDefinedFunctionSource(ArmClient client)
        {
            _client = client;
        }

        SqlUserDefinedFunction IOperationSource<SqlUserDefinedFunction>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlUserDefinedFunctionData.DeserializeSqlUserDefinedFunctionData(document.RootElement);
            return new SqlUserDefinedFunction(_client, data);
        }

        async ValueTask<SqlUserDefinedFunction> IOperationSource<SqlUserDefinedFunction>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlUserDefinedFunctionData.DeserializeSqlUserDefinedFunctionData(document.RootElement);
            return new SqlUserDefinedFunction(_client, data);
        }
    }
}
