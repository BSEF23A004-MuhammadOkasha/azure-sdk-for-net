// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Creates or updates the specified Network Virtual Appliance. </summary>
    public partial class NetworkVirtualAppliancesCreateOrUpdateOperation : Operation<NetworkVirtualAppliance>, IOperationSource<NetworkVirtualAppliance>
    {
        private readonly ArmOperationHelpers<NetworkVirtualAppliance> _operation;

        /// <summary> Initializes a new instance of NetworkVirtualAppliancesCreateOrUpdateOperation for mocking. </summary>
        protected NetworkVirtualAppliancesCreateOrUpdateOperation()
        {
        }

        internal NetworkVirtualAppliancesCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<NetworkVirtualAppliance>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "NetworkVirtualAppliancesCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override NetworkVirtualAppliance Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NetworkVirtualAppliance>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NetworkVirtualAppliance>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        NetworkVirtualAppliance IOperationSource<NetworkVirtualAppliance>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return NetworkVirtualAppliance.DeserializeNetworkVirtualAppliance(document.RootElement);
        }

        async ValueTask<NetworkVirtualAppliance> IOperationSource<NetworkVirtualAppliance>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return NetworkVirtualAppliance.DeserializeNetworkVirtualAppliance(document.RootElement);
        }
    }
}
