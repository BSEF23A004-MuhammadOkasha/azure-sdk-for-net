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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A Class representing a SharedGallery along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SharedGalleryResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSharedGalleryResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetSharedGallery method.
    /// </summary>
    public partial class SharedGalleryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SharedGalleryResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string location, string galleryUniqueName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sharedGalleryClientDiagnostics;
        private readonly SharedGalleriesRestOperations _sharedGalleryRestClient;
        private readonly SharedGalleryData _data;

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryResource"/> class for mocking. </summary>
        protected SharedGalleryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SharedGalleryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SharedGalleryResource(ArmClient client, SharedGalleryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SharedGalleryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedGalleryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sharedGalleryApiVersion);
            _sharedGalleryRestClient = new SharedGalleriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sharedGalleryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/sharedGalleries";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SharedGalleryData Data
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

        /// <summary> Gets a collection of SharedGalleryImageResources in the SharedGallery. </summary>
        /// <returns> An object representing collection of SharedGalleryImageResources and their operations over a SharedGalleryImageResource. </returns>
        public virtual SharedGalleryImageCollection GetSharedGalleryImages()
        {
            return GetCachedClient(Client => new SharedGalleryImageCollection(Client, Id));
        }

        /// <summary>
        /// Get a shared gallery image by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}
        /// Operation Id: SharedGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual async Task<Response<SharedGalleryImageResource>> GetSharedGalleryImageAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            return await GetSharedGalleryImages().GetAsync(galleryImageName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a shared gallery image by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}
        /// Operation Id: SharedGalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the Shared Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<SharedGalleryImageResource> GetSharedGalleryImage(string galleryImageName, CancellationToken cancellationToken = default)
        {
            return GetSharedGalleryImages().Get(galleryImageName, cancellationToken);
        }

        /// <summary>
        /// Get a shared gallery by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SharedGalleryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryResource.Get");
            scope.Start();
            try
            {
                var response = await _sharedGalleryRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name);
                return Response.FromValue(new SharedGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SharedGalleryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGalleryResource.Get");
            scope.Start();
            try
            {
                var response = _sharedGalleryRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name);
                return Response.FromValue(new SharedGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
