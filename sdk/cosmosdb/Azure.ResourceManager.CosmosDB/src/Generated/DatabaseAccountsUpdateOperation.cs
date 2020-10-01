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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> Updates the properties of an existing Azure Cosmos DB database account. </summary>
    public partial class DatabaseAccountsUpdateOperation : Operation<DatabaseAccountGetResults>, IOperationSource<DatabaseAccountGetResults>
    {
        private readonly ArmOperationHelpers<DatabaseAccountGetResults> _operation;
        internal DatabaseAccountsUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<DatabaseAccountGetResults>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DatabaseAccountsUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DatabaseAccountGetResults Value => _operation.Value;

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
        public override ValueTask<Response<DatabaseAccountGetResults>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DatabaseAccountGetResults>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DatabaseAccountGetResults IOperationSource<DatabaseAccountGetResults>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DatabaseAccountGetResults.DeserializeDatabaseAccountGetResults(document.RootElement);
        }

        async ValueTask<DatabaseAccountGetResults> IOperationSource<DatabaseAccountGetResults>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DatabaseAccountGetResults.DeserializeDatabaseAccountGetResults(document.RootElement);
        }
    }
}
