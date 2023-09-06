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

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerRegistryPrivateLinkResource" /> and their operations.
    /// Each <see cref="ContainerRegistryPrivateLinkResource" /> in the collection will belong to the same instance of <see cref="ContainerRegistryResource" />.
    /// To get a <see cref="ContainerRegistryPrivateLinkResourceCollection" /> instance call the GetContainerRegistryPrivateLinkResources method from an instance of <see cref="ContainerRegistryResource" />.
    /// </summary>
    public partial class ContainerRegistryPrivateLinkResourceCollection : ArmCollection, IEnumerable<ContainerRegistryPrivateLinkResource>, IAsyncEnumerable<ContainerRegistryPrivateLinkResource>
    {
        private readonly ClientDiagnostics _containerRegistryPrivateLinkResourceRegistriesClientDiagnostics;
        private readonly RegistriesRestOperations _containerRegistryPrivateLinkResourceRegistriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected ContainerRegistryPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerRegistryPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerRegistryPrivateLinkResourceRegistriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ContainerRegistryPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerRegistryPrivateLinkResource.ResourceType, out string containerRegistryPrivateLinkResourceRegistriesApiVersion);
            _containerRegistryPrivateLinkResourceRegistriesRestClient = new RegistriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryPrivateLinkResourceRegistriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a private link resource by a specified group name for a container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_GetPrivateLinkResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<ContainerRegistryPrivateLinkResource>> GetAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _containerRegistryPrivateLinkResourceRegistriesClientDiagnostics.CreateScope("ContainerRegistryPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryPrivateLinkResourceRegistriesRestClient.GetPrivateLinkResourceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private link resource by a specified group name for a container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_GetPrivateLinkResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<ContainerRegistryPrivateLinkResource> Get(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _containerRegistryPrivateLinkResourceRegistriesClientDiagnostics.CreateScope("ContainerRegistryPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryPrivateLinkResourceRegistriesRestClient.GetPrivateLinkResource(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the private link resources for a container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_ListPrivateLinkResources</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerRegistryPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryPrivateLinkResourceRegistriesRestClient.CreateListPrivateLinkResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryPrivateLinkResourceRegistriesRestClient.CreateListPrivateLinkResourcesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ContainerRegistryPrivateLinkResource(Client, ContainerRegistryPrivateLinkResourceData.DeserializeContainerRegistryPrivateLinkResourceData(e)), _containerRegistryPrivateLinkResourceRegistriesClientDiagnostics, Pipeline, "ContainerRegistryPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the private link resources for a container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_ListPrivateLinkResources</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerRegistryPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryPrivateLinkResourceRegistriesRestClient.CreateListPrivateLinkResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryPrivateLinkResourceRegistriesRestClient.CreateListPrivateLinkResourcesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ContainerRegistryPrivateLinkResource(Client, ContainerRegistryPrivateLinkResourceData.DeserializeContainerRegistryPrivateLinkResourceData(e)), _containerRegistryPrivateLinkResourceRegistriesClientDiagnostics, Pipeline, "ContainerRegistryPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_GetPrivateLinkResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _containerRegistryPrivateLinkResourceRegistriesClientDiagnostics.CreateScope("ContainerRegistryPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerRegistryPrivateLinkResourceRegistriesRestClient.GetPrivateLinkResourceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_GetPrivateLinkResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<bool> Exists(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _containerRegistryPrivateLinkResourceRegistriesClientDiagnostics.CreateScope("ContainerRegistryPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerRegistryPrivateLinkResourceRegistriesRestClient.GetPrivateLinkResource(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerRegistryPrivateLinkResource> IEnumerable<ContainerRegistryPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerRegistryPrivateLinkResource> IAsyncEnumerable<ContainerRegistryPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
