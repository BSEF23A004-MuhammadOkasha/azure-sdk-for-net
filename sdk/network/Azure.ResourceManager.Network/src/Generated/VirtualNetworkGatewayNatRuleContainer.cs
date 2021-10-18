// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualNetworkGatewayNatRule and their operations over its parent. </summary>
    public partial class VirtualNetworkGatewayNatRuleContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualNetworkGatewayNatRulesRestOperations _virtualNetworkGatewayNatRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayNatRuleContainer"/> class for mocking. </summary>
        protected VirtualNetworkGatewayNatRuleContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayNatRuleContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkGatewayNatRuleContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualNetworkGatewayNatRulesRestClient = new VirtualNetworkGatewayNatRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => "Microsoft.Network/virtualNetworkGateways";

        // Container level operations.

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public virtual VirtualNetworkGatewayNatRuleCreateOrUpdateOperation CreateOrUpdate(string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayNatRulesRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken);
                var operation = new VirtualNetworkGatewayNatRuleCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualNetworkGatewayNatRulesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkGatewayNatRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayNatRulesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkGatewayNatRuleCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualNetworkGatewayNatRulesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a nat rule. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayNatRule> Get(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayNatRulesRestClient.Get(Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayNatRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a nat rule. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGatewayNatRule>> GetAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayNatRulesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkGatewayNatRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayNatRule> GetIfExists(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayNatRulesRestClient.Get(Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkGatewayNatRule>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGatewayNatRule>> GetIfExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayNatRulesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkGatewayNatRule>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(natRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkGatewayNatRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkGatewayNatRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkGatewayNatRulesRestClient.GetAllByVirtualNetworkGateway(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkGatewayNatRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkGatewayNatRulesRestClient.GetAllByVirtualNetworkGatewayNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkGatewayNatRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkGatewayNatRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkGatewayNatRulesRestClient.GetAllByVirtualNetworkGatewayAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkGatewayNatRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkGatewayNatRulesRestClient.GetAllByVirtualNetworkGatewayNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, VirtualNetworkGatewayNatRule, VirtualNetworkGatewayNatRuleData> Construct() { }
    }
}
