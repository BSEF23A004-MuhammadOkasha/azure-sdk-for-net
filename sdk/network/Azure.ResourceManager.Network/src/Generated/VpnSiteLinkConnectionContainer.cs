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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VpnSiteLinkConnection and their operations over its parent. </summary>
    public partial class VpnSiteLinkConnectionContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VpnSiteLinkConnectionsRestOperations _vpnSiteLinkConnectionsRestClient;
        private readonly VpnLinkConnectionsRestOperations _vpnLinkConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnSiteLinkConnectionContainer"/> class for mocking. </summary>
        protected VpnSiteLinkConnectionContainer()
        {
        }

        /// <summary> Initializes a new instance of VpnSiteLinkConnectionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VpnSiteLinkConnectionContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnSiteLinkConnectionsRestClient = new VpnSiteLinkConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
            _vpnLinkConnectionsRestClient = new VpnLinkConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => "Microsoft.Network/vpnGateways/vpnConnections";

        // Container level operations.

        /// <summary> Retrieves the details of a vpn site link connection. </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public virtual Response<VpnSiteLinkConnection> Get(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            if (linkConnectionName == null)
            {
                throw new ArgumentNullException(nameof(linkConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionContainer.Get");
            scope.Start();
            try
            {
                var response = _vpnSiteLinkConnectionsRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkConnectionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnSiteLinkConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a vpn site link connection. </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public async virtual Task<Response<VpnSiteLinkConnection>> GetAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            if (linkConnectionName == null)
            {
                throw new ArgumentNullException(nameof(linkConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionContainer.Get");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinkConnectionsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnSiteLinkConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public virtual Response<VpnSiteLinkConnection> GetIfExists(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            if (linkConnectionName == null)
            {
                throw new ArgumentNullException(nameof(linkConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _vpnSiteLinkConnectionsRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkConnectionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VpnSiteLinkConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new VpnSiteLinkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public async virtual Task<Response<VpnSiteLinkConnection>> GetIfExistsAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            if (linkConnectionName == null)
            {
                throw new ArgumentNullException(nameof(linkConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinkConnectionsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VpnSiteLinkConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new VpnSiteLinkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            if (linkConnectionName == null)
            {
                throw new ArgumentNullException(nameof(linkConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(linkConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkConnectionName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            if (linkConnectionName == null)
            {
                throw new ArgumentNullException(nameof(linkConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(linkConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnSiteLinkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnSiteLinkConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnSiteLinkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnLinkConnectionsRestClient.GetAllByVpnConnection(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSiteLinkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnSiteLinkConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnLinkConnectionsRestClient.GetAllByVpnConnectionNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSiteLinkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnSiteLinkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnSiteLinkConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnSiteLinkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnLinkConnectionsRestClient.GetAllByVpnConnectionAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSiteLinkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnSiteLinkConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnLinkConnectionsRestClient.GetAllByVpnConnectionNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSiteLinkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, VpnSiteLinkConnection, VpnSiteLinkConnectionData> Construct() { }
    }
}
