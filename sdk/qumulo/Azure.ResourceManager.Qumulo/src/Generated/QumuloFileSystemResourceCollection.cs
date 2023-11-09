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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Qumulo
{
    /// <summary>
    /// A class representing a collection of <see cref="QumuloFileSystemResource" /> and their operations.
    /// Each <see cref="QumuloFileSystemResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="QumuloFileSystemResourceCollection" /> instance call the GetQumuloFileSystemResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class QumuloFileSystemResourceCollection : ArmCollection, IEnumerable<QumuloFileSystemResource>, IAsyncEnumerable<QumuloFileSystemResource>
    {
        private readonly ClientDiagnostics _qumuloFileSystemResourceFileSystemsClientDiagnostics;
        private readonly FileSystemsRestOperations _qumuloFileSystemResourceFileSystemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="QumuloFileSystemResourceCollection"/> class for mocking. </summary>
        protected QumuloFileSystemResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="QumuloFileSystemResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal QumuloFileSystemResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _qumuloFileSystemResourceFileSystemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Qumulo", QumuloFileSystemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(QumuloFileSystemResource.ResourceType, out string qumuloFileSystemResourceFileSystemsApiVersion);
            _qumuloFileSystemResourceFileSystemsRestClient = new FileSystemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, qumuloFileSystemResourceFileSystemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a FileSystemResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystemName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<QumuloFileSystemResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fileSystemName, QumuloFileSystemResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileSystemName, nameof(fileSystemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _qumuloFileSystemResourceFileSystemsClientDiagnostics.CreateScope("QumuloFileSystemResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _qumuloFileSystemResourceFileSystemsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, fileSystemName, data, cancellationToken).ConfigureAwait(false);
                var operation = new QumuloArmOperation<QumuloFileSystemResource>(new QumuloFileSystemResourceOperationSource(Client), _qumuloFileSystemResourceFileSystemsClientDiagnostics, Pipeline, _qumuloFileSystemResourceFileSystemsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, fileSystemName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a FileSystemResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystemName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<QumuloFileSystemResource> CreateOrUpdate(WaitUntil waitUntil, string fileSystemName, QumuloFileSystemResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileSystemName, nameof(fileSystemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _qumuloFileSystemResourceFileSystemsClientDiagnostics.CreateScope("QumuloFileSystemResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _qumuloFileSystemResourceFileSystemsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, fileSystemName, data, cancellationToken);
                var operation = new QumuloArmOperation<QumuloFileSystemResource>(new QumuloFileSystemResourceOperationSource(Client), _qumuloFileSystemResourceFileSystemsClientDiagnostics, Pipeline, _qumuloFileSystemResourceFileSystemsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, fileSystemName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a FileSystemResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystemName"/> is null. </exception>
        public virtual async Task<Response<QumuloFileSystemResource>> GetAsync(string fileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileSystemName, nameof(fileSystemName));

            using var scope = _qumuloFileSystemResourceFileSystemsClientDiagnostics.CreateScope("QumuloFileSystemResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _qumuloFileSystemResourceFileSystemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fileSystemName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QumuloFileSystemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FileSystemResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystemName"/> is null. </exception>
        public virtual Response<QumuloFileSystemResource> Get(string fileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileSystemName, nameof(fileSystemName));

            using var scope = _qumuloFileSystemResourceFileSystemsClientDiagnostics.CreateScope("QumuloFileSystemResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _qumuloFileSystemResourceFileSystemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fileSystemName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QumuloFileSystemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List FileSystemResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="QumuloFileSystemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<QumuloFileSystemResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _qumuloFileSystemResourceFileSystemsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _qumuloFileSystemResourceFileSystemsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new QumuloFileSystemResource(Client, QumuloFileSystemResourceData.DeserializeQumuloFileSystemResourceData(e)), _qumuloFileSystemResourceFileSystemsClientDiagnostics, Pipeline, "QumuloFileSystemResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List FileSystemResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="QumuloFileSystemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<QumuloFileSystemResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _qumuloFileSystemResourceFileSystemsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _qumuloFileSystemResourceFileSystemsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new QumuloFileSystemResource(Client, QumuloFileSystemResourceData.DeserializeQumuloFileSystemResourceData(e)), _qumuloFileSystemResourceFileSystemsClientDiagnostics, Pipeline, "QumuloFileSystemResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystemName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileSystemName, nameof(fileSystemName));

            using var scope = _qumuloFileSystemResourceFileSystemsClientDiagnostics.CreateScope("QumuloFileSystemResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _qumuloFileSystemResourceFileSystemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fileSystemName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystemName"/> is null. </exception>
        public virtual Response<bool> Exists(string fileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileSystemName, nameof(fileSystemName));

            using var scope = _qumuloFileSystemResourceFileSystemsClientDiagnostics.CreateScope("QumuloFileSystemResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _qumuloFileSystemResourceFileSystemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fileSystemName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystemName"/> is null. </exception>
        public virtual async Task<NullableResponse<QumuloFileSystemResource>> GetIfExistsAsync(string fileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileSystemName, nameof(fileSystemName));

            using var scope = _qumuloFileSystemResourceFileSystemsClientDiagnostics.CreateScope("QumuloFileSystemResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _qumuloFileSystemResourceFileSystemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fileSystemName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<QumuloFileSystemResource>(response.GetRawResponse());
                return Response.FromValue(new QumuloFileSystemResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystemName"/> is null. </exception>
        public virtual NullableResponse<QumuloFileSystemResource> GetIfExists(string fileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileSystemName, nameof(fileSystemName));

            using var scope = _qumuloFileSystemResourceFileSystemsClientDiagnostics.CreateScope("QumuloFileSystemResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _qumuloFileSystemResourceFileSystemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fileSystemName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<QumuloFileSystemResource>(response.GetRawResponse());
                return Response.FromValue(new QumuloFileSystemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<QumuloFileSystemResource> IEnumerable<QumuloFileSystemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<QumuloFileSystemResource> IAsyncEnumerable<QumuloFileSystemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
