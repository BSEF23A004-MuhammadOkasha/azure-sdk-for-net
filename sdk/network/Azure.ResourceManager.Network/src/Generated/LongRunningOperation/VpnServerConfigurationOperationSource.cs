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
    internal class VpnServerConfigurationOperationSource : IOperationSource<VpnServerConfigurationResource>
    {
        private readonly ArmClient _client;

        internal VpnServerConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        VpnServerConfigurationResource IOperationSource<VpnServerConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VpnServerConfigurationData.DeserializeVpnServerConfigurationData(document.RootElement);
            return new VpnServerConfigurationResource(_client, data);
        }

        async ValueTask<VpnServerConfigurationResource> IOperationSource<VpnServerConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VpnServerConfigurationData.DeserializeVpnServerConfigurationData(document.RootElement);
            return new VpnServerConfigurationResource(_client, data);
        }
    }
}
