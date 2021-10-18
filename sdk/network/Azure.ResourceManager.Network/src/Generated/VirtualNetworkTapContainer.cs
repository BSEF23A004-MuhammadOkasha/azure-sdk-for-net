// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualNetworkTap and their operations over its parent. </summary>
    public partial class VirtualNetworkTapContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualNetworkTapsRestOperations _virtualNetworkTapsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkTapContainer"/> class for mocking. </summary>
        protected VirtualNetworkTapContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkTapContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkTapContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualNetworkTapsRestClient = new VirtualNetworkTapsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a Virtual Network Tap. </summary>
        /// <param name="tapName"> The name of the virtual network tap. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network tap operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualNetworkTapCreateOrUpdateOperation CreateOrUpdate(string tapName, VirtualNetworkTapData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkTapsRestClient.CreateOrUpdate(Id.ResourceGroupName, tapName, parameters, cancellationToken);
                var operation = new VirtualNetworkTapCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualNetworkTapsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, tapName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Virtual Network Tap. </summary>
        /// <param name="tapName"> The name of the virtual network tap. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network tap operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkTapCreateOrUpdateOperation> CreateOrUpdateAsync(string tapName, VirtualNetworkTapData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkTapsRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, tapName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkTapCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualNetworkTapsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, tapName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified virtual network tap. </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> is null. </exception>
        public virtual Response<VirtualNetworkTap> Get(string tapName, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkTapsRestClient.Get(Id.ResourceGroupName, tapName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkTap(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified virtual network tap. </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkTap>> GetAsync(string tapName, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkTapsRestClient.GetAsync(Id.ResourceGroupName, tapName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkTap(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> is null. </exception>
        public virtual Response<VirtualNetworkTap> GetIfExists(string tapName, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkTapsRestClient.Get(Id.ResourceGroupName, tapName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkTap>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkTap(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkTap>> GetIfExistsAsync(string tapName, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _virtualNetworkTapsRestClient.GetAsync(Id.ResourceGroupName, tapName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkTap>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkTap(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string tapName, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(tapName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string tapName, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tapName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the VirtualNetworkTaps in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkTap" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkTap> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkTap> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkTapsRestClient.GetAllByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkTap(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkTap> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkTapsRestClient.GetAllByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkTap(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the VirtualNetworkTaps in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkTap" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkTap> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkTap>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkTapsRestClient.GetAllByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkTap(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkTap>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkTapsRestClient.GetAllByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkTap(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkTap" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkTap.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkTap" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkTap.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, VirtualNetworkTap, VirtualNetworkTapData> Construct() { }
    }
}
