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

namespace Azure.ResourceManager.ContainerRegistry
{
    internal class ContainerRegistryPrivateEndpointConnectionOperationSource : IOperationSource<ContainerRegistryPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal ContainerRegistryPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ContainerRegistryPrivateEndpointConnectionResource IOperationSource<ContainerRegistryPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ContainerRegistryPrivateEndpointConnectionData.DeserializeContainerRegistryPrivateEndpointConnectionData(document.RootElement);
            return new ContainerRegistryPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<ContainerRegistryPrivateEndpointConnectionResource> IOperationSource<ContainerRegistryPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ContainerRegistryPrivateEndpointConnectionData.DeserializeContainerRegistryPrivateEndpointConnectionData(document.RootElement);
            return new ContainerRegistryPrivateEndpointConnectionResource(_client, data);
        }
    }
}
