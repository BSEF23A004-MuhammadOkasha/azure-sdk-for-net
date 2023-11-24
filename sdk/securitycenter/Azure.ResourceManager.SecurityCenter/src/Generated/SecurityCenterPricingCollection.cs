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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityCenterPricingResource"/> and their operations.
    /// Each <see cref="SecurityCenterPricingResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="SecurityCenterPricingCollection"/> instance call the GetSecurityCenterPricings method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class SecurityCenterPricingCollection : ArmCollection, IEnumerable<SecurityCenterPricingResource>, IAsyncEnumerable<SecurityCenterPricingResource>
    {
        private readonly ClientDiagnostics _securityCenterPricingPricingsClientDiagnostics;
        private readonly PricingsRestOperations _securityCenterPricingPricingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityCenterPricingCollection"/> class for mocking. </summary>
        protected SecurityCenterPricingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityCenterPricingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityCenterPricingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityCenterPricingPricingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecurityCenterPricingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityCenterPricingResource.ResourceType, out string securityCenterPricingPricingsApiVersion);
            _securityCenterPricingPricingsRestClient = new PricingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityCenterPricingPricingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="data"> Pricing object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityCenterPricingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string pricingName, SecurityCenterPricingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityCenterPricingPricingsRestClient.UpdateAsync(Id.SubscriptionId, pricingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SecurityCenterPricingResource>(Response.FromValue(new SecurityCenterPricingResource(Client, response), response.GetRawResponse()));
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
        /// Updates a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="data"> Pricing object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityCenterPricingResource> CreateOrUpdate(WaitUntil waitUntil, string pricingName, SecurityCenterPricingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityCenterPricingPricingsRestClient.Update(Id.SubscriptionId, pricingName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SecurityCenterPricingResource>(Response.FromValue(new SecurityCenterPricingResource(Client, response), response.GetRawResponse()));
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
        /// Gets a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> is null. </exception>
        public virtual async Task<Response<SecurityCenterPricingResource>> GetAsync(string pricingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));

            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityCenterPricingPricingsRestClient.GetAsync(Id.SubscriptionId, pricingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterPricingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> is null. </exception>
        public virtual Response<SecurityCenterPricingResource> Get(string pricingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));

            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingCollection.Get");
            scope.Start();
            try
            {
                var response = _securityCenterPricingPricingsRestClient.Get(Id.SubscriptionId, pricingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterPricingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Microsoft Defender for Cloud pricing configurations in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityCenterPricingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityCenterPricingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityCenterPricingPricingsRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new SecurityCenterPricingResource(Client, SecurityCenterPricingData.DeserializeSecurityCenterPricingData(e)), _securityCenterPricingPricingsClientDiagnostics, Pipeline, "SecurityCenterPricingCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists Microsoft Defender for Cloud pricing configurations in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityCenterPricingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityCenterPricingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityCenterPricingPricingsRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new SecurityCenterPricingResource(Client, SecurityCenterPricingData.DeserializeSecurityCenterPricingData(e)), _securityCenterPricingPricingsClientDiagnostics, Pipeline, "SecurityCenterPricingCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string pricingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));

            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityCenterPricingPricingsRestClient.GetAsync(Id.SubscriptionId, pricingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> is null. </exception>
        public virtual Response<bool> Exists(string pricingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));

            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityCenterPricingPricingsRestClient.Get(Id.SubscriptionId, pricingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityCenterPricingResource>> GetIfExistsAsync(string pricingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));

            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityCenterPricingPricingsRestClient.GetAsync(Id.SubscriptionId, pricingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityCenterPricingResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterPricingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pricingName"> name of the pricing configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="pricingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="pricingName"/> is null. </exception>
        public virtual NullableResponse<SecurityCenterPricingResource> GetIfExists(string pricingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(pricingName, nameof(pricingName));

            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityCenterPricingPricingsRestClient.Get(Id.SubscriptionId, pricingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityCenterPricingResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterPricingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityCenterPricingResource> IEnumerable<SecurityCenterPricingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityCenterPricingResource> IAsyncEnumerable<SecurityCenterPricingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
