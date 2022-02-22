// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    internal partial class TenantExtensionClient : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private CdnManagementRestOperations _defaultRestClient;
        private ClientDiagnostics _edgeNodesClientDiagnostics;
        private EdgeNodesRestOperations _edgeNodesRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantExtensionClient"/> class for mocking. </summary>
        protected TenantExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private CdnManagementRestOperations DefaultRestClient => _defaultRestClient ??= new CdnManagementRestOperations(DefaultClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics EdgeNodesClientDiagnostics => _edgeNodesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private EdgeNodesRestOperations EdgeNodesRestClient => _edgeNodesRestClient ??= new EdgeNodesRestOperations(EdgeNodesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint.
        /// Request Path: /providers/Microsoft.Cdn/checkNameAvailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<CheckNameAvailabilityOutput>> CheckCdnNameAvailabilityAsync(CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("TenantExtensionClient.CheckCdnNameAvailability");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckNameAvailabilityAsync(checkNameAvailabilityInput, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint.
        /// Request Path: /providers/Microsoft.Cdn/checkNameAvailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityOutput> CheckCdnNameAvailability(CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("TenantExtensionClient.CheckCdnNameAvailability");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckNameAvailability(checkNameAvailabilityInput, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Edgenodes are the global Point of Presence (POP) locations used to deliver CDN content to end users.
        /// Request Path: /providers/Microsoft.Cdn/edgenodes
        /// Operation Id: EdgeNodes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EdgeNode" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EdgeNode> GetEdgeNodesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EdgeNode>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = EdgeNodesClientDiagnostics.CreateScope("TenantExtensionClient.GetEdgeNodes");
                scope.Start();
                try
                {
                    var response = await EdgeNodesRestClient.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EdgeNode>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = EdgeNodesClientDiagnostics.CreateScope("TenantExtensionClient.GetEdgeNodes");
                scope.Start();
                try
                {
                    var response = await EdgeNodesRestClient.ListNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Edgenodes are the global Point of Presence (POP) locations used to deliver CDN content to end users.
        /// Request Path: /providers/Microsoft.Cdn/edgenodes
        /// Operation Id: EdgeNodes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EdgeNode" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EdgeNode> GetEdgeNodes(CancellationToken cancellationToken = default)
        {
            Page<EdgeNode> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = EdgeNodesClientDiagnostics.CreateScope("TenantExtensionClient.GetEdgeNodes");
                scope.Start();
                try
                {
                    var response = EdgeNodesRestClient.List(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EdgeNode> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = EdgeNodesClientDiagnostics.CreateScope("TenantExtensionClient.GetEdgeNodes");
                scope.Start();
                try
                {
                    var response = EdgeNodesRestClient.ListNextPage(nextLink, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
