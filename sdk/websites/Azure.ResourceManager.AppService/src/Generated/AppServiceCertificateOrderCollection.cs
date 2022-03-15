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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of AppServiceCertificateOrder and their operations over its parent. </summary>
    public partial class AppServiceCertificateOrderCollection : ArmCollection, IEnumerable<AppServiceCertificateOrder>, IAsyncEnumerable<AppServiceCertificateOrder>
    {
        private readonly ClientDiagnostics _appServiceCertificateOrderClientDiagnostics;
        private readonly AppServiceCertificateOrdersRestOperations _appServiceCertificateOrderRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceCertificateOrderCollection"/> class for mocking. </summary>
        protected AppServiceCertificateOrderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceCertificateOrderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppServiceCertificateOrderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServiceCertificateOrderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppServiceCertificateOrder.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(AppServiceCertificateOrder.ResourceType, out string appServiceCertificateOrderApiVersion);
            _appServiceCertificateOrderRestClient = new AppServiceCertificateOrdersRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, appServiceCertificateOrderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Create or update a certificate purchase order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// Operation Id: AppServiceCertificateOrders_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateOrderName"> Name of the certificate order. </param>
        /// <param name="certificateDistinguishedName"> Distinguished name to use for the certificate order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> or <paramref name="certificateDistinguishedName"/> is null. </exception>
        public virtual async Task<ArmOperation<AppServiceCertificateOrder>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateOrderName, AppServiceCertificateOrderData certificateDistinguishedName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));
            Argument.AssertNotNull(certificateDistinguishedName, nameof(certificateDistinguishedName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrderRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, certificateDistinguishedName, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<AppServiceCertificateOrder>(new AppServiceCertificateOrderOperationSource(Client), _appServiceCertificateOrderClientDiagnostics, Pipeline, _appServiceCertificateOrderRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, certificateDistinguishedName).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Create or update a certificate purchase order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// Operation Id: AppServiceCertificateOrders_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateOrderName"> Name of the certificate order. </param>
        /// <param name="certificateDistinguishedName"> Distinguished name to use for the certificate order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> or <paramref name="certificateDistinguishedName"/> is null. </exception>
        public virtual ArmOperation<AppServiceCertificateOrder> CreateOrUpdate(WaitUntil waitUntil, string certificateOrderName, AppServiceCertificateOrderData certificateDistinguishedName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));
            Argument.AssertNotNull(certificateDistinguishedName, nameof(certificateDistinguishedName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrderRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, certificateDistinguishedName, cancellationToken);
                var operation = new AppServiceArmOperation<AppServiceCertificateOrder>(new AppServiceCertificateOrderOperationSource(Client), _appServiceCertificateOrderClientDiagnostics, Pipeline, _appServiceCertificateOrderRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, certificateDistinguishedName).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// Operation Id: AppServiceCertificateOrders_Get
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual async Task<Response<AppServiceCertificateOrder>> GetAsync(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceCertificateOrder(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// Operation Id: AppServiceCertificateOrders_Get
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual Response<AppServiceCertificateOrder> Get(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceCertificateOrder(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get certificate orders in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders
        /// Operation Id: AppServiceCertificateOrders_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceCertificateOrder" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceCertificateOrder> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AppServiceCertificateOrder>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceCertificateOrderRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateOrder(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppServiceCertificateOrder>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceCertificateOrderRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateOrder(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get certificate orders in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders
        /// Operation Id: AppServiceCertificateOrders_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceCertificateOrder" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceCertificateOrder> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AppServiceCertificateOrder> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceCertificateOrderRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateOrder(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppServiceCertificateOrder> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceCertificateOrderRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateOrder(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// Operation Id: AppServiceCertificateOrders_Get
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(certificateOrderName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// Operation Id: AppServiceCertificateOrders_Get
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(certificateOrderName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// Operation Id: AppServiceCertificateOrders_Get
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual async Task<Response<AppServiceCertificateOrder>> GetIfExistsAsync(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AppServiceCertificateOrder>(null, response.GetRawResponse());
                return Response.FromValue(new AppServiceCertificateOrder(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// Operation Id: AppServiceCertificateOrders_Get
        /// </summary>
        /// <param name="certificateOrderName"> Name of the certificate order.. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateOrderName"/> is null. </exception>
        public virtual Response<AppServiceCertificateOrder> GetIfExists(string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var scope = _appServiceCertificateOrderClientDiagnostics.CreateScope("AppServiceCertificateOrderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, certificateOrderName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AppServiceCertificateOrder>(null, response.GetRawResponse());
                return Response.FromValue(new AppServiceCertificateOrder(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceCertificateOrder> IEnumerable<AppServiceCertificateOrder>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceCertificateOrder> IAsyncEnumerable<AppServiceCertificateOrder>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
