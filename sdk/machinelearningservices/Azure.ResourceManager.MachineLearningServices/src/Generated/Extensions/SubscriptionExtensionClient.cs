// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _workspaceClientDiagnostics;
        private WorkspacesRestOperations _workspaceRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;
        private ClientDiagnostics _virtualMachineSizesClientDiagnostics;
        private VirtualMachineSizesRestOperations _virtualMachineSizesRestClient;
        private ClientDiagnostics _quotasClientDiagnostics;
        private QuotasRestOperations _quotasRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics WorkspaceClientDiagnostics => _workspaceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearningServices", Workspace.ResourceType.Namespace, DiagnosticOptions);
        private WorkspacesRestOperations WorkspaceRestClient => _workspaceRestClient ??= new WorkspacesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(Workspace.ResourceType));
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearningServices", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics VirtualMachineSizesClientDiagnostics => _virtualMachineSizesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearningServices", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private VirtualMachineSizesRestOperations VirtualMachineSizesRestClient => _virtualMachineSizesRestClient ??= new VirtualMachineSizesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics QuotasClientDiagnostics => _quotasClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearningServices", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private QuotasRestOperations QuotasRestClient => _quotasRestClient ??= new QuotasRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the available machine learning workspaces under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/workspaces
        /// Operation Id: Workspaces_ListBySubscription
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Workspace" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Workspace> GetWorkspacesAsync(string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Workspace>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = WorkspaceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetWorkspaces");
                scope.Start();
                try
                {
                    var response = await WorkspaceRestClient.ListBySubscriptionAsync(Id.SubscriptionId, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Workspace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Workspace>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = WorkspaceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetWorkspaces");
                scope.Start();
                try
                {
                    var response = await WorkspaceRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Workspace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all the available machine learning workspaces under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/workspaces
        /// Operation Id: Workspaces_ListBySubscription
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Workspace" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Workspace> GetWorkspaces(string skip = null, CancellationToken cancellationToken = default)
        {
            Page<Workspace> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = WorkspaceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetWorkspaces");
                scope.Start();
                try
                {
                    var response = WorkspaceRestClient.ListBySubscription(Id.SubscriptionId, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Workspace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Workspace> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = WorkspaceClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetWorkspaces");
                scope.Start();
                try
                {
                    var response = WorkspaceRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Workspace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the current usage information as well as limits for AML resources for given subscription and location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/usages
        /// Operation Id: Usages_List
        /// </summary>
        /// <param name="location"> The location for which resource usage is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningServicesUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningServicesUsage> GetUsagesAsync(string location, CancellationToken cancellationToken = default)
        {
            async Task<Page<MachineLearningServicesUsage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetUsages");
                scope.Start();
                try
                {
                    var response = await UsagesRestClient.ListAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MachineLearningServicesUsage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetUsages");
                scope.Start();
                try
                {
                    var response = await UsagesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the current usage information as well as limits for AML resources for given subscription and location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/usages
        /// Operation Id: Usages_List
        /// </summary>
        /// <param name="location"> The location for which resource usage is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningServicesUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningServicesUsage> GetUsages(string location, CancellationToken cancellationToken = default)
        {
            Page<MachineLearningServicesUsage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetUsages");
                scope.Start();
                try
                {
                    var response = UsagesRestClient.List(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MachineLearningServicesUsage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetUsages");
                scope.Start();
                try
                {
                    var response = UsagesRestClient.ListNextPage(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Returns supported VM Sizes in a location
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/vmSizes
        /// Operation Id: VirtualMachineSizes_List
        /// </summary>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineSize" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineSize> GetVirtualMachineSizesAsync(string location, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineSize>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualMachineSizesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineSizes");
                scope.Start();
                try
                {
                    var response = await VirtualMachineSizesRestClient.ListAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Returns supported VM Sizes in a location
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/vmSizes
        /// Operation Id: VirtualMachineSizes_List
        /// </summary>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineSize" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineSize> GetVirtualMachineSizes(string location, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineSize> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualMachineSizesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineSizes");
                scope.Start();
                try
                {
                    var response = VirtualMachineSizesRestClient.List(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Update quota for each VM family in workspace.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/updateQuotas
        /// Operation Id: Quotas_Update
        /// </summary>
        /// <param name="location"> The location for update quota is queried. </param>
        /// <param name="value"> The list for update quota. </param>
        /// <param name="quotaUpdateParametersLocation"> Region of workspace quota to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="UpdateWorkspaceQuotas" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<UpdateWorkspaceQuotas> UpdateQuotasAsync(string location, IEnumerable<QuotaBaseProperties> value = null, string quotaUpdateParametersLocation = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<UpdateWorkspaceQuotas>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = QuotasClientDiagnostics.CreateScope("SubscriptionExtensionClient.UpdateQuotas");
                scope.Start();
                try
                {
                    var response = await QuotasRestClient.UpdateAsync(Id.SubscriptionId, location, value, quotaUpdateParametersLocation, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Update quota for each VM family in workspace.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/updateQuotas
        /// Operation Id: Quotas_Update
        /// </summary>
        /// <param name="location"> The location for update quota is queried. </param>
        /// <param name="value"> The list for update quota. </param>
        /// <param name="quotaUpdateParametersLocation"> Region of workspace quota to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="UpdateWorkspaceQuotas" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<UpdateWorkspaceQuotas> UpdateQuotas(string location, IEnumerable<QuotaBaseProperties> value = null, string quotaUpdateParametersLocation = null, CancellationToken cancellationToken = default)
        {
            Page<UpdateWorkspaceQuotas> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = QuotasClientDiagnostics.CreateScope("SubscriptionExtensionClient.UpdateQuotas");
                scope.Start();
                try
                {
                    var response = QuotasRestClient.Update(Id.SubscriptionId, location, value, quotaUpdateParametersLocation, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets the currently assigned Workspace Quotas based on VMFamily.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/quotas
        /// Operation Id: Quotas_List
        /// </summary>
        /// <param name="location"> The location for which resource usage is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceQuota" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceQuota> GetQuotasAsync(string location, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceQuota>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = QuotasClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetQuotas");
                scope.Start();
                try
                {
                    var response = await QuotasRestClient.ListAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceQuota>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = QuotasClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetQuotas");
                scope.Start();
                try
                {
                    var response = await QuotasRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the currently assigned Workspace Quotas based on VMFamily.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/quotas
        /// Operation Id: Quotas_List
        /// </summary>
        /// <param name="location"> The location for which resource usage is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceQuota" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceQuota> GetQuotas(string location, CancellationToken cancellationToken = default)
        {
            Page<ResourceQuota> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = QuotasClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetQuotas");
                scope.Start();
                try
                {
                    var response = QuotasRestClient.List(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceQuota> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = QuotasClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetQuotas");
                scope.Start();
                try
                {
                    var response = QuotasRestClient.ListNextPage(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
