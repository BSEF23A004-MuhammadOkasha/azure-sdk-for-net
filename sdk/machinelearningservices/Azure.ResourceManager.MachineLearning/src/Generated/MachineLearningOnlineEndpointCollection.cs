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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningOnlineEndpointResource" /> and their operations.
    /// Each <see cref="MachineLearningOnlineEndpointResource" /> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource" />.
    /// To get a <see cref="MachineLearningOnlineEndpointCollection" /> instance call the GetMachineLearningOnlineEndpoints method from an instance of <see cref="MachineLearningWorkspaceResource" />.
    /// </summary>
    public partial class MachineLearningOnlineEndpointCollection : ArmCollection, IEnumerable<MachineLearningOnlineEndpointResource>, IAsyncEnumerable<MachineLearningOnlineEndpointResource>
    {
        private readonly ClientDiagnostics _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics;
        private readonly OnlineEndpointsRestOperations _machineLearningOnlineEndpointOnlineEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningOnlineEndpointCollection"/> class for mocking. </summary>
        protected MachineLearningOnlineEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningOnlineEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningOnlineEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningOnlineEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningOnlineEndpointResource.ResourceType, out string machineLearningOnlineEndpointOnlineEndpointsApiVersion);
            _machineLearningOnlineEndpointOnlineEndpointsRestClient = new OnlineEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningOnlineEndpointOnlineEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update Online Endpoint (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OnlineEndpoints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="data"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningOnlineEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string endpointName, MachineLearningOnlineEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics.CreateScope("MachineLearningOnlineEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningOnlineEndpointOnlineEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningOnlineEndpointResource>(new MachineLearningOnlineEndpointOperationSource(Client), _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics, Pipeline, _machineLearningOnlineEndpointOnlineEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update Online Endpoint (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OnlineEndpoints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="data"> Online Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningOnlineEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string endpointName, MachineLearningOnlineEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics.CreateScope("MachineLearningOnlineEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningOnlineEndpointOnlineEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningOnlineEndpointResource>(new MachineLearningOnlineEndpointOperationSource(Client), _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics, Pipeline, _machineLearningOnlineEndpointOnlineEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get Online Endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OnlineEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<MachineLearningOnlineEndpointResource>> GetAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics.CreateScope("MachineLearningOnlineEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningOnlineEndpointOnlineEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningOnlineEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Online Endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OnlineEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<MachineLearningOnlineEndpointResource> Get(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics.CreateScope("MachineLearningOnlineEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningOnlineEndpointOnlineEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningOnlineEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Online Endpoints.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OnlineEndpoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningOnlineEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningOnlineEndpointResource> GetAllAsync(MachineLearningOnlineEndpointCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new MachineLearningOnlineEndpointCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningOnlineEndpointOnlineEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Name, options.Count, options.ComputeType, options.Skip, options.Tags, options.Properties, options.OrderBy);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningOnlineEndpointOnlineEndpointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Name, options.Count, options.ComputeType, options.Skip, options.Tags, options.Properties, options.OrderBy);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningOnlineEndpointResource(Client, MachineLearningOnlineEndpointData.DeserializeMachineLearningOnlineEndpointData(e)), _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics, Pipeline, "MachineLearningOnlineEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Online Endpoints.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OnlineEndpoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningOnlineEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningOnlineEndpointResource> GetAll(MachineLearningOnlineEndpointCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new MachineLearningOnlineEndpointCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningOnlineEndpointOnlineEndpointsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Name, options.Count, options.ComputeType, options.Skip, options.Tags, options.Properties, options.OrderBy);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningOnlineEndpointOnlineEndpointsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Name, options.Count, options.ComputeType, options.Skip, options.Tags, options.Properties, options.OrderBy);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningOnlineEndpointResource(Client, MachineLearningOnlineEndpointData.DeserializeMachineLearningOnlineEndpointData(e)), _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics, Pipeline, "MachineLearningOnlineEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OnlineEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics.CreateScope("MachineLearningOnlineEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningOnlineEndpointOnlineEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/onlineEndpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OnlineEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> Online Endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _machineLearningOnlineEndpointOnlineEndpointsClientDiagnostics.CreateScope("MachineLearningOnlineEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningOnlineEndpointOnlineEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningOnlineEndpointResource> IEnumerable<MachineLearningOnlineEndpointResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningOnlineEndpointResource> IAsyncEnumerable<MachineLearningOnlineEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
