// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary>
    /// A class representing a collection of <see cref="WebPubSubHubResource" /> and their operations.
    /// Each <see cref="WebPubSubHubResource" /> in the collection will belong to the same instance of <see cref="WebPubSubResource" />.
    /// To get a <see cref="WebPubSubHubCollection" /> instance call the GetWebPubSubHubs method from an instance of <see cref="WebPubSubResource" />.
    /// </summary>
    public partial class WebPubSubHubCollection : ArmCollection, IEnumerable<WebPubSubHubResource>, IAsyncEnumerable<WebPubSubHubResource>
    {
        private readonly ClientDiagnostics _webPubSubHubClientDiagnostics;
        private readonly WebPubSubHubsRestOperations _webPubSubHubRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebPubSubHubCollection"/> class for mocking. </summary>
        protected WebPubSubHubCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebPubSubHubCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebPubSubHubCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webPubSubHubClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.WebPubSub", WebPubSubHubResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebPubSubHubResource.ResourceType, out string webPubSubHubApiVersion);
            _webPubSubHubRestClient = new WebPubSubHubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webPubSubHubApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebPubSubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebPubSubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a hub setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/hubs/{hubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSubHubs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="data"> The resource of WebPubSubHub and its properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebPubSubHubResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hubName, WebPubSubHubData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webPubSubHubClientDiagnostics.CreateScope("WebPubSubHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webPubSubHubRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, data, cancellationToken).ConfigureAwait(false);
                var operation = new WebPubSubArmOperation<WebPubSubHubResource>(new WebPubSubHubOperationSource(Client), _webPubSubHubClientDiagnostics, Pipeline, _webPubSubHubRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a hub setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/hubs/{hubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSubHubs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="data"> The resource of WebPubSubHub and its properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebPubSubHubResource> CreateOrUpdate(WaitUntil waitUntil, string hubName, WebPubSubHubData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webPubSubHubClientDiagnostics.CreateScope("WebPubSubHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webPubSubHubRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, data, cancellationToken);
                var operation = new WebPubSubArmOperation<WebPubSubHubResource>(new WebPubSubHubOperationSource(Client), _webPubSubHubClientDiagnostics, Pipeline, _webPubSubHubRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a hub setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/hubs/{hubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSubHubs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> is null. </exception>
        public virtual async Task<Response<WebPubSubHubResource>> GetAsync(string hubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));

            using var scope = _webPubSubHubClientDiagnostics.CreateScope("WebPubSubHubCollection.Get");
            scope.Start();
            try
            {
                var response = await _webPubSubHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebPubSubHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a hub setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/hubs/{hubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSubHubs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> is null. </exception>
        public virtual Response<WebPubSubHubResource> Get(string hubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));

            using var scope = _webPubSubHubClientDiagnostics.CreateScope("WebPubSubHubCollection.Get");
            scope.Start();
            try
            {
                var response = _webPubSubHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebPubSubHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List hub settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/hubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSubHubs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebPubSubHubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebPubSubHubResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webPubSubHubRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webPubSubHubRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebPubSubHubResource(Client, WebPubSubHubData.DeserializeWebPubSubHubData(e)), _webPubSubHubClientDiagnostics, Pipeline, "WebPubSubHubCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List hub settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/hubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSubHubs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebPubSubHubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebPubSubHubResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webPubSubHubRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webPubSubHubRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebPubSubHubResource(Client, WebPubSubHubData.DeserializeWebPubSubHubData(e)), _webPubSubHubClientDiagnostics, Pipeline, "WebPubSubHubCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/hubs/{hubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSubHubs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));

            using var scope = _webPubSubHubClientDiagnostics.CreateScope("WebPubSubHubCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webPubSubHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/hubs/{hubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSubHubs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> is null. </exception>
        public virtual Response<bool> Exists(string hubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));

            using var scope = _webPubSubHubClientDiagnostics.CreateScope("WebPubSubHubCollection.Exists");
            scope.Start();
            try
            {
                var response = _webPubSubHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/hubs/{hubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSubHubs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> is null. </exception>
        public virtual async Task<NullableResponse<WebPubSubHubResource>> GetIfExistsAsync(string hubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));

            using var scope = _webPubSubHubClientDiagnostics.CreateScope("WebPubSubHubCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webPubSubHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WebPubSubHubResource>(response.GetRawResponse());
                return Response.FromValue(new WebPubSubHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/hubs/{hubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebPubSubHubs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> is null. </exception>
        public virtual NullableResponse<WebPubSubHubResource> GetIfExists(string hubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hubName, nameof(hubName));

            using var scope = _webPubSubHubClientDiagnostics.CreateScope("WebPubSubHubCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webPubSubHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WebPubSubHubResource>(response.GetRawResponse());
                return Response.FromValue(new WebPubSubHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebPubSubHubResource> IEnumerable<WebPubSubHubResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebPubSubHubResource> IAsyncEnumerable<WebPubSubHubResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
