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

namespace Azure.ResourceManager.ServiceLinker
{
    internal class LinkerResourceOperationSource : IOperationSource<LinkerResource>
    {
        private readonly ArmClient _client;

        internal LinkerResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        LinkerResource IOperationSource<LinkerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LinkerResourceData.DeserializeLinkerResourceData(document.RootElement);
            return new LinkerResource(_client, data);
        }

        async ValueTask<LinkerResource> IOperationSource<LinkerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LinkerResourceData.DeserializeLinkerResourceData(document.RootElement);
            return new LinkerResource(_client, data);
        }
    }
}
