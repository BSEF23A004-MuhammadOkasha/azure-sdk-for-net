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

namespace Azure.ResourceManager.Network
{
    internal class ExpressRouteConnectionOperationSource : IOperationSource<ExpressRouteConnectionResource>
    {
        private readonly ArmClient _client;

        internal ExpressRouteConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ExpressRouteConnectionResource IOperationSource<ExpressRouteConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ExpressRouteConnectionData.DeserializeExpressRouteConnectionData(document.RootElement);
            return new ExpressRouteConnectionResource(_client, data);
        }

        async ValueTask<ExpressRouteConnectionResource> IOperationSource<ExpressRouteConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ExpressRouteConnectionData.DeserializeExpressRouteConnectionData(document.RootElement);
            return new ExpressRouteConnectionResource(_client, data);
        }
    }
}
