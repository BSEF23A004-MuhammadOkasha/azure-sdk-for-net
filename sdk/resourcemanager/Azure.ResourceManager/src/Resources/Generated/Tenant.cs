// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a Tenant along with the instance operations that can be performed on it. </summary>
    public partial class Tenant : ArmResource
    {
        private readonly ClientDiagnostics _tenantClientDiagnostics;
        private readonly TenantsRestOperations _tenantRestClient;
        private readonly ClientDiagnostics _providersClientDiagnostics;
        private readonly ProvidersRestOperations _providersRestClient;
        private readonly TenantData _data;

        /// <summary> Initializes a new instance of the <see cref="Tenant"/> class for mocking. </summary>
        protected Tenant()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="Tenant"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal Tenant(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _tenantClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string tenantApiVersion);
            _tenantRestClient = new TenantsRestOperations(_tenantClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, tenantApiVersion);
            _providersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _providersRestClient = new ProvidersRestOperations(_providersClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
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

        /// <summary> Gets a collection of GenericResources in the GenericResource. </summary>
        /// <returns> An object representing collection of GenericResources and their operations over a GenericResource. </returns>
        public virtual GenericResourceCollection GetGenericResources()
        {
            return new GenericResourceCollection(ArmClient, Id);
        }

        /// <summary> Gets a collection of TenantPolicyDefinitions in the TenantPolicyDefinition. </summary>
        /// <returns> An object representing collection of TenantPolicyDefinitions and their operations over a TenantPolicyDefinition. </returns>
        public virtual TenantPolicyDefinitionCollection GetTenantPolicyDefinitions()
        {
            return new TenantPolicyDefinitionCollection(ArmClient, Id);
        }

        /// <summary> Gets a collection of TenantPolicySetDefinitions in the TenantPolicySetDefinition. </summary>
        /// <returns> An object representing collection of TenantPolicySetDefinitions and their operations over a TenantPolicySetDefinition. </returns>
        public virtual TenantPolicySetDefinitionCollection GetTenantPolicySetDefinitions()
        {
            return new TenantPolicySetDefinitionCollection(ArmClient, Id);
        }

        /// <summary> Gets a collection of DataPolicyManifests in the DataPolicyManifest. </summary>
        /// <returns> An object representing collection of DataPolicyManifests and their operations over a DataPolicyManifest. </returns>
        public virtual DataPolicyManifestCollection GetDataPolicyManifests()
        {
            return new DataPolicyManifestCollection(ArmClient, Id);
        }

        /// <summary> Gets a collection of ResourceLinks in the ResourceLink. </summary>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> An object representing collection of ResourceLinks and their operations over a ResourceLink. </returns>
        public virtual ResourceLinkCollection GetResourceLinks(string scope)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            return new ResourceLinkCollection(ArmClient, Id, scope);
        }

        /// <summary> Gets a collection of Subscriptions in the Subscription. </summary>
        /// <returns> An object representing collection of Subscriptions and their operations over a Subscription. </returns>
        public virtual SubscriptionCollection GetSubscriptions()
        {
            return new SubscriptionCollection(ArmClient, Id);
        }

        /// RequestPath: /providers
        /// ContextualPath: /
        /// OperationId: Providers_ListAtTenantScope
        /// <summary> Gets all resource providers for the tenant. </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all providers. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProviderInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProviderInfo> GetTenantProvidersAsync(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ProviderInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _providersClientDiagnostics.CreateScope("Tenant.GetTenantProviders");
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
            async Task<Page<ProviderInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _providersClientDiagnostics.CreateScope("Tenant.GetTenantProviders");
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

        /// RequestPath: /providers
        /// ContextualPath: /
        /// OperationId: Providers_ListAtTenantScope
        /// <summary> Gets all resource providers for the tenant. </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all providers. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProviderInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProviderInfo> GetTenantProviders(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Page<ProviderInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _providersClientDiagnostics.CreateScope("Tenant.GetTenantProviders");
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
            Page<ProviderInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _providersClientDiagnostics.CreateScope("Tenant.GetTenantProviders");
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

        /// RequestPath: /providers/{resourceProviderNamespace}
        /// ContextualPath: /
        /// OperationId: Providers_GetAtTenantScope
        /// <summary> Gets the specified resource provider at the tenant level. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public async virtual Task<Response<ProviderInfo>> GetTenantProviderAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope0 = _providersClientDiagnostics.CreateScope("Tenant.GetTenantProvider");
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

        /// RequestPath: /providers/{resourceProviderNamespace}
        /// ContextualPath: /
        /// OperationId: Providers_GetAtTenantScope
        /// <summary> Gets the specified resource provider at the tenant level. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceProviderNamespace"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual Response<ProviderInfo> GetTenantProvider(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope0 = _providersClientDiagnostics.CreateScope("Tenant.GetTenantProvider");
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
