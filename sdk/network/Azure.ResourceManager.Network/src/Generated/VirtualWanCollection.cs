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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualWan and their operations over its parent. </summary>
    public partial class VirtualWanCollection : ArmCollection, IEnumerable<VirtualWan>, IAsyncEnumerable<VirtualWan>
    {
        private readonly ClientDiagnostics _virtualWanClientDiagnostics;
        private readonly VirtualWansRestOperations _virtualWanRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualWanCollection"/> class for mocking. </summary>
        protected VirtualWanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualWanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualWanCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualWanClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualWan.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(VirtualWan.ResourceType, out string virtualWanApiVersion);
            _virtualWanRestClient = new VirtualWansRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualWanApiVersion);
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
        /// Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWanName}
        /// Operation Id: VirtualWans_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualWanName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wanParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> or <paramref name="wanParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualWan>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualWanName, VirtualWanData wanParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));
            Argument.AssertNotNull(wanParameters, nameof(wanParameters));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualWanRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, wanParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualWan>(new VirtualWanOperationSource(Client), _virtualWanClientDiagnostics, Pipeline, _virtualWanRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, wanParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWanName}
        /// Operation Id: VirtualWans_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualWanName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wanParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> or <paramref name="wanParameters"/> is null. </exception>
        public virtual ArmOperation<VirtualWan> CreateOrUpdate(WaitUntil waitUntil, string virtualWanName, VirtualWanData wanParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));
            Argument.AssertNotNull(wanParameters, nameof(wanParameters));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualWanRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, wanParameters, cancellationToken);
                var operation = new NetworkArmOperation<VirtualWan>(new VirtualWanOperationSource(Client), _virtualWanClientDiagnostics, Pipeline, _virtualWanRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, wanParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a VirtualWAN.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWanName}
        /// Operation Id: VirtualWans_Get
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual async Task<Response<VirtualWan>> GetAsync(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualWanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualWan(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a VirtualWAN.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWanName}
        /// Operation Id: VirtualWans_Get
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual Response<VirtualWan> Get(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualWanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualWan(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the VirtualWANs in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans
        /// Operation Id: VirtualWans_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualWan" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualWan> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualWan>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualWanRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWan(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualWan>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualWanRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWan(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the VirtualWANs in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans
        /// Operation Id: VirtualWans_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualWan" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualWan> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualWan> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualWanRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWan(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualWan> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualWanRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWan(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWanName}
        /// Operation Id: VirtualWans_Get
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualWanName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWanName}
        /// Operation Id: VirtualWans_Get
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualWanName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWanName}
        /// Operation Id: VirtualWans_Get
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual async Task<Response<VirtualWan>> GetIfExistsAsync(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualWanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualWan>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualWan(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWanName}
        /// Operation Id: VirtualWans_Get
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual Response<VirtualWan> GetIfExists(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualWanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualWan>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualWan(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualWan> IEnumerable<VirtualWan>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualWan> IAsyncEnumerable<VirtualWan>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
