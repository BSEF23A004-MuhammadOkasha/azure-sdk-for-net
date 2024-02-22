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

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing a collection of <see cref="NestedResourceTypeSecondSkuResource"/> and their operations.
    /// Each <see cref="NestedResourceTypeSecondSkuResource"/> in the collection will belong to the same instance of <see cref="ResourceTypeRegistrationResource"/>.
    /// To get a <see cref="NestedResourceTypeSecondSkuCollection"/> instance call the GetNestedResourceTypeSecondSkus method from an instance of <see cref="ResourceTypeRegistrationResource"/>.
    /// </summary>
    public partial class NestedResourceTypeSecondSkuCollection : ArmCollection, IEnumerable<NestedResourceTypeSecondSkuResource>, IAsyncEnumerable<NestedResourceTypeSecondSkuResource>
    {
        private readonly ClientDiagnostics _nestedResourceTypeSecondSkuSkusClientDiagnostics;
        private readonly SkusRestOperations _nestedResourceTypeSecondSkuSkusRestClient;
        private readonly string _nestedResourceTypeFirst;
        private readonly string _nestedResourceTypeSecond;

        /// <summary> Initializes a new instance of the <see cref="NestedResourceTypeSecondSkuCollection"/> class for mocking. </summary>
        protected NestedResourceTypeSecondSkuCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NestedResourceTypeSecondSkuCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="nestedResourceTypeFirst"> The first child resource type. </param>
        /// <param name="nestedResourceTypeSecond"> The second child resource type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nestedResourceTypeFirst"/> or <paramref name="nestedResourceTypeSecond"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="nestedResourceTypeFirst"/> or <paramref name="nestedResourceTypeSecond"/> is an empty string, and was expected to be non-empty. </exception>
        internal NestedResourceTypeSecondSkuCollection(ArmClient client, ResourceIdentifier id, string nestedResourceTypeFirst, string nestedResourceTypeSecond) : base(client, id)
        {
            _nestedResourceTypeFirst = nestedResourceTypeFirst;
            _nestedResourceTypeSecond = nestedResourceTypeSecond;
            _nestedResourceTypeSecondSkuSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", NestedResourceTypeSecondSkuResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NestedResourceTypeSecondSkuResource.ResourceType, out string nestedResourceTypeSecondSkuSkusApiVersion);
            _nestedResourceTypeSecondSkuSkusRestClient = new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, nestedResourceTypeSecondSkuSkusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceTypeRegistrationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceTypeRegistrationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the resource type skus in the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_CreateOrUpdateNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NestedResourceTypeSecondSkuResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sku, ResourceTypeSkuData data, CancellationToken cancellationToken = default)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }
            if (sku.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sku));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _nestedResourceTypeSecondSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeSecondSkuCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeSecondSkuSkusRestClient.CreateOrUpdateNestedResourceTypeSecondAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, sku, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<NestedResourceTypeSecondSkuResource>(Response.FromValue(new NestedResourceTypeSecondSkuResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the resource type skus in the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_CreateOrUpdateNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="data"> The required body parameters supplied to the resource sku operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NestedResourceTypeSecondSkuResource> CreateOrUpdate(WaitUntil waitUntil, string sku, ResourceTypeSkuData data, CancellationToken cancellationToken = default)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }
            if (sku.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sku));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _nestedResourceTypeSecondSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeSecondSkuCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeSecondSkuSkusRestClient.CreateOrUpdateNestedResourceTypeSecond(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, sku, data, cancellationToken);
                var operation = new ProviderHubArmOperation<NestedResourceTypeSecondSkuResource>(Response.FromValue(new NestedResourceTypeSecondSkuResource(Client, response), response.GetRawResponse()));
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
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<Response<NestedResourceTypeSecondSkuResource>> GetAsync(string sku, CancellationToken cancellationToken = default)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }
            if (sku.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sku));
            }

            using var scope = _nestedResourceTypeSecondSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeSecondSkuCollection.Get");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeSecondSkuSkusRestClient.GetNestedResourceTypeSecondAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, sku, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeSecondSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual Response<NestedResourceTypeSecondSkuResource> Get(string sku, CancellationToken cancellationToken = default)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }
            if (sku.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sku));
            }

            using var scope = _nestedResourceTypeSecondSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeSecondSkuCollection.Get");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeSecondSkuSkusRestClient.GetNestedResourceTypeSecond(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, sku, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeSecondSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_ListByResourceTypeRegistrationsNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NestedResourceTypeSecondSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NestedResourceTypeSecondSkuResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _nestedResourceTypeSecondSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeSecondRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _nestedResourceTypeSecondSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeSecondNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NestedResourceTypeSecondSkuResource(Client, ResourceTypeSkuData.DeserializeResourceTypeSkuData(e)), _nestedResourceTypeSecondSkuSkusClientDiagnostics, Pipeline, "NestedResourceTypeSecondSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_ListByResourceTypeRegistrationsNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NestedResourceTypeSecondSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NestedResourceTypeSecondSkuResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _nestedResourceTypeSecondSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeSecondRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _nestedResourceTypeSecondSkuSkusRestClient.CreateListByResourceTypeRegistrationsNestedResourceTypeSecondNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NestedResourceTypeSecondSkuResource(Client, ResourceTypeSkuData.DeserializeResourceTypeSkuData(e)), _nestedResourceTypeSecondSkuSkusClientDiagnostics, Pipeline, "NestedResourceTypeSecondSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sku, CancellationToken cancellationToken = default)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }
            if (sku.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sku));
            }

            using var scope = _nestedResourceTypeSecondSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeSecondSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeSecondSkuSkusRestClient.GetNestedResourceTypeSecondAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, sku, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual Response<bool> Exists(string sku, CancellationToken cancellationToken = default)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }
            if (sku.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sku));
            }

            using var scope = _nestedResourceTypeSecondSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeSecondSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeSecondSkuSkusRestClient.GetNestedResourceTypeSecond(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, sku, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual async Task<NullableResponse<NestedResourceTypeSecondSkuResource>> GetIfExistsAsync(string sku, CancellationToken cancellationToken = default)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }
            if (sku.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sku));
            }

            using var scope = _nestedResourceTypeSecondSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeSecondSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _nestedResourceTypeSecondSkuSkusRestClient.GetNestedResourceTypeSecondAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, sku, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NestedResourceTypeSecondSkuResource>(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeSecondSkuResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}/resourcetypeRegistrations/{nestedResourceTypeFirst}/resourcetypeRegistrations/{nestedResourceTypeSecond}/skus/{sku}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_GetNestedResourceTypeSecond</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-20</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NestedResourceTypeSecondSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sku"> The SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sku"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public virtual NullableResponse<NestedResourceTypeSecondSkuResource> GetIfExists(string sku, CancellationToken cancellationToken = default)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }
            if (sku.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sku));
            }

            using var scope = _nestedResourceTypeSecondSkuSkusClientDiagnostics.CreateScope("NestedResourceTypeSecondSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _nestedResourceTypeSecondSkuSkusRestClient.GetNestedResourceTypeSecond(Id.SubscriptionId, Id.Parent.Name, Id.Name, _nestedResourceTypeFirst, _nestedResourceTypeSecond, sku, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NestedResourceTypeSecondSkuResource>(response.GetRawResponse());
                return Response.FromValue(new NestedResourceTypeSecondSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NestedResourceTypeSecondSkuResource> IEnumerable<NestedResourceTypeSecondSkuResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NestedResourceTypeSecondSkuResource> IAsyncEnumerable<NestedResourceTypeSecondSkuResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
