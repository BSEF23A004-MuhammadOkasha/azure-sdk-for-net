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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServiceObjective and their operations over its parent. </summary>
    public partial class ServiceObjectiveCollection : ArmCollection, IEnumerable<ServiceObjectiveResource>, IAsyncEnumerable<ServiceObjectiveResource>
    {
        private readonly ClientDiagnostics _serviceObjectiveClientDiagnostics;
        private readonly ServiceObjectivesRestOperations _serviceObjectiveRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceObjectiveCollection"/> class for mocking. </summary>
        protected ServiceObjectiveCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceObjectiveCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceObjectiveCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceObjectiveClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServiceObjectiveResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceObjectiveResource.ResourceType, out string serviceObjectiveApiVersion);
            _serviceObjectiveRestClient = new ServiceObjectivesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceObjectiveApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a database service objective.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}
        /// Operation Id: ServiceObjectives_Get
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual async Task<Response<ServiceObjectiveResource>> GetAsync(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceObjectiveRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceObjectiveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database service objective.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}
        /// Operation Id: ServiceObjectives_Get
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual Response<ServiceObjectiveResource> Get(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceObjectiveRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceObjectiveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns database service objectives.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives
        /// Operation Id: ServiceObjectives_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceObjectiveResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceObjectiveResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceObjectiveResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceObjectiveRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceObjectiveResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Returns database service objectives.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives
        /// Operation Id: ServiceObjectives_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceObjectiveResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceObjectiveResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServiceObjectiveResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceObjectiveRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceObjectiveResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}
        /// Operation Id: ServiceObjectives_Get
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serviceObjectiveName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}
        /// Operation Id: ServiceObjectives_Get
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(serviceObjectiveName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}
        /// Operation Id: ServiceObjectives_Get
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual async Task<Response<ServiceObjectiveResource>> GetIfExistsAsync(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceObjectiveRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServiceObjectiveResource>(null, response.GetRawResponse());
                return Response.FromValue(new ServiceObjectiveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/serviceObjectives/{serviceObjectiveName}
        /// Operation Id: ServiceObjectives_Get
        /// </summary>
        /// <param name="serviceObjectiveName"> The name of the service objective to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceObjectiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceObjectiveName"/> is null. </exception>
        public virtual Response<ServiceObjectiveResource> GetIfExists(string serviceObjectiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceObjectiveName, nameof(serviceObjectiveName));

            using var scope = _serviceObjectiveClientDiagnostics.CreateScope("ServiceObjectiveCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceObjectiveRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceObjectiveName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServiceObjectiveResource>(null, response.GetRawResponse());
                return Response.FromValue(new ServiceObjectiveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceObjectiveResource> IEnumerable<ServiceObjectiveResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceObjectiveResource> IAsyncEnumerable<ServiceObjectiveResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
