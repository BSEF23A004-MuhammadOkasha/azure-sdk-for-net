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

namespace Azure.ResourceManager.Avs
{
    internal class WorkloadNetworkSegmentOperationSource : IOperationSource<WorkloadNetworkSegmentResource>
    {
        private readonly ArmClient _client;

        internal WorkloadNetworkSegmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        WorkloadNetworkSegmentResource IOperationSource<WorkloadNetworkSegmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WorkloadNetworkSegmentData.DeserializeWorkloadNetworkSegmentData(document.RootElement);
            return new WorkloadNetworkSegmentResource(_client, data);
        }

        async ValueTask<WorkloadNetworkSegmentResource> IOperationSource<WorkloadNetworkSegmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WorkloadNetworkSegmentData.DeserializeWorkloadNetworkSegmentData(document.RootElement);
            return new WorkloadNetworkSegmentResource(_client, data);
        }
    }
}
