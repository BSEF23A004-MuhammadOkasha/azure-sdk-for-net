// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal class ConnectionSharedKeyOperationSource : IOperationSource<ConnectionSharedKey>
    {
        ConnectionSharedKey IOperationSource<ConnectionSharedKey>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ConnectionSharedKey.DeserializeConnectionSharedKey(document.RootElement);
        }

        async ValueTask<ConnectionSharedKey> IOperationSource<ConnectionSharedKey>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ConnectionSharedKey.DeserializeConnectionSharedKey(document.RootElement);
        }
    }
}
