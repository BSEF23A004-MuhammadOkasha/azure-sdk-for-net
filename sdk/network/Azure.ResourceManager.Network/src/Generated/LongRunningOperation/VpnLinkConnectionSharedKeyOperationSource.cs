// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class VpnLinkConnectionSharedKeyOperationSource : IOperationSource<VpnLinkConnectionSharedKeyResource>
    {
        private readonly ArmClient _client;

        internal VpnLinkConnectionSharedKeyOperationSource(ArmClient client)
        {
            _client = client;
        }

        VpnLinkConnectionSharedKeyResource IOperationSource<VpnLinkConnectionSharedKeyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VpnLinkConnectionSharedKeyData.DeserializeVpnLinkConnectionSharedKeyData(document.RootElement);
            return new VpnLinkConnectionSharedKeyResource(_client, data);
        }

        async ValueTask<VpnLinkConnectionSharedKeyResource> IOperationSource<VpnLinkConnectionSharedKeyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VpnLinkConnectionSharedKeyData.DeserializeVpnLinkConnectionSharedKeyData(document.RootElement);
            return new VpnLinkConnectionSharedKeyResource(_client, data);
        }
    }
}
