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

namespace Azure.ResourceManager.SignalR
{
    /// <summary>
    /// A class representing a collection of <see cref="SignalRSharedPrivateLinkResource"/> and their operations.
    /// Each <see cref="SignalRSharedPrivateLinkResource"/> in the collection will belong to the same instance of <see cref="SignalRResource"/>.
    /// To get a <see cref="SignalRSharedPrivateLinkResourceCollection"/> instance call the GetSignalRSharedPrivateLinkResources method from an instance of <see cref="SignalRResource"/>.
    /// </summary>
    public partial class SignalRSharedPrivateLinkResourceCollection : ArmCollection, IEnumerable<SignalRSharedPrivateLinkResource>, IAsyncEnumerable<SignalRSharedPrivateLinkResource>
    {
        private readonly ClientDiagnostics _signalRSharedPrivateLinkResourceClientDiagnostics;
        private readonly SignalRSharedPrivateLinkResourcesRestOperations _signalRSharedPrivateLinkResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="SignalRSharedPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected SignalRSharedPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SignalRSharedPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SignalRSharedPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _signalRSharedPrivateLinkResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SignalR", SignalRSharedPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SignalRSharedPrivateLinkResource.ResourceType, out string signalRSharedPrivateLinkResourceApiVersion);
            _signalRSharedPrivateLinkResourceRestClient = new SignalRSharedPrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, signalRSharedPrivateLinkResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SignalRResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SignalRResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a shared private link resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRSharedPrivateLinkResources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="data"> The shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SignalRSharedPrivateLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sharedPrivateLinkResourceName, SignalRSharedPrivateLinkResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _signalRSharedPrivateLinkResourceClientDiagnostics.CreateScope("SignalRSharedPrivateLinkResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _signalRSharedPrivateLinkResourceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SignalRArmOperation<SignalRSharedPrivateLinkResource>(new SignalRSharedPrivateLinkResourceOperationSource(Client), _signalRSharedPrivateLinkResourceClientDiagnostics, Pipeline, _signalRSharedPrivateLinkResourceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a shared private link resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRSharedPrivateLinkResources_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="data"> The shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SignalRSharedPrivateLinkResource> CreateOrUpdate(WaitUntil waitUntil, string sharedPrivateLinkResourceName, SignalRSharedPrivateLinkResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _signalRSharedPrivateLinkResourceClientDiagnostics.CreateScope("SignalRSharedPrivateLinkResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _signalRSharedPrivateLinkResourceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data, cancellationToken);
                var operation = new SignalRArmOperation<SignalRSharedPrivateLinkResource>(new SignalRSharedPrivateLinkResourceOperationSource(Client), _signalRSharedPrivateLinkResourceClientDiagnostics, Pipeline, _signalRSharedPrivateLinkResourceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the specified shared private link resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRSharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<SignalRSharedPrivateLinkResource>> GetAsync(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _signalRSharedPrivateLinkResourceClientDiagnostics.CreateScope("SignalRSharedPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _signalRSharedPrivateLinkResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SignalRSharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified shared private link resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRSharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual Response<SignalRSharedPrivateLinkResource> Get(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _signalRSharedPrivateLinkResourceClientDiagnostics.CreateScope("SignalRSharedPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _signalRSharedPrivateLinkResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SignalRSharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List shared private link resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRSharedPrivateLinkResources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SignalRSharedPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SignalRSharedPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _signalRSharedPrivateLinkResourceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _signalRSharedPrivateLinkResourceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SignalRSharedPrivateLinkResource(Client, SignalRSharedPrivateLinkResourceData.DeserializeSignalRSharedPrivateLinkResourceData(e)), _signalRSharedPrivateLinkResourceClientDiagnostics, Pipeline, "SignalRSharedPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List shared private link resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRSharedPrivateLinkResources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SignalRSharedPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SignalRSharedPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _signalRSharedPrivateLinkResourceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _signalRSharedPrivateLinkResourceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SignalRSharedPrivateLinkResource(Client, SignalRSharedPrivateLinkResourceData.DeserializeSignalRSharedPrivateLinkResourceData(e)), _signalRSharedPrivateLinkResourceClientDiagnostics, Pipeline, "SignalRSharedPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRSharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _signalRSharedPrivateLinkResourceClientDiagnostics.CreateScope("SignalRSharedPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _signalRSharedPrivateLinkResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRSharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _signalRSharedPrivateLinkResourceClientDiagnostics.CreateScope("SignalRSharedPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _signalRSharedPrivateLinkResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRSharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<SignalRSharedPrivateLinkResource>> GetIfExistsAsync(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _signalRSharedPrivateLinkResourceClientDiagnostics.CreateScope("SignalRSharedPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _signalRSharedPrivateLinkResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SignalRSharedPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new SignalRSharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalRSharedPrivateLinkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual NullableResponse<SignalRSharedPrivateLinkResource> GetIfExists(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _signalRSharedPrivateLinkResourceClientDiagnostics.CreateScope("SignalRSharedPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _signalRSharedPrivateLinkResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SignalRSharedPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new SignalRSharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SignalRSharedPrivateLinkResource> IEnumerable<SignalRSharedPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SignalRSharedPrivateLinkResource> IAsyncEnumerable<SignalRSharedPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
