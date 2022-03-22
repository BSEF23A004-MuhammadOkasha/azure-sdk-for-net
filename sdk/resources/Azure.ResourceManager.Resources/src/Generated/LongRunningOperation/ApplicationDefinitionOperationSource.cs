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

namespace Azure.ResourceManager.Resources
{
    internal class ApplicationDefinitionOperationSource : IOperationSource<ApplicationDefinitionResource>
    {
        private readonly ArmClient _client;

        internal ApplicationDefinitionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApplicationDefinitionResource IOperationSource<ApplicationDefinitionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApplicationDefinitionData.DeserializeApplicationDefinitionData(document.RootElement);
            return new ApplicationDefinitionResource(_client, data);
        }

        async ValueTask<ApplicationDefinitionResource> IOperationSource<ApplicationDefinitionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApplicationDefinitionData.DeserializeApplicationDefinitionData(document.RootElement);
            return new ApplicationDefinitionResource(_client, data);
        }
    }
}
