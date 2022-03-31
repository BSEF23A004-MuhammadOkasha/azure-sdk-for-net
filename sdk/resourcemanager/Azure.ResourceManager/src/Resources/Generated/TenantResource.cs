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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A Class representing a Tenant along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TenantResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTenantResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetTenant method.
    /// </summary>
    public partial class TenantResource : ArmResource
    {

        private readonly ClientDiagnostics _tenantClientDiagnostics;
        private readonly TenantsRestOperations _tenantRestClient;
        private readonly ClientDiagnostics _providersClientDiagnostics;
        private readonly ProvidersRestOperations _providersRestClient;
        private readonly TenantData _data;

        /// <summary> Initializes a new instance of the <see cref="TenantResource"/> class for mocking. </summary>
        protected TenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantApiVersion);
            _tenantRestClient = new TenantsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantApiVersion);
            _providersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _providersRestClient = new ProvidersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/tenants";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TenantData Data
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

        /// <summary> Gets a collection of GenericResources in the Tenant. </summary>
        /// <returns> An object representing collection of GenericResources and their operations over a GenericResource. </returns>
        public virtual GenericResourceCollection GetGenericResources()
        {
            return GetCachedClient(Client => new GenericResourceCollection(Client, Id));
        }

        /// <summary>
        /// Gets a resource by ID.
        /// Request Path: /{resourceId}
        /// Operation Id: Resources_GetById
        /// </summary>
        /// <param name="resourceId"> The fully qualified ID of the resource, including the resource name and resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public virtual async Task<Response<GenericResource>> GetGenericResourceAsync(ResourceIdentifier resourceId, CancellationToken cancellationToken = default)
        {
            return await GetGenericResources().GetAsync(resourceId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a resource by ID.
        /// Request Path: /{resourceId}
        /// Operation Id: Resources_GetById
        /// </summary>
        /// <param name="resourceId"> The fully qualified ID of the resource, including the resource name and resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public virtual Response<GenericResource> GetGenericResource(ResourceIdentifier resourceId, CancellationToken cancellationToken = default)
        {
            return GetGenericResources().Get(resourceId, cancellationToken);
        }

        /// <summary> Gets a collection of TenantPolicyDefinitionResources in the Tenant. </summary>
        /// <returns> An object representing collection of TenantPolicyDefinitionResources and their operations over a TenantPolicyDefinitionResource. </returns>
        public virtual TenantPolicyDefinitionCollection GetTenantPolicyDefinitions()
        {
            return GetCachedClient(Client => new TenantPolicyDefinitionCollection(Client, Id));
        }

        /// <summary>
        /// This operation retrieves the built-in policy definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual async Task<Response<TenantPolicyDefinitionResource>> GetTenantPolicyDefinitionAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            return await GetTenantPolicyDefinitions().GetAsync(policyDefinitionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This operation retrieves the built-in policy definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<TenantPolicyDefinitionResource> GetTenantPolicyDefinition(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            return GetTenantPolicyDefinitions().Get(policyDefinitionName, cancellationToken);
        }

        /// <summary> Gets a collection of TenantPolicySetDefinitionResources in the Tenant. </summary>
        /// <returns> An object representing collection of TenantPolicySetDefinitionResources and their operations over a TenantPolicySetDefinitionResource. </returns>
        public virtual TenantPolicySetDefinitionCollection GetTenantPolicySetDefinitions()
        {
            return GetCachedClient(Client => new TenantPolicySetDefinitionCollection(Client, Id));
        }

        /// <summary>
        /// This operation retrieves the built-in policy set definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual async Task<Response<TenantPolicySetDefinitionResource>> GetTenantPolicySetDefinitionAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            return await GetTenantPolicySetDefinitions().GetAsync(policySetDefinitionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This operation retrieves the built-in policy set definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// Operation Id: PolicySetDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policySetDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual Response<TenantPolicySetDefinitionResource> GetTenantPolicySetDefinition(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            return GetTenantPolicySetDefinitions().Get(policySetDefinitionName, cancellationToken);
        }

        /// <summary> Gets a collection of DataPolicyManifestResources in the Tenant. </summary>
        /// <returns> An object representing collection of DataPolicyManifestResources and their operations over a DataPolicyManifestResource. </returns>
        public virtual DataPolicyManifestCollection GetDataPolicyManifests()
        {
            return GetCachedClient(Client => new DataPolicyManifestCollection(Client, Id));
        }

        /// <summary>
        /// This operation retrieves the data policy manifest with the given policy mode.
        /// Request Path: /providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}
        /// Operation Id: DataPolicyManifests_GetByPolicyMode
        /// </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyMode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public virtual async Task<Response<DataPolicyManifestResource>> GetDataPolicyManifestAsync(string policyMode, CancellationToken cancellationToken = default)
        {
            return await GetDataPolicyManifests().GetAsync(policyMode, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This operation retrieves the data policy manifest with the given policy mode.
        /// Request Path: /providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}
        /// Operation Id: DataPolicyManifests_GetByPolicyMode
        /// </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyMode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public virtual Response<DataPolicyManifestResource> GetDataPolicyManifest(string policyMode, CancellationToken cancellationToken = default)
        {
            return GetDataPolicyManifests().Get(policyMode, cancellationToken);
        }

        /// <summary> Gets a collection of ResourceLinkResources in the Tenant. </summary>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> An object representing collection of ResourceLinkResources and their operations over a ResourceLinkResource. </returns>
        public virtual ResourceLinkCollection GetResourceLinks(string scope)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            return new ResourceLinkCollection(Client, Id, scope);
        }

        /// <summary>
        /// Gets a resource link with the specified ID.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public virtual async Task<Response<ResourceLinkResource>> GetResourceLinkAsync(string scope, CancellationToken cancellationToken = default)
        {
            return await GetResourceLinks(scope).GetAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a resource link with the specified ID.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public virtual Response<ResourceLinkResource> GetResourceLink(string scope, CancellationToken cancellationToken = default)
        {
            return GetResourceLinks(scope).Get(cancellationToken);
        }

        /// <summary> Gets a collection of SubscriptionResources in the Tenant. </summary>
        /// <returns> An object representing collection of SubscriptionResources and their operations over a SubscriptionResource. </returns>
        public virtual SubscriptionCollection GetSubscriptions()
        {
            return GetCachedClient(Client => new SubscriptionCollection(Client, Id));
        }

        /// <summary>
        /// Gets details about a specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public virtual async Task<Response<SubscriptionResource>> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            return await GetSubscriptions().GetAsync(subscriptionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details about a specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public virtual Response<SubscriptionResource> GetSubscription(string subscriptionId, CancellationToken cancellationToken = default)
        {
            return GetSubscriptions().Get(subscriptionId, cancellationToken);
        }

        /// <summary>
        /// Gets all resource providers for the tenant.
        /// Request Path: /providers
        /// Operation Id: Providers_ListAtTenantScope
        /// </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all providers. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TenantResourceProvider" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TenantResourceProvider> GetTenantResourceProvidersAsync(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<TenantResourceProvider>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _providersClientDiagnostics.CreateScope("TenantResource.GetTenantResourceProviders");
                scope0.Start();
                try
                {
                    var response = await _providersRestClient.ListAtTenantScopeAsync(top, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            async Task<Page<TenantResourceProvider>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _providersClientDiagnostics.CreateScope("TenantResource.GetTenantResourceProviders");
                scope0.Start();
                try
                {
                    var response = await _providersRestClient.ListAtTenantScopeNextPageAsync(nextLink, top, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all resource providers for the tenant.
        /// Request Path: /providers
        /// Operation Id: Providers_ListAtTenantScope
        /// </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all providers. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TenantResourceProvider" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TenantResourceProvider> GetTenantResourceProviders(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Page<TenantResourceProvider> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _providersClientDiagnostics.CreateScope("TenantResource.GetTenantResourceProviders");
                scope0.Start();
                try
                {
                    var response = _providersRestClient.ListAtTenantScope(top, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            Page<TenantResourceProvider> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _providersClientDiagnostics.CreateScope("TenantResource.GetTenantResourceProviders");
                scope0.Start();
                try
                {
                    var response = _providersRestClient.ListAtTenantScopeNextPage(nextLink, top, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the specified resource provider at the tenant level.
        /// Request Path: /providers/{resourceProviderNamespace}
        /// Operation Id: Providers_GetAtTenantScope
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual async Task<Response<TenantResourceProvider>> GetTenantResourceProviderAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope0 = _providersClientDiagnostics.CreateScope("TenantResource.GetTenantResourceProvider");
            scope0.Start();
            try
            {
                var response = await _providersRestClient.GetAtTenantScopeAsync(resourceProviderNamespace, expand, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified resource provider at the tenant level.
        /// Request Path: /providers/{resourceProviderNamespace}
        /// Operation Id: Providers_GetAtTenantScope
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual Response<TenantResourceProvider> GetTenantResourceProvider(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope0 = _providersClientDiagnostics.CreateScope("TenantResource.GetTenantResourceProvider");
            scope0.Start();
            try
            {
                var response = _providersRestClient.GetAtTenantScope(resourceProviderNamespace, expand, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }
    }
}
