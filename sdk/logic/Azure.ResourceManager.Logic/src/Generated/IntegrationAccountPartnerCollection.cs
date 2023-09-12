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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="IntegrationAccountPartnerResource" /> and their operations.
    /// Each <see cref="IntegrationAccountPartnerResource" /> in the collection will belong to the same instance of <see cref="IntegrationAccountResource" />.
    /// To get an <see cref="IntegrationAccountPartnerCollection" /> instance call the GetIntegrationAccountPartners method from an instance of <see cref="IntegrationAccountResource" />.
    /// </summary>
    public partial class IntegrationAccountPartnerCollection : ArmCollection, IEnumerable<IntegrationAccountPartnerResource>, IAsyncEnumerable<IntegrationAccountPartnerResource>
    {
        private readonly ClientDiagnostics _integrationAccountPartnerClientDiagnostics;
        private readonly IntegrationAccountPartnersRestOperations _integrationAccountPartnerRestClient;

        /// <summary> Initializes a new instance of the <see cref="IntegrationAccountPartnerCollection"/> class for mocking. </summary>
        protected IntegrationAccountPartnerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IntegrationAccountPartnerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IntegrationAccountPartnerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _integrationAccountPartnerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationAccountPartnerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IntegrationAccountPartnerResource.ResourceType, out string integrationAccountPartnerApiVersion);
            _integrationAccountPartnerRestClient = new IntegrationAccountPartnersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, integrationAccountPartnerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IntegrationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IntegrationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an integration account partner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/partners/{partnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountPartners_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="data"> The integration account partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IntegrationAccountPartnerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string partnerName, IntegrationAccountPartnerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _integrationAccountPartnerClientDiagnostics.CreateScope("IntegrationAccountPartnerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _integrationAccountPartnerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, partnerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LogicArmOperation<IntegrationAccountPartnerResource>(Response.FromValue(new IntegrationAccountPartnerResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an integration account partner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/partners/{partnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountPartners_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="data"> The integration account partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IntegrationAccountPartnerResource> CreateOrUpdate(WaitUntil waitUntil, string partnerName, IntegrationAccountPartnerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _integrationAccountPartnerClientDiagnostics.CreateScope("IntegrationAccountPartnerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _integrationAccountPartnerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, partnerName, data, cancellationToken);
                var operation = new LogicArmOperation<IntegrationAccountPartnerResource>(Response.FromValue(new IntegrationAccountPartnerResource(Client, response), response.GetRawResponse()));
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
        /// Gets an integration account partner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/partners/{partnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountPartners_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerName"/> is null. </exception>
        public virtual async Task<Response<IntegrationAccountPartnerResource>> GetAsync(string partnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));

            using var scope = _integrationAccountPartnerClientDiagnostics.CreateScope("IntegrationAccountPartnerCollection.Get");
            scope.Start();
            try
            {
                var response = await _integrationAccountPartnerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, partnerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountPartnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an integration account partner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/partners/{partnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountPartners_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerName"/> is null. </exception>
        public virtual Response<IntegrationAccountPartnerResource> Get(string partnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));

            using var scope = _integrationAccountPartnerClientDiagnostics.CreateScope("IntegrationAccountPartnerCollection.Get");
            scope.Start();
            try
            {
                var response = _integrationAccountPartnerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, partnerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountPartnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of integration account partners.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/partners</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountPartners_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: PartnerType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationAccountPartnerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationAccountPartnerResource> GetAllAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationAccountPartnerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _integrationAccountPartnerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IntegrationAccountPartnerResource(Client, IntegrationAccountPartnerData.DeserializeIntegrationAccountPartnerData(e)), _integrationAccountPartnerClientDiagnostics, Pipeline, "IntegrationAccountPartnerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of integration account partners.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/partners</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountPartners_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: PartnerType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationAccountPartnerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationAccountPartnerResource> GetAll(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationAccountPartnerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _integrationAccountPartnerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IntegrationAccountPartnerResource(Client, IntegrationAccountPartnerData.DeserializeIntegrationAccountPartnerData(e)), _integrationAccountPartnerClientDiagnostics, Pipeline, "IntegrationAccountPartnerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/partners/{partnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountPartners_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string partnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));

            using var scope = _integrationAccountPartnerClientDiagnostics.CreateScope("IntegrationAccountPartnerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _integrationAccountPartnerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, partnerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/partners/{partnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountPartners_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerName"/> is null. </exception>
        public virtual Response<bool> Exists(string partnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));

            using var scope = _integrationAccountPartnerClientDiagnostics.CreateScope("IntegrationAccountPartnerCollection.Exists");
            scope.Start();
            try
            {
                var response = _integrationAccountPartnerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, partnerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IntegrationAccountPartnerResource> IEnumerable<IntegrationAccountPartnerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IntegrationAccountPartnerResource> IAsyncEnumerable<IntegrationAccountPartnerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
