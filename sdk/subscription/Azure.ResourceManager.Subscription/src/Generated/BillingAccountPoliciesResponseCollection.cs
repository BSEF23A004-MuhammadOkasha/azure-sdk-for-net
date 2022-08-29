// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Subscription
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingAccountPoliciesResponseResource" /> and their operations.
    /// Each <see cref="BillingAccountPoliciesResponseResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="BillingAccountPoliciesResponseCollection" /> instance call the GetBillingAccountPoliciesResponses method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class BillingAccountPoliciesResponseCollection : ArmCollection
    {
        private readonly ClientDiagnostics _billingAccountPoliciesResponseBillingAccountClientDiagnostics;
        private readonly BillingAccountRestOperations _billingAccountPoliciesResponseBillingAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingAccountPoliciesResponseCollection"/> class for mocking. </summary>
        protected BillingAccountPoliciesResponseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingAccountPoliciesResponseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingAccountPoliciesResponseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingAccountPoliciesResponseBillingAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Subscription", BillingAccountPoliciesResponseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingAccountPoliciesResponseResource.ResourceType, out string billingAccountPoliciesResponseBillingAccountApiVersion);
            _billingAccountPoliciesResponseBillingAccountRestClient = new BillingAccountRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingAccountPoliciesResponseBillingAccountApiVersion);
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
        /// Get Billing Account Policy.
        /// Request Path: /providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default
        /// Operation Id: BillingAccount_GetPolicy
        /// </summary>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        public virtual async Task<Response<BillingAccountPoliciesResponseResource>> GetAsync(string billingAccountId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var scope = _billingAccountPoliciesResponseBillingAccountClientDiagnostics.CreateScope("BillingAccountPoliciesResponseCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingAccountPoliciesResponseBillingAccountRestClient.GetPolicyAsync(billingAccountId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPoliciesResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Billing Account Policy.
        /// Request Path: /providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default
        /// Operation Id: BillingAccount_GetPolicy
        /// </summary>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        public virtual Response<BillingAccountPoliciesResponseResource> Get(string billingAccountId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var scope = _billingAccountPoliciesResponseBillingAccountClientDiagnostics.CreateScope("BillingAccountPoliciesResponseCollection.Get");
            scope.Start();
            try
            {
                var response = _billingAccountPoliciesResponseBillingAccountRestClient.GetPolicy(billingAccountId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAccountPoliciesResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default
        /// Operation Id: BillingAccount_GetPolicy
        /// </summary>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string billingAccountId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var scope = _billingAccountPoliciesResponseBillingAccountClientDiagnostics.CreateScope("BillingAccountPoliciesResponseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingAccountPoliciesResponseBillingAccountRestClient.GetPolicyAsync(billingAccountId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default
        /// Operation Id: BillingAccount_GetPolicy
        /// </summary>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountId"/> is null. </exception>
        public virtual Response<bool> Exists(string billingAccountId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountId, nameof(billingAccountId));

            using var scope = _billingAccountPoliciesResponseBillingAccountClientDiagnostics.CreateScope("BillingAccountPoliciesResponseCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingAccountPoliciesResponseBillingAccountRestClient.GetPolicy(billingAccountId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
