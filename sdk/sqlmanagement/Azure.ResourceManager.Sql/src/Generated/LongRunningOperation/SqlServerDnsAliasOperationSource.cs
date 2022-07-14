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
    internal class SqlServerDnsAliasOperationSource : IOperationSource<SqlServerDnsAliasResource>
    {
        private readonly ArmClient _client;

        internal SqlServerDnsAliasOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlServerDnsAliasResource IOperationSource<SqlServerDnsAliasResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlServerDnsAliasData.DeserializeSqlServerDnsAliasData(document.RootElement);
            return new SqlServerDnsAliasResource(_client, data);
        }

        async ValueTask<SqlServerDnsAliasResource> IOperationSource<SqlServerDnsAliasResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlServerDnsAliasData.DeserializeSqlServerDnsAliasData(document.RootElement);
            return new SqlServerDnsAliasResource(_client, data);
        }
    }
}
