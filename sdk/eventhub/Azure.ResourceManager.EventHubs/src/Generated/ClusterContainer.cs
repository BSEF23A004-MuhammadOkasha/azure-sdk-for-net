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
using Azure.ResourceManager.EventHub.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventHub
{
    /// <summary> A class representing collection of Cluster and their operations over a ResourceGroup. </summary>
    public partial class ClusterContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ClustersRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="ClusterContainer"/> class for mocking. </summary>
        protected ClusterContainer()
        {
        }

        /// <summary> Initializes a new instance of ClusterContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ClusterContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ClustersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates an instance of an Event Hubs Cluster. </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="parameters"> Parameters for creating a eventhub cluster resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ClusterCreateOrUpdateOperation CreateOrUpdate(string clusterName, ClusterData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ClusterContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, clusterName, parameters, cancellationToken);
                var operation = new ClusterCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, clusterName, parameters).Request, response);
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

        /// <summary> Creates or updates an instance of an Event Hubs Cluster. </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="parameters"> Parameters for creating a eventhub cluster resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ClusterCreateOrUpdateOperation> CreateOrUpdateAsync(string clusterName, ClusterData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (clusterName == null)
            {
                throw new ArgumentNullException(nameof(clusterName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ClusterContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, clusterName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ClusterCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, clusterName, parameters).Request, response);
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

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Cluster> Get(string clusterName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ClusterContainer.Get");
            scope.Start();
            try
            {
                if (clusterName == null)
                {
                    throw new ArgumentNullException(nameof(clusterName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Cluster(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Cluster>> GetAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ClusterContainer.Get");
            scope.Start();
            try
            {
                if (clusterName == null)
                {
                    throw new ArgumentNullException(nameof(clusterName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Cluster(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Cluster> GetIfExists(string clusterName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ClusterContainer.GetIfExists");
            scope.Start();
            try
            {
                if (clusterName == null)
                {
                    throw new ArgumentNullException(nameof(clusterName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Cluster>(null, response.GetRawResponse())
                    : Response.FromValue(new Cluster(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Cluster>> GetIfExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ClusterContainer.GetIfExists");
            scope.Start();
            try
            {
                if (clusterName == null)
                {
                    throw new ArgumentNullException(nameof(clusterName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Cluster>(null, response.GetRawResponse())
                    : Response.FromValue(new Cluster(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string clusterName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ClusterContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (clusterName == null)
                {
                    throw new ArgumentNullException(nameof(clusterName));
                }

                var response = GetIfExists(clusterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ClusterContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (clusterName == null)
                {
                    throw new ArgumentNullException(nameof(clusterName));
                }

                var response = await GetIfExistsAsync(clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the available Event Hubs Clusters within an ARM resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Cluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Cluster> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Cluster> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ClusterContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Cluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Cluster> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ClusterContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Cluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the available Event Hubs Clusters within an ARM resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Cluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Cluster> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Cluster>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ClusterContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Cluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Cluster>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ClusterContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Cluster(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Cluster" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ClusterContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Cluster.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Cluster" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ClusterContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Cluster.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, Cluster, ClusterData> Construct() { }
    }
}
