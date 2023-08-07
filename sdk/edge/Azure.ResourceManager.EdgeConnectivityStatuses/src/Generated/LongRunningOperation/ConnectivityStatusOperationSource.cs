// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.EdgeConnectivityStatuses.Models;

namespace Azure.ResourceManager.EdgeConnectivityStatuses
{
    internal class ConnectivityStatusOperationSource : IOperationSource<ConnectivityStatus>
    {
        ConnectivityStatus IOperationSource<ConnectivityStatus>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ConnectivityStatus.DeserializeConnectivityStatus(document.RootElement);
        }

        async ValueTask<ConnectivityStatus> IOperationSource<ConnectivityStatus>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ConnectivityStatus.DeserializeConnectivityStatus(document.RootElement);
        }
    }
}
