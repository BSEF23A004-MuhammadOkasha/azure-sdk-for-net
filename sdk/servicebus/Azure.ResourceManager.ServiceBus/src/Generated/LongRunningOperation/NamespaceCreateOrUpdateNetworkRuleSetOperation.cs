// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Create or update NetworkRuleSet for a Namespace. </summary>
    public partial class NamespaceCreateOrUpdateNetworkRuleSetOperation : Operation<NetworkRuleSet>
    {
        private readonly OperationOrResponseInternals<NetworkRuleSet> _operation;

        /// <summary> Initializes a new instance of NamespaceCreateOrUpdateNetworkRuleSetOperation for mocking. </summary>
        protected NamespaceCreateOrUpdateNetworkRuleSetOperation()
        {
        }

        internal NamespaceCreateOrUpdateNetworkRuleSetOperation(ArmResource operationsBase, Response<NetworkRuleSetData> response)
        {
            _operation = new OperationOrResponseInternals<NetworkRuleSet>(Response.FromValue(new NetworkRuleSet(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override NetworkRuleSet Value => _operation.Value;

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
        public override ValueTask<Response<NetworkRuleSet>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NetworkRuleSet>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
