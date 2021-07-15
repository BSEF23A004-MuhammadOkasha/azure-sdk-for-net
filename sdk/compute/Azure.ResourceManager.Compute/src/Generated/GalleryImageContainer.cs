// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of GalleryImage and their operations over a Gallery. </summary>
    public partial class GalleryImageContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, GalleryImage, GalleryImageData>
    {
        /// <summary> Initializes a new instance of the <see cref="GalleryImageContainer"/> class for mocking. </summary>
        protected GalleryImageContainer()
        {
        }

        /// <summary> Initializes a new instance of GalleryImageContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GalleryImageContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private GalleryImagesRestOperations _restClient => new GalleryImagesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => GalleryOperations.ResourceType;

        // Container level operations.

        /// <summary> Create or update a gallery image definition. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryImage"> Parameters supplied to the create or update gallery image operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImage"/> is null. </exception>
        public virtual Response<GalleryImage> CreateOrUpdate(string galleryImageName, GalleryImageData galleryImage, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImage == null)
            {
                throw new ArgumentNullException(nameof(galleryImage));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(galleryImageName, galleryImage, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a gallery image definition. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryImage"> Parameters supplied to the create or update gallery image operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImage"/> is null. </exception>
        public async virtual Task<Response<GalleryImage>> CreateOrUpdateAsync(string galleryImageName, GalleryImageData galleryImage, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImage == null)
            {
                throw new ArgumentNullException(nameof(galleryImage));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(galleryImageName, galleryImage, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a gallery image definition. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryImage"> Parameters supplied to the create or update gallery image operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImage"/> is null. </exception>
        public virtual GalleryImagesCreateOrUpdateOperation StartCreateOrUpdate(string galleryImageName, GalleryImageData galleryImage, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImage == null)
            {
                throw new ArgumentNullException(nameof(galleryImage));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage, cancellationToken);
                return new GalleryImagesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a gallery image definition. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryImage"> Parameters supplied to the create or update gallery image operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImage"/> is null. </exception>
        public async virtual Task<GalleryImagesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string galleryImageName, GalleryImageData galleryImage, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImage == null)
            {
                throw new ArgumentNullException(nameof(galleryImage));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage, cancellationToken).ConfigureAwait(false);
                return new GalleryImagesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<GalleryImage> Get(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.Get");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken: cancellationToken);
                return Response.FromValue(new GalleryImage(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<GalleryImage>> GetAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.Get");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new GalleryImage(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual GalleryImage TryGet(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.TryGet");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                return Get(galleryImageName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<GalleryImage> TryGetAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.TryGet");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                return await GetAsync(galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.DoesExist");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                return TryGet(galleryImageName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.DoesExist");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                return await TryGetAsync(galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List gallery image definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<GalleryImage> List(CancellationToken cancellationToken = default)
        {
            Page<GalleryImage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.ListByGallery");
                scope.Start();
                try
                {
                    var response = _restClient.ListByGallery(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryImage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.ListByGallery");
                scope.Start();
                try
                {
                    var response = _restClient.ListByGalleryNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List gallery image definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GalleryImage> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryImage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.ListByGallery");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByGalleryAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryImage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.ListByGallery");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByGalleryNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of GalleryImage for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(GalleryImageOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of GalleryImage for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(GalleryImageOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, GalleryImage, GalleryImageData> Construct() { }
    }
}
