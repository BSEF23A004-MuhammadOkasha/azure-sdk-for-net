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
    /// <summary> Query the status of a running packet capture session. </summary>
    public partial class PacketCapturesGetStatusOperation : Operation<PacketCaptureQueryStatusResult>, IOperationSource<PacketCaptureQueryStatusResult>
    {
        private readonly ArmOperationHelpers<PacketCaptureQueryStatusResult> _operation;
        internal PacketCapturesGetStatusOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<PacketCaptureQueryStatusResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "PacketCapturesGetStatusOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override PacketCaptureQueryStatusResult Value => _operation.Value;

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
        public override ValueTask<Response<PacketCaptureQueryStatusResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PacketCaptureQueryStatusResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PacketCaptureQueryStatusResult IOperationSource<PacketCaptureQueryStatusResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return PacketCaptureQueryStatusResult.DeserializePacketCaptureQueryStatusResult(document.RootElement);
            }
        }

        async ValueTask<PacketCaptureQueryStatusResult> IOperationSource<PacketCaptureQueryStatusResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return PacketCaptureQueryStatusResult.DeserializePacketCaptureQueryStatusResult(document.RootElement);
            }
        }
    }
}
