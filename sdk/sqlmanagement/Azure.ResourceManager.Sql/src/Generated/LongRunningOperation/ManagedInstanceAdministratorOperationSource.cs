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
    internal class ManagedInstanceAdministratorOperationSource : IOperationSource<ManagedInstanceAdministratorResource>
    {
        private readonly ArmClient _client;

        internal ManagedInstanceAdministratorOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedInstanceAdministratorResource IOperationSource<ManagedInstanceAdministratorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedInstanceAdministratorData.DeserializeManagedInstanceAdministratorData(document.RootElement);
            return new ManagedInstanceAdministratorResource(_client, data);
        }

        async ValueTask<ManagedInstanceAdministratorResource> IOperationSource<ManagedInstanceAdministratorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedInstanceAdministratorData.DeserializeManagedInstanceAdministratorData(document.RootElement);
            return new ManagedInstanceAdministratorResource(_client, data);
        }
    }
}
