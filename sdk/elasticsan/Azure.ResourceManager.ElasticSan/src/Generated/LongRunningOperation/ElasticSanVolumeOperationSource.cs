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

namespace Azure.ResourceManager.ElasticSan
{
    internal class ElasticSanVolumeOperationSource : IOperationSource<ElasticSanVolumeResource>
    {
        private readonly ArmClient _client;

        internal ElasticSanVolumeOperationSource(ArmClient client)
        {
            _client = client;
        }

        ElasticSanVolumeResource IOperationSource<ElasticSanVolumeResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ElasticSanVolumeData.DeserializeElasticSanVolumeData(document.RootElement);
            return new ElasticSanVolumeResource(_client, data);
        }

        async ValueTask<ElasticSanVolumeResource> IOperationSource<ElasticSanVolumeResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ElasticSanVolumeData.DeserializeElasticSanVolumeData(document.RootElement);
            return new ElasticSanVolumeResource(_client, data);
        }
    }
}
