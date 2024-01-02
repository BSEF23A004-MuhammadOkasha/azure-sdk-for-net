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

namespace Azure.ResourceManager.Hci
{
    internal class GuestAgentOperationSource : IOperationSource<GuestAgentResource>
    {
        private readonly ArmClient _client;

        internal GuestAgentOperationSource(ArmClient client)
        {
            _client = client;
        }

        GuestAgentResource IOperationSource<GuestAgentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GuestAgentData.DeserializeGuestAgentData(document.RootElement);
            return new GuestAgentResource(_client, data);
        }

        async ValueTask<GuestAgentResource> IOperationSource<GuestAgentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GuestAgentData.DeserializeGuestAgentData(document.RootElement);
            return new GuestAgentResource(_client, data);
        }
    }
}
