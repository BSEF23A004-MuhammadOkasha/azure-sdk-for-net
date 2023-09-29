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
    /// A class representing a collection of <see cref="SharedGalleryImageVersionResource" /> and their operations.
    /// Each <see cref="SharedGalleryImageVersionResource" /> in the collection will belong to the same instance of <see cref="SharedGalleryImageResource" />.
    /// To get a <see cref="SharedGalleryImageVersionCollection" /> instance call the GetSharedGalleryImageVersions method from an instance of <see cref="SharedGalleryImageResource" />.
    /// </summary>
    public partial class SharedGalleryImageVersionCollection : ArmCollection, IEnumerable<SharedGalleryImageVersionResource>, IAsyncEnumerable<SharedGalleryImageVersionResource>
    {
        private readonly ClientDiagnostics _sharedGalleryImageVersionClientDiagnostics;
        private readonly SharedGalleryImageVersionsRestOperations _sharedGalleryImageVersionRestClient;

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageVersionCollection"/> class for mocking. </summary>
        protected SharedGalleryImageVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SharedGalleryImageVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedGalleryImageVersionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", SharedGalleryImageVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SharedGalleryImageVersionResource.ResourceType, out string sharedGalleryImageVersionApiVersion);
            _sharedGalleryImageVersionRestClient = new SharedGalleryImageVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sharedGalleryImageVersionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SharedGalleryImageResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SharedGalleryImageResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a shared gallery image version by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<Response<SharedGalleryImageVersionResource>> GetAsync(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _sharedGalleryImageVersionClientDiagnostics.CreateScope("SharedGalleryImageVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImageVersionRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, galleryImageVersionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = SharedGalleryImageVersionResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, galleryImageVersionName);
                return Response.FromValue(new SharedGalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery image version by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual Response<SharedGalleryImageVersionResource> Get(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _sharedGalleryImageVersionClientDiagnostics.CreateScope("SharedGalleryImageVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _sharedGalleryImageVersionRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, galleryImageVersionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = SharedGalleryImageVersionResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, galleryImageVersionName);
                return Response.FromValue(new SharedGalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List shared gallery image versions by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImageVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedGalleryImageVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedGalleryImageVersionResource> GetAllAsync(SharedToValue? sharedTo = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sharedGalleryImageVersionRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, sharedTo);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sharedGalleryImageVersionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, sharedTo);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SharedGalleryImageVersionResource(Client, SharedGalleryImageVersionData.DeserializeSharedGalleryImageVersionData(e)), _sharedGalleryImageVersionClientDiagnostics, Pipeline, "SharedGalleryImageVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List shared gallery image versions by subscription id or tenant id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImageVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sharedTo"> The query parameter to decide what shared galleries to fetch when doing listing operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedGalleryImageVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedGalleryImageVersionResource> GetAll(SharedToValue? sharedTo = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sharedGalleryImageVersionRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, sharedTo);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sharedGalleryImageVersionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, sharedTo);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SharedGalleryImageVersionResource(Client, SharedGalleryImageVersionData.DeserializeSharedGalleryImageVersionData(e)), _sharedGalleryImageVersionClientDiagnostics, Pipeline, "SharedGalleryImageVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _sharedGalleryImageVersionClientDiagnostics.CreateScope("SharedGalleryImageVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImageVersionRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, galleryImageVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _sharedGalleryImageVersionClientDiagnostics.CreateScope("SharedGalleryImageVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _sharedGalleryImageVersionRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, galleryImageVersionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<NullableResponse<SharedGalleryImageVersionResource>> GetIfExistsAsync(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _sharedGalleryImageVersionClientDiagnostics.CreateScope("SharedGalleryImageVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImageVersionRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, galleryImageVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SharedGalleryImageVersionResource>(response.GetRawResponse());
                response.Value.Id = SharedGalleryImageVersionResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, galleryImageVersionName);
                return Response.FromValue(new SharedGalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SharedGalleryImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual NullableResponse<SharedGalleryImageVersionResource> GetIfExists(string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _sharedGalleryImageVersionClientDiagnostics.CreateScope("SharedGalleryImageVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sharedGalleryImageVersionRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, galleryImageVersionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SharedGalleryImageVersionResource>(response.GetRawResponse());
                response.Value.Id = SharedGalleryImageVersionResource.CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Name), Id.Parent.Name, Id.Name, galleryImageVersionName);
                return Response.FromValue(new SharedGalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SharedGalleryImageVersionResource> IEnumerable<SharedGalleryImageVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SharedGalleryImageVersionResource> IAsyncEnumerable<SharedGalleryImageVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
