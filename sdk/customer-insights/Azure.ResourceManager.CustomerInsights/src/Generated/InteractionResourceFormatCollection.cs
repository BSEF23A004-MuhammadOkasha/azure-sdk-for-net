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

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="InteractionResourceFormatResource" /> and their operations.
    /// Each <see cref="InteractionResourceFormatResource" /> in the collection will belong to the same instance of <see cref="HubResource" />.
    /// To get an <see cref="InteractionResourceFormatCollection" /> instance call the GetInteractionResourceFormats method from an instance of <see cref="HubResource" />.
    /// </summary>
    public partial class InteractionResourceFormatCollection : ArmCollection, IEnumerable<InteractionResourceFormatResource>, IAsyncEnumerable<InteractionResourceFormatResource>
    {
        private readonly ClientDiagnostics _interactionResourceFormatInteractionsClientDiagnostics;
        private readonly InteractionsRestOperations _interactionResourceFormatInteractionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="InteractionResourceFormatCollection"/> class for mocking. </summary>
        protected InteractionResourceFormatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="InteractionResourceFormatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal InteractionResourceFormatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _interactionResourceFormatInteractionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", InteractionResourceFormatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(InteractionResourceFormatResource.ResourceType, out string interactionResourceFormatInteractionsApiVersion);
            _interactionResourceFormatInteractionsRestClient = new InteractionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, interactionResourceFormatInteractionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an interaction or updates an existing interaction within a hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/interactions/{interactionName}
        /// Operation Id: Interactions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="interactionName"> The name of the interaction. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Interaction operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="interactionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="interactionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<InteractionResourceFormatResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string interactionName, InteractionResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(interactionName, nameof(interactionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _interactionResourceFormatInteractionsClientDiagnostics.CreateScope("InteractionResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _interactionResourceFormatInteractionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, interactionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<InteractionResourceFormatResource>(new InteractionResourceFormatOperationSource(Client), _interactionResourceFormatInteractionsClientDiagnostics, Pipeline, _interactionResourceFormatInteractionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, interactionName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Creates an interaction or updates an existing interaction within a hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/interactions/{interactionName}
        /// Operation Id: Interactions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="interactionName"> The name of the interaction. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Interaction operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="interactionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="interactionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<InteractionResourceFormatResource> CreateOrUpdate(WaitUntil waitUntil, string interactionName, InteractionResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(interactionName, nameof(interactionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _interactionResourceFormatInteractionsClientDiagnostics.CreateScope("InteractionResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _interactionResourceFormatInteractionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, interactionName, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<InteractionResourceFormatResource>(new InteractionResourceFormatOperationSource(Client), _interactionResourceFormatInteractionsClientDiagnostics, Pipeline, _interactionResourceFormatInteractionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, interactionName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Gets information about the specified interaction.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/interactions/{interactionName}
        /// Operation Id: Interactions_Get
        /// </summary>
        /// <param name="interactionName"> The name of the interaction. </param>
        /// <param name="localeCode"> Locale of interaction to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="interactionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="interactionName"/> is null. </exception>
        public virtual async Task<Response<InteractionResourceFormatResource>> GetAsync(string interactionName, string localeCode = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(interactionName, nameof(interactionName));

            using var scope = _interactionResourceFormatInteractionsClientDiagnostics.CreateScope("InteractionResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = await _interactionResourceFormatInteractionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, interactionName, localeCode, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InteractionResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified interaction.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/interactions/{interactionName}
        /// Operation Id: Interactions_Get
        /// </summary>
        /// <param name="interactionName"> The name of the interaction. </param>
        /// <param name="localeCode"> Locale of interaction to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="interactionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="interactionName"/> is null. </exception>
        public virtual Response<InteractionResourceFormatResource> Get(string interactionName, string localeCode = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(interactionName, nameof(interactionName));

            using var scope = _interactionResourceFormatInteractionsClientDiagnostics.CreateScope("InteractionResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = _interactionResourceFormatInteractionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, interactionName, localeCode, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InteractionResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all interactions in the hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/interactions
        /// Operation Id: Interactions_ListByHub
        /// </summary>
        /// <param name="localeCode"> Locale of interaction to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InteractionResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InteractionResourceFormatResource> GetAllAsync(string localeCode = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<InteractionResourceFormatResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _interactionResourceFormatInteractionsClientDiagnostics.CreateScope("InteractionResourceFormatCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _interactionResourceFormatInteractionsRestClient.ListByHubAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, localeCode, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InteractionResourceFormatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<InteractionResourceFormatResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _interactionResourceFormatInteractionsClientDiagnostics.CreateScope("InteractionResourceFormatCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _interactionResourceFormatInteractionsRestClient.ListByHubNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, localeCode, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InteractionResourceFormatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all interactions in the hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/interactions
        /// Operation Id: Interactions_ListByHub
        /// </summary>
        /// <param name="localeCode"> Locale of interaction to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InteractionResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InteractionResourceFormatResource> GetAll(string localeCode = null, CancellationToken cancellationToken = default)
        {
            Page<InteractionResourceFormatResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _interactionResourceFormatInteractionsClientDiagnostics.CreateScope("InteractionResourceFormatCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _interactionResourceFormatInteractionsRestClient.ListByHub(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, localeCode, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InteractionResourceFormatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<InteractionResourceFormatResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _interactionResourceFormatInteractionsClientDiagnostics.CreateScope("InteractionResourceFormatCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _interactionResourceFormatInteractionsRestClient.ListByHubNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, localeCode, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InteractionResourceFormatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/interactions/{interactionName}
        /// Operation Id: Interactions_Get
        /// </summary>
        /// <param name="interactionName"> The name of the interaction. </param>
        /// <param name="localeCode"> Locale of interaction to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="interactionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="interactionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string interactionName, string localeCode = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(interactionName, nameof(interactionName));

            using var scope = _interactionResourceFormatInteractionsClientDiagnostics.CreateScope("InteractionResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _interactionResourceFormatInteractionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, interactionName, localeCode, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/interactions/{interactionName}
        /// Operation Id: Interactions_Get
        /// </summary>
        /// <param name="interactionName"> The name of the interaction. </param>
        /// <param name="localeCode"> Locale of interaction to retrieve, default is en-us. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="interactionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="interactionName"/> is null. </exception>
        public virtual Response<bool> Exists(string interactionName, string localeCode = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(interactionName, nameof(interactionName));

            using var scope = _interactionResourceFormatInteractionsClientDiagnostics.CreateScope("InteractionResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = _interactionResourceFormatInteractionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, interactionName, localeCode, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<InteractionResourceFormatResource> IEnumerable<InteractionResourceFormatResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InteractionResourceFormatResource> IAsyncEnumerable<InteractionResourceFormatResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
