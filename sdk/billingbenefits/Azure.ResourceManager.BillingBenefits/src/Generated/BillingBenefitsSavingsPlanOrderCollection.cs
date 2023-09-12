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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.BillingBenefits
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingBenefitsSavingsPlanOrderResource" /> and their operations.
    /// Each <see cref="BillingBenefitsSavingsPlanOrderResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="BillingBenefitsSavingsPlanOrderCollection" /> instance call the GetBillingBenefitsSavingsPlanOrders method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class BillingBenefitsSavingsPlanOrderCollection : ArmCollection, IEnumerable<BillingBenefitsSavingsPlanOrderResource>, IAsyncEnumerable<BillingBenefitsSavingsPlanOrderResource>
    {
        private readonly ClientDiagnostics _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics;
        private readonly SavingsPlanOrderRestOperations _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsSavingsPlanOrderCollection"/> class for mocking. </summary>
        protected BillingBenefitsSavingsPlanOrderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsSavingsPlanOrderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingBenefitsSavingsPlanOrderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.BillingBenefits", BillingBenefitsSavingsPlanOrderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingBenefitsSavingsPlanOrderResource.ResourceType, out string billingBenefitsSavingsPlanOrderSavingsPlanOrderApiVersion);
            _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient = new SavingsPlanOrderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingBenefitsSavingsPlanOrderSavingsPlanOrderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a savings plan order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanOrderId"> Order ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> is null. </exception>
        public virtual async Task<Response<BillingBenefitsSavingsPlanOrderResource>> GetAsync(string savingsPlanOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderId, nameof(savingsPlanOrderId));

            using var scope = _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanOrderCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.GetAsync(savingsPlanOrderId, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingBenefitsSavingsPlanOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a savings plan order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanOrderId"> Order ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> is null. </exception>
        public virtual Response<BillingBenefitsSavingsPlanOrderResource> Get(string savingsPlanOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderId, nameof(savingsPlanOrderId));

            using var scope = _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanOrderCollection.Get");
            scope.Start();
            try
            {
                var response = _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.Get(savingsPlanOrderId, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingBenefitsSavingsPlanOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Savings plan orders.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrder_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingBenefitsSavingsPlanOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingBenefitsSavingsPlanOrderResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingBenefitsSavingsPlanOrderResource(Client, BillingBenefitsSavingsPlanOrderData.DeserializeBillingBenefitsSavingsPlanOrderData(e)), _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics, Pipeline, "BillingBenefitsSavingsPlanOrderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Savings plan orders.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrder_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingBenefitsSavingsPlanOrderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingBenefitsSavingsPlanOrderResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingBenefitsSavingsPlanOrderResource(Client, BillingBenefitsSavingsPlanOrderData.DeserializeBillingBenefitsSavingsPlanOrderData(e)), _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics, Pipeline, "BillingBenefitsSavingsPlanOrderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanOrderId"> Order ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string savingsPlanOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderId, nameof(savingsPlanOrderId));

            using var scope = _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.GetAsync(savingsPlanOrderId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanOrderId"> Order ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> is null. </exception>
        public virtual Response<bool> Exists(string savingsPlanOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderId, nameof(savingsPlanOrderId));

            using var scope = _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.Get(savingsPlanOrderId, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingBenefitsSavingsPlanOrderResource> IEnumerable<BillingBenefitsSavingsPlanOrderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BillingBenefitsSavingsPlanOrderResource> IAsyncEnumerable<BillingBenefitsSavingsPlanOrderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
