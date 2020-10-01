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
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The NetworkManagement service client. </summary>
    public partial class NetworkManagementOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal NetworkManagementRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of NetworkManagementOperations for mocking. </summary>
        protected NetworkManagementOperations()
        {
        }
        /// <summary> Initializes a new instance of NetworkManagementOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal NetworkManagementOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new NetworkManagementRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Checks whether a domain name in the cloudapp.azure.com zone is available for use. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="domainNameLabel"> The domain name to be verified. It must conform to the following regular expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DnsNameAvailabilityResult>> CheckDnsNameAvailabilityAsync(string location, string domainNameLabel, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.CheckDnsNameAvailability");
            scope.Start();
            try
            {
                return await RestClient.CheckDnsNameAvailabilityAsync(location, domainNameLabel, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks whether a domain name in the cloudapp.azure.com zone is available for use. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="domainNameLabel"> The domain name to be verified. It must conform to the following regular expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DnsNameAvailabilityResult> CheckDnsNameAvailability(string location, string domainNameLabel, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.CheckDnsNameAvailability");
            scope.Start();
            try
            {
                return RestClient.CheckDnsNameAvailability(location, domainNameLabel, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gives the supported security providers for the virtual wan. </summary>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN for which supported security providers are needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualWanSecurityProviders>> SupportedSecurityProvidersAsync(string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.SupportedSecurityProviders");
            scope.Start();
            try
            {
                return await RestClient.SupportedSecurityProvidersAsync(resourceGroupName, virtualWANName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gives the supported security providers for the virtual wan. </summary>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN for which supported security providers are needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualWanSecurityProviders> SupportedSecurityProviders(string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.SupportedSecurityProviders");
            scope.Start();
            try
            {
                return RestClient.SupportedSecurityProviders(resourceGroupName, virtualWANName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return the Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="bslRequest"> Post request for all the Bastion Shareable Link endpoints. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="bastionHostName"/>, or <paramref name="bslRequest"/> is null. </exception>
        public virtual AsyncPageable<BastionShareableLink> GetBastionShareableLinkAsync(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }
            if (bslRequest == null)
            {
                throw new ArgumentNullException(nameof(bslRequest));
            }

            async Task<Page<BastionShareableLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.GetBastionShareableLink");
                scope.Start();
                try
                {
                    var response = await RestClient.GetBastionShareableLinkAsync(resourceGroupName, bastionHostName, bslRequest, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BastionShareableLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.GetBastionShareableLink");
                scope.Start();
                try
                {
                    var response = await RestClient.GetBastionShareableLinkNextPageAsync(nextLink, resourceGroupName, bastionHostName, bslRequest, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Return the Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="bslRequest"> Post request for all the Bastion Shareable Link endpoints. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="bastionHostName"/>, or <paramref name="bslRequest"/> is null. </exception>
        public virtual Pageable<BastionShareableLink> GetBastionShareableLink(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }
            if (bslRequest == null)
            {
                throw new ArgumentNullException(nameof(bslRequest));
            }

            Page<BastionShareableLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.GetBastionShareableLink");
                scope.Start();
                try
                {
                    var response = RestClient.GetBastionShareableLink(resourceGroupName, bastionHostName, bslRequest, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BastionShareableLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.GetBastionShareableLink");
                scope.Start();
                try
                {
                    var response = RestClient.GetBastionShareableLinkNextPage(nextLink, resourceGroupName, bastionHostName, bslRequest, cancellationToken);
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

        /// <summary> Returns the list of currently active sessions on the Bastion. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="sessionIds"> The list of sessionids to disconnect. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="bastionHostName"/>, or <paramref name="sessionIds"/> is null. </exception>
        public virtual AsyncPageable<BastionSessionState> DisconnectActiveSessionsAsync(string resourceGroupName, string bastionHostName, SessionIds sessionIds, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }
            if (sessionIds == null)
            {
                throw new ArgumentNullException(nameof(sessionIds));
            }

            async Task<Page<BastionSessionState>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.DisconnectActiveSessions");
                scope.Start();
                try
                {
                    var response = await RestClient.DisconnectActiveSessionsAsync(resourceGroupName, bastionHostName, sessionIds, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BastionSessionState>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.DisconnectActiveSessions");
                scope.Start();
                try
                {
                    var response = await RestClient.DisconnectActiveSessionsNextPageAsync(nextLink, resourceGroupName, bastionHostName, sessionIds, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Returns the list of currently active sessions on the Bastion. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="sessionIds"> The list of sessionids to disconnect. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="bastionHostName"/>, or <paramref name="sessionIds"/> is null. </exception>
        public virtual Pageable<BastionSessionState> DisconnectActiveSessions(string resourceGroupName, string bastionHostName, SessionIds sessionIds, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }
            if (sessionIds == null)
            {
                throw new ArgumentNullException(nameof(sessionIds));
            }

            Page<BastionSessionState> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.DisconnectActiveSessions");
                scope.Start();
                try
                {
                    var response = RestClient.DisconnectActiveSessions(resourceGroupName, bastionHostName, sessionIds, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BastionSessionState> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.DisconnectActiveSessions");
                scope.Start();
                try
                {
                    var response = RestClient.DisconnectActiveSessionsNextPage(nextLink, resourceGroupName, bastionHostName, sessionIds, cancellationToken);
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

        /// <summary> Creates a Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="bslRequest"> Post request for all the Bastion Shareable Link endpoints. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="bastionHostName"/>, or <paramref name="bslRequest"/> is null. </exception>
        public virtual async Task<NetworkManagementPutBastionShareableLinkOperation> StartPutBastionShareableLinkAsync(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }
            if (bslRequest == null)
            {
                throw new ArgumentNullException(nameof(bslRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.StartPutBastionShareableLink");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PutBastionShareableLinkAsync(resourceGroupName, bastionHostName, bslRequest, cancellationToken).ConfigureAwait(false);
                return new NetworkManagementPutBastionShareableLinkOperation(_clientDiagnostics, _pipeline, RestClient.CreatePutBastionShareableLinkRequest(resourceGroupName, bastionHostName, bslRequest).Request, originalResponse, nextLink => RestClient.PutBastionShareableLinkNextPageAsync(nextLink, resourceGroupName, bastionHostName, bslRequest, cancellationToken));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="bslRequest"> Post request for all the Bastion Shareable Link endpoints. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="bastionHostName"/>, or <paramref name="bslRequest"/> is null. </exception>
        public virtual NetworkManagementPutBastionShareableLinkOperation StartPutBastionShareableLink(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }
            if (bslRequest == null)
            {
                throw new ArgumentNullException(nameof(bslRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.StartPutBastionShareableLink");
            scope.Start();
            try
            {
                var originalResponse = RestClient.PutBastionShareableLink(resourceGroupName, bastionHostName, bslRequest, cancellationToken);
                return new NetworkManagementPutBastionShareableLinkOperation(_clientDiagnostics, _pipeline, RestClient.CreatePutBastionShareableLinkRequest(resourceGroupName, bastionHostName, bslRequest).Request, originalResponse, nextLink => RestClient.PutBastionShareableLinkNextPageAsync(nextLink, resourceGroupName, bastionHostName, bslRequest, cancellationToken));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="bslRequest"> Post request for all the Bastion Shareable Link endpoints. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="bastionHostName"/>, or <paramref name="bslRequest"/> is null. </exception>
        public virtual async Task<NetworkManagementDeleteBastionShareableLinkOperation> StartDeleteBastionShareableLinkAsync(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }
            if (bslRequest == null)
            {
                throw new ArgumentNullException(nameof(bslRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.StartDeleteBastionShareableLink");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteBastionShareableLinkAsync(resourceGroupName, bastionHostName, bslRequest, cancellationToken).ConfigureAwait(false);
                return new NetworkManagementDeleteBastionShareableLinkOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteBastionShareableLinkRequest(resourceGroupName, bastionHostName, bslRequest).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="bslRequest"> Post request for all the Bastion Shareable Link endpoints. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="bastionHostName"/>, or <paramref name="bslRequest"/> is null. </exception>
        public virtual NetworkManagementDeleteBastionShareableLinkOperation StartDeleteBastionShareableLink(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }
            if (bslRequest == null)
            {
                throw new ArgumentNullException(nameof(bslRequest));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.StartDeleteBastionShareableLink");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeleteBastionShareableLink(resourceGroupName, bastionHostName, bslRequest, cancellationToken);
                return new NetworkManagementDeleteBastionShareableLinkOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteBastionShareableLinkRequest(resourceGroupName, bastionHostName, bslRequest).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns the list of currently active sessions on the Bastion. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="bastionHostName"/> is null. </exception>
        public virtual async Task<NetworkManagementGetActiveSessionsOperation> StartGetActiveSessionsAsync(string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.StartGetActiveSessions");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.GetActiveSessionsAsync(resourceGroupName, bastionHostName, cancellationToken).ConfigureAwait(false);
                return new NetworkManagementGetActiveSessionsOperation(_clientDiagnostics, _pipeline, RestClient.CreateGetActiveSessionsRequest(resourceGroupName, bastionHostName).Request, originalResponse, nextLink => RestClient.GetActiveSessionsNextPageAsync(nextLink, resourceGroupName, bastionHostName, cancellationToken));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns the list of currently active sessions on the Bastion. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="bastionHostName"/> is null. </exception>
        public virtual NetworkManagementGetActiveSessionsOperation StartGetActiveSessions(string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.StartGetActiveSessions");
            scope.Start();
            try
            {
                var originalResponse = RestClient.GetActiveSessions(resourceGroupName, bastionHostName, cancellationToken);
                return new NetworkManagementGetActiveSessionsOperation(_clientDiagnostics, _pipeline, RestClient.CreateGetActiveSessionsRequest(resourceGroupName, bastionHostName).Request, originalResponse, nextLink => RestClient.GetActiveSessionsNextPageAsync(nextLink, resourceGroupName, bastionHostName, cancellationToken));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Generates a unique VPN profile for P2S clients for VirtualWan and associated VpnServerConfiguration combination in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN whose associated VpnServerConfigurations is needed. </param>
        /// <param name="vpnClientParams"> Parameters supplied to the generate VirtualWan VPN profile generation operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualWANName"/>, or <paramref name="vpnClientParams"/> is null. </exception>
        public virtual async Task<NetworkManagementGeneratevirtualwanvpnserverconfigurationvpnprofileOperation> StartGeneratevirtualwanvpnserverconfigurationvpnprofileAsync(string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (vpnClientParams == null)
            {
                throw new ArgumentNullException(nameof(vpnClientParams));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.StartGeneratevirtualwanvpnserverconfigurationvpnprofile");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.GeneratevirtualwanvpnserverconfigurationvpnprofileAsync(resourceGroupName, virtualWANName, vpnClientParams, cancellationToken).ConfigureAwait(false);
                return new NetworkManagementGeneratevirtualwanvpnserverconfigurationvpnprofileOperation(_clientDiagnostics, _pipeline, RestClient.CreateGeneratevirtualwanvpnserverconfigurationvpnprofileRequest(resourceGroupName, virtualWANName, vpnClientParams).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Generates a unique VPN profile for P2S clients for VirtualWan and associated VpnServerConfiguration combination in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN whose associated VpnServerConfigurations is needed. </param>
        /// <param name="vpnClientParams"> Parameters supplied to the generate VirtualWan VPN profile generation operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualWANName"/>, or <paramref name="vpnClientParams"/> is null. </exception>
        public virtual NetworkManagementGeneratevirtualwanvpnserverconfigurationvpnprofileOperation StartGeneratevirtualwanvpnserverconfigurationvpnprofile(string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (vpnClientParams == null)
            {
                throw new ArgumentNullException(nameof(vpnClientParams));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkManagementOperations.StartGeneratevirtualwanvpnserverconfigurationvpnprofile");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Generatevirtualwanvpnserverconfigurationvpnprofile(resourceGroupName, virtualWANName, vpnClientParams, cancellationToken);
                return new NetworkManagementGeneratevirtualwanvpnserverconfigurationvpnprofileOperation(_clientDiagnostics, _pipeline, RestClient.CreateGeneratevirtualwanvpnserverconfigurationvpnprofileRequest(resourceGroupName, virtualWANName, vpnClientParams).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
