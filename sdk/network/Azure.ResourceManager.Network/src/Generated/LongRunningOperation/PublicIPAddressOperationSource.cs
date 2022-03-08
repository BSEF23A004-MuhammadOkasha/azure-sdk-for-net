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
    internal class PublicIPAddressOperationSource : IOperationSource<PublicIPAddress>
    {
        private readonly ArmClient _client;

        internal PublicIPAddressOperationSource(ArmClient client)
        {
            _client = client;
        }

        PublicIPAddress IOperationSource<PublicIPAddress>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PublicIPAddressData.DeserializePublicIPAddressData(document.RootElement);
            return new PublicIPAddress(_client, data);
        }

        async ValueTask<PublicIPAddress> IOperationSource<PublicIPAddress>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PublicIPAddressData.DeserializePublicIPAddressData(document.RootElement);
            return new PublicIPAddress(_client, data);
        }
    }
}
