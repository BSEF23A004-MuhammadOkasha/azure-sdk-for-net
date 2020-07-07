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
using Azure.ResourceManager.AppConfiguration.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> The ConfigurationStores service client. </summary>
    public partial class ConfigurationStoresOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ConfigurationStoresRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ConfigurationStoresOperations for mocking. </summary>
        protected ConfigurationStoresOperations()
        {
        }
        /// <summary> Initializes a new instance of ConfigurationStoresOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal ConfigurationStoresOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-06-01")
        {
            RestClient = new ConfigurationStoresRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the properties of the specified configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConfigurationStore>> GetAsync(string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, configStoreName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the properties of the specified configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConfigurationStore> Get(string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, configStoreName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerates an access key for the specified configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="regenerateKeyParameters"> The parameters for regenerating an access key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiKey>> RegenerateKeyAsync(string resourceGroupName, string configStoreName, RegenerateKeyParameters regenerateKeyParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.RegenerateKey");
            scope.Start();
            try
            {
                return await RestClient.RegenerateKeyAsync(resourceGroupName, configStoreName, regenerateKeyParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerates an access key for the specified configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="regenerateKeyParameters"> The parameters for regenerating an access key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiKey> RegenerateKey(string resourceGroupName, string configStoreName, RegenerateKeyParameters regenerateKeyParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.RegenerateKey");
            scope.Start();
            try
            {
                return RestClient.RegenerateKey(resourceGroupName, configStoreName, regenerateKeyParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists a configuration store key-value. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="listKeyValueParameters"> The parameters for retrieving a key-value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KeyValue>> ListKeyValueAsync(string resourceGroupName, string configStoreName, ListKeyValueParameters listKeyValueParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.ListKeyValue");
            scope.Start();
            try
            {
                return await RestClient.ListKeyValueAsync(resourceGroupName, configStoreName, listKeyValueParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists a configuration store key-value. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="listKeyValueParameters"> The parameters for retrieving a key-value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KeyValue> ListKeyValue(string resourceGroupName, string configStoreName, ListKeyValueParameters listKeyValueParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.ListKeyValue");
            scope.Start();
            try
            {
                return RestClient.ListKeyValue(resourceGroupName, configStoreName, listKeyValueParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the configuration stores for a given subscription. </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ConfigurationStore> ListAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ConfigurationStore>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(skipToken, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ConfigurationStore>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, skipToken, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists the configuration stores for a given subscription. </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ConfigurationStore> List(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ConfigurationStore> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(skipToken, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ConfigurationStore> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, skipToken, cancellationToken);
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

        /// <summary> Lists the configuration stores for a given resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ConfigurationStore> ListByResourceGroupAsync(string resourceGroupName, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<ConfigurationStore>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, skipToken, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ConfigurationStore>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, skipToken, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists the configuration stores for a given resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ConfigurationStore> ListByResourceGroup(string resourceGroupName, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<ConfigurationStore> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, skipToken, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ConfigurationStore> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, skipToken, cancellationToken);
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

        /// <summary> Lists the access key for the specified configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ApiKey> ListKeysAsync(string resourceGroupName, string configStoreName, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            async Task<Page<ApiKey>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.ListKeys");
                scope.Start();
                try
                {
                    var response = await RestClient.ListKeysAsync(resourceGroupName, configStoreName, skipToken, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiKey>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.ListKeys");
                scope.Start();
                try
                {
                    var response = await RestClient.ListKeysNextPageAsync(nextLink, resourceGroupName, configStoreName, skipToken, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists the access key for the specified configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ApiKey> ListKeys(string resourceGroupName, string configStoreName, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            Page<ApiKey> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.ListKeys");
                scope.Start();
                try
                {
                    var response = RestClient.ListKeys(resourceGroupName, configStoreName, skipToken, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiKey> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.ListKeys");
                scope.Start();
                try
                {
                    var response = RestClient.ListKeysNextPage(nextLink, resourceGroupName, configStoreName, skipToken, cancellationToken);
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

        /// <summary> Creates a configuration store with the specified parameters. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="configStoreCreationParameters"> The parameters for creating a configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ConfigurationStoresCreateOperation> StartCreateAsync(string resourceGroupName, string configStoreName, ConfigurationStore configStoreCreationParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (configStoreCreationParameters == null)
            {
                throw new ArgumentNullException(nameof(configStoreCreationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.StartCreate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateAsync(resourceGroupName, configStoreName, configStoreCreationParameters, cancellationToken).ConfigureAwait(false);
                return new ConfigurationStoresCreateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRequest(resourceGroupName, configStoreName, configStoreCreationParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a configuration store with the specified parameters. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="configStoreCreationParameters"> The parameters for creating a configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConfigurationStoresCreateOperation StartCreate(string resourceGroupName, string configStoreName, ConfigurationStore configStoreCreationParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (configStoreCreationParameters == null)
            {
                throw new ArgumentNullException(nameof(configStoreCreationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.StartCreate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Create(resourceGroupName, configStoreName, configStoreCreationParameters, cancellationToken);
                return new ConfigurationStoresCreateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRequest(resourceGroupName, configStoreName, configStoreCreationParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ConfigurationStoresDeleteOperation> StartDeleteAsync(string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, configStoreName, cancellationToken).ConfigureAwait(false);
                return new ConfigurationStoresDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, configStoreName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConfigurationStoresDeleteOperation StartDelete(string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, configStoreName, cancellationToken);
                return new ConfigurationStoresDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, configStoreName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a configuration store with the specified parameters. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="configStoreUpdateParameters"> The parameters for updating a configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ConfigurationStoresUpdateOperation> StartUpdateAsync(string resourceGroupName, string configStoreName, ConfigurationStoreUpdateParameters configStoreUpdateParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (configStoreUpdateParameters == null)
            {
                throw new ArgumentNullException(nameof(configStoreUpdateParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, configStoreName, configStoreUpdateParameters, cancellationToken).ConfigureAwait(false);
                return new ConfigurationStoresUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, configStoreName, configStoreUpdateParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a configuration store with the specified parameters. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="configStoreUpdateParameters"> The parameters for updating a configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConfigurationStoresUpdateOperation StartUpdate(string resourceGroupName, string configStoreName, ConfigurationStoreUpdateParameters configStoreUpdateParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (configStoreUpdateParameters == null)
            {
                throw new ArgumentNullException(nameof(configStoreUpdateParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationStoresOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, configStoreName, configStoreUpdateParameters, cancellationToken);
                return new ConfigurationStoresUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, configStoreName, configStoreUpdateParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
