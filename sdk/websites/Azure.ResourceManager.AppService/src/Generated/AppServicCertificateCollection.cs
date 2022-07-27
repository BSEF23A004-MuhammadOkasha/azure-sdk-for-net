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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="AppServicCertificateResource" /> and their operations.
    /// Each <see cref="AppServicCertificateResource" /> in the collection will belong to the same instance of <see cref="AppServiceCertificateOrderResource" />.
    /// To get an <see cref="AppServicCertificateCollection" /> instance call the GetAppServicCertificates method from an instance of <see cref="AppServiceCertificateOrderResource" />.
    /// </summary>
    public partial class AppServicCertificateCollection : ArmCollection, IEnumerable<AppServicCertificateResource>, IAsyncEnumerable<AppServicCertificateResource>
    {
        private readonly ClientDiagnostics _appServicCertificateAppServiceCertificateOrdersClientDiagnostics;
        private readonly AppServiceCertificateOrdersRestOperations _appServicCertificateAppServiceCertificateOrdersRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServicCertificateCollection"/> class for mocking. </summary>
        protected AppServicCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServicCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppServicCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServicCertificateAppServiceCertificateOrdersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppServicCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppServicCertificateResource.ResourceType, out string appServicCertificateAppServiceCertificateOrdersApiVersion);
            _appServicCertificateAppServiceCertificateOrdersRestClient = new AppServiceCertificateOrdersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appServicCertificateAppServiceCertificateOrdersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceCertificateOrderResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceCertificateOrderResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates or updates a certificate and associates with key vault secret.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}
        /// Operation Id: AppServiceCertificateOrders_CreateOrUpdateCertificate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="data"> Key vault certificate resource Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppServicCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, AppServicCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServicCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServicCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServicCertificateAppServiceCertificateOrdersRestClient.CreateOrUpdateCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<AppServicCertificateResource>(new AppServicCertificateOperationSource(Client), _appServicCertificateAppServiceCertificateOrdersClientDiagnostics, Pipeline, _appServicCertificateAppServiceCertificateOrdersRestClient.CreateCreateOrUpdateCertificateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Creates or updates a certificate and associates with key vault secret.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}
        /// Operation Id: AppServiceCertificateOrders_CreateOrUpdateCertificate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="data"> Key vault certificate resource Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppServicCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string name, AppServicCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServicCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServicCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServicCertificateAppServiceCertificateOrdersRestClient.CreateOrUpdateCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new AppServiceArmOperation<AppServicCertificateResource>(new AppServicCertificateOperationSource(Client), _appServicCertificateAppServiceCertificateOrdersClientDiagnostics, Pipeline, _appServicCertificateAppServiceCertificateOrdersRestClient.CreateCreateOrUpdateCertificateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get the certificate associated with a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}
        /// Operation Id: AppServiceCertificateOrders_GetCertificate
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<AppServicCertificateResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServicCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServicCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServicCertificateAppServiceCertificateOrdersRestClient.GetCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServicCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the certificate associated with a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}
        /// Operation Id: AppServiceCertificateOrders_GetCertificate
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AppServicCertificateResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServicCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServicCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _appServicCertificateAppServiceCertificateOrdersRestClient.GetCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServicCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List all certificates associated with a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates
        /// Operation Id: AppServiceCertificateOrders_ListCertificates
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServicCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServicCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AppServicCertificateResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appServicCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServicCertificateAppServiceCertificateOrdersRestClient.ListCertificatesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServicCertificateResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppServicCertificateResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appServicCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServicCertificateAppServiceCertificateOrdersRestClient.ListCertificatesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServicCertificateResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for List all certificates associated with a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates
        /// Operation Id: AppServiceCertificateOrders_ListCertificates
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServicCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServicCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AppServicCertificateResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appServicCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServicCertificateAppServiceCertificateOrdersRestClient.ListCertificates(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServicCertificateResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppServicCertificateResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appServicCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServicCertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServicCertificateAppServiceCertificateOrdersRestClient.ListCertificatesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServicCertificateResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}
        /// Operation Id: AppServiceCertificateOrders_GetCertificate
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServicCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServicCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appServicCertificateAppServiceCertificateOrdersRestClient.GetCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}
        /// Operation Id: AppServiceCertificateOrders_GetCertificate
        /// </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServicCertificateAppServiceCertificateOrdersClientDiagnostics.CreateScope("AppServicCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _appServicCertificateAppServiceCertificateOrdersRestClient.GetCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServicCertificateResource> IEnumerable<AppServicCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServicCertificateResource> IAsyncEnumerable<AppServicCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
