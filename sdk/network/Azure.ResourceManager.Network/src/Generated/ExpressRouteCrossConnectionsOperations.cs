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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The ExpressRouteCrossConnections service client. </summary>
    public partial class ExpressRouteCrossConnectionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ExpressRouteCrossConnectionsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionsOperations for mocking. </summary>
        protected ExpressRouteCrossConnectionsOperations()
        {
        }
        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ExpressRouteCrossConnectionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ExpressRouteCrossConnectionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets details about the specified ExpressRouteCrossConnection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group (peering location of the circuit). </param>
        /// <param name="crossConnectionName"> The name of the ExpressRouteCrossConnection (service key of the circuit). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteCrossConnection>> GetAsync(string resourceGroupName, string crossConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, crossConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details about the specified ExpressRouteCrossConnection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group (peering location of the circuit). </param>
        /// <param name="crossConnectionName"> The name of the ExpressRouteCrossConnection (service key of the circuit). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCrossConnection> Get(string resourceGroupName, string crossConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, crossConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an express route cross connection tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="crossConnectionName"> The name of the cross connection. </param>
        /// <param name="crossConnectionParameters"> Parameters supplied to update express route cross connection tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteCrossConnection>> UpdateTagsAsync(string resourceGroupName, string crossConnectionName, TagsObject crossConnectionParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, crossConnectionName, crossConnectionParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an express route cross connection tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="crossConnectionName"> The name of the cross connection. </param>
        /// <param name="crossConnectionParameters"> Parameters supplied to update express route cross connection tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCrossConnection> UpdateTags(string resourceGroupName, string crossConnectionName, TagsObject crossConnectionParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, crossConnectionName, crossConnectionParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all the ExpressRouteCrossConnections in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ExpressRouteCrossConnection> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCrossConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCrossConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Retrieves all the ExpressRouteCrossConnections in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ExpressRouteCrossConnection> List(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCrossConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCrossConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
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

        /// <summary> Retrieves all the ExpressRouteCrossConnections in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ExpressRouteCrossConnection> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<ExpressRouteCrossConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCrossConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Retrieves all the ExpressRouteCrossConnections in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ExpressRouteCrossConnection> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<ExpressRouteCrossConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCrossConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
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

        /// <summary> Update the specified ExpressRouteCrossConnection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="crossConnectionName"> The name of the ExpressRouteCrossConnection. </param>
        /// <param name="parameters"> Parameters supplied to the update express route crossConnection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ExpressRouteCrossConnectionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string crossConnectionName, ExpressRouteCrossConnection parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (crossConnectionName == null)
            {
                throw new ArgumentNullException(nameof(crossConnectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, crossConnectionName, parameters, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCrossConnectionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, crossConnectionName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update the specified ExpressRouteCrossConnection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="crossConnectionName"> The name of the ExpressRouteCrossConnection. </param>
        /// <param name="parameters"> Parameters supplied to the update express route crossConnection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCrossConnectionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string crossConnectionName, ExpressRouteCrossConnection parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (crossConnectionName == null)
            {
                throw new ArgumentNullException(nameof(crossConnectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, crossConnectionName, parameters, cancellationToken);
                return new ExpressRouteCrossConnectionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, crossConnectionName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised ARP table associated with the express route cross connection in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="crossConnectionName"> The name of the ExpressRouteCrossConnection. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ExpressRouteCrossConnectionsListArpTableOperation> StartListArpTableAsync(string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (crossConnectionName == null)
            {
                throw new ArgumentNullException(nameof(crossConnectionName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.StartListArpTable");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ListArpTableAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCrossConnectionsListArpTableOperation(_clientDiagnostics, _pipeline, RestClient.CreateListArpTableRequest(resourceGroupName, crossConnectionName, peeringName, devicePath).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised ARP table associated with the express route cross connection in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="crossConnectionName"> The name of the ExpressRouteCrossConnection. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCrossConnectionsListArpTableOperation StartListArpTable(string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (crossConnectionName == null)
            {
                throw new ArgumentNullException(nameof(crossConnectionName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.StartListArpTable");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ListArpTable(resourceGroupName, crossConnectionName, peeringName, devicePath, cancellationToken);
                return new ExpressRouteCrossConnectionsListArpTableOperation(_clientDiagnostics, _pipeline, RestClient.CreateListArpTableRequest(resourceGroupName, crossConnectionName, peeringName, devicePath).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the route table summary associated with the express route cross connection in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="crossConnectionName"> The name of the ExpressRouteCrossConnection. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ExpressRouteCrossConnectionsListRoutesTableSummaryOperation> StartListRoutesTableSummaryAsync(string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (crossConnectionName == null)
            {
                throw new ArgumentNullException(nameof(crossConnectionName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.StartListRoutesTableSummary");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ListRoutesTableSummaryAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCrossConnectionsListRoutesTableSummaryOperation(_clientDiagnostics, _pipeline, RestClient.CreateListRoutesTableSummaryRequest(resourceGroupName, crossConnectionName, peeringName, devicePath).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the route table summary associated with the express route cross connection in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="crossConnectionName"> The name of the ExpressRouteCrossConnection. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCrossConnectionsListRoutesTableSummaryOperation StartListRoutesTableSummary(string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (crossConnectionName == null)
            {
                throw new ArgumentNullException(nameof(crossConnectionName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.StartListRoutesTableSummary");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ListRoutesTableSummary(resourceGroupName, crossConnectionName, peeringName, devicePath, cancellationToken);
                return new ExpressRouteCrossConnectionsListRoutesTableSummaryOperation(_clientDiagnostics, _pipeline, RestClient.CreateListRoutesTableSummaryRequest(resourceGroupName, crossConnectionName, peeringName, devicePath).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised routes table associated with the express route cross connection in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="crossConnectionName"> The name of the ExpressRouteCrossConnection. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ExpressRouteCrossConnectionsListRoutesTableOperation> StartListRoutesTableAsync(string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (crossConnectionName == null)
            {
                throw new ArgumentNullException(nameof(crossConnectionName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.StartListRoutesTable");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ListRoutesTableAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCrossConnectionsListRoutesTableOperation(_clientDiagnostics, _pipeline, RestClient.CreateListRoutesTableRequest(resourceGroupName, crossConnectionName, peeringName, devicePath).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised routes table associated with the express route cross connection in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="crossConnectionName"> The name of the ExpressRouteCrossConnection. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCrossConnectionsListRoutesTableOperation StartListRoutesTable(string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (crossConnectionName == null)
            {
                throw new ArgumentNullException(nameof(crossConnectionName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionsOperations.StartListRoutesTable");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ListRoutesTable(resourceGroupName, crossConnectionName, peeringName, devicePath, cancellationToken);
                return new ExpressRouteCrossConnectionsListRoutesTableOperation(_clientDiagnostics, _pipeline, RestClient.CreateListRoutesTableRequest(resourceGroupName, crossConnectionName, peeringName, devicePath).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
