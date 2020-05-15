// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The LoadBalancerOutboundRules service client. </summary>
    public partial class LoadBalancerOutboundRulesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LoadBalancerOutboundRulesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of LoadBalancerOutboundRulesClient for mocking. </summary>
        protected LoadBalancerOutboundRulesClient()
        {
        }

        /// <summary> Initializes a new instance of LoadBalancerOutboundRulesClient. </summary>
        public LoadBalancerOutboundRulesClient(string subscriptionId, TokenCredential tokenCredential, NetworkManagementClientOptions options = null) : this(subscriptionId, "https://management.azure.com", tokenCredential, options)
        {
        }

        /// <summary> Initializes a new instance of LoadBalancerOutboundRulesClient. </summary>
        public LoadBalancerOutboundRulesClient(string subscriptionId, string host, TokenCredential tokenCredential, NetworkManagementClientOptions options = null)
        {
            options ??= new NetworkManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, host, options);
            RestClient = new LoadBalancerOutboundRulesRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId, host: host);
        }

        /// <summary> Gets the specified load balancer outbound rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OutboundRule>> GetAsync(string resourceGroupName, string loadBalancerName, string outboundRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerOutboundRulesClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, loadBalancerName, outboundRuleName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified load balancer outbound rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OutboundRule> Get(string resourceGroupName, string loadBalancerName, string outboundRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerOutboundRulesClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, loadBalancerName, outboundRuleName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the outbound rules in a load balancer. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<OutboundRule> ListAsync(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            async Task<Page<OutboundRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerOutboundRulesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, loadBalancerName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OutboundRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerOutboundRulesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, loadBalancerName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the outbound rules in a load balancer. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<OutboundRule> List(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            Page<OutboundRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerOutboundRulesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, loadBalancerName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OutboundRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerOutboundRulesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, loadBalancerName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
