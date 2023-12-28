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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing an AzureWebCategory along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AzureWebCategoryResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAzureWebCategoryResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetAzureWebCategory method.
    /// </summary>
    public partial class AzureWebCategoryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AzureWebCategoryResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _azureWebCategoryWebCategoriesClientDiagnostics;
        private readonly WebCategoriesRestOperations _azureWebCategoryWebCategoriesRestClient;
        private readonly AzureWebCategoryData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/azureWebCategories";

        /// <summary> Initializes a new instance of the <see cref="AzureWebCategoryResource"/> class for mocking. </summary>
        protected AzureWebCategoryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AzureWebCategoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AzureWebCategoryResource(ArmClient client, AzureWebCategoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AzureWebCategoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AzureWebCategoryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _azureWebCategoryWebCategoriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string azureWebCategoryWebCategoriesApiVersion);
            _azureWebCategoryWebCategoriesRestClient = new WebCategoriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, azureWebCategoryWebCategoriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AzureWebCategoryData Data
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

        /// <summary>
        /// Gets the specified Azure Web Category.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebCategories_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/azureWebCategories</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AzureWebCategoryResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _azureWebCategoryWebCategoriesClientDiagnostics.CreateScope("AzureWebCategoryResource.Get");
            scope.Start();
            try
            {
                var response = await _azureWebCategoryWebCategoriesRestClient.GetAsync(Id.SubscriptionId, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureWebCategoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Azure Web Category.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/azureWebCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebCategories_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Network/azureWebCategories</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AzureWebCategoryResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _azureWebCategoryWebCategoriesClientDiagnostics.CreateScope("AzureWebCategoryResource.Get");
            scope.Start();
            try
            {
                var response = _azureWebCategoryWebCategoriesRestClient.Get(Id.SubscriptionId, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureWebCategoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
