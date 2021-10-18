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
    /// <summary> A class representing collection of IpAllocation and their operations over its parent. </summary>
    public partial class IpAllocationContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly IpAllocationsRestOperations _ipAllocationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="IpAllocationContainer"/> class for mocking. </summary>
        protected IpAllocationContainer()
        {
        }

        /// <summary> Initializes a new instance of IpAllocationContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal IpAllocationContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _ipAllocationsRestClient = new IpAllocationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates an IpAllocation in the specified resource group. </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual IpAllocationCreateOrUpdateOperation CreateOrUpdate(string ipAllocationName, IpAllocationData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ipAllocationName == null)
            {
                throw new ArgumentNullException(nameof(ipAllocationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ipAllocationsRestClient.CreateOrUpdate(Id.ResourceGroupName, ipAllocationName, parameters, cancellationToken);
                var operation = new IpAllocationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _ipAllocationsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, ipAllocationName, parameters).Request, response);
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

        /// <summary> Creates or updates an IpAllocation in the specified resource group. </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<IpAllocationCreateOrUpdateOperation> CreateOrUpdateAsync(string ipAllocationName, IpAllocationData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ipAllocationName == null)
            {
                throw new ArgumentNullException(nameof(ipAllocationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ipAllocationsRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, ipAllocationName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new IpAllocationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _ipAllocationsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, ipAllocationName, parameters).Request, response);
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

        /// <summary> Gets the specified IpAllocation by resource group. </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual Response<IpAllocation> Get(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipAllocationName == null)
            {
                throw new ArgumentNullException(nameof(ipAllocationName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.Get");
            scope.Start();
            try
            {
                var response = _ipAllocationsRestClient.Get(Id.ResourceGroupName, ipAllocationName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IpAllocation(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified IpAllocation by resource group. </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public async virtual Task<Response<IpAllocation>> GetAsync(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipAllocationName == null)
            {
                throw new ArgumentNullException(nameof(ipAllocationName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.Get");
            scope.Start();
            try
            {
                var response = await _ipAllocationsRestClient.GetAsync(Id.ResourceGroupName, ipAllocationName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new IpAllocation(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual Response<IpAllocation> GetIfExists(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipAllocationName == null)
            {
                throw new ArgumentNullException(nameof(ipAllocationName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _ipAllocationsRestClient.Get(Id.ResourceGroupName, ipAllocationName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<IpAllocation>(null, response.GetRawResponse())
                    : Response.FromValue(new IpAllocation(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public async virtual Task<Response<IpAllocation>> GetIfExistsAsync(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipAllocationName == null)
            {
                throw new ArgumentNullException(nameof(ipAllocationName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _ipAllocationsRestClient.GetAsync(Id.ResourceGroupName, ipAllocationName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<IpAllocation>(null, response.GetRawResponse())
                    : Response.FromValue(new IpAllocation(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipAllocationName == null)
            {
                throw new ArgumentNullException(nameof(ipAllocationName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(ipAllocationName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipAllocationName"> The name of the IpAllocation. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAllocationName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string ipAllocationName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipAllocationName == null)
            {
                throw new ArgumentNullException(nameof(ipAllocationName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ipAllocationName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all IpAllocations in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IpAllocation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IpAllocation> GetAll(CancellationToken cancellationToken = default)
        {
            Page<IpAllocation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _ipAllocationsRestClient.GetAllByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IpAllocation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IpAllocation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _ipAllocationsRestClient.GetAllByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IpAllocation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all IpAllocations in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IpAllocation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IpAllocation> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<IpAllocation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _ipAllocationsRestClient.GetAllByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IpAllocation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IpAllocation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _ipAllocationsRestClient.GetAllByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IpAllocation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="IpAllocation" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(IpAllocation.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="IpAllocation" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpAllocationContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(IpAllocation.ResourceType);
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
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, IpAllocation, IpAllocationData> Construct() { }
    }
}
