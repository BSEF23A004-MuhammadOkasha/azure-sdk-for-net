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

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="ArcExtensionResource" /> and their operations.
    /// Each <see cref="ArcExtensionResource" /> in the collection will belong to the same instance of <see cref="ArcSettingResource" />.
    /// To get an <see cref="ArcExtensionCollection" /> instance call the GetArcExtensions method from an instance of <see cref="ArcSettingResource" />.
    /// </summary>
    public partial class ArcExtensionCollection : ArmCollection, IEnumerable<ArcExtensionResource>, IAsyncEnumerable<ArcExtensionResource>
    {
        private readonly ClientDiagnostics _arcExtensionExtensionsClientDiagnostics;
        private readonly ExtensionsRestOperations _arcExtensionExtensionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ArcExtensionCollection"/> class for mocking. </summary>
        protected ArcExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArcExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ArcExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _arcExtensionExtensionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", ArcExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ArcExtensionResource.ResourceType, out string arcExtensionExtensionsApiVersion);
            _arcExtensionExtensionsRestClient = new ExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, arcExtensionExtensionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ArcSettingResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ArcSettingResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Extension for HCI cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="data"> Details of the Machine Extension to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ArcExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string extensionName, ArcExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _arcExtensionExtensionsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<ArcExtensionResource>(new ArcExtensionOperationSource(Client), _arcExtensionExtensionsClientDiagnostics, Pipeline, _arcExtensionExtensionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Extension for HCI cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="data"> Details of the Machine Extension to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ArcExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string extensionName, ArcExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _arcExtensionExtensionsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, data, cancellationToken);
                var operation = new HciArmOperation<ArcExtensionResource>(new ArcExtensionOperationSource(Client), _arcExtensionExtensionsClientDiagnostics, Pipeline, _arcExtensionExtensionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get particular Arc Extension of HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<ArcExtensionResource>> GetAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _arcExtensionExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArcExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get particular Arc Extension of HCI Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<ArcExtensionResource> Get(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _arcExtensionExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArcExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Extensions under ArcSetting resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_ListByArcSetting</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ArcExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ArcExtensionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _arcExtensionExtensionsRestClient.CreateListByArcSettingRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _arcExtensionExtensionsRestClient.CreateListByArcSettingNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ArcExtensionResource(Client, ArcExtensionData.DeserializeArcExtensionData(e)), _arcExtensionExtensionsClientDiagnostics, Pipeline, "ArcExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Extensions under ArcSetting resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_ListByArcSetting</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ArcExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ArcExtensionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _arcExtensionExtensionsRestClient.CreateListByArcSettingRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _arcExtensionExtensionsRestClient.CreateListByArcSettingNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ArcExtensionResource(Client, ArcExtensionData.DeserializeArcExtensionData(e)), _arcExtensionExtensionsClientDiagnostics, Pipeline, "ArcExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _arcExtensionExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _arcExtensionExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ArcExtensionResource> IEnumerable<ArcExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ArcExtensionResource> IAsyncEnumerable<ArcExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
