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
    /// A class representing a collection of <see cref="PrivateLinkServiceResource"/> and their operations.
    /// Each <see cref="PrivateLinkServiceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="PrivateLinkServiceCollection"/> instance call the GetPrivateLinkServices method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class PrivateLinkServiceCollection : ArmCollection, IEnumerable<PrivateLinkServiceResource>, IAsyncEnumerable<PrivateLinkServiceResource>
    {
        private readonly ClientDiagnostics _privateLinkServiceClientDiagnostics;
        private readonly PrivateLinkServicesRestOperations _privateLinkServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkServiceCollection"/> class for mocking. </summary>
        protected PrivateLinkServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateLinkServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateLinkServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PrivateLinkServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PrivateLinkServiceResource.ResourceType, out string privateLinkServiceApiVersion);
            _privateLinkServiceRestClient = new PrivateLinkServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateLinkServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an private link service in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="data"> Parameters supplied to the create or update private link service operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateLinkServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serviceName, PrivateLinkServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateLinkServiceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<PrivateLinkServiceResource>(new PrivateLinkServiceOperationSource(Client), _privateLinkServiceClientDiagnostics, Pipeline, _privateLinkServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an private link service in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="data"> Parameters supplied to the create or update private link service operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PrivateLinkServiceResource> CreateOrUpdate(WaitUntil waitUntil, string serviceName, PrivateLinkServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateLinkServiceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, serviceName, data, cancellationToken);
                var operation = new NetworkArmOperation<PrivateLinkServiceResource>(new PrivateLinkServiceOperationSource(Client), _privateLinkServiceClientDiagnostics, Pipeline, _privateLinkServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified private link service by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<PrivateLinkServiceResource>> GetAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateLinkServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateLinkServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private link service by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<PrivateLinkServiceResource> Get(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _privateLinkServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateLinkServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all private link services in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateLinkServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateLinkServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _privateLinkServiceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _privateLinkServiceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new PrivateLinkServiceResource(Client, PrivateLinkServiceData.DeserializePrivateLinkServiceData(e)), _privateLinkServiceClientDiagnostics, Pipeline, "PrivateLinkServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all private link services in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateLinkServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateLinkServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _privateLinkServiceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _privateLinkServiceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new PrivateLinkServiceResource(Client, PrivateLinkServiceData.DeserializePrivateLinkServiceData(e)), _privateLinkServiceClientDiagnostics, Pipeline, "PrivateLinkServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _privateLinkServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _privateLinkServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<NullableResponse<PrivateLinkServiceResource>> GetIfExistsAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _privateLinkServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PrivateLinkServiceResource>(response.GetRawResponse());
                return Response.FromValue(new PrivateLinkServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateLinkServices/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual NullableResponse<PrivateLinkServiceResource> GetIfExists(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _privateLinkServiceClientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateLinkServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PrivateLinkServiceResource>(response.GetRawResponse());
                return Response.FromValue(new PrivateLinkServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateLinkServiceResource> IEnumerable<PrivateLinkServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateLinkServiceResource> IAsyncEnumerable<PrivateLinkServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
