// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A Class representing a DevCenterGallery along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DevCenterGalleryResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDevCenterGalleryResource method.
    /// Otherwise you can get one from its parent resource <see cref="DevCenterResource"/> using the GetDevCenterGallery method.
    /// </summary>
    public partial class DevCenterGalleryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DevCenterGalleryResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="devCenterName"> The devCenterName. </param>
        /// <param name="galleryName"> The galleryName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string devCenterName, string galleryName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _devCenterGalleryGalleriesClientDiagnostics;
        private readonly GalleriesRestOperations _devCenterGalleryGalleriesRestClient;
        private readonly DevCenterGalleryData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevCenter/devcenters/galleries";

        /// <summary> Initializes a new instance of the <see cref="DevCenterGalleryResource"/> class for mocking. </summary>
        protected DevCenterGalleryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevCenterGalleryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DevCenterGalleryResource(ArmClient client, DevCenterGalleryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DevCenterGalleryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DevCenterGalleryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devCenterGalleryGalleriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string devCenterGalleryGalleriesApiVersion);
            _devCenterGalleryGalleriesRestClient = new GalleriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devCenterGalleryGalleriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DevCenterGalleryData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of DevCenterImageResources in the DevCenterGallery. </summary>
        /// <returns> An object representing collection of DevCenterImageResources and their operations over a DevCenterImageResource. </returns>
        public virtual DevCenterImageCollection GetDevCenterImages()
        {
            return GetCachedClient(client => new DevCenterImageCollection(client, Id));
        }

        /// <summary>
        /// Gets a gallery image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DevCenterImageResource>> GetDevCenterImageAsync(string imageName, CancellationToken cancellationToken = default)
        {
            return await GetDevCenterImages().GetAsync(imageName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a gallery image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DevCenterImageResource> GetDevCenterImage(string imageName, CancellationToken cancellationToken = default)
        {
            return GetDevCenterImages().Get(imageName, cancellationToken);
        }

        /// <summary>
        /// Gets a gallery
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Galleries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DevCenterGalleryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _devCenterGalleryGalleriesClientDiagnostics.CreateScope("DevCenterGalleryResource.Get");
            scope.Start();
            try
            {
                var response = await _devCenterGalleryGalleriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a gallery
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Galleries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DevCenterGalleryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _devCenterGalleryGalleriesClientDiagnostics.CreateScope("DevCenterGalleryResource.Get");
            scope.Start();
            try
            {
                var response = _devCenterGalleryGalleriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a gallery resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Galleries_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _devCenterGalleryGalleriesClientDiagnostics.CreateScope("DevCenterGalleryResource.Delete");
            scope.Start();
            try
            {
                var response = await _devCenterGalleryGalleriesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation(_devCenterGalleryGalleriesClientDiagnostics, Pipeline, _devCenterGalleryGalleriesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a gallery resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Galleries_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _devCenterGalleryGalleriesClientDiagnostics.CreateScope("DevCenterGalleryResource.Delete");
            scope.Start();
            try
            {
                var response = _devCenterGalleryGalleriesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DevCenterArmOperation(_devCenterGalleryGalleriesClientDiagnostics, Pipeline, _devCenterGalleryGalleriesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a gallery.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Galleries_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Represents a gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevCenterGalleryResource>> UpdateAsync(WaitUntil waitUntil, DevCenterGalleryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterGalleryGalleriesClientDiagnostics.CreateScope("DevCenterGalleryResource.Update");
            scope.Start();
            try
            {
                var response = await _devCenterGalleryGalleriesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<DevCenterGalleryResource>(new DevCenterGalleryOperationSource(Client), _devCenterGalleryGalleriesClientDiagnostics, Pipeline, _devCenterGalleryGalleriesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a gallery.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Galleries_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Represents a gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevCenterGalleryResource> Update(WaitUntil waitUntil, DevCenterGalleryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterGalleryGalleriesClientDiagnostics.CreateScope("DevCenterGalleryResource.Update");
            scope.Start();
            try
            {
                var response = _devCenterGalleryGalleriesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DevCenterArmOperation<DevCenterGalleryResource>(new DevCenterGalleryOperationSource(Client), _devCenterGalleryGalleriesClientDiagnostics, Pipeline, _devCenterGalleryGalleriesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
