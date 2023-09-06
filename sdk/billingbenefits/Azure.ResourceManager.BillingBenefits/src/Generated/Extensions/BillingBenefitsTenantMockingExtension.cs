// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.BillingBenefits;
using Azure.ResourceManager.BillingBenefits.Models;

namespace Azure.ResourceManager.BillingBenefits.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class BillingBenefitsTenantMockingExtension : ArmResource
    {
        private ClientDiagnostics _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics;
        private SavingsPlanRestOperations _billingBenefitsSavingsPlanSavingsPlanRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private BillingBenefitsRPRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsTenantMockingExtension"/> class for mocking. </summary>
        protected BillingBenefitsTenantMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsTenantMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingBenefitsTenantMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics BillingBenefitsSavingsPlanSavingsPlanClientDiagnostics => _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.BillingBenefits", BillingBenefitsSavingsPlanResource.ResourceType.Namespace, Diagnostics);
        private SavingsPlanRestOperations BillingBenefitsSavingsPlanSavingsPlanRestClient => _billingBenefitsSavingsPlanSavingsPlanRestClient ??= new SavingsPlanRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(BillingBenefitsSavingsPlanResource.ResourceType));
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.BillingBenefits", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private BillingBenefitsRPRestOperations DefaultRestClient => _defaultRestClient ??= new BillingBenefitsRPRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of BillingBenefitsSavingsPlanOrderAliasResources in the TenantResource. </summary>
        /// <returns> An object representing collection of BillingBenefitsSavingsPlanOrderAliasResources and their operations over a BillingBenefitsSavingsPlanOrderAliasResource. </returns>
        public virtual BillingBenefitsSavingsPlanOrderAliasCollection GetBillingBenefitsSavingsPlanOrderAliases()
        {
            return GetCachedClient(Client => new BillingBenefitsSavingsPlanOrderAliasCollection(Client, Id));
        }

        /// <summary>
        /// Get a savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrderAliases/{savingsPlanOrderAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrderAlias_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanOrderAliasName"> Name of the savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderAliasName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BillingBenefitsSavingsPlanOrderAliasResource>> GetBillingBenefitsSavingsPlanOrderAliasAsync(string savingsPlanOrderAliasName, CancellationToken cancellationToken = default)
        {
            return await GetBillingBenefitsSavingsPlanOrderAliases().GetAsync(savingsPlanOrderAliasName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrderAliases/{savingsPlanOrderAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrderAlias_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanOrderAliasName"> Name of the savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderAliasName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<BillingBenefitsSavingsPlanOrderAliasResource> GetBillingBenefitsSavingsPlanOrderAlias(string savingsPlanOrderAliasName, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsSavingsPlanOrderAliases().Get(savingsPlanOrderAliasName, cancellationToken);
        }

        /// <summary> Gets a collection of BillingBenefitsSavingsPlanOrderResources in the TenantResource. </summary>
        /// <returns> An object representing collection of BillingBenefitsSavingsPlanOrderResources and their operations over a BillingBenefitsSavingsPlanOrderResource. </returns>
        public virtual BillingBenefitsSavingsPlanOrderCollection GetBillingBenefitsSavingsPlanOrders()
        {
            return GetCachedClient(Client => new BillingBenefitsSavingsPlanOrderCollection(Client, Id));
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
        [ForwardsClientCalls]
        public virtual async Task<Response<BillingBenefitsSavingsPlanOrderResource>> GetBillingBenefitsSavingsPlanOrderAsync(string savingsPlanOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetBillingBenefitsSavingsPlanOrders().GetAsync(savingsPlanOrderId, expand, cancellationToken).ConfigureAwait(false);
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
        [ForwardsClientCalls]
        public virtual Response<BillingBenefitsSavingsPlanOrderResource> GetBillingBenefitsSavingsPlanOrder(string savingsPlanOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsSavingsPlanOrders().Get(savingsPlanOrderId, expand, cancellationToken);
        }

        /// <summary> Gets a collection of BillingBenefitsReservationOrderAliasResources in the TenantResource. </summary>
        /// <returns> An object representing collection of BillingBenefitsReservationOrderAliasResources and their operations over a BillingBenefitsReservationOrderAliasResource. </returns>
        public virtual BillingBenefitsReservationOrderAliasCollection GetBillingBenefitsReservationOrderAliases()
        {
            return GetCachedClient(Client => new BillingBenefitsReservationOrderAliasCollection(Client, Id));
        }

        /// <summary>
        /// Get a reservation order alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/reservationOrderAliases/{reservationOrderAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrderAlias_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationOrderAliasName"> Name of the reservation order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderAliasName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BillingBenefitsReservationOrderAliasResource>> GetBillingBenefitsReservationOrderAliasAsync(string reservationOrderAliasName, CancellationToken cancellationToken = default)
        {
            return await GetBillingBenefitsReservationOrderAliases().GetAsync(reservationOrderAliasName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a reservation order alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/reservationOrderAliases/{reservationOrderAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrderAlias_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationOrderAliasName"> Name of the reservation order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderAliasName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<BillingBenefitsReservationOrderAliasResource> GetBillingBenefitsReservationOrderAlias(string reservationOrderAliasName, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsReservationOrderAliases().Get(reservationOrderAliasName, cancellationToken);
        }

        /// <summary>
        /// List savings plans.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingBenefitsSavingsPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingBenefitsSavingsPlanResource> GetBillingBenefitsSavingsPlansAsync(TenantResourceGetBillingBenefitsSavingsPlansOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new TenantResourceGetBillingBenefitsSavingsPlansOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => BillingBenefitsSavingsPlanSavingsPlanRestClient.CreateListAllRequest(options.Filter, options.OrderBy, options.RefreshSummary, options.SkipToken, options.SelectedState, options.Take);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => BillingBenefitsSavingsPlanSavingsPlanRestClient.CreateListAllNextPageRequest(nextLink, options.Filter, options.OrderBy, options.RefreshSummary, options.SkipToken, options.SelectedState, options.Take);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingBenefitsSavingsPlanResource(Client, BillingBenefitsSavingsPlanData.DeserializeBillingBenefitsSavingsPlanData(e)), BillingBenefitsSavingsPlanSavingsPlanClientDiagnostics, Pipeline, "BillingBenefitsTenantMockingExtension.GetBillingBenefitsSavingsPlans", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List savings plans.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingBenefitsSavingsPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingBenefitsSavingsPlanResource> GetBillingBenefitsSavingsPlans(TenantResourceGetBillingBenefitsSavingsPlansOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new TenantResourceGetBillingBenefitsSavingsPlansOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => BillingBenefitsSavingsPlanSavingsPlanRestClient.CreateListAllRequest(options.Filter, options.OrderBy, options.RefreshSummary, options.SkipToken, options.SelectedState, options.Take);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => BillingBenefitsSavingsPlanSavingsPlanRestClient.CreateListAllNextPageRequest(nextLink, options.Filter, options.OrderBy, options.RefreshSummary, options.SkipToken, options.SelectedState, options.Take);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingBenefitsSavingsPlanResource(Client, BillingBenefitsSavingsPlanData.DeserializeBillingBenefitsSavingsPlanData(e)), BillingBenefitsSavingsPlanSavingsPlanClientDiagnostics, Pipeline, "BillingBenefitsTenantMockingExtension.GetBillingBenefitsSavingsPlans", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Validate savings plan purchase.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ValidatePurchase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request body for validating the purchase of a savings plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="SavingsPlanValidateResult" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SavingsPlanValidateResult> ValidatePurchaseAsync(SavingsPlanPurchaseValidateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateValidatePurchaseRequest(content);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateValidatePurchaseNextPageRequest(nextLink, content);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SavingsPlanValidateResult.DeserializeSavingsPlanValidateResult, DefaultClientDiagnostics, Pipeline, "BillingBenefitsTenantMockingExtension.ValidatePurchase", "benefits", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Validate savings plan purchase.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ValidatePurchase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request body for validating the purchase of a savings plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="SavingsPlanValidateResult" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SavingsPlanValidateResult> ValidatePurchase(SavingsPlanPurchaseValidateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            HttpMessage FirstPageRequest(int? pageSizeHint) => DefaultRestClient.CreateValidatePurchaseRequest(content);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DefaultRestClient.CreateValidatePurchaseNextPageRequest(nextLink, content);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SavingsPlanValidateResult.DeserializeSavingsPlanValidateResult, DefaultClientDiagnostics, Pipeline, "BillingBenefitsTenantMockingExtension.ValidatePurchase", "benefits", "nextLink", cancellationToken);
        }
    }
}
