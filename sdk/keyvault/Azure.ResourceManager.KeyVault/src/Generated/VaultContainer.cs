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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing collection of Vault and their operations over a ResourceGroup. </summary>
    public partial class VaultContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, Vault, VaultData>
    {
        /// <summary> Initializes a new instance of the <see cref="VaultContainer"/> class for mocking. </summary>
        protected VaultContainer()
        {
        }

        /// <summary> Initializes a new instance of VaultContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VaultContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VaultsRestOperations _restClient => new VaultsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Create or update a key vault in the specified subscription. </summary>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="parameters"> Parameters to create or update the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<Vault> CreateOrUpdate(string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(vaultName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a key vault in the specified subscription. </summary>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="parameters"> Parameters to create or update the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<Vault>> CreateOrUpdateAsync(string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(vaultName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a key vault in the specified subscription. </summary>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="parameters"> Parameters to create or update the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VaultsCreateOrUpdateOperation StartCreateOrUpdate(string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, vaultName, parameters, cancellationToken);
                return new VaultsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, vaultName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a key vault in the specified subscription. </summary>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="parameters"> Parameters to create or update the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VaultsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, vaultName, parameters, cancellationToken).ConfigureAwait(false);
                return new VaultsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, vaultName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Vault> Get(string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultContainer.Get");
            scope.Start();
            try
            {
                if (vaultName == null)
                {
                    throw new ArgumentNullException(nameof(vaultName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken);
                return Response.FromValue(new Vault(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Vault>> GetAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultContainer.Get");
            scope.Start();
            try
            {
                if (vaultName == null)
                {
                    throw new ArgumentNullException(nameof(vaultName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Vault(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Vault TryGet(string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultContainer.TryGet");
            scope.Start();
            try
            {
                if (vaultName == null)
                {
                    throw new ArgumentNullException(nameof(vaultName));
                }

                return Get(vaultName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Vault> TryGetAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultContainer.TryGet");
            scope.Start();
            try
            {
                if (vaultName == null)
                {
                    throw new ArgumentNullException(nameof(vaultName));
                }

                return await GetAsync(vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultContainer.DoesExist");
            scope.Start();
            try
            {
                if (vaultName == null)
                {
                    throw new ArgumentNullException(nameof(vaultName));
                }

                return TryGet(vaultName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultContainer.DoesExist");
            scope.Start();
            try
            {
                if (vaultName == null)
                {
                    throw new ArgumentNullException(nameof(vaultName));
                }

                return await TryGetAsync(vaultName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription and within the specified resource group. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Vault" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<Vault> List(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Vault> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroup(Id.ResourceGroupName, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Vault(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Vault> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroupNextPage(nextLink, Id.ResourceGroupName, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Vault(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription and within the specified resource group. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Vault" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<Vault> ListAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Vault>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupAsync(Id.ResourceGroupName, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Vault(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Vault>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Vault(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Vault" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VaultOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Vault" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VaultOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, Vault, VaultData> Construct() { }
    }
}
