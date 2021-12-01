// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a VpnSiteLinkConnection along with the instance operations that can be performed on it. </summary>
    public partial class VpnSiteLinkConnection : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VpnSiteLinkConnectionsRestOperations _vpnSiteLinkConnectionsRestClient;
        private readonly VpnLinkConnectionsRestOperations _vpnLinkConnectionsRestClient;
        private readonly VpnSiteLinkConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="VpnSiteLinkConnection"/> class for mocking. </summary>
        protected VpnSiteLinkConnection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VpnSiteLinkConnection"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VpnSiteLinkConnection(ArmResource options, VpnSiteLinkConnectionData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnSiteLinkConnectionsRestClient = new VpnSiteLinkConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _vpnLinkConnectionsRestClient = new VpnLinkConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="VpnSiteLinkConnection"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VpnSiteLinkConnection(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnSiteLinkConnectionsRestClient = new VpnSiteLinkConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _vpnLinkConnectionsRestClient = new VpnLinkConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="VpnSiteLinkConnection"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VpnSiteLinkConnection(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnSiteLinkConnectionsRestClient = new VpnSiteLinkConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _vpnLinkConnectionsRestClient = new VpnLinkConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/vpnGateways/vpnConnections/vpnLinkConnections";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VpnSiteLinkConnectionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Retrieves the details of a vpn site link connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VpnSiteLinkConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnection.Get");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinkConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnSiteLinkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a vpn site link connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnSiteLinkConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnection.Get");
            scope.Start();
            try
            {
                var response = _vpnSiteLinkConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnSiteLinkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Resets the VpnLink connection specified. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnLinkConnectionResetConnectionOperation> ResetConnectionVpnLinkConnectionAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnection.ResetConnectionVpnLinkConnection");
            scope.Start();
            try
            {
                var response = await _vpnLinkConnectionsRestClient.ResetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new VpnLinkConnectionResetConnectionOperation(_clientDiagnostics, Pipeline, _vpnLinkConnectionsRestClient.CreateResetConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the VpnLink connection specified. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnLinkConnectionResetConnectionOperation ResetConnectionVpnLinkConnection(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnection.ResetConnectionVpnLinkConnection");
            scope.Start();
            try
            {
                var response = _vpnLinkConnectionsRestClient.ResetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new VpnLinkConnectionResetConnectionOperation(_clientDiagnostics, Pipeline, _vpnLinkConnectionsRestClient.CreateResetConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
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

        /// <summary> Lists IKE Security Associations for Vpn Site Link Connection in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnLinkConnectionGetIkeSasOperation> GetIkeSasVpnLinkConnectionAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnection.GetIkeSasVpnLinkConnection");
            scope.Start();
            try
            {
                var response = await _vpnLinkConnectionsRestClient.GetIkeSasAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new VpnLinkConnectionGetIkeSasOperation(_clientDiagnostics, Pipeline, _vpnLinkConnectionsRestClient.CreateGetIkeSasRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
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

        /// <summary> Lists IKE Security Associations for Vpn Site Link Connection in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnLinkConnectionGetIkeSasOperation GetIkeSasVpnLinkConnection(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnection.GetIkeSasVpnLinkConnection");
            scope.Start();
            try
            {
                var response = _vpnLinkConnectionsRestClient.GetIkeSas(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new VpnLinkConnectionGetIkeSasOperation(_clientDiagnostics, Pipeline, _vpnLinkConnectionsRestClient.CreateGetIkeSasRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
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
    }
}
