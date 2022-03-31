// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="OutboundRuleResource" /> and their operations.
    /// Each <see cref="OutboundRuleResource" /> in the collection will belong to the same instance of <see cref="LoadBalancerResource" />.
    /// To get an <see cref="OutboundRuleCollection" /> instance call the GetOutboundRules method from an instance of <see cref="LoadBalancerResource" />.
    /// </summary>
    public partial class OutboundRuleCollection : ArmCollection, IEnumerable<OutboundRuleResource>, IAsyncEnumerable<OutboundRuleResource>
    {
        private readonly ClientDiagnostics _outboundRuleLoadBalancerOutboundRulesClientDiagnostics;
        private readonly LoadBalancerOutboundRulesRestOperations _outboundRuleLoadBalancerOutboundRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="OutboundRuleCollection"/> class for mocking. </summary>
        protected OutboundRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OutboundRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OutboundRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _outboundRuleLoadBalancerOutboundRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", OutboundRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OutboundRuleResource.ResourceType, out string outboundRuleLoadBalancerOutboundRulesApiVersion);
            _outboundRuleLoadBalancerOutboundRulesRestClient = new LoadBalancerOutboundRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, outboundRuleLoadBalancerOutboundRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified load balancer outbound rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules/{outboundRuleName}
        /// Operation Id: LoadBalancerOutboundRules_Get
        /// </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual async Task<Response<OutboundRuleResource>> GetAsync(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleName, nameof(outboundRuleName));

            using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _outboundRuleLoadBalancerOutboundRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified load balancer outbound rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules/{outboundRuleName}
        /// Operation Id: LoadBalancerOutboundRules_Get
        /// </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual Response<OutboundRuleResource> Get(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleName, nameof(outboundRuleName));

            using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _outboundRuleLoadBalancerOutboundRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the outbound rules in a load balancer.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules
        /// Operation Id: LoadBalancerOutboundRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OutboundRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OutboundRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<OutboundRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _outboundRuleLoadBalancerOutboundRulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OutboundRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _outboundRuleLoadBalancerOutboundRulesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all the outbound rules in a load balancer.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules
        /// Operation Id: LoadBalancerOutboundRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OutboundRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OutboundRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<OutboundRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _outboundRuleLoadBalancerOutboundRulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OutboundRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _outboundRuleLoadBalancerOutboundRulesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules/{outboundRuleName}
        /// Operation Id: LoadBalancerOutboundRules_Get
        /// </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleName, nameof(outboundRuleName));

            using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _outboundRuleLoadBalancerOutboundRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules/{outboundRuleName}
        /// Operation Id: LoadBalancerOutboundRules_Get
        /// </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleName, nameof(outboundRuleName));

            using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _outboundRuleLoadBalancerOutboundRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OutboundRuleResource> IEnumerable<OutboundRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OutboundRuleResource> IAsyncEnumerable<OutboundRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
