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
    internal class HciMachineExtensionOperationSource : IOperationSource<HciMachineExtensionResource>
    {
        private readonly ArmClient _client;

        internal HciMachineExtensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        HciMachineExtensionResource IOperationSource<HciMachineExtensionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HciMachineExtensionData.DeserializeHciMachineExtensionData(document.RootElement);
            return new HciMachineExtensionResource(_client, data);
        }

        async ValueTask<HciMachineExtensionResource> IOperationSource<HciMachineExtensionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HciMachineExtensionData.DeserializeHciMachineExtensionData(document.RootElement);
            return new HciMachineExtensionResource(_client, data);
        }
    }
}
