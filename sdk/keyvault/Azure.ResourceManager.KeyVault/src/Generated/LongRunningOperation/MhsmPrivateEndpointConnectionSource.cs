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

namespace Azure.ResourceManager.KeyVault
{
    internal class MhsmPrivateEndpointConnectionSource : IOperationSource<MhsmPrivateEndpointConnection>
    {
        private readonly ArmClient _client;

        internal MhsmPrivateEndpointConnectionSource(ArmClient client)
        {
            _client = client;
        }

        MhsmPrivateEndpointConnection IOperationSource<MhsmPrivateEndpointConnection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MhsmPrivateEndpointConnectionData.DeserializeMhsmPrivateEndpointConnectionData(document.RootElement);
            return new MhsmPrivateEndpointConnection(_client, data);
        }

        async ValueTask<MhsmPrivateEndpointConnection> IOperationSource<MhsmPrivateEndpointConnection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MhsmPrivateEndpointConnectionData.DeserializeMhsmPrivateEndpointConnectionData(document.RootElement);
            return new MhsmPrivateEndpointConnection(_client, data);
        }
    }
}
