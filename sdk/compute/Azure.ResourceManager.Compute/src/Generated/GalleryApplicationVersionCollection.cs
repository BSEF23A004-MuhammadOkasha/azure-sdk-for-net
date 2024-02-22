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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="GalleryApplicationVersionResource"/> and their operations.
    /// Each <see cref="GalleryApplicationVersionResource"/> in the collection will belong to the same instance of <see cref="GalleryApplicationResource"/>.
    /// To get a <see cref="GalleryApplicationVersionCollection"/> instance call the GetGalleryApplicationVersions method from an instance of <see cref="GalleryApplicationResource"/>.
    /// </summary>
    public partial class GalleryApplicationVersionCollection : ArmCollection, IEnumerable<GalleryApplicationVersionResource>, IAsyncEnumerable<GalleryApplicationVersionResource>
    {
        private readonly ClientDiagnostics _galleryApplicationVersionClientDiagnostics;
        private readonly GalleryApplicationVersionsRestOperations _galleryApplicationVersionRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryApplicationVersionCollection"/> class for mocking. </summary>
        protected GalleryApplicationVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GalleryApplicationVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GalleryApplicationVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _galleryApplicationVersionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", GalleryApplicationVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GalleryApplicationVersionResource.ResourceType, out string galleryApplicationVersionApiVersion);
            _galleryApplicationVersionRestClient = new GalleryApplicationVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, galleryApplicationVersionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GalleryApplicationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GalleryApplicationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a gallery Application Version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}/versions/{galleryApplicationVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryApplicationVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryApplicationVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="data"> Parameters supplied to the create or update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GalleryApplicationVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string galleryApplicationVersionName, GalleryApplicationVersionData data, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryApplicationVersionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _galleryApplicationVersionClientDiagnostics.CreateScope("GalleryApplicationVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleryApplicationVersionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<GalleryApplicationVersionResource>(new GalleryApplicationVersionOperationSource(Client), _galleryApplicationVersionClientDiagnostics, Pipeline, _galleryApplicationVersionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a gallery Application Version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}/versions/{galleryApplicationVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryApplicationVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryApplicationVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="data"> Parameters supplied to the create or update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GalleryApplicationVersionResource> CreateOrUpdate(WaitUntil waitUntil, string galleryApplicationVersionName, GalleryApplicationVersionData data, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryApplicationVersionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _galleryApplicationVersionClientDiagnostics.CreateScope("GalleryApplicationVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleryApplicationVersionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, data, cancellationToken);
                var operation = new ComputeArmOperation<GalleryApplicationVersionResource>(new GalleryApplicationVersionOperationSource(Client), _galleryApplicationVersionClientDiagnostics, Pipeline, _galleryApplicationVersionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves information about a gallery Application Version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}/versions/{galleryApplicationVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryApplicationVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryApplicationVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> is null. </exception>
        public virtual async Task<Response<GalleryApplicationVersionResource>> GetAsync(string galleryApplicationVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryApplicationVersionName));
            }

            using var scope = _galleryApplicationVersionClientDiagnostics.CreateScope("GalleryApplicationVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleryApplicationVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryApplicationVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a gallery Application Version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}/versions/{galleryApplicationVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryApplicationVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryApplicationVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> is null. </exception>
        public virtual Response<GalleryApplicationVersionResource> Get(string galleryApplicationVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryApplicationVersionName));
            }

            using var scope = _galleryApplicationVersionClientDiagnostics.CreateScope("GalleryApplicationVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _galleryApplicationVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryApplicationVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List gallery Application Versions in a gallery Application Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryApplicationVersions_ListByGalleryApplication</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryApplicationVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryApplicationVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryApplicationVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _galleryApplicationVersionRestClient.CreateListByGalleryApplicationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _galleryApplicationVersionRestClient.CreateListByGalleryApplicationNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GalleryApplicationVersionResource(Client, GalleryApplicationVersionData.DeserializeGalleryApplicationVersionData(e)), _galleryApplicationVersionClientDiagnostics, Pipeline, "GalleryApplicationVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List gallery Application Versions in a gallery Application Definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryApplicationVersions_ListByGalleryApplication</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryApplicationVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryApplicationVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryApplicationVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _galleryApplicationVersionRestClient.CreateListByGalleryApplicationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _galleryApplicationVersionRestClient.CreateListByGalleryApplicationNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GalleryApplicationVersionResource(Client, GalleryApplicationVersionData.DeserializeGalleryApplicationVersionData(e)), _galleryApplicationVersionClientDiagnostics, Pipeline, "GalleryApplicationVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}/versions/{galleryApplicationVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryApplicationVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryApplicationVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string galleryApplicationVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryApplicationVersionName));
            }

            using var scope = _galleryApplicationVersionClientDiagnostics.CreateScope("GalleryApplicationVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _galleryApplicationVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}/versions/{galleryApplicationVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryApplicationVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryApplicationVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryApplicationVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryApplicationVersionName));
            }

            using var scope = _galleryApplicationVersionClientDiagnostics.CreateScope("GalleryApplicationVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _galleryApplicationVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}/versions/{galleryApplicationVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryApplicationVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryApplicationVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> is null. </exception>
        public virtual async Task<NullableResponse<GalleryApplicationVersionResource>> GetIfExistsAsync(string galleryApplicationVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryApplicationVersionName));
            }

            using var scope = _galleryApplicationVersionClientDiagnostics.CreateScope("GalleryApplicationVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _galleryApplicationVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GalleryApplicationVersionResource>(response.GetRawResponse());
                return Response.FromValue(new GalleryApplicationVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{galleryApplicationName}/versions/{galleryApplicationVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GalleryApplicationVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GalleryApplicationVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryApplicationVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> is null. </exception>
        public virtual NullableResponse<GalleryApplicationVersionResource> GetIfExists(string galleryApplicationVersionName, ReplicationStatusType? expand = null, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(galleryApplicationVersionName));
            }

            using var scope = _galleryApplicationVersionClientDiagnostics.CreateScope("GalleryApplicationVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _galleryApplicationVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GalleryApplicationVersionResource>(response.GetRawResponse());
                return Response.FromValue(new GalleryApplicationVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GalleryApplicationVersionResource> IEnumerable<GalleryApplicationVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GalleryApplicationVersionResource> IAsyncEnumerable<GalleryApplicationVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
