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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WebSiteResourceHealthMetadata along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSiteResourceHealthMetadataResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSiteResourceHealthMetadataResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetWebSiteResourceHealthMetadata method.
    /// </summary>
    public partial class WebSiteResourceHealthMetadataResource : ResourceHealthMetadataResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteResourceHealthMetadataResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/resourceHealthMetadata/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteResourceHealthMetadataResourceHealthMetadataClientDiagnostics;
        private readonly ResourceHealthMetadataRestOperations _webSiteResourceHealthMetadataResourceHealthMetadataRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteResourceHealthMetadataResource"/> class for mocking. </summary>
        protected WebSiteResourceHealthMetadataResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSiteResourceHealthMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteResourceHealthMetadataResource(ArmClient client, ResourceHealthMetadataData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteResourceHealthMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteResourceHealthMetadataResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteResourceHealthMetadataResourceHealthMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteResourceHealthMetadataResourceHealthMetadataApiVersion);
            _webSiteResourceHealthMetadataResourceHealthMetadataRestClient = new ResourceHealthMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteResourceHealthMetadataResourceHealthMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/resourceHealthMetadata";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ResourceHealthMetadataResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteResourceHealthMetadataResourceHealthMetadataClientDiagnostics.CreateScope("WebSiteResourceHealthMetadataResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteResourceHealthMetadataResourceHealthMetadataRestClient.GetBySiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the category of ResourceHealthMetadata to use for the given site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/resourceHealthMetadata/default
        /// Operation Id: ResourceHealthMetadata_GetBySite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<WebSiteResourceHealthMetadataResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken);
            return Response.FromValue((WebSiteResourceHealthMetadataResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ResourceHealthMetadataResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteResourceHealthMetadataResourceHealthMetadataClientDiagnostics.CreateScope("WebSiteResourceHealthMetadataResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteResourceHealthMetadataResourceHealthMetadataRestClient.GetBySite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the category of ResourceHealthMetadata to use for the given site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/resourceHealthMetadata/default
        /// Operation Id: ResourceHealthMetadata_GetBySite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<WebSiteResourceHealthMetadataResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((WebSiteResourceHealthMetadataResource)value.Value, value.GetRawResponse());
        }
    }
}
