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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningRegistryDataVersionResource"/> and their operations.
    /// Each <see cref="MachineLearningRegistryDataVersionResource"/> in the collection will belong to the same instance of <see cref="MachineLearningRegistryDataContainerResource"/>.
    /// To get a <see cref="MachineLearningRegistryDataVersionCollection"/> instance call the GetMachineLearningRegistryDataVersions method from an instance of <see cref="MachineLearningRegistryDataContainerResource"/>.
    /// </summary>
    public partial class MachineLearningRegistryDataVersionCollection : ArmCollection, IEnumerable<MachineLearningRegistryDataVersionResource>, IAsyncEnumerable<MachineLearningRegistryDataVersionResource>
    {
        private readonly ClientDiagnostics _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics;
        private readonly RegistryDataVersionsRestOperations _machineLearningRegistryDataVersionRegistryDataVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryDataVersionCollection"/> class for mocking. </summary>
        protected MachineLearningRegistryDataVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryDataVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningRegistryDataVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningRegistryDataVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningRegistryDataVersionResource.ResourceType, out string machineLearningRegistryDataVersionRegistryDataVersionsApiVersion);
            _machineLearningRegistryDataVersionRegistryDataVersionsRestClient = new RegistryDataVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningRegistryDataVersionRegistryDataVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningRegistryDataContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningRegistryDataContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningRegistryDataVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string version, MachineLearningDataVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics.CreateScope("MachineLearningRegistryDataVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryDataVersionResource>(new MachineLearningRegistryDataVersionOperationSource(Client), _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics, Pipeline, _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningRegistryDataVersionResource> CreateOrUpdate(WaitUntil waitUntil, string version, MachineLearningDataVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics.CreateScope("MachineLearningRegistryDataVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryDataVersionResource>(new MachineLearningRegistryDataVersionOperationSource(Client), _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics, Pipeline, _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<MachineLearningRegistryDataVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics.CreateScope("MachineLearningRegistryDataVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryDataVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<MachineLearningRegistryDataVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics.CreateScope("MachineLearningRegistryDataVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryDataVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List data versions in the data container
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="orderBy"> Please choose OrderBy value from ['createdtime', 'modifiedtime']. </param>
        /// <param name="top">
        /// Top count of results, top count cannot be greater than the page size.
        ///                               If topCount &gt; page size, results with be default page size count will be returned
        /// </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="listViewType"> [ListViewType.ActiveOnly, ListViewType.ArchivedOnly, ListViewType.All]View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningRegistryDataVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningRegistryDataVersionResource> GetAllAsync(string orderBy = null, int? top = null, string skip = null, string tags = null, MachineLearningListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, tags, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, tags, listViewType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningRegistryDataVersionResource(Client, MachineLearningDataVersionData.DeserializeMachineLearningDataVersionData(e)), _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics, Pipeline, "MachineLearningRegistryDataVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List data versions in the data container
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="orderBy"> Please choose OrderBy value from ['createdtime', 'modifiedtime']. </param>
        /// <param name="top">
        /// Top count of results, top count cannot be greater than the page size.
        ///                               If topCount &gt; page size, results with be default page size count will be returned
        /// </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="listViewType"> [ListViewType.ActiveOnly, ListViewType.ArchivedOnly, ListViewType.All]View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningRegistryDataVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningRegistryDataVersionResource> GetAll(string orderBy = null, int? top = null, string skip = null, string tags = null, MachineLearningListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, tags, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, tags, listViewType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningRegistryDataVersionResource(Client, MachineLearningDataVersionData.DeserializeMachineLearningDataVersionData(e)), _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics, Pipeline, "MachineLearningRegistryDataVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics.CreateScope("MachineLearningRegistryDataVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics.CreateScope("MachineLearningRegistryDataVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningRegistryDataVersionResource>> GetIfExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics.CreateScope("MachineLearningRegistryDataVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningRegistryDataVersionResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryDataVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual NullableResponse<MachineLearningRegistryDataVersionResource> GetIfExists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _machineLearningRegistryDataVersionRegistryDataVersionsClientDiagnostics.CreateScope("MachineLearningRegistryDataVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataVersionRegistryDataVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningRegistryDataVersionResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryDataVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningRegistryDataVersionResource> IEnumerable<MachineLearningRegistryDataVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningRegistryDataVersionResource> IAsyncEnumerable<MachineLearningRegistryDataVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
