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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of NetworkInterfaceTapConfiguration and their operations over its parent. </summary>
    public partial class NetworkInterfaceTapConfigurationContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly NetworkInterfaceTapConfigurationsRestOperations _networkInterfaceTapConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceTapConfigurationContainer"/> class for mocking. </summary>
        protected NetworkInterfaceTapConfigurationContainer()
        {
        }

        /// <summary> Initializes a new instance of NetworkInterfaceTapConfigurationContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal NetworkInterfaceTapConfigurationContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _networkInterfaceTapConfigurationsRestClient = new NetworkInterfaceTapConfigurationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => "Microsoft.Network/networkInterfaces";

        // Container level operations.

        /// <summary> Creates or updates a Tap configuration in the specified NetworkInterface. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="tapConfigurationParameters"> Parameters supplied to the create or update tap configuration operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> or <paramref name="tapConfigurationParameters"/> is null. </exception>
        public virtual NetworkInterfaceTapConfigurationCreateOrUpdateOperation CreateOrUpdate(string tapConfigurationName, NetworkInterfaceTapConfigurationData tapConfigurationParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }
            if (tapConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationsRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters, cancellationToken);
                var operation = new NetworkInterfaceTapConfigurationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _networkInterfaceTapConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters).Request, response);
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

        /// <summary> Creates or updates a Tap configuration in the specified NetworkInterface. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="tapConfigurationParameters"> Parameters supplied to the create or update tap configuration operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> or <paramref name="tapConfigurationParameters"/> is null. </exception>
        public async virtual Task<NetworkInterfaceTapConfigurationCreateOrUpdateOperation> CreateOrUpdateAsync(string tapConfigurationName, NetworkInterfaceTapConfigurationData tapConfigurationParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }
            if (tapConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationsRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkInterfaceTapConfigurationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _networkInterfaceTapConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters).Request, response);
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

        /// <summary> Get the specified tap configuration on a network interface. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<NetworkInterfaceTapConfiguration> Get(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.Get");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationsRestClient.Get(Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified tap configuration on a network interface. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public async virtual Task<Response<NetworkInterfaceTapConfiguration>> GetAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.Get");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationsRestClient.GetAsync(Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkInterfaceTapConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<NetworkInterfaceTapConfiguration> GetIfExists(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationsRestClient.Get(Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<NetworkInterfaceTapConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new NetworkInterfaceTapConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public async virtual Task<Response<NetworkInterfaceTapConfiguration>> GetIfExistsAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationsRestClient.GetAsync(Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<NetworkInterfaceTapConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new NetworkInterfaceTapConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(tapConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            if (tapConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tapConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all Tap configurations in a network interface. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterfaceTapConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterfaceTapConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkInterfaceTapConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _networkInterfaceTapConfigurationsRestClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkInterfaceTapConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _networkInterfaceTapConfigurationsRestClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get all Tap configurations in a network interface. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterfaceTapConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterfaceTapConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkInterfaceTapConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceTapConfigurationsRestClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkInterfaceTapConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceTapConfigurationsRestClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfiguration(Parent, value)), response.Value.NextLink, response.GetRawResponse());
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
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, NetworkInterfaceTapConfiguration, NetworkInterfaceTapConfigurationData> Construct() { }
    }
}
