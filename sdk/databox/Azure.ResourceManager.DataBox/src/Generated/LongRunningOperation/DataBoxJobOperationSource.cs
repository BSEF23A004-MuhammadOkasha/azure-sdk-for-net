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

namespace Azure.ResourceManager.DataBox
{
    internal class DataBoxJobOperationSource : IOperationSource<DataBoxJobResource>
    {
        private readonly ArmClient _client;

        internal DataBoxJobOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxJobResource IOperationSource<DataBoxJobResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataBoxJobData.DeserializeDataBoxJobData(document.RootElement);
            return new DataBoxJobResource(_client, data);
        }

        async ValueTask<DataBoxJobResource> IOperationSource<DataBoxJobResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataBoxJobData.DeserializeDataBoxJobData(document.RootElement);
            return new DataBoxJobResource(_client, data);
        }
    }
}
