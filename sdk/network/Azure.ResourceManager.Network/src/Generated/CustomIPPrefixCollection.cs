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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of CustomIPPrefix and their operations over its parent. </summary>
    public partial class CustomIPPrefixCollection : ArmCollection, IEnumerable<CustomIPPrefix>, IAsyncEnumerable<CustomIPPrefix>
    {
        private readonly ClientDiagnostics _customIPPrefixClientDiagnostics;
        private readonly CustomIPPrefixesRestOperations _customIPPrefixRestClient;

        /// <summary> Initializes a new instance of the <see cref="CustomIPPrefixCollection"/> class for mocking. </summary>
        protected CustomIPPrefixCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CustomIPPrefixCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CustomIPPrefixCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _customIPPrefixClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", CustomIPPrefix.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(CustomIPPrefix.ResourceType, out string customIPPrefixApiVersion);
            _customIPPrefixRestClient = new CustomIPPrefixesRestOperations(_customIPPrefixClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, customIPPrefixApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a custom IP prefix.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/customIpPrefixes/{customIpPrefixName}
        /// Operation Id: CustomIPPrefixes_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update custom IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customIpPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<CustomIPPrefix>> CreateOrUpdateAsync(bool waitForCompletion, string customIpPrefixName, CustomIPPrefixData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customIpPrefixName, nameof(customIpPrefixName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _customIPPrefixRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<CustomIPPrefix>(new CustomIPPrefixOperationSource(Client), _customIPPrefixClientDiagnostics, Pipeline, _customIPPrefixRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Creates or updates a custom IP prefix.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/customIpPrefixes/{customIpPrefixName}
        /// Operation Id: CustomIPPrefixes_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update custom IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customIpPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<CustomIPPrefix> CreateOrUpdate(bool waitForCompletion, string customIpPrefixName, CustomIPPrefixData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customIpPrefixName, nameof(customIpPrefixName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _customIPPrefixRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<CustomIPPrefix>(new CustomIPPrefixOperationSource(Client), _customIPPrefixClientDiagnostics, Pipeline, _customIPPrefixRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Gets the specified custom IP prefix in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/customIpPrefixes/{customIpPrefixName}
        /// Operation Id: CustomIPPrefixes_Get
        /// </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customIpPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public async virtual Task<Response<CustomIPPrefix>> GetAsync(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customIpPrefixName, nameof(customIpPrefixName));

            using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = await _customIPPrefixRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _customIPPrefixClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CustomIPPrefix(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified custom IP prefix in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/customIpPrefixes/{customIpPrefixName}
        /// Operation Id: CustomIPPrefixes_Get
        /// </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customIpPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public virtual Response<CustomIPPrefix> Get(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customIpPrefixName, nameof(customIpPrefixName));

            using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = _customIPPrefixRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken);
                if (response.Value == null)
                    throw _customIPPrefixClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomIPPrefix(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all custom IP prefixes in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/customIpPrefixes
        /// Operation Id: CustomIPPrefixes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomIPPrefix" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CustomIPPrefix> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CustomIPPrefix>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _customIPPrefixRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIPPrefix(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CustomIPPrefix>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _customIPPrefixRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIPPrefix(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all custom IP prefixes in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/customIpPrefixes
        /// Operation Id: CustomIPPrefixes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomIPPrefix" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CustomIPPrefix> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CustomIPPrefix> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _customIPPrefixRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIPPrefix(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CustomIPPrefix> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _customIPPrefixRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomIPPrefix(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/customIpPrefixes/{customIpPrefixName}
        /// Operation Id: CustomIPPrefixes_Get
        /// </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customIpPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customIpPrefixName, nameof(customIpPrefixName));

            using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(customIpPrefixName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/customIpPrefixes/{customIpPrefixName}
        /// Operation Id: CustomIPPrefixes_Get
        /// </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customIpPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public virtual Response<bool> Exists(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customIpPrefixName, nameof(customIpPrefixName));

            using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(customIpPrefixName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/customIpPrefixes/{customIpPrefixName}
        /// Operation Id: CustomIPPrefixes_Get
        /// </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customIpPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public async virtual Task<Response<CustomIPPrefix>> GetIfExistsAsync(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customIpPrefixName, nameof(customIpPrefixName));

            using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _customIPPrefixRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CustomIPPrefix>(null, response.GetRawResponse());
                return Response.FromValue(new CustomIPPrefix(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/customIpPrefixes/{customIpPrefixName}
        /// Operation Id: CustomIPPrefixes_Get
        /// </summary>
        /// <param name="customIpPrefixName"> The name of the custom IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customIpPrefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customIpPrefixName"/> is null. </exception>
        public virtual Response<CustomIPPrefix> GetIfExists(string customIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customIpPrefixName, nameof(customIpPrefixName));

            using var scope = _customIPPrefixClientDiagnostics.CreateScope("CustomIPPrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _customIPPrefixRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customIpPrefixName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CustomIPPrefix>(null, response.GetRawResponse());
                return Response.FromValue(new CustomIPPrefix(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CustomIPPrefix> IEnumerable<CustomIPPrefix>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CustomIPPrefix> IAsyncEnumerable<CustomIPPrefix>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
