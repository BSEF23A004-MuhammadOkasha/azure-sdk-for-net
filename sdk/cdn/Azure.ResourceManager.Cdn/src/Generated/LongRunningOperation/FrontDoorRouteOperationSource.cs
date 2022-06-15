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

namespace Azure.ResourceManager.Cdn
{
    internal class FrontDoorRouteOperationSource : IOperationSource<FrontDoorRouteResource>
    {
        private readonly ArmClient _client;

        internal FrontDoorRouteOperationSource(ArmClient client)
        {
            _client = client;
        }

        FrontDoorRouteResource IOperationSource<FrontDoorRouteResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FrontDoorRouteData.DeserializeFrontDoorRouteData(document.RootElement);
            return new FrontDoorRouteResource(_client, data);
        }

        async ValueTask<FrontDoorRouteResource> IOperationSource<FrontDoorRouteResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FrontDoorRouteData.DeserializeFrontDoorRouteData(document.RootElement);
            return new FrontDoorRouteResource(_client, data);
        }
    }
}
