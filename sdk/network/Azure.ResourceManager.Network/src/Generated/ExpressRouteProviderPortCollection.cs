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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRouteProviderPortResource"/> and their operations.
    /// Each <see cref="ExpressRouteProviderPortResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get an <see cref="ExpressRouteProviderPortCollection"/> instance call the GetExpressRouteProviderPorts method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class ExpressRouteProviderPortCollection : ArmCollection, IEnumerable<ExpressRouteProviderPortResource>, IAsyncEnumerable<ExpressRouteProviderPortResource>
    {
        private readonly ClientDiagnostics _expressRouteProviderPortClientDiagnostics;
        private readonly NetworkManagementRestOperations _expressRouteProviderPortRestClient;
        private readonly ClientDiagnostics _expressRouteProviderPortExpressRouteProviderPortsLocationClientDiagnostics;
        private readonly ExpressRouteProviderPortsLocationRestOperations _expressRouteProviderPortExpressRouteProviderPortsLocationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteProviderPortCollection"/> class for mocking. </summary>
        protected ExpressRouteProviderPortCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteProviderPortCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteProviderPortCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteProviderPortClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteProviderPortResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteProviderPortResource.ResourceType, out string expressRouteProviderPortApiVersion);
            _expressRouteProviderPortRestClient = new NetworkManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteProviderPortApiVersion);
            _expressRouteProviderPortExpressRouteProviderPortsLocationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteProviderPortResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteProviderPortResource.ResourceType, out string expressRouteProviderPortExpressRouteProviderPortsLocationApiVersion);
            _expressRouteProviderPortExpressRouteProviderPortsLocationRestClient = new ExpressRouteProviderPortsLocationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteProviderPortExpressRouteProviderPortsLocationApiVersion);
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
        /// Retrieves detail of a provider port.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts/{providerport}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteProviderPort</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerport"> The name of the provider port. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerport"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerport"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteProviderPortResource>> GetAsync(string providerport, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerport, nameof(providerport));

            using var scope = _expressRouteProviderPortClientDiagnostics.CreateScope("ExpressRouteProviderPortCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteProviderPortRestClient.ExpressRouteProviderPortAsync(Id.SubscriptionId, providerport, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteProviderPortResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves detail of a provider port.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts/{providerport}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteProviderPort</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerport"> The name of the provider port. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerport"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerport"/> is null. </exception>
        public virtual Response<ExpressRouteProviderPortResource> Get(string providerport, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerport, nameof(providerport));

            using var scope = _expressRouteProviderPortClientDiagnostics.CreateScope("ExpressRouteProviderPortCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteProviderPortRestClient.ExpressRouteProviderPort(Id.SubscriptionId, providerport, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteProviderPortResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves all the ExpressRouteProviderPorts in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteProviderPortsLocation_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=location eq '{state}'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteProviderPortResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteProviderPortResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteProviderPortExpressRouteProviderPortsLocationRestClient.CreateListRequest(Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new ExpressRouteProviderPortResource(Client, ExpressRouteProviderPortData.DeserializeExpressRouteProviderPortData(e)), _expressRouteProviderPortExpressRouteProviderPortsLocationClientDiagnostics, Pipeline, "ExpressRouteProviderPortCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieves all the ExpressRouteProviderPorts in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteProviderPortsLocation_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=location eq '{state}'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteProviderPortResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteProviderPortResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteProviderPortExpressRouteProviderPortsLocationRestClient.CreateListRequest(Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new ExpressRouteProviderPortResource(Client, ExpressRouteProviderPortData.DeserializeExpressRouteProviderPortData(e)), _expressRouteProviderPortExpressRouteProviderPortsLocationClientDiagnostics, Pipeline, "ExpressRouteProviderPortCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts/{providerport}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteProviderPort</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerport"> The name of the provider port. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerport"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerport"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string providerport, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerport, nameof(providerport));

            using var scope = _expressRouteProviderPortClientDiagnostics.CreateScope("ExpressRouteProviderPortCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRouteProviderPortRestClient.ExpressRouteProviderPortAsync(Id.SubscriptionId, providerport, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts/{providerport}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteProviderPort</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerport"> The name of the provider port. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerport"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerport"/> is null. </exception>
        public virtual Response<bool> Exists(string providerport, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerport, nameof(providerport));

            using var scope = _expressRouteProviderPortClientDiagnostics.CreateScope("ExpressRouteProviderPortCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRouteProviderPortRestClient.ExpressRouteProviderPort(Id.SubscriptionId, providerport, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts/{providerport}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteProviderPort</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerport"> The name of the provider port. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerport"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerport"/> is null. </exception>
        public virtual async Task<NullableResponse<ExpressRouteProviderPortResource>> GetIfExistsAsync(string providerport, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerport, nameof(providerport));

            using var scope = _expressRouteProviderPortClientDiagnostics.CreateScope("ExpressRouteProviderPortCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteProviderPortRestClient.ExpressRouteProviderPortAsync(Id.SubscriptionId, providerport, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteProviderPortResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteProviderPortResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts/{providerport}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteProviderPort</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerport"> The name of the provider port. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerport"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerport"/> is null. </exception>
        public virtual NullableResponse<ExpressRouteProviderPortResource> GetIfExists(string providerport, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerport, nameof(providerport));

            using var scope = _expressRouteProviderPortClientDiagnostics.CreateScope("ExpressRouteProviderPortCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteProviderPortRestClient.ExpressRouteProviderPort(Id.SubscriptionId, providerport, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ExpressRouteProviderPortResource>(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteProviderPortResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteProviderPortResource> IEnumerable<ExpressRouteProviderPortResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteProviderPortResource> IAsyncEnumerable<ExpressRouteProviderPortResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
