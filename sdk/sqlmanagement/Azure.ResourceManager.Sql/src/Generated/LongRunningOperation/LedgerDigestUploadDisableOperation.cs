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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Disables uploading ledger digests to an Azure Storage account or an Azure Confidential Ledger instance. </summary>
    public partial class LedgerDigestUploadDisableOperation : Operation<LedgerDigestUploadsData>, IOperationSource<LedgerDigestUploadsData>
    {
        private readonly OperationInternals<LedgerDigestUploadsData> _operation;

        /// <summary> Initializes a new instance of LedgerDigestUploadDisableOperation for mocking. </summary>
        protected LedgerDigestUploadDisableOperation()
        {
        }

        internal LedgerDigestUploadDisableOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<LedgerDigestUploadsData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "LedgerDigestUploadDisableOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override LedgerDigestUploadsData Value => _operation.Value;

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
        public override ValueTask<Response<LedgerDigestUploadsData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<LedgerDigestUploadsData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        LedgerDigestUploadsData IOperationSource<LedgerDigestUploadsData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return LedgerDigestUploadsData.DeserializeLedgerDigestUploadsData(document.RootElement);
        }

        async ValueTask<LedgerDigestUploadsData> IOperationSource<LedgerDigestUploadsData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return LedgerDigestUploadsData.DeserializeLedgerDigestUploadsData(document.RootElement);
        }
    }
}
