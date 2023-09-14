// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedNetworkPeeringPolicyResource" /> and their operations.
    /// Each <see cref="ManagedNetworkPeeringPolicyResource" /> in the collection will belong to the same instance of <see cref="ManagedNetworkResource" />.
    /// To get a <see cref="ManagedNetworkPeeringPolicyCollection" /> instance call the GetManagedNetworkPeeringPolicies method from an instance of <see cref="ManagedNetworkResource" />.
    /// </summary>
    public partial class ManagedNetworkPeeringPolicyCollection : ArmCollection, IEnumerable<ManagedNetworkPeeringPolicyResource>, IAsyncEnumerable<ManagedNetworkPeeringPolicyResource>
    {
        private readonly ClientDiagnostics _managedNetworkPeeringPolicyClientDiagnostics;
        private readonly ManagedNetworkPeeringPoliciesRestOperations _managedNetworkPeeringPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedNetworkPeeringPolicyCollection"/> class for mocking. </summary>
        protected ManagedNetworkPeeringPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedNetworkPeeringPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedNetworkPeeringPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedNetworkPeeringPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetwork", ManagedNetworkPeeringPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedNetworkPeeringPolicyResource.ResourceType, out string managedNetworkPeeringPolicyApiVersion);
            _managedNetworkPeeringPolicyRestClient = new ManagedNetworkPeeringPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedNetworkPeeringPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedNetworkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedNetworkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The Put ManagedNetworkPeeringPolicies operation creates/updates a new Managed Network Peering Policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkPeeringPolicies/{managedNetworkPeeringPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkPeeringPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedNetworkPeeringPolicyName"> The name of the Managed Network Peering Policy. </param>
        /// <param name="data"> Parameters supplied to create/update a Managed Network Peering Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkPeeringPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkPeeringPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedNetworkPeeringPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string managedNetworkPeeringPolicyName, ManagedNetworkPeeringPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedNetworkPeeringPolicyName, nameof(managedNetworkPeeringPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedNetworkPeeringPolicyClientDiagnostics.CreateScope("ManagedNetworkPeeringPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedNetworkPeeringPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkPeeringPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkArmOperation<ManagedNetworkPeeringPolicyResource>(new ManagedNetworkPeeringPolicyOperationSource(Client), _managedNetworkPeeringPolicyClientDiagnostics, Pipeline, _managedNetworkPeeringPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkPeeringPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Put ManagedNetworkPeeringPolicies operation creates/updates a new Managed Network Peering Policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkPeeringPolicies/{managedNetworkPeeringPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkPeeringPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedNetworkPeeringPolicyName"> The name of the Managed Network Peering Policy. </param>
        /// <param name="data"> Parameters supplied to create/update a Managed Network Peering Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkPeeringPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkPeeringPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedNetworkPeeringPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string managedNetworkPeeringPolicyName, ManagedNetworkPeeringPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedNetworkPeeringPolicyName, nameof(managedNetworkPeeringPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedNetworkPeeringPolicyClientDiagnostics.CreateScope("ManagedNetworkPeeringPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedNetworkPeeringPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkPeeringPolicyName, data, cancellationToken);
                var operation = new ManagedNetworkArmOperation<ManagedNetworkPeeringPolicyResource>(new ManagedNetworkPeeringPolicyOperationSource(Client), _managedNetworkPeeringPolicyClientDiagnostics, Pipeline, _managedNetworkPeeringPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkPeeringPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Get ManagedNetworkPeeringPolicies operation gets a Managed Network Peering Policy resource, specified by the  resource group, Managed Network name, and peering policy name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkPeeringPolicies/{managedNetworkPeeringPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkPeeringPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkPeeringPolicyName"> The name of the Managed Network Peering Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkPeeringPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkPeeringPolicyName"/> is null. </exception>
        public virtual async Task<Response<ManagedNetworkPeeringPolicyResource>> GetAsync(string managedNetworkPeeringPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedNetworkPeeringPolicyName, nameof(managedNetworkPeeringPolicyName));

            using var scope = _managedNetworkPeeringPolicyClientDiagnostics.CreateScope("ManagedNetworkPeeringPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedNetworkPeeringPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkPeeringPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedNetworkPeeringPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Get ManagedNetworkPeeringPolicies operation gets a Managed Network Peering Policy resource, specified by the  resource group, Managed Network name, and peering policy name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkPeeringPolicies/{managedNetworkPeeringPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkPeeringPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkPeeringPolicyName"> The name of the Managed Network Peering Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkPeeringPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkPeeringPolicyName"/> is null. </exception>
        public virtual Response<ManagedNetworkPeeringPolicyResource> Get(string managedNetworkPeeringPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedNetworkPeeringPolicyName, nameof(managedNetworkPeeringPolicyName));

            using var scope = _managedNetworkPeeringPolicyClientDiagnostics.CreateScope("ManagedNetworkPeeringPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _managedNetworkPeeringPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkPeeringPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedNetworkPeeringPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The ListByManagedNetwork PeeringPolicies operation retrieves all the Managed Network Peering Policies in a specified Managed Network, in a paginated format.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkPeeringPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkPeeringPolicies_ListByManagedNetwork</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> May be used to limit the number of results in a page for list queries. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedNetworkPeeringPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedNetworkPeeringPolicyResource> GetAllAsync(int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedNetworkPeeringPolicyRestClient.CreateListByManagedNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedNetworkPeeringPolicyRestClient.CreateListByManagedNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedNetworkPeeringPolicyResource(Client, ManagedNetworkPeeringPolicyData.DeserializeManagedNetworkPeeringPolicyData(e)), _managedNetworkPeeringPolicyClientDiagnostics, Pipeline, "ManagedNetworkPeeringPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The ListByManagedNetwork PeeringPolicies operation retrieves all the Managed Network Peering Policies in a specified Managed Network, in a paginated format.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkPeeringPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkPeeringPolicies_ListByManagedNetwork</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> May be used to limit the number of results in a page for list queries. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedNetworkPeeringPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedNetworkPeeringPolicyResource> GetAll(int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedNetworkPeeringPolicyRestClient.CreateListByManagedNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedNetworkPeeringPolicyRestClient.CreateListByManagedNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedNetworkPeeringPolicyResource(Client, ManagedNetworkPeeringPolicyData.DeserializeManagedNetworkPeeringPolicyData(e)), _managedNetworkPeeringPolicyClientDiagnostics, Pipeline, "ManagedNetworkPeeringPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkPeeringPolicies/{managedNetworkPeeringPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkPeeringPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkPeeringPolicyName"> The name of the Managed Network Peering Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkPeeringPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkPeeringPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string managedNetworkPeeringPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedNetworkPeeringPolicyName, nameof(managedNetworkPeeringPolicyName));

            using var scope = _managedNetworkPeeringPolicyClientDiagnostics.CreateScope("ManagedNetworkPeeringPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedNetworkPeeringPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkPeeringPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetwork/managedNetworks/{managedNetworkName}/managedNetworkPeeringPolicies/{managedNetworkPeeringPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworkPeeringPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedNetworkPeeringPolicyName"> The name of the Managed Network Peering Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedNetworkPeeringPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedNetworkPeeringPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string managedNetworkPeeringPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedNetworkPeeringPolicyName, nameof(managedNetworkPeeringPolicyName));

            using var scope = _managedNetworkPeeringPolicyClientDiagnostics.CreateScope("ManagedNetworkPeeringPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedNetworkPeeringPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedNetworkPeeringPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedNetworkPeeringPolicyResource> IEnumerable<ManagedNetworkPeeringPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedNetworkPeeringPolicyResource> IAsyncEnumerable<ManagedNetworkPeeringPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
